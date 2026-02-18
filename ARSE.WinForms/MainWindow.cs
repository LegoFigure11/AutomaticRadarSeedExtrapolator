using ARSE.Core;
using ARSE.Core.Connection;
using ARSE.Core.Enums;
using ARSE.Core.Interfaces;
using PKHeX.Core;
using SysBot.Base;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using static ARSE.Core.Encounters;
using static ARSE.Core.RNG.Util;

namespace ARSE.WinForms;

public partial class MainWindow : Form
{
    private static CancellationTokenSource Source = new();
    private static readonly Lock _connectLock = new();

    public ClientConfig Config;
    private ConnectionWrapperAsync ConnectionWrapper = default!;
    private readonly SwitchConnectionConfig ConnectionConfig;

    private bool stop;
    private bool reset;
    private bool readPause;
    private bool forecast;
    private long total;
    private bool found;
    private ulong remaining;
    private bool auto;
    private ulong targetAdvance;

    private RadarContinuationConfig _cfg = new();

    List<RadarContinuationFrame> ContinuationFrames = [];
    List<PokemonFrame> PokemonFrames = [];

    public readonly GameStrings Strings = GameInfo.GetStrings("en");

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
        UpdateEncounterSlotsAreas();

        CB_Rate.SelectedIndex = 4;
        CB_Action.SelectedIndex = 1;
        SetComboBoxSelectedIndex(0, CB_CaliDir, CB_Patch, CB_Lead, CB_Filter_Shiny, CB_Filter_Height);

        SetTextBoxText("0", TB_Seed0, TB_Seed1);
        SetTextBoxText(string.Empty, TB_CurrentAdvances, TB_AdvancesIncrease, TB_CurrentS0, TB_CurrentS1);

        TB_Status.Text = "Not Connected.";
        TB_Wild.Text = string.Empty;

        CheckForUpdates();
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

                var (tid, sid) = ConnectionWrapper.GetIDs();
                SetTextBoxText(tid, TB_TID);
                SetTextBoxText(sid, TB_SID);

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

                await ConnectionWrapper.DoTurboCommand("Release Stick", token).ConfigureAwait(false);

                SetControlEnabledState(true, B_Disconnect, B_CopyToInitial, B_Forecast, B_ReadChainCount, B_ReadChainSpecies, findSafeAdvanceToolStripMenuItem);
#if DEBUG
                SetControlVisibleState(true, B_A, B_B, B_X, B_Y, B_Up, B_Down, B_Left, B_Right, B_Minus, TB_Input);
#endif

                UpdateStatus("Monitoring RNG State...");
                try
                {
                    total = 0;
                    stop = false;
                    remaining = 0;
                    long target = 0;
                    string dir = string.Empty;
                    while (!stop)
                    {
                        if (ConnectionWrapper.Connected && !readPause)
                        {
                            var (s0, s1) = await ConnectionWrapper.ReadRNGState(token).ConfigureAwait(false);
                            if (auto)
                            {
                                UpdateStatus($"Primed! {targetAdvance:N0}");
                                dir = GetTurboCommandFromComboBox(GetComboBoxSelectedIndex(CB_CaliDir) + 3);
                            }
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
                                }
                                else
                                {
                                    total += adv;
                                    if (auto)
                                    {
                                        if ((ulong)total >= targetAdvance)
                                        {
                                            readPause = true;
                                            await ConnectionWrapper.DoTurboCommand(dir, token).ConfigureAwait(false);
                                            UpdateStatus("Monitoring RNG State...");

                                            var __s0 = ulong.Parse(TB_Seed0.Text, NumberStyles.AllowHexSpecifier);
                                            var __s1 = ulong.Parse(TB_Seed1.Text, NumberStyles.AllowHexSpecifier);
                                            var d = GetNUDValue(NUD_Delay);
                                            var ecs = await Core.RNG.ChainPokemon.GenerateECs(__s0, __s1, (uint)targetAdvance + 2000);
                                            var pk = new PB8();
                                            do
                                            {
                                                await Task.Delay(2_000, token).ConfigureAwait(false);
                                                pk = await ConnectionWrapper.ReadWildPokemon(token).ConfigureAwait(false);
                                            } while (pk.Species <= 0);

                                            var ec = pk.EncryptionConstant;
                                            var idx = ecs.IndexOf(ec);
                                            this.DisplayMessageBox(idx == -1 ? "EC not found!" : $"Target {targetAdvance + d} was {(targetAdvance + d == (ulong)idx ? "Hit" : "Missed")}!\n\nEC was on advance {idx}, after {(uint)idx - targetAdvance} advances. \"{dir}\" happened on advance {total}, while aiming for {targetAdvance}.", "Calibration Result");
                                            SetNUDValue(Math.Max(0, (uint)idx - targetAdvance), NUD_Delay);
                                            readPause = false;
                                            auto = false;
                                        }
                                    }
                                    else if (found)
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

    public void SetControlVisibleState(bool state, params object[] obj)
    {
        foreach (object o in obj)
        {
            if (o is not Control c)
                continue;

            if (InvokeRequired)
                Invoke(() => c.Visible = state);
            else
                c.Visible = state;
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

    public void SetNUDValue(decimal val, params NumericUpDown[] nuds)
    {
        foreach (var nud in nuds)
        {
            if (InvokeRequired) Invoke(() => nud.Value = val);
            else nud.Value = val;
        }
    }

    public int GetComboBoxSelectedIndex(ComboBox c)
    {
        return (InvokeRequired ? Invoke(() => c.SelectedIndex) : c.SelectedIndex);
    }

    public void SetComboBoxOption(string opt, params ComboBox[] cbs)
    {
        foreach (var cb in cbs)
        {
            if (InvokeRequired) Invoke(() => cb.SelectedIndex = cb.Items.IndexOf(opt));
            else cb.SelectedIndex = cb.Items.IndexOf(opt);
        }
    }

    public void SetComboBoxSelectedIndex(int idx, params ComboBox[] cbs)
    {
        foreach (var cb in cbs)
        {
            if (InvokeRequired) Invoke(() => cb.SelectedIndex = idx);
            else cb.SelectedIndex = idx;
        }
    }

    public string GetComboBoxSelectedText(ComboBox c)
    {
        return (InvokeRequired ? Invoke(() => c.SelectedText) : c.SelectedText);
    }

    public string GetControlText(Control c)
    {
        return (InvokeRequired ? Invoke(() => c.Text) : c.Text);
    }

    public bool GetCheckBoxCheckedState(CheckBox c)
    {
        return (InvokeRequired ? Invoke(() => c.Checked) : c.Checked);
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

                try
                {
                    Task.Run(async () =>
                    {
                        await ConnectionWrapper.PressHOME(2000, Source.Token).ConfigureAwait(false);
                        reset = true;
                        await ConnectionWrapper.PressHOME(0, Source.Token).ConfigureAwait(false);
                    });
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }

                reset = true;
            }
#if DEBUG
        }
#endif
    }

    private void B_Forecast_Click(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                if (ConnectionWrapper.Connected)
                {
                    await ConnectionWrapper.PressHOME(2_000, Source.Token).ConfigureAwait(false);
                    forecast = true;
                    found = false;
                    // Task.Delay(2000, Source.Token).ConfigureAwait(false);
                    await ConnectionWrapper.PressHOME(0, Source.Token).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                this.DisplayMessageBox(ex.Message);
            }
        });
    }

    private void B_Search_Click(object sender, EventArgs e)
    {
        ValidateInputs();

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
            SetBindingSourceDataSource(results, ResultsSourceContinuation);
            ContinuationFrames = results;

            var subset = results[..99];
            SetTextBoxText($"{subset.Count(x => x.Fail == '*')}", TB_FailsNext);
            SetTextBoxText($"{results.Count(x => x.Fail == '*')}/{results.Count}", TB_FailsTotal);

            var nud = GetNUDValue(NUD_SafeNum);
            var fc = Core.RNG.RadarContinuation.Forecast(s0, s1, (int)nud, cfg, initial, initial + 0xFFFFFFFF);
            SetTextBoxText(fc.found ? $"{(fc.advances + initial):N0}" : "None found", TB_SafeDistance);
        });
    }

    private void DGV_ResultsContinuation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var index = e.RowIndex;
        if (ContinuationFrames.Count <= index) return;
        var row = DGV_ResultsContinuation.Rows[index];
        var result = ContinuationFrames[index];

        if (result.Fail == '*') row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
        else row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
    }

    private void B_PokemonSearch_Click(object sender, EventArgs e)
    {
        ValidateInputs();

        var initial = ulong.Parse(TB_MonInitial.Text);
        var advances = ulong.Parse(TB_MonAdv.Text);

        var s0 = ulong.Parse(TB_Seed0.Text, NumberStyles.AllowHexSpecifier);
        var s1 = ulong.Parse(TB_Seed1.Text, NumberStyles.AllowHexSpecifier);

        ChainPokemonConfig cfg = new()
        {
            Cluster = (byte)GetNUDValue(NUD_Cluster),
            ForceHiddenAbility = GetComboBoxSelectedIndex(CB_Patch) == 2,
            IsShinyPatch = GetComboBoxSelectedIndex(CB_Patch) == 1,
            TID = uint.Parse(GetControlText(TB_TID)),
            SID = uint.Parse(GetControlText(TB_SID)),
            ChainLength = (int)GetNUDValue(NUD_ChainCount),
            Species = SpeciesNameToValue(GetControlText(CB_Species)),
            IsSync = GetComboBoxSelectedIndex(CB_Lead) == 1,

            TargetMinIVs = [GetNUDValue(NUD_HP_Min), GetNUDValue(NUD_Atk_Min), GetNUDValue(NUD_Def_Min), GetNUDValue(NUD_SpA_Min), GetNUDValue(NUD_SpD_Min), GetNUDValue(NUD_Spe_Min)],
            TargetMaxIVs = [GetNUDValue(NUD_HP_Max), GetNUDValue(NUD_Atk_Max), GetNUDValue(NUD_Def_Max), GetNUDValue(NUD_SpA_Max), GetNUDValue(NUD_SpD_Max), GetNUDValue(NUD_Spe_Max)],
            SearchTypes = [GetIVSearchType(GetControlText(L_HPSpacer)), GetIVSearchType(GetControlText(L_AtkSpacer)), GetIVSearchType(GetControlText(L_DefSpacer)), GetIVSearchType(GetControlText(L_SpASpacer)), GetIVSearchType(GetControlText(L_SpDSpacer)), GetIVSearchType(GetControlText(L_SpeSpacer))],
            RareEC = GetCheckBoxCheckedState(CB_RareEC),

            TargetShiny = GetFilterShinyType(GetComboBoxSelectedIndex(CB_Filter_Shiny)),
            TargetScale = (ScaleType)(GetComboBoxSelectedIndex(CB_Filter_Height)),

            FiltersEnabled = GetCheckBoxCheckedState(CB_EnableFilters),
        };

        List<PokemonFrame> results = [];

        Task.Run(async () =>
        {
            SetControlEnabledState(false, B_PokemonSearch);
            results = await Core.RNG.ChainPokemon.Generate(s0, s1, initial, advances, cfg);
            SetBindingSourceDataSource(results, ResultsSourcePokemon);
            PokemonFrames = results;
            SetControlEnabledState(true, B_PokemonSearch);
        });
    }

    private static ShinyType GetFilterShinyType(int selected) => selected switch
    {
        1 => ShinyType.Either,
        2 => ShinyType.Square,
        3 => ShinyType.Star,
        4 => ShinyType.None,
        _ => ShinyType.Any,
    };

    private void B_IV_Max_Click(object sender, EventArgs e)
    {
        var st = ((Button)sender).Name.Replace("B_", string.Empty).Replace("_Max", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            min.Value = 31;
            max.Value = 31;
        }
    }

    private void B_IV_Min_Click(object sender, EventArgs e)
    {
        var st = ((Button)sender).Name.Replace("B_", string.Empty).Replace("_Min", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            min.Value = 0;
            max.Value = 0;
        }
    }

    private void IV_Label_Click(object sender, EventArgs e)
    {
        var st = ((Label)sender).Name.Replace("L_", string.Empty);
        List<string> stats = ModifierKeys == Keys.Shift ? ["HP", "Atk", "Def", "SpA", "SpD", "Spe"] : [st];
        foreach (var stat in stats)
        {
            var min = (NumericUpDown)Controls.Find($"NUD_{stat}_Min", true).FirstOrDefault()!;
            var max = (NumericUpDown)Controls.Find($"NUD_{stat}_Max", true).FirstOrDefault()!;
            var lab = (Label)Controls.Find($"L_{stat}Spacer", true).FirstOrDefault()!;
            min.Value = 0;
            max.Value = 31;
            if (lab.Text == "||")
            {
                lab.Text = "~";
                lab.Location = lab.Location with { X = lab.Location.X - 1 };
            }
        }
    }

    private void IV_Spacer_Click(object sender, EventArgs e)
    {
        var l = (Label)sender;
        if (l.Text == "~")
        {
            l.Text = "||";
            l.Location = l.Location with { X = l.Location.X + 1 };
        }
        else
        {
            l.Text = "~";
            l.Location = l.Location with { X = l.Location.X - 1 };
        }
    }

    private void CB_Game_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateEncounterSlotsAreas();
    }

    private void UpdateEncounterSlotsAreas()
    {
        var game = (Game)CB_Game.SelectedIndex;
        var areas = GetAreaList(game);
        CB_Area.DataSource = areas;
        CB_Area.SelectedIndex = 0;

        UpdateEncounterSlotsSpecies();
    }

    private void UpdateEncounterSlotsSpecies()
    {
        var game = (Game)CB_Game.SelectedIndex;
        var area = CB_Area.SelectedItem;
        var species = GetEncountersForArea(game, $"{area}");
        CB_Species.DataSource = species;
    }

    private void CB_Area_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateEncounterSlotsSpecies();
    }

    private void TB_TID_TextChanged(object sender, EventArgs e)
    {
        if (TB_TID.Text.Length > 0)
        {
            var tid = int.Parse(TB_TID.Text);
            if (tid > 0xFFFF)
            {
                tid = 0xFFFF;
                SetTextBoxText($"{tid}", TB_TID);
            }
            Config.TID = tid;
        }
    }

    private void TB_SID_TextChanged(object sender, EventArgs e)
    {
        if (TB_SID.Text.Length > 0)
        {
            var sid = int.Parse(TB_SID.Text);
            if (sid > 0xFFFF)
            {
                sid = 0xFFFF;
                SetTextBoxText($"{sid}", TB_SID);
            }
            Config.SID = sid;
        }
    }

    private void TB_SwitchIP_TextChanged(object sender, EventArgs e)
    {
        if (Config.Protocol is SwitchProtocol.WiFi)
        {
            Config.IP = TB_SwitchIP.Text;
            ConnectionConfig.IP = TB_SwitchIP.Text;
        }
        else
        {
            if (int.TryParse(TB_SwitchIP.Text, out var port) && port >= 0)
            {
                Config.UsbPort = port;
                ConnectionConfig.Port = port;
                return;
            }

            MessageBox.Show("Please enter a valid numerical USB port.");
        }
    }

    private readonly JsonSerializerOptions options = new() { WriteIndented = true };
    private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
        var configpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        string output = JsonSerializer.Serialize(Config, options);
        using StreamWriter sw = new(configpath);
        sw.Write(output);

        if (ConnectionWrapper is { Connected: true })
        {
            try
            {
                _ = ConnectionWrapper.DisconnectAsync(Source.Token).ConfigureAwait(false);
            }
            catch
            {
                // ignored
            }
        }

        Source.Cancel();
        Source = new();
    }

    private void B_ReadChainCount_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    readPause = true;
                    await Task.Delay(100, Source.Token).ConfigureAwait(false);
                    var count = await ConnectionWrapper.GetChainLength(Source.Token).ConfigureAwait(false);
                    readPause = false;
                    SetNUDValue(count, NUD_ChainCount);
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }
            });
        }
    }

    private void B_ReadChainSpecies_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    readPause = true;
                    await Task.Delay(100, Source.Token).ConfigureAwait(false);
                    var val = await ConnectionWrapper.GetChainSpecies(Source.Token).ConfigureAwait(false);
                    readPause = false;
                    var species = ValueToSpeciesName(val);
                    var lastIndex = GetComboBoxSelectedIndex(CB_Species);
                    SetComboBoxOption(species, CB_Species);
                    if (GetComboBoxSelectedIndex(CB_Species) == -1)
                    {
                        this.DisplayMessageBox($"{species} was not found in the current encounter table! Have you selected the right area?");
                        SetComboBoxSelectedIndex(lastIndex, CB_Species);
                    }
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }
            });
        }
    }

    private void B_ReadWildPokemon_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    readPause = true;
                    await Task.Delay(100, Source.Token).ConfigureAwait(false);
                    var pk = await ConnectionWrapper.ReadWildPokemon(Source.Token).ConfigureAwait(false);
                    readPause = false;
                    if (pk is { Valid: true, Species: > 0 })
                    {
                        // CachedEncounter = pk;

                        var n = Environment.NewLine;

                        var form = pk.Form == 0 ? string.Empty : $"-{pk.Form}";
                        var gender = pk.Gender switch
                        {
                            0 => " (M)",
                            1 => " (F)",
                            _ => string.Empty,
                        };
                        var shiny = pk.ShinyXor switch
                        {
                            0 => "■ - ",
                            < 16 => "★ - ",
                            _ => string.Empty,
                        };


                        var item = pk.HeldItem > 0 ? $" @ {Strings.Item[pk.HeldItem]}" : string.Empty;

                        var scale = $"Height: {PokeSizeDetailedUtil.GetSizeRating(pk.HeightScalar)} ({pk.HeightScalar})";

                        var moves = pk.Moves.TakeWhile(move => move != 0).Aggregate(string.Empty, (current, move) => current + $"{n}- {Strings.Move[move]}");

                        var output = $"{shiny}{(Species)pk.Species}{form}{gender}{item}{n}EC: {pk.EncryptionConstant:X8}{n}PID: {pk.PID:X8}{n}{Strings.Natures[(int)pk.Nature]} Nature{n}Ability: {Strings.Ability[pk.Ability]}{n}IVs: {pk.IV_HP}/{pk.IV_ATK}/{pk.IV_DEF}/{pk.IV_SPA}/{pk.IV_SPD}/{pk.IV_SPE}{n}{scale}{moves}";

                        readPause = false;
                        //SetPictureBoxImage(pk.Sprite(), PB_PokemonSprite);
                        SetTextBoxText(output, TB_Wild);
                        //SetControlEnabledState(true, B_CopyToFilter);
                    }

                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox(ex.Message);
                }
            });
        }
    }

    private void B_HitTarget_Click(object sender, EventArgs e)
    {
        ValidateInputs();

        var t = ulong.Parse(GetControlText(TB_Target));
        var d = GetNUDValue(NUD_Delay);
        targetAdvance = t - d;
        auto = true;
    }

    private void B_Up_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("D-Pad Up", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_Left_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("D-Pad Left", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_Down_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("D-Pad Down", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_Right_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("D-Pad Right", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_Minus_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("-", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_A_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("A", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_B_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("B", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_X_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("X", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private void B_Y_Click(object sender, EventArgs e)
    {
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    await ConnectionWrapper.DoTurboCommand("Y", Source.Token).ConfigureAwait(false);
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    private string GetTurboCommandFromKey(Keys key) => key switch
    {
        Keys.Left => "D-Pad Left",
        Keys.Right => "D-Pad Right",
        Keys.Up => "D-Pad Up",
        Keys.Down => "D-Pad Down",
        Keys.Z => "A",
        Keys.X => "B",
        Keys.A => "X",
        Keys.S => "Y",
        Keys.Q => "-",
        _ => "",
    };

    private void TB_Input_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = true;
        TB_Input.Text = "";
        if (ConnectionWrapper.Connected)
        {
            Task.Run(async () =>
            {
                try
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            B_Forecast_Click(sender, EventArgs.Empty);
                            break;
                        case Keys.M:
                            await ConnectionWrapper.DoTurboCommand("A", Source.Token).ConfigureAwait(false);
                            break;
                        case Keys.P:
                            readPause = true;
                            await Task.Delay(200, Source.Token).ConfigureAwait(false);
                            await ConnectionWrapper.RechargeRadar(Source.Token).ConfigureAwait(false);
                            readPause = false;
                            break;
                        case Keys.Space:
                            await ConnectionWrapper.DoTurboCommand("X", Source.Token).ConfigureAwait(false);
                            await Task.Delay(1_000, Source.Token).ConfigureAwait(false);
                            await ConnectionWrapper.DoTurboCommand("A", Source.Token).ConfigureAwait(false);
                            await Task.Delay(16_500, Source.Token).ConfigureAwait(false);
                            await ConnectionWrapper.DoTurboCommand("A", Source.Token).ConfigureAwait(false);
                            B_Forecast_Click(sender, EventArgs.Empty);
                            break;
                        default:
                            await ConnectionWrapper.DoTurboCommand(GetTurboCommandFromKey(e.KeyCode), Source.Token).ConfigureAwait(false);
                            break;
                    }
                }
                catch
                {
                    // Ignore
                }
            });
        }
    }

    public static readonly Font BoldFont = new("Microsoft Sans Serif", 8, FontStyle.Bold);
    private void DGV_ResultsPokemon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var index = e.RowIndex;
        if (PokemonFrames.Count <= index) return;
        var row = DGV_ResultsPokemon.Rows[index];
        var result = PokemonFrames[index];

        if (result.Shiny is "Square" && GetComboBoxSelectedIndex(CB_Patch) != 1) row.DefaultCellStyle.BackColor = Color.LightCyan;
        else if (result.Shiny.Contains("Star")) row.DefaultCellStyle.BackColor = Color.Aqua;
        else row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;

        const int iv = 6;
        byte[] ivs = [result.H, result.A, result.B, result.C, result.D, result.S];
        for (var i = 0; i < ivs.Length; i++)
        {
            if (ivs[i] == 0)
            {
                row.Cells[iv + i].Style.Font = BoldFont;
                row.Cells[iv + i].Style.ForeColor = Color.OrangeRed;
            }
            else if (ivs[i] == 31)
            {
                row.Cells[iv + i].Style.Font = BoldFont;
                row.Cells[iv + i].Style.ForeColor = Color.SeaGreen;
            }
            else
            {
                row.Cells[iv + i].Style.ForeColor = row.DefaultCellStyle.ForeColor;
                row.Cells[iv + i].Style.Font = row.DefaultCellStyle.Font;
            }
        }

        row.Cells[14].Style.Font = result.Height is not "XXXL (255)" and not "XXXS (0)" ? row.DefaultCellStyle.Font : BoldFont;
    }

    private void findSafeAdvanceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        B_Forecast_Click(sender, e);
    }

    private void AllowOnlyHex_KeyPress(object sender, KeyPressEventArgs e)
    {
        var c = e.KeyChar;
        if (c != (char)Keys.Back && !char.IsControl(c))
        {
            if (!c.IsHex())
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }

    public void AllowOnlyNumerical_KeyPress(object sender, KeyPressEventArgs e)
    {
        var c = e.KeyChar;
        if (c != (char)Keys.Back && !char.IsControl(c))
        {
            if (!c.IsDec())
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }

    public void AllowOnlyIP_KeyPress(object sender, KeyPressEventArgs e)
    {
        var c = e.KeyChar;
        if (c != (char)Keys.Back && !char.IsControl(c))
        {
            if (!c.IsDec(true))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }

    public void State_HandlePaste(object sender, KeyEventArgs e)
    {
        if (e is not { Modifiers: Keys.Control, KeyCode: Keys.V } && e is not { Modifiers: Keys.Shift, KeyCode: Keys.Insert }) return;
        var n = string.Empty;
        var newline = 0;
        foreach (char c in Clipboard.GetText())
        {
            if (c.IsHex()) n += c;
            if (c == (char)Keys.Enter) newline++;
        }

        var l = n.Length;
        if (l == 0)
        {
            Clipboard.Clear();
            return;
        }
        if (l == 32 && newline <= 1)
        {
            ((Control)sender).Parent!.Controls.Find("TB_Seed0", true).FirstOrDefault()!.Text = n[..16];
            ((Control)sender).Parent!.Controls.Find("TB_Seed1", true).FirstOrDefault()!.Text = n[16..32];
        }
        else if (l > 16)
        {
            ((TextBox)sender).Text = n[..16];
        }
        else
        {
            Clipboard.SetText(n);
        }
    }

    public void Dec_HandlePaste(object sender, KeyEventArgs e)
    {
        if (e is not { Modifiers: Keys.Control, KeyCode: Keys.V } && e is not { Modifiers: Keys.Shift, KeyCode: Keys.Insert }) return;
        var n = string.Empty;

        foreach (char c in Clipboard.GetText())
        {
            if (c.IsDec()) n += c;
        }

        var l = n.Length;
        var tb = (TextBox)sender;
        var max = tb.MaxLength;
        if (l == 0)
        {
            Clipboard.Clear();
        }
        else if (l > max)
        {
            tb.Text = n[..max];
        }
        else
        {
            Clipboard.SetText(n);
        }
    }

    private void IP_HandlePaste(object sender, KeyEventArgs e)
    {
        if (e is not { Modifiers: Keys.Control, KeyCode: Keys.V } && e is not { Modifiers: Keys.Shift, KeyCode: Keys.Insert }) return;
        var n = string.Empty;

        foreach (char c in Clipboard.GetText())
        {
            if (c.IsDec(true)) n += c;
        }

        var l = n.Length;
        var tb = (TextBox)sender;
        var max = tb.MaxLength;
        if (l == 0)
        {
            Clipboard.Clear();
        }
        else if (l > max)
        {
            tb.Text = n[..max];
        }
        else
        {
            Clipboard.SetText(n);
        }
    }

    private void ValidateInputs()
    {
        // Initial
        var initial = (TextBox)Controls.Find($"TB_Initial", true).FirstOrDefault()!;
        if (string.IsNullOrEmpty(initial.GetText())) SetTextBoxText("0", initial);
        var mon = (TextBox)Controls.Find($"TB_MonInitial", true).FirstOrDefault()!;
        if (string.IsNullOrEmpty(mon.GetText())) SetTextBoxText("0", mon);

        // Advances
        var advances = (TextBox)Controls.Find($"TB_Advances", true).FirstOrDefault()!;
        var adv = advances.GetText();
        if (string.IsNullOrEmpty(adv) || adv is "0") SetTextBoxText("1", advances);

        var monadvances = (TextBox)Controls.Find($"TB_MonAdvances", true).FirstOrDefault()!;
        var monadv = advances.GetText();
        if (string.IsNullOrEmpty(monadv) || monadv is "0") SetTextBoxText("1", monadvances);

        // Seed
        if (string.IsNullOrEmpty(TB_Seed0.GetText())) SetTextBoxText("0", TB_Seed0);
        if (string.IsNullOrEmpty(TB_Seed1.GetText())) SetTextBoxText("0", TB_Seed1);

        if (TB_Seed0.GetText() is "0" && TB_Seed1.GetText() is "0")
        {
            SetTextBoxText("1337", TB_Seed0);
            SetTextBoxText("1390", TB_Seed1);
        }
        SetTextBoxText(TB_Seed0.GetText().PadLeft(16, '0'), TB_Seed0);
        SetTextBoxText(TB_Seed1.GetText().PadLeft(16, '0'), TB_Seed1);

        // IDs
        if (string.IsNullOrEmpty(TB_TID.GetText())) SetTextBoxText("0", TB_TID);
        if (string.IsNullOrEmpty(TB_SID.GetText())) SetTextBoxText("0", TB_SID);
        SetTextBoxText(TB_TID.GetText().PadLeft(5, '0'), TB_TID);
        SetTextBoxText(TB_SID.GetText().PadLeft(5, '0'), TB_SID);

        // Target
        var tgt = (TextBox)Controls.Find($"TB_Target", true).FirstOrDefault()!;
        if (string.IsNullOrEmpty(tgt.GetText()) || tgt.GetText() is "0") SetTextBoxText("1000", tgt);
    }

    private void CheckForUpdates()
    {
        Task.Run(async () =>
        {
            Version? latestVersion;
            try { latestVersion = Utils.GetLatestVersion(); }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception while checking for latest version: {ex}");
                return;
            }

            if (latestVersion is null || latestVersion <= CurrentVersion)
                return;

            while (!IsHandleCreated) // Wait for form to be ready
                await Task.Delay(2_000).ConfigureAwait(false);
            await InvokeAsync(() => NotifyNewVersionAvailable(latestVersion));
        });
    }

    private void NotifyNewVersionAvailable(Version version)
    {
        Text += $" - Update v{version.Major}.{version.Minor}.{version.Build} available!";

#if !DEBUG
        using Subforms.UpdateNotifPopup nup = new(CurrentVersion, version);
        if (nup.ShowDialog() == DialogResult.OK)
        {
            Process.Start(new ProcessStartInfo("https://github.com/LegoFigure11/AutomaticRadarSeedExtrapolator/releases/")
            {
                UseShellExecute = true
            });
        }
#endif
    }
}

