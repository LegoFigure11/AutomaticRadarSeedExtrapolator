using System.Net.Sockets;
using PKHeX.Core;
using ARSE.Core.Structures;
using SysBot.Base;
using static System.Buffers.Binary.BinaryPrimitives;
using static SysBot.Base.SwitchButton;
using static SysBot.Base.SwitchCommand;

namespace ARSE.Core.Connection;

public class ConnectionWrapperAsync(SwitchConnectionConfig Config, Action<string> StatusUpdate) : Offsets
{
    public readonly ISwitchConnectionAsync Connection = Config.Protocol switch
    {
        SwitchProtocol.USB => new SwitchUSBAsync(Config.Port),
        _ => new SwitchSocketAsync(Config),
    };

    public bool Connected => IsConnected;
    private bool IsConnected { get; set; }
    private readonly bool CRLF = Config.Protocol is SwitchProtocol.WiFi;

    private readonly SAV8BS sav = new();

    private ulong MainRNGOffset;
    private ulong MyStatusOffset;
    private ulong SwayGrassOffset;
    private ulong WildPokemonOffset;
    private ulong RadarStepCounterOffset;

    private const byte CHARGED_STEP_COUNT = 0x32;

    public async Task<(bool, string)> Connect(CancellationToken token)
    {
        if (Connected) return (true, "");

        try
        {
            StatusUpdate("Connecting...");
            Connection.Connect();
            IsConnected = true;

            StatusUpdate("Detecting Game Version");
            string title = await Connection.GetTitleID(token).ConfigureAwait(false);

            var myStatusPointer = title switch
            {
                BrilliantDiamondID => MyStatusTIDPointerBD,
                ShiningPearlID     => MyStatusTIDPointerSP,
                _                  => throw new Exception("Cannot detect Brilliant Diamond or Shining Pearl running on your switch!")
            };

            var swayGrassPointer = title switch
            {
                BrilliantDiamondID => SwayGrassPoinerBD,
                ShiningPearlID     => SwayGrassPoinerSP,
                _                  => throw new Exception("Cannot detect Brilliant Diamond or Shining Pearl running on your switch!")
            };

            var wildPokemonPointer = title switch
            {
                BrilliantDiamondID => WildPokemonPointerBD,
                ShiningPearlID     => WildPokemonPointerSP,
                _                  => throw new Exception("Cannot detect Brilliant Diamond or Shining Pearl running on your switch!")
            };

            var RadarStepCounterPointer = title switch
            {
                BrilliantDiamondID => RadarStepCounterPointerBD,
                ShiningPearlID     => RadarStepCounterPointerSP,
                _                  => throw new Exception("Cannot detect Brilliant Diamond or Shining Pearl running on your switch!")
            };

            StatusUpdate("Caching Pointers...");

            MainRNGOffset = await Connection.PointerAll(MainRNGPointer, token).ConfigureAwait(false);
            MyStatusOffset = await Connection.PointerAll(myStatusPointer,  token).ConfigureAwait(false);
            SwayGrassOffset = await Connection.PointerAll(swayGrassPointer, token).ConfigureAwait(false);
            WildPokemonOffset = await Connection.PointerAll(wildPokemonPointer, token).ConfigureAwait(false);
            RadarStepCounterOffset = await Connection.PointerAll(RadarStepCounterPointer, token).ConfigureAwait(false);

            StatusUpdate("Reading SAV...");
            var tid = await Connection.ReadBytesAbsoluteAsync(MyStatusOffset, 2, token).ConfigureAwait(false);
            var sid = await Connection.ReadBytesAbsoluteAsync(MyStatusOffset + 2, 2, token).ConfigureAwait(false);

            sav.MyStatus.TID16 = ReadUInt16LittleEndian(tid);
            sav.MyStatus.SID16 = ReadUInt16LittleEndian(sid);

            StatusUpdate("Connected!");
            return (true, "");
        }
        catch (SocketException e)
        {
            IsConnected = false;
            return (false, e.Message);
        }
    }

    public async Task<(bool, string)> DisconnectAsync(CancellationToken token)
    {
        if (!Connected) return (true, "");

        try
        {
            StatusUpdate("Disconnecting controller");
            await Connection.SendAsync(DetachController(CRLF), token).ConfigureAwait(false);

            StatusUpdate("Disconnecting...");
            Connection.Disconnect();
            IsConnected = false;
            StatusUpdate("Disconnected!");
            return (true, "");
        }
        catch (SocketException e)
        {
            IsConnected = false;
            return (false, e.Message);
        }
    }

    public async Task<(ulong, ulong)> ReadRNGState(CancellationToken token)
    {
        var data = await Connection.ReadBytesAbsoluteAsync(MainRNGOffset, MainRNG_SIZE, token).ConfigureAwait(false);
        return (BitConverter.ToUInt64(data, 0), BitConverter.ToUInt64(data, 8));
    }

    public async Task WriteRNGState(ulong _s0, ulong _s1, CancellationToken token)
    {
        var s0 = BitConverter.GetBytes(_s0);
        var s1 = BitConverter.GetBytes(_s1);
        await Connection.WriteBytesAbsoluteAsync(s0, MainRNGOffset, token).ConfigureAwait(false);
        await Connection.WriteBytesAbsoluteAsync(s1, MainRNGOffset + (MainRNG_SIZE / 2), token).ConfigureAwait(false);
    }

    public async Task<SwayGrass> ReadSwayGrass(CancellationToken token)
    {
        var data = await Connection.ReadBytesAbsoluteAsync(SwayGrassOffset, SwayGrass.SIZE, token)
            .ConfigureAwait(false);
        return new SwayGrass(data);
    }

    public async Task<ushort> GetChainSpecies(CancellationToken token)
    {
        var block = await ReadSwayGrass(token).ConfigureAwait(false);
        return (ushort)block.ChainEncounterSpecies;
    }

    public async Task<decimal> GetChainLength(CancellationToken token)
    {
        var block = await ReadSwayGrass(token).ConfigureAwait(false);
        return block.ChainCount;
    }

    public async Task SetChainLength(byte value, CancellationToken token)
    {
        var block = await ReadSwayGrass(token).ConfigureAwait(false);
        block.ChainCount = value;
        await Connection.WriteBytesAbsoluteAsync(block.Data, SwayGrassOffset, token).ConfigureAwait(false);
    }

    public async Task<PB8> ReadWildPokemon(CancellationToken token)
    {
        var data = await Connection.ReadBytesAbsoluteAsync(WildPokemonOffset, 0x168, token).ConfigureAwait(false);
        return new PB8(data);
    }

    public async Task<byte> GetStepCount(CancellationToken token)
    {
        return (await Connection.ReadBytesAbsoluteAsync(RadarStepCounterOffset, 1, token).ConfigureAwait(false))[0];
    }

    public async Task RechargeRadar(CancellationToken token)
    {
        var i = await GetStepCount(token).ConfigureAwait(false);
        var d = true;
        for (; i < CHARGED_STEP_COUNT; i++)
        {
            for (var j = 0; j < 2; j++) {
                if (d) await DoTurboCommand("D-Pad Right", token).ConfigureAwait(false);
                else await DoTurboCommand("D-Pad Left", token).ConfigureAwait(false);
                await Task.Delay(100, token).ConfigureAwait(false);
            }

            d = !d;
            await Task.Delay(300, token).ConfigureAwait(false);
        }
    }

    public async Task PressHOME(int sleep, CancellationToken token)
    {
        await Connection.SendAsync(Click(HOME, CRLF), token).ConfigureAwait(false);
        await Task.Delay(sleep, token).ConfigureAwait(false);
    }

    public async Task DoTurboCommand(string command, CancellationToken token)
    {
        switch (command)
        {
            case "Wait (100ms)":
                await Task.Delay(100, token).ConfigureAwait(false);
                break;
            case "Wait (500ms)":
                await Task.Delay(500, token).ConfigureAwait(false);
                break;
            case "Wait (1000ms)":
                await Task.Delay(1_000, token).ConfigureAwait(false);
                break;
            default:
                _ = command switch
                {
                    "A" => await Connection.SendAsync(Click(A, CRLF), token).ConfigureAwait(false),
                    "B" => await Connection.SendAsync(Click(B, CRLF), token).ConfigureAwait(false),
                    "X" => await Connection.SendAsync(Click(X, CRLF), token).ConfigureAwait(false),
                    "Y" => await Connection.SendAsync(Click(Y, CRLF), token).ConfigureAwait(false),

                    "Left Stick (L3)" => await Connection.SendAsync(Click(LSTICK, CRLF), token).ConfigureAwait(false),
                    "Right Stick (R3)" => await Connection.SendAsync(Click(RSTICK, CRLF), token).ConfigureAwait(false),

                    "L" => await Connection.SendAsync(Click(L, CRLF), token).ConfigureAwait(false),
                    "R" => await Connection.SendAsync(Click(R, CRLF), token).ConfigureAwait(false),
                    "ZL" => await Connection.SendAsync(Click(ZL, CRLF), token).ConfigureAwait(false),
                    "ZR" => await Connection.SendAsync(Click(ZR, CRLF), token).ConfigureAwait(false),

                    "+" => await Connection.SendAsync(Click(PLUS, CRLF), token).ConfigureAwait(false),
                    "-" => await Connection.SendAsync(Click(MINUS, CRLF), token).ConfigureAwait(false),

                    "Up (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 0, 30000, CRLF), token).ConfigureAwait(false),
                    "Down (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 0, -30000, CRLF), token).ConfigureAwait(false),
                    "Left (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, -30000, 0, CRLF), token).ConfigureAwait(false),
                    "Right (Hold)" => await Connection.SendAsync(SetStick(SwitchStick.LEFT, 30000, 0, CRLF), token).ConfigureAwait(false),
                    "Release Stick" => await Connection.SendAsync(SwitchCommand.ResetStick(SwitchStick.LEFT, CRLF), token).ConfigureAwait(false),

                    "D-Pad Up" => await Connection.SendAsync(Click(DUP, CRLF), token).ConfigureAwait(false),
                    "D-Pad Down" => await Connection.SendAsync(Click(DDOWN, CRLF), token).ConfigureAwait(false),
                    "D-Pad Left" => await Connection.SendAsync(Click(DLEFT, CRLF), token).ConfigureAwait(false),
                    "D-Pad Right" => await Connection.SendAsync(Click(DRIGHT, CRLF), token).ConfigureAwait(false),

                    "HOME" => await Connection.SendAsync(Click(HOME, CRLF), token).ConfigureAwait(false),
                    "Screenshot" => await Connection.SendAsync(Click(CAPTURE, CRLF), token).ConfigureAwait(false),

                    _ => throw new NotImplementedException(),
                };
                break;
        }
    }

    public (string TID, string SID) GetIDs()
    {
        var myStatus = sav.MyStatus;
        return ($"{myStatus.TID16:D05}", $"{myStatus.SID16:D05}");
    }
}
