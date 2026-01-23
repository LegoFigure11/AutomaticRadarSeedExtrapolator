using ARSE.Core.Enums;
using ARSE.Core.Interfaces;
using PKHeX.Core;

namespace ARSE.Core.RNG;

public static class Util
{
    public static readonly IReadOnlyList<string> Natures = GameInfo.GetStrings("en").Natures;

    public const uint MAX_TRACKED_ADVANCES = 50_000; // 50,000 chosen arbitrarily to prevent an infinite loop

    public static uint GetAdvancesPassed(ulong s0, ulong s1, ulong _s0, ulong _s1, ulong limit = MAX_TRACKED_ADVANCES)
    {
        if (s0 == _s0 && s1 == _s1) return 0;
        var rng = new XorShift128(s0, s1);
        uint i = 0;
        do
        {
            i++;
            rng.Next();

            var (cur0, cur1) = rng.GetState64();
            if (cur0 == _s0 && cur1 == _s1) break;

        } while (i < limit);

        return i;
    }

    public static int GetRateFromComboBox(int selected) => selected switch
    {
        0 => 53,
        1 => 63,
        2 => 73,
        3 => 83,
        _ => 93,
    };

    public static string GetTurboCommandFromComboBox(int selected) => selected switch
    {
        1 => "A",
        2 => "HOME",
        _ => string.Empty,
    };

    public static uint GetShinyValue(uint x, uint y) => x ^ y;
    public static uint GetShinyValue(uint x) => (x >> 16) ^ (x & 0xFFFF);

    public static uint GetShinyXOR(uint pid, uint tsv) => GetShinyValue(GetShinyValue(pid), tsv);

    private static uint GetShinyXOR2(uint pid, uint id32)
    {
        var xor = pid ^ id32;
        return (xor ^ (xor >> 16)) & 0xFFFF;
    }

    private static Shiny GetRareType(uint xor, Shiny fallback = Shiny.Never) => xor switch
    {
        0    => Shiny.AlwaysSquare,
        < 16 => Shiny.AlwaysStar,
        _    => fallback,
    };

    public static string GetShinyType(uint xor) => xor switch
    {
        0    => "Square",
        < 16 => $"Star ({xor})",
        _    => "No",
    };

    public static uint GetActualPID(uint fakeID, uint pid, uint tid, uint sid, Shiny shinyType)
    {
        var xor = GetShinyXOR2(pid, fakeID);
        var newXor = GetShinyXOR2(pid, tid << 16 | sid);

        var fakeRare = GetRareType(xor, shinyType);
        var newRare = GetRareType(newXor, shinyType);

        if (fakeRare == newRare && shinyType is not Shiny.Always)
            return pid;

        var isShiny = xor < 16;
        if (isShiny && shinyType is Shiny.Never) return pid ^ 0x1000_0000;
        var low = pid & 0xFFFF;
        return (((fakeRare == Shiny.AlwaysStar ? 1 : 0u) ^ tid ^ sid ^ low) << 16) | low;
    }

    public static uint GenerateGuaranteedIVIndex(ref XorShift128 rng)
    {
        return rng.NextUInt(6);
    }

    public static byte GenerateIV(ref XorShift128 rng)
    {
        return (byte)rng.NextInt(0, 32);
    }

    public static (bool, byte[]) GenerateIVs(ref XorShift128 rng, ChainPokemonConfig config)
    {
        byte[] ivs = [32, 32, 32, 32, 32, 32];
        var g = config.GuaranteedIVs;
        // Guaranteed
        uint idx;
        for (var i = 0; i < g; i++)
        {
            do
            {
                idx = GenerateGuaranteedIVIndex(ref rng);
            } while (ivs[idx] != 32);

            ivs[idx] = 31;

            if (
                config.FiltersEnabled &&
                (
                    (config.SearchTypes[idx] == IVSearchType.Range && ivs[idx] > config.TargetMaxIVs[idx]) ||
                    (config.SearchTypes[idx] == IVSearchType.Or && ivs[idx] != config.TargetMinIVs[idx] && ivs[idx] != config.TargetMaxIVs[idx])
                )
            ) return (false, ivs);
        }
        // Random
        for (var i = 0; i < 6; i++)
        {
            if (ivs[i] == 32) ivs[i] = GenerateIV(ref rng);

            if (
                config.FiltersEnabled &&
                (
                    (config.SearchTypes[i] == IVSearchType.Range && (ivs[i] < config.TargetMinIVs[i] || ivs[i] > config.TargetMaxIVs[i])) ||
                    (config.SearchTypes[i] == IVSearchType.Or && ivs[i] != config.TargetMinIVs[i] && ivs[i] != config.TargetMaxIVs[i])
                )
            ) return (false, ivs);
        }
        return (true, ivs);
    }

    public static string GenerateNature(ref XorShift128 rng)
    {
        return Natures[(int)rng.NextUInt(25)];
    }

    public static IVSearchType GetIVSearchType(string labelText) =>
        labelText == "||" ? IVSearchType.Or : IVSearchType.Range;

    public static string GetHeightString(uint height) => height switch
    {
        >= 255 => $"XXXL ({height})",
        >= 231 => $"XXL ({height})",
        >= 196 => $"XL ({height})",
        >= 156 => $"L ({height})",
        >= 100 => $"M ({height})",
        >= 60  => $"S ({height})",
        >= 25  => $"XS ({height})",
        >= 1   => $"XXS ({height})",
        _      => $"XXXS ({height})",
    };
}
