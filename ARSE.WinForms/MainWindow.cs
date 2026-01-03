using PKHeX.Core;
using ARSE.Core.Connection;
using SysBot.Base;
using System.Globalization;
using System.Text.Json;
using Microsoft.VisualBasic;
using ARSE.Core.Interfaces;
using static ARSE.Core.RNG.Util;

namespace ARSE.WinForms;

public partial class MainWindow : Form
{
    private static CancellationTokenSource Source = new();
    private static readonly Lock _connectLock = new();

    public ClientConfig Config;
    private ConnectionWrapperAsync ConnectionWrapper = default!;
    private readonly SwitchConnectionConfig ConnectionConfig;

    public readonly GameStrings Strings = GameInfo.GetStrings("en");

    private bool stop;
    private bool reset;
    private bool readPause;
    private bool flipPause;
    private long flipTarget;
    private bool forecast;
    private long total;
    private bool found;
    private ulong remaining;

    private RadarContinuationConfig _cfg = new();

    List<RadarContinuationFrame> Frames = [];

    private readonly Version CurrentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!;

    public MainWindow()
    {
        Config = new ClientConfig();
        var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        if (File.Exists(configPath))
        {
            var text = File.ReadAllText(configPath);
            Config = JsonSerializer.Deserialize<ClientConfig>(text)!;
        }
        else
        {
            Config = new();
        }

        ConnectionConfig = new()
        {
            IP = Config.IP,
            Port = Config.Protocol is SwitchProtocol.WiFi ? 6000 : Config.UsbPort,
            Protocol = Config.Protocol,
        };

        var v = CurrentVersion;
#if DEBUG
        var build = "";

        var asm = System.Reflection.Assembly.GetEntryAssembly();
        var gitVersionInformationType = asm?.GetType("GitVersionInformation");
        var sha = gitVersionInformationType?.GetField("ShortSha");

        if (sha is not null) build += $"#{sha.GetValue(null)}";

        var date = File.GetLastWriteTime(AppContext.BaseDirectory);
        build += $" (dev-{date:yyyyMMdd})";

#else
        var build = "";
#endif

        Text = $"Automatic Radar Seed Extrapolator v{v.Major}.{v.Minor}.{v.Build}{build}";

        InitializeComponent();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        CenterToScreen();

        if (Config.Protocol is SwitchProtocol.WiFi)
        {
            TB_SwitchIP.Text = Config.IP;
        }
        else
        {
            L_SwitchIP.Text = "USB Port:";
            TB_SwitchIP.Text = $"{Config.UsbPort}";
        }

        TB_TID.Text = $"{Config.TID:D5}";
        TB_SID.Text = $"{Config.SID:D5}";

        CB_Game.SelectedIndex = Config.Game;

        CB_Rate.SelectedIndex = 4;
        CB_Action.SelectedIndex = 1;

        SetTextBoxText("0", TB_Seed0, TB_Seed1);
        SetTextBoxText(string.Empty, TB_CurrentAdvances, TB_AdvancesIncrease, TB_CurrentS0, TB_CurrentS1);

        TB_Status.Text = "Not Connected.";

        // CheckForUpdates();
    }

    private void Connect(CancellationToken token)
    {
        Task.Run(
            async () =>
            {
                SetControlEnabledState(false, B_Connect);
                try
                {
                    ConnectionConfig.IP = TB_SwitchIP.Text;
                    (bool success, string err) = await ConnectionWrapper
                        .Connect(token)
                        .ConfigureAwait(false);
                    if (!success)
                    {
                        SetControlEnabledState(true, B_Connect);
                        this.DisplayMessageBox(err);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    SetControlEnabledState(true, B_Connect);
                    this.DisplayMessageBox(ex.Message);
                    return;
                }

                UpdateStatus("Detecting game version...");

                /*if (game is "")
                {
                    try
                    {
                        (bool success, string err) = await ConnectionWrapper
                            .DisconnectAsync(token)
                            .ConfigureAwait(false);
                        if (!success)
                        {
                            SetControlEnabledState(true, B_Connect);
                            this.DisplayMessageBox(err);
                            return;
                        }
                    }
                    catch
                    {
                        // ignored
                    }
                    finally
                    {
                        SetControlEnabledState(true, B_Connect);
                        this.DisplayMessageBox("Unable to detect Pokémon Sword or Pokémon Shield running on your Switch!");
                    }
                    return;
                }*/

                // SetCheckBoxCheckedState(ConnectionWrapper.GetHasShinyCharm(), CB_ShinyCharm);
                var (tid, sid) = ConnectionWrapper.GetIDs();
                SetTextBoxText(tid, TB_TID);
                SetTextBoxText(sid, TB_SID);

                // SetComboBoxSelectedIndex(game == "Sword" ? (int)Game.Sword : (int)Game.Shield, CB_Game);

                UpdateStatus("Reading RNG State...");
                ulong _s0, _s1;
                try
                {
                    (_s0, _s1) = await ConnectionWrapper.ReadRNGState(token).ConfigureAwait(false);
                    SetTextBoxText($"{_s0:X16}", TB_Seed0, TB_CurrentS0);
                    SetTextBoxText($"{_s1:X16}", TB_Seed1, TB_CurrentS1);
                    SetTextBoxText("0", TB_CurrentAdvances, TB_AdvancesIncrease);

                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox($"Error occurred while reading initial RNG state: {ex.Message}");
                    return;
                }

                SetControlEnabledState(true, B_Disconnect, B_CopyToInitial, B_Forecast);

                UpdateStatus("Monitoring RNG State...");
                try
                {
                    total = 0;
                    stop = false;
                    remaining = 0;
                    long target = 0;

                    while (!stop)
                    {
                        if (ConnectionWrapper.Connected && !readPause)
                        {
                            if (total >= flipTarget) flipPause = true;
                            var (s0, s1) = await ConnectionWrapper.ReadRNGState(token).ConfigureAwait(false);
                            if (forecast && !found)
                            {
                                UpdateStatus("Forecasting...");
                                _cfg.ContinueRate = GetRateFromComboBox(GetComboBoxSelectedIndex(CB_Rate));
                                var num = GetNUDValue(NUD_SafeNum);
                                var (safe, dist) = Core.RNG.RadarContinuation.Forecast(s0, s1, (int)num, _cfg, 0);
                                if (safe)
                                {
                                    found = true;
                                    remaining = dist;
                                    target = (long)dist + total;
                                }

                            }
                            var adv = GetAdvancesPassed(_s0, _s1, s0, s1);
                            if (reset || adv > 0)
                            {
                                if (reset || adv == 50_000)
                                {
                                    total = 0;
                                    reset = false;
                                    adv = 0;
                                    remaining = 0;
                                    found = false;
                                    flipPause = true;
                                    flipTarget = 0;
                                }
                                else
                                {
                                    total += adv;
                                    if (found)
                                    {
                                        if (remaining <= adv)
                                        {
                                            UpdateStatus("Continuing Chain...");
                                            var action = GetTurboCommandFromComboBox(GetComboBoxSelectedIndex(CB_Action));
                                            if (action != string.Empty)
                                            {
                                                var actionTimes = GetNUDValue(NUD_ActionTimes);
                                                for (var i = 0; i < actionTimes; i++)
                                                {
                                                    await ConnectionWrapper.DoTurboCommand(action, token)
                                                        .ConfigureAwait(false);
                                                }
                                            }

                                            forecast = false;
                                            found = false;
                                            UpdateStatus("Monitoring RNG state...");
                                        }
                                        else
                                        {
                                            remaining -= adv;
                                            UpdateStatus($"Remaining: {remaining:N0} ({target:N0})");
                                        }

                                    }
                                }

                                _s0 = s0;
                                _s1 = s1;

                                SetTextBoxText($"{_s0:X16}", TB_CurrentS0);
                                SetTextBoxText($"{_s1:X16}", TB_CurrentS1);
                                SetTextBoxText($"{total:N0}", TB_CurrentAdvances);
                                SetTextBoxText($"{adv:N0}", TB_AdvancesIncrease);
                            }
                        }
                    }
                }
                catch
                {
                    // Ignored
                }
            },
            token
        );
    }

    private void Disconnect(CancellationToken token)
    {
        Task.Run(
            async () =>
            {
                SetControlEnabledState(false, B_Disconnect, B_Forecast);
                stop = true;
                try
                {
                    (bool success, string err) = await ConnectionWrapper.DisconnectAsync(token).ConfigureAwait(false);
                    if (!success) this.DisplayMessageBox(err);
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }
                await Source.CancelAsync().ConfigureAwait(false);
                Source = new();
                SetControlEnabledState(true, B_Connect);
            },
            token
        );
    }

    private void UpdateStatus(string status)
    {
        SetTextBoxText(status, TB_Status);
    }

    public void SetTextBoxText(string text, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not TextBox tb)
                continue;

            if (InvokeRequired)
                Invoke(() => tb.Text = text);
            else
                tb.Text = text;
        }
    }

    public void SetControlEnabledState(bool state, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not Control c)
                continue;

            if (InvokeRequired)
                Invoke(() => c.Enabled = state);
            else
                c.Enabled = state;
        }
    }

    public void SetBindingSourceDataSource(object source, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not BindingSource b)
                continue;

            if (InvokeRequired)
                Invoke(() => b.DataSource = source);
            else
                b.DataSource = source;
        }
    }

    public uint GetNUDValue(NumericUpDown c)
    {
        return (uint)(InvokeRequired ? Invoke(() => c.Value) : c.Value);
    }

    public int GetComboBoxSelectedIndex(ComboBox c)
    {
        return (InvokeRequired ? Invoke(() => c.SelectedIndex) : c.SelectedIndex);
    }

    private void B_Connect_Click(object sender, EventArgs e)
    {
        lock (_connectLock)
        {
            if (ConnectionWrapper is { Connected: true })
                return;

            ConnectionWrapper = new(ConnectionConfig, UpdateStatus);
            Connect(Source.Token);
        }
    }

    private void B_Disconnect_Click(object sender, EventArgs e)
    {
        lock (_connectLock)
        {
            if (ConnectionWrapper is not { Connected: true })
                return;

            Disconnect(Source.Token);
        }
    }

    private void B_CopyToInitial_Click(object sender, EventArgs e)
    {
#if DEBUG
        if (((Button)sender).Name == "B_CopyToInitial" && ModifierKeys == Keys.Shift)
        {
            Task.Run(
                async () =>
                {
                    try
                    {
                        ulong s0 = ulong.Parse(TB_Seed0.Text, NumberStyles.AllowHexSpecifier);
                        ulong s1 = ulong.Parse(TB_Seed1.Text, NumberStyles.AllowHexSpecifier);
                        await ConnectionWrapper.WriteRNGState(s0, s1, Source.Token).ConfigureAwait(false);
                        reset = true;
                    }
                    catch (Exception ex)
                    {
                        this.DisplayMessageBox($"Something went wrong when writing the RNG state: {ex.Message}");
                    }
                }
            );
        }
        else
        {
#endif
            if (TB_CurrentS0.Text != string.Empty && TB_CurrentS1.Text != string.Empty)
            {
                var s0 = TB_CurrentS0.Text;
                var s1 = TB_CurrentS1.Text;

                SetTextBoxText(s0, TB_Seed0);
                SetTextBoxText(s1, TB_Seed1);

                reset = true;
            }
#if DEBUG
        }
#endif
    }

    private void B_Forecast_Click(object sender, EventArgs e)
    {
        forecast = true;
        found = false;
    }

    private void B_Search_Click(object sender, EventArgs e)
    {
        var initial = ulong.Parse(TB_Initial.Text);
        var advances = ulong.Parse(TB_Advances.Text);

        var s0 = ulong.Parse(TB_Seed0.Text, NumberStyles.AllowHexSpecifier);
        var s1 = ulong.Parse(TB_Seed1.Text, NumberStyles.AllowHexSpecifier);

        RadarContinuationConfig cfg = new()
        {
            ContinueRate = GetRateFromComboBox(GetComboBoxSelectedIndex(CB_Rate)),
        };

        List<RadarContinuationFrame> results = [];

        Task.Run(async () =>
        {
            results = await Core.RNG.RadarContinuation.Generate(s0, s1, initial, advances, cfg);
            SetBindingSourceDataSource(results, ResultsSource);
            Frames = results;

            var subset = results[..99];
            SetTextBoxText($"{subset.Count(x => x.Fail == '*')}", TB_FailsNext);
            SetTextBoxText($"{results.Count(x => x.Fail == '*')}/{results.Count}", TB_FailsTotal);

            var nud = GetNUDValue(NUD_SafeNum);
            var fc = Core.RNG.RadarContinuation.Forecast(s0, s1, (int)nud, cfg, initial, initial + 0xFFFFFFFF);
            SetTextBoxText(fc.found ? $"{(fc.advances + initial):N0}" : "None found", TB_SafeDistance);
        });
    }

    private void DGV_Results_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var index = e.RowIndex;
        if (Frames.Count <= index) return;
        var row = DGV_Results.Rows[index];
        var result = Frames[index];

        if (result.Fail == '*') row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
        else row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
    }

    private void B_Up_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("D-Pad Up", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("D-Pad Down", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("D-Pad Left", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("D-Pad Right", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button8_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("-", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("A", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button6_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("B", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button5_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("X", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button7_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("Y", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button9_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("Up (Hold)", Source.Token).ConfigureAwait(false);
                await ConnectionWrapper.DoTurboCommand("Release Stick", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button10_Click(object sender, EventArgs e)
    {
        var t = textBox1.Text;
        var h = Frames.Where(x => x.Seed0 == t || x.Seed1 == t).FirstOrDefault();
        if (h is not null)
        {
            MessageBox.Show($"{h.Advances} ({h.Seed0} {h.Seed1})");
        }
        else
            MessageBox.Show("No result found!")
                ;
    }

    private void button11_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("HOME", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button12_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            if (ConnectionWrapper.Connected)
            {
                await ConnectionWrapper.DoTurboCommand("R", Source.Token).ConfigureAwait(false);
            }
        });
    }

    private void button13_Click(object sender, EventArgs e)
    {
        flipTarget = long.Parse(TB_FlipTarget.Text);
        flipPause = false;
        Task.Run(async () =>
        {
            try
            {
                await ConnectionWrapper.SetMainLoopSleepTime(39, CancellationToken.None).ConfigureAwait(false);

                while (ConnectionWrapper.Connected && !flipPause)
                {
                    await ConnectionWrapper.DoTurboCommand("Right (Hold)", CancellationToken.None).ConfigureAwait(false);
                    await Task.Delay(40, CancellationToken.None).ConfigureAwait(false);
                    await ConnectionWrapper.DoTurboCommand("Left (Hold)", CancellationToken.None).ConfigureAwait(false);
                    await Task.Delay(40, CancellationToken.None).ConfigureAwait(false);
                }

                await ConnectionWrapper.DoTurboCommand("Reset Stick", CancellationToken.None).ConfigureAwait(false);

                await ConnectionWrapper.SetMainLoopSleepTime(49, CancellationToken.None).ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
            }
        });
    }

    private void button14_Click(object sender, EventArgs e)
    {
        flipPause = true;
        flipTarget = 0;
    }
}

