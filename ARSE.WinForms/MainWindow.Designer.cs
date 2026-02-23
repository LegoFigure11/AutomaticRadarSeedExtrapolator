namespace ARSE.WinForms;

    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        GB_Connection = new GroupBox();
        TB_AdvancesIncrease = new TextBox();
        B_CopyToInitial = new Button();
        L_CurrentS1 = new Label();
        TB_Status = new TextBox();
        L_CurrentS0 = new Label();
        TB_CurrentS1 = new TextBox();
        L_Status = new Label();
        TB_CurrentS0 = new TextBox();
        TB_CurrentAdvances = new TextBox();
        L_CurrentAdvances = new Label();
        B_Disconnect = new Button();
        B_Connect = new Button();
        L_SwitchIP = new Label();
        TB_SwitchIP = new TextBox();
        GB_Seed = new GroupBox();
        L_Seed1 = new Label();
        L_Seed0 = new Label();
        TB_Seed1 = new TextBox();
        TB_Seed0 = new TextBox();
        GB_SAVInfo = new GroupBox();
        L_Game = new Label();
        CB_Game = new ComboBox();
        L_SID = new Label();
        L_TID = new Label();
        TB_SID = new TextBox();
        TB_TID = new TextBox();
        NUD_SafeNum = new NumericUpDown();
        L_SafeNum = new Label();
        B_Forecast = new Button();
        DGV_ResultsContinuation = new DataGridView();
        advancesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        seed0DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        seed1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        failDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        rollDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ResultsSourceContinuation = new BindingSource(components);
        B_Search = new Button();
        L_Static_Advances = new Label();
        L_Static_Initial = new Label();
        TB_Advances = new TextBox();
        TB_Initial = new TextBox();
        TB_FailsNext = new TextBox();
        TB_FailsTotal = new TextBox();
        label1 = new Label();
        label2 = new Label();
        TB_SafeDistance = new TextBox();
        L_SafeDistance = new Label();
        CB_Rate = new ComboBox();
        label4 = new Label();
        CB_Action = new ComboBox();
        label5 = new Label();
        NUD_ActionTimes = new NumericUpDown();
        label6 = new Label();
        B_PokemonSearch = new Button();
        DGV_ResultsPokemon = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        Cluster = new DataGridViewTextBoxColumn();
        Shiny = new DataGridViewTextBoxColumn();
        Ability = new DataGridViewTextBoxColumn();
        Nature = new DataGridViewTextBoxColumn();
        Gender = new DataGridViewTextBoxColumn();
        H = new DataGridViewTextBoxColumn();
        A = new DataGridViewTextBoxColumn();
        B = new DataGridViewTextBoxColumn();
        C = new DataGridViewTextBoxColumn();
        D = new DataGridViewTextBoxColumn();
        S = new DataGridViewTextBoxColumn();
        EC = new DataGridViewTextBoxColumn();
        PID = new DataGridViewTextBoxColumn();
        Height = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        ResultsSourcePokemon = new BindingSource(components);
        GB_Filters = new GroupBox();
        L_Delay = new Label();
        NUD_Delay = new NumericUpDown();
        NUD_Cluster = new NumericUpDown();
        L_Cluster = new Label();
        CB_RareEC = new CheckBox();
        CB_EnableFilters = new CheckBox();
        L_Filter_Height = new Label();
        CB_Filter_Height = new ComboBox();
        L_Filter_Shiny = new Label();
        CB_Filter_Shiny = new ComboBox();
        B_Spe_Max = new Button();
        B_Spe_Min = new Button();
        L_Spe = new Label();
        L_SpeSpacer = new Label();
        NUD_Spe_Max = new NumericUpDown();
        NUD_Spe_Min = new NumericUpDown();
        B_SpD_Max = new Button();
        B_SpD_Min = new Button();
        L_SpD = new Label();
        L_SpDSpacer = new Label();
        NUD_SpD_Max = new NumericUpDown();
        NUD_SpD_Min = new NumericUpDown();
        B_SpA_Max = new Button();
        B_SpA_Min = new Button();
        L_SpA = new Label();
        L_SpASpacer = new Label();
        NUD_SpA_Max = new NumericUpDown();
        NUD_SpA_Min = new NumericUpDown();
        B_Def_Max = new Button();
        B_Def_Min = new Button();
        L_Def = new Label();
        L_DefSpacer = new Label();
        NUD_Def_Max = new NumericUpDown();
        NUD_Def_Min = new NumericUpDown();
        B_Atk_Max = new Button();
        B_Atk_Min = new Button();
        L_Atk = new Label();
        L_AtkSpacer = new Label();
        NUD_Atk_Max = new NumericUpDown();
        NUD_Atk_Min = new NumericUpDown();
        B_HP_Max = new Button();
        B_HP_Min = new Button();
        L_HP = new Label();
        L_HPSpacer = new Label();
        NUD_HP_Max = new NumericUpDown();
        NUD_HP_Min = new NumericUpDown();
        groupBox1 = new GroupBox();
        L_MonAdv = new Label();
        L_MonInitial = new Label();
        TB_MonAdv = new TextBox();
        TB_MonInitial = new TextBox();
        B_ReadChainSpecies = new Button();
        B_ReadChainCount = new Button();
        L_Area = new Label();
        CB_Area = new ComboBox();
        L_Species = new Label();
        CB_Species = new ComboBox();
        L_Lead = new Label();
        CB_Lead = new ComboBox();
        L_ChainCount = new Label();
        NUD_ChainCount = new NumericUpDown();
        L_Patch = new Label();
        CB_Patch = new ComboBox();
        B_ReadWildPokemon = new Button();
        TB_Wild = new TextBox();
        B_Left = new Button();
        B_Right = new Button();
        B_Up = new Button();
        B_Down = new Button();
        B_B = new Button();
        B_X = new Button();
        B_A = new Button();
        B_Y = new Button();
        B_Minus = new Button();
        TB_Input = new TextBox();
        menuStrip1 = new MenuStrip();
        shortcutsToolStripMenuItem = new ToolStripMenuItem();
        findSafeAdvanceToolStripMenuItem = new ToolStripMenuItem();
        B_CalcDelayAuto = new Button();
        TB_SafeDistance3 = new TextBox();
        TB_SafeDistance2 = new TextBox();
        TB_SafeDistance1 = new TextBox();
        B_CalcDelayManual = new Button();
        GB_Connection.SuspendLayout();
        GB_Seed.SuspendLayout();
        GB_SAVInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_SafeNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DGV_ResultsContinuation).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSourceContinuation).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ActionTimes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DGV_ResultsPokemon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSourcePokemon).BeginInit();
        GB_Filters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Delay).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Cluster).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Min).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ChainCount).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // GB_Connection
        // 
        GB_Connection.Controls.Add(TB_AdvancesIncrease);
        GB_Connection.Controls.Add(B_CopyToInitial);
        GB_Connection.Controls.Add(L_CurrentS1);
        GB_Connection.Controls.Add(TB_Status);
        GB_Connection.Controls.Add(L_CurrentS0);
        GB_Connection.Controls.Add(TB_CurrentS1);
        GB_Connection.Controls.Add(L_Status);
        GB_Connection.Controls.Add(TB_CurrentS0);
        GB_Connection.Controls.Add(TB_CurrentAdvances);
        GB_Connection.Controls.Add(L_CurrentAdvances);
        GB_Connection.Controls.Add(B_Disconnect);
        GB_Connection.Controls.Add(B_Connect);
        GB_Connection.Controls.Add(L_SwitchIP);
        GB_Connection.Controls.Add(TB_SwitchIP);
        GB_Connection.Location = new Point(0, 43);
        GB_Connection.Margin = new Padding(3, 0, 3, 3);
        GB_Connection.Name = "GB_Connection";
        GB_Connection.RightToLeft = RightToLeft.No;
        GB_Connection.Size = new Size(212, 184);
        GB_Connection.TabIndex = 2;
        GB_Connection.TabStop = false;
        // 
        // TB_AdvancesIncrease
        // 
        TB_AdvancesIncrease.CharacterCasing = CharacterCasing.Lower;
        TB_AdvancesIncrease.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_AdvancesIncrease.Location = new Point(159, 82);
        TB_AdvancesIncrease.MaxLength = 15;
        TB_AdvancesIncrease.Name = "TB_AdvancesIncrease";
        TB_AdvancesIncrease.ReadOnly = true;
        TB_AdvancesIncrease.Size = new Size(47, 22);
        TB_AdvancesIncrease.TabIndex = 21;
        TB_AdvancesIncrease.TabStop = false;
        TB_AdvancesIncrease.Text = "12,345";
        TB_AdvancesIncrease.TextAlign = HorizontalAlignment.Right;
        // 
        // B_CopyToInitial
        // 
        B_CopyToInitial.Enabled = false;
        B_CopyToInitial.Location = new Point(11, 154);
        B_CopyToInitial.Name = "B_CopyToInitial";
        B_CopyToInitial.Size = new Size(196, 25);
        B_CopyToInitial.TabIndex = 3;
        B_CopyToInitial.Text = "Update Seeds";
        B_CopyToInitial.UseVisualStyleBackColor = true;
        B_CopyToInitial.Click += B_CopyToInitial_Click;
        // 
        // L_CurrentS1
        // 
        L_CurrentS1.AutoSize = true;
        L_CurrentS1.Location = new Point(11, 132);
        L_CurrentS1.Name = "L_CurrentS1";
        L_CurrentS1.Size = new Size(49, 15);
        L_CurrentS1.TabIndex = 11;
        L_CurrentS1.Text = "Seed[1]:";
        // 
        // TB_Status
        // 
        TB_Status.BackColor = SystemColors.Control;
        TB_Status.BorderStyle = BorderStyle.None;
        TB_Status.Location = new Point(74, 64);
        TB_Status.Name = "TB_Status";
        TB_Status.ReadOnly = true;
        TB_Status.RightToLeft = RightToLeft.No;
        TB_Status.Size = new Size(132, 16);
        TB_Status.TabIndex = 18;
        TB_Status.TabStop = false;
        TB_Status.Text = "wwwwwwwwwwwwww";
        TB_Status.TextAlign = HorizontalAlignment.Right;
        // 
        // L_CurrentS0
        // 
        L_CurrentS0.AutoSize = true;
        L_CurrentS0.Location = new Point(11, 108);
        L_CurrentS0.Name = "L_CurrentS0";
        L_CurrentS0.Size = new Size(49, 15);
        L_CurrentS0.TabIndex = 10;
        L_CurrentS0.Text = "Seed[0]:";
        // 
        // TB_CurrentS1
        // 
        TB_CurrentS1.CharacterCasing = CharacterCasing.Upper;
        TB_CurrentS1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_CurrentS1.Location = new Point(88, 130);
        TB_CurrentS1.MaxLength = 16;
        TB_CurrentS1.Name = "TB_CurrentS1";
        TB_CurrentS1.ReadOnly = true;
        TB_CurrentS1.Size = new Size(118, 22);
        TB_CurrentS1.TabIndex = 9;
        TB_CurrentS1.TabStop = false;
        TB_CurrentS1.Text = "0123456789ABCDEF";
        // 
        // L_Status
        // 
        L_Status.AutoSize = true;
        L_Status.Location = new Point(11, 64);
        L_Status.Name = "L_Status";
        L_Status.Size = new Size(42, 15);
        L_Status.TabIndex = 17;
        L_Status.Text = "Status:";
        // 
        // TB_CurrentS0
        // 
        TB_CurrentS0.CharacterCasing = CharacterCasing.Upper;
        TB_CurrentS0.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_CurrentS0.Location = new Point(88, 106);
        TB_CurrentS0.MaxLength = 16;
        TB_CurrentS0.Name = "TB_CurrentS0";
        TB_CurrentS0.ReadOnly = true;
        TB_CurrentS0.Size = new Size(118, 22);
        TB_CurrentS0.TabIndex = 8;
        TB_CurrentS0.TabStop = false;
        TB_CurrentS0.Text = "0123456789ABCDEF";
        // 
        // TB_CurrentAdvances
        // 
        TB_CurrentAdvances.CharacterCasing = CharacterCasing.Lower;
        TB_CurrentAdvances.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_CurrentAdvances.Location = new Point(51, 82);
        TB_CurrentAdvances.MaxLength = 15;
        TB_CurrentAdvances.Name = "TB_CurrentAdvances";
        TB_CurrentAdvances.ReadOnly = true;
        TB_CurrentAdvances.Size = new Size(106, 22);
        TB_CurrentAdvances.TabIndex = 16;
        TB_CurrentAdvances.TabStop = false;
        TB_CurrentAdvances.Text = "12,345,678,901";
        TB_CurrentAdvances.TextAlign = HorizontalAlignment.Right;
        // 
        // L_CurrentAdvances
        // 
        L_CurrentAdvances.AutoSize = true;
        L_CurrentAdvances.Location = new Point(11, 87);
        L_CurrentAdvances.Name = "L_CurrentAdvances";
        L_CurrentAdvances.Size = new Size(34, 15);
        L_CurrentAdvances.TabIndex = 15;
        L_CurrentAdvances.Text = "Adv.:";
        // 
        // B_Disconnect
        // 
        B_Disconnect.Enabled = false;
        B_Disconnect.Location = new Point(109, 36);
        B_Disconnect.Name = "B_Disconnect";
        B_Disconnect.Size = new Size(97, 25);
        B_Disconnect.TabIndex = 2;
        B_Disconnect.Text = "Disconnect";
        B_Disconnect.UseVisualStyleBackColor = true;
        B_Disconnect.Click += B_Disconnect_Click;
        // 
        // B_Connect
        // 
        B_Connect.Location = new Point(11, 36);
        B_Connect.Name = "B_Connect";
        B_Connect.Size = new Size(97, 25);
        B_Connect.TabIndex = 1;
        B_Connect.Text = "Connect";
        B_Connect.UseVisualStyleBackColor = true;
        B_Connect.Click += B_Connect_Click;
        // 
        // L_SwitchIP
        // 
        L_SwitchIP.AutoSize = true;
        L_SwitchIP.Location = new Point(11, 17);
        L_SwitchIP.Name = "L_SwitchIP";
        L_SwitchIP.Size = new Size(58, 15);
        L_SwitchIP.TabIndex = 12;
        L_SwitchIP.Text = "Switch IP:";
        // 
        // TB_SwitchIP
        // 
        TB_SwitchIP.CharacterCasing = CharacterCasing.Lower;
        TB_SwitchIP.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SwitchIP.Location = new Point(95, 12);
        TB_SwitchIP.MaxLength = 15;
        TB_SwitchIP.Name = "TB_SwitchIP";
        TB_SwitchIP.Size = new Size(111, 22);
        TB_SwitchIP.TabIndex = 0;
        TB_SwitchIP.Text = "123.123.123.123";
        TB_SwitchIP.TextChanged += TB_SwitchIP_TextChanged;
        TB_SwitchIP.KeyDown += IP_HandlePaste;
        TB_SwitchIP.KeyPress += AllowOnlyIP_KeyPress;
        // 
        // GB_Seed
        // 
        GB_Seed.Controls.Add(L_Seed1);
        GB_Seed.Controls.Add(L_Seed0);
        GB_Seed.Controls.Add(TB_Seed1);
        GB_Seed.Controls.Add(TB_Seed0);
        GB_Seed.Location = new Point(0, -8);
        GB_Seed.Name = "GB_Seed";
        GB_Seed.RightToLeft = RightToLeft.No;
        GB_Seed.Size = new Size(212, 60);
        GB_Seed.TabIndex = 3;
        GB_Seed.TabStop = false;
        // 
        // L_Seed1
        // 
        L_Seed1.AutoSize = true;
        L_Seed1.Location = new Point(11, 35);
        L_Seed1.Name = "L_Seed1";
        L_Seed1.Size = new Size(49, 15);
        L_Seed1.TabIndex = 7;
        L_Seed1.Text = "Seed[1]:";
        // 
        // L_Seed0
        // 
        L_Seed0.AutoSize = true;
        L_Seed0.Location = new Point(11, 11);
        L_Seed0.Name = "L_Seed0";
        L_Seed0.Size = new Size(49, 15);
        L_Seed0.TabIndex = 6;
        L_Seed0.Text = "Seed[0]:";
        // 
        // TB_Seed1
        // 
        TB_Seed1.CharacterCasing = CharacterCasing.Upper;
        TB_Seed1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Seed1.Location = new Point(88, 33);
        TB_Seed1.MaxLength = 16;
        TB_Seed1.Name = "TB_Seed1";
        TB_Seed1.Size = new Size(118, 22);
        TB_Seed1.TabIndex = 1;
        TB_Seed1.Text = "0123456789ABCDEF";
        TB_Seed1.KeyDown += State_HandlePaste;
        TB_Seed1.KeyPress += AllowOnlyHex_KeyPress;
        // 
        // TB_Seed0
        // 
        TB_Seed0.CharacterCasing = CharacterCasing.Upper;
        TB_Seed0.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Seed0.Location = new Point(88, 9);
        TB_Seed0.MaxLength = 16;
        TB_Seed0.Name = "TB_Seed0";
        TB_Seed0.Size = new Size(118, 22);
        TB_Seed0.TabIndex = 0;
        TB_Seed0.Text = "0123456789ABCDEF";
        TB_Seed0.KeyDown += State_HandlePaste;
        TB_Seed0.KeyPress += AllowOnlyHex_KeyPress;
        // 
        // GB_SAVInfo
        // 
        GB_SAVInfo.Controls.Add(L_Game);
        GB_SAVInfo.Controls.Add(CB_Game);
        GB_SAVInfo.Controls.Add(L_SID);
        GB_SAVInfo.Controls.Add(L_TID);
        GB_SAVInfo.Controls.Add(TB_SID);
        GB_SAVInfo.Controls.Add(TB_TID);
        GB_SAVInfo.Location = new Point(0, 217);
        GB_SAVInfo.Name = "GB_SAVInfo";
        GB_SAVInfo.Size = new Size(212, 83);
        GB_SAVInfo.TabIndex = 4;
        GB_SAVInfo.TabStop = false;
        // 
        // L_Game
        // 
        L_Game.AutoSize = true;
        L_Game.Location = new Point(11, 47);
        L_Game.Name = "L_Game";
        L_Game.Size = new Size(41, 15);
        L_Game.TabIndex = 11;
        L_Game.Text = "Game:";
        // 
        // CB_Game
        // 
        CB_Game.FormattingEnabled = true;
        CB_Game.Items.AddRange(new object[] { "Brilliant Diamond", "Shining Pearl" });
        CB_Game.Location = new Point(71, 44);
        CB_Game.Name = "CB_Game";
        CB_Game.Size = new Size(135, 23);
        CB_Game.TabIndex = 2;
        CB_Game.SelectedIndexChanged += CB_Game_SelectedIndexChanged;
        // 
        // L_SID
        // 
        L_SID.AutoSize = true;
        L_SID.Location = new Point(132, 18);
        L_SID.Name = "L_SID";
        L_SID.Size = new Size(27, 15);
        L_SID.TabIndex = 20;
        L_SID.Text = "SID:";
        // 
        // L_TID
        // 
        L_TID.AutoSize = true;
        L_TID.Location = new Point(25, 18);
        L_TID.Name = "L_TID";
        L_TID.Size = new Size(27, 15);
        L_TID.TabIndex = 19;
        L_TID.Text = "TID:";
        // 
        // TB_SID
        // 
        TB_SID.CharacterCasing = CharacterCasing.Upper;
        TB_SID.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SID.Location = new Point(165, 16);
        TB_SID.MaxLength = 5;
        TB_SID.Name = "TB_SID";
        TB_SID.Size = new Size(41, 22);
        TB_SID.TabIndex = 1;
        TB_SID.Text = "54321";
        TB_SID.TextChanged += TB_SID_TextChanged;
        // 
        // TB_TID
        // 
        TB_TID.CharacterCasing = CharacterCasing.Upper;
        TB_TID.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_TID.Location = new Point(71, 16);
        TB_TID.MaxLength = 5;
        TB_TID.Name = "TB_TID";
        TB_TID.Size = new Size(41, 22);
        TB_TID.TabIndex = 0;
        TB_TID.Text = "12345";
        TB_TID.TextChanged += TB_TID_TextChanged;
        // 
        // NUD_SafeNum
        // 
        NUD_SafeNum.Location = new Point(480, 5);
        NUD_SafeNum.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        NUD_SafeNum.Name = "NUD_SafeNum";
        NUD_SafeNum.Size = new Size(38, 23);
        NUD_SafeNum.TabIndex = 0;
        NUD_SafeNum.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // L_SafeNum
        // 
        L_SafeNum.AutoSize = true;
        L_SafeNum.Location = new Point(230, 7);
        L_SafeNum.Name = "L_SafeNum";
        L_SafeNum.Size = new Size(113, 15);
        L_SafeNum.TabIndex = 6;
        L_SafeNum.Text = "Min. Safe Advances:";
        // 
        // B_Forecast
        // 
        B_Forecast.Enabled = false;
        B_Forecast.Location = new Point(230, 55);
        B_Forecast.Name = "B_Forecast";
        B_Forecast.Size = new Size(288, 25);
        B_Forecast.TabIndex = 3;
        B_Forecast.Text = "Find Safe Advance";
        B_Forecast.UseVisualStyleBackColor = true;
        B_Forecast.Click += B_Forecast_Click;
        // 
        // DGV_ResultsContinuation
        // 
        DGV_ResultsContinuation.AllowUserToAddRows = false;
        DGV_ResultsContinuation.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
        DGV_ResultsContinuation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        DGV_ResultsContinuation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        DGV_ResultsContinuation.AutoGenerateColumns = false;
        DGV_ResultsContinuation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DGV_ResultsContinuation.Columns.AddRange(new DataGridViewColumn[] { advancesDataGridViewTextBoxColumn, seed0DataGridViewTextBoxColumn, seed1DataGridViewTextBoxColumn, failDataGridViewTextBoxColumn, rollDataGridViewTextBoxColumn });
        DGV_ResultsContinuation.DataSource = ResultsSourceContinuation;
        DGV_ResultsContinuation.Location = new Point(12, 306);
        DGV_ResultsContinuation.Name = "DGV_ResultsContinuation";
        DGV_ResultsContinuation.ReadOnly = true;
        DGV_ResultsContinuation.RowHeadersVisible = false;
        DGV_ResultsContinuation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DGV_ResultsContinuation.Size = new Size(506, 293);
        DGV_ResultsContinuation.TabIndex = 8;
        DGV_ResultsContinuation.CellFormatting += DGV_ResultsContinuation_CellFormatting;
        // 
        // advancesDataGridViewTextBoxColumn
        // 
        advancesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        advancesDataGridViewTextBoxColumn.DataPropertyName = "Advances";
        advancesDataGridViewTextBoxColumn.HeaderText = "Advances";
        advancesDataGridViewTextBoxColumn.Name = "advancesDataGridViewTextBoxColumn";
        advancesDataGridViewTextBoxColumn.ReadOnly = true;
        advancesDataGridViewTextBoxColumn.Width = 83;
        // 
        // seed0DataGridViewTextBoxColumn
        // 
        seed0DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        seed0DataGridViewTextBoxColumn.DataPropertyName = "Seed0";
        seed0DataGridViewTextBoxColumn.HeaderText = "Seed0";
        seed0DataGridViewTextBoxColumn.Name = "seed0DataGridViewTextBoxColumn";
        seed0DataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // seed1DataGridViewTextBoxColumn
        // 
        seed1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        seed1DataGridViewTextBoxColumn.DataPropertyName = "Seed1";
        seed1DataGridViewTextBoxColumn.HeaderText = "Seed1";
        seed1DataGridViewTextBoxColumn.Name = "seed1DataGridViewTextBoxColumn";
        seed1DataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // failDataGridViewTextBoxColumn
        // 
        failDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        failDataGridViewTextBoxColumn.DataPropertyName = "Fail";
        failDataGridViewTextBoxColumn.HeaderText = "Fail";
        failDataGridViewTextBoxColumn.Name = "failDataGridViewTextBoxColumn";
        failDataGridViewTextBoxColumn.ReadOnly = true;
        failDataGridViewTextBoxColumn.Width = 50;
        // 
        // rollDataGridViewTextBoxColumn
        // 
        rollDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        rollDataGridViewTextBoxColumn.DataPropertyName = "Roll";
        rollDataGridViewTextBoxColumn.HeaderText = "Roll";
        rollDataGridViewTextBoxColumn.Name = "rollDataGridViewTextBoxColumn";
        rollDataGridViewTextBoxColumn.ReadOnly = true;
        rollDataGridViewTextBoxColumn.Width = 52;
        // 
        // ResultsSourceContinuation
        // 
        ResultsSourceContinuation.DataSource = typeof(Core.Interfaces.RadarContinuationFrame);
        // 
        // B_Search
        // 
        B_Search.Location = new Point(230, 173);
        B_Search.Name = "B_Search";
        B_Search.Size = new Size(288, 25);
        B_Search.TabIndex = 7;
        B_Search.Text = "Generate";
        B_Search.UseVisualStyleBackColor = true;
        B_Search.Click += B_Search_Click;
        // 
        // L_Static_Advances
        // 
        L_Static_Advances.AutoSize = true;
        L_Static_Advances.Location = new Point(324, 147);
        L_Static_Advances.Name = "L_Static_Advances";
        L_Static_Advances.Size = new Size(15, 15);
        L_Static_Advances.TabIndex = 61;
        L_Static_Advances.Text = "+";
        // 
        // L_Static_Initial
        // 
        L_Static_Initial.AutoSize = true;
        L_Static_Initial.Location = new Point(246, 123);
        L_Static_Initial.Name = "L_Static_Initial";
        L_Static_Initial.Size = new Size(93, 15);
        L_Static_Initial.TabIndex = 60;
        L_Static_Initial.Text = "Initial Advances:";
        // 
        // TB_Advances
        // 
        TB_Advances.CharacterCasing = CharacterCasing.Upper;
        TB_Advances.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Advances.Location = new Point(345, 145);
        TB_Advances.MaxLength = 16;
        TB_Advances.Name = "TB_Advances";
        TB_Advances.Size = new Size(173, 22);
        TB_Advances.TabIndex = 6;
        TB_Advances.Text = "500";
        TB_Advances.TextAlign = HorizontalAlignment.Right;
        TB_Advances.KeyDown += Dec_HandlePaste;
        TB_Advances.KeyPress += AllowOnlyNumerical_KeyPress;
        // 
        // TB_Initial
        // 
        TB_Initial.CharacterCasing = CharacterCasing.Upper;
        TB_Initial.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Initial.Location = new Point(345, 121);
        TB_Initial.MaxLength = 16;
        TB_Initial.Name = "TB_Initial";
        TB_Initial.Size = new Size(173, 22);
        TB_Initial.TabIndex = 5;
        TB_Initial.Text = "0";
        TB_Initial.TextAlign = HorizontalAlignment.Right;
        TB_Initial.KeyDown += Dec_HandlePaste;
        TB_Initial.KeyPress += AllowOnlyNumerical_KeyPress;
        // 
        // TB_FailsNext
        // 
        TB_FailsNext.CharacterCasing = CharacterCasing.Upper;
        TB_FailsNext.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_FailsNext.Location = new Point(434, 207);
        TB_FailsNext.MaxLength = 16;
        TB_FailsNext.Name = "TB_FailsNext";
        TB_FailsNext.ReadOnly = true;
        TB_FailsNext.Size = new Size(84, 22);
        TB_FailsNext.TabIndex = 62;
        TB_FailsNext.TextAlign = HorizontalAlignment.Right;
        // 
        // TB_FailsTotal
        // 
        TB_FailsTotal.CharacterCasing = CharacterCasing.Upper;
        TB_FailsTotal.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_FailsTotal.Location = new Point(434, 230);
        TB_FailsTotal.MaxLength = 16;
        TB_FailsTotal.Name = "TB_FailsTotal";
        TB_FailsTotal.ReadOnly = true;
        TB_FailsTotal.Size = new Size(84, 22);
        TB_FailsTotal.TabIndex = 63;
        TB_FailsTotal.TextAlign = HorizontalAlignment.Right;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(230, 208);
        label1.Name = "label1";
        label1.Size = new Size(162, 15);
        label1.TabIndex = 64;
        label1.Text = "Failures in next 100 advances:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(230, 232);
        label2.Name = "label2";
        label2.Size = new Size(100, 15);
        label2.TabIndex = 65;
        label2.Text = "Failures in results:";
        // 
        // TB_SafeDistance
        // 
        TB_SafeDistance.CharacterCasing = CharacterCasing.Upper;
        TB_SafeDistance.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SafeDistance.Location = new Point(434, 254);
        TB_SafeDistance.MaxLength = 16;
        TB_SafeDistance.Name = "TB_SafeDistance";
        TB_SafeDistance.ReadOnly = true;
        TB_SafeDistance.Size = new Size(84, 22);
        TB_SafeDistance.TabIndex = 66;
        TB_SafeDistance.TextAlign = HorizontalAlignment.Right;
        // 
        // L_SafeDistance
        // 
        L_SafeDistance.AutoSize = true;
        L_SafeDistance.Location = new Point(230, 256);
        L_SafeDistance.Name = "L_SafeDistance";
        L_SafeDistance.Size = new Size(180, 15);
        L_SafeDistance.TabIndex = 67;
        L_SafeDistance.Text = "Next safe advance (100 in a row):";
        // 
        // CB_Rate
        // 
        CB_Rate.FormattingEnabled = true;
        CB_Rate.Items.AddRange(new object[] { "53%", "63%", "73%", "83%", "93%" });
        CB_Rate.Location = new Point(345, 96);
        CB_Rate.Name = "CB_Rate";
        CB_Rate.Size = new Size(173, 23);
        CB_Rate.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(254, 99);
        label4.Name = "label4";
        label4.Size = new Size(85, 15);
        label4.TabIndex = 69;
        label4.Text = "Continue Rate:";
        // 
        // CB_Action
        // 
        CB_Action.FormattingEnabled = true;
        CB_Action.Items.AddRange(new object[] { "(None)", "Press A", "Press HOME" });
        CB_Action.Location = new Point(345, 30);
        CB_Action.Name = "CB_Action";
        CB_Action.Size = new Size(116, 23);
        CB_Action.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(246, 33);
        label5.Name = "label5";
        label5.Size = new Size(93, 15);
        label5.TabIndex = 71;
        label5.Text = "Action at Target:";
        // 
        // NUD_ActionTimes
        // 
        NUD_ActionTimes.Location = new Point(480, 31);
        NUD_ActionTimes.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        NUD_ActionTimes.Name = "NUD_ActionTimes";
        NUD_ActionTimes.Size = new Size(38, 23);
        NUD_ActionTimes.TabIndex = 2;
        NUD_ActionTimes.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(467, 33);
        label6.Name = "label6";
        label6.Size = new Size(13, 15);
        label6.TabIndex = 73;
        label6.Text = "x";
        // 
        // B_PokemonSearch
        // 
        B_PokemonSearch.Location = new Point(566, 275);
        B_PokemonSearch.Name = "B_PokemonSearch";
        B_PokemonSearch.Size = new Size(227, 25);
        B_PokemonSearch.TabIndex = 124;
        B_PokemonSearch.Text = "Generate";
        B_PokemonSearch.UseVisualStyleBackColor = true;
        B_PokemonSearch.Click += B_PokemonSearch_Click;
        // 
        // DGV_ResultsPokemon
        // 
        DGV_ResultsPokemon.AllowUserToAddRows = false;
        DGV_ResultsPokemon.AllowUserToDeleteRows = false;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
        DGV_ResultsPokemon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
        DGV_ResultsPokemon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DGV_ResultsPokemon.AutoGenerateColumns = false;
        DGV_ResultsPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DGV_ResultsPokemon.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Cluster, Shiny, Ability, Nature, Gender, H, A, B, C, D, S, EC, PID, Height, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        DGV_ResultsPokemon.DataSource = ResultsSourcePokemon;
        DGV_ResultsPokemon.Location = new Point(545, 306);
        DGV_ResultsPokemon.Name = "DGV_ResultsPokemon";
        DGV_ResultsPokemon.ReadOnly = true;
        DGV_ResultsPokemon.RowHeadersVisible = false;
        DGV_ResultsPokemon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DGV_ResultsPokemon.Size = new Size(922, 293);
        DGV_ResultsPokemon.TabIndex = 125;
        DGV_ResultsPokemon.CellFormatting += DGV_ResultsPokemon_CellFormatting;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Advances";
        dataGridViewTextBoxColumn1.HeaderText = "Advances";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 83;
        // 
        // Cluster
        // 
        Cluster.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Cluster.DataPropertyName = "Cluster";
        Cluster.HeaderText = "Cluster";
        Cluster.Name = "Cluster";
        Cluster.ReadOnly = true;
        Cluster.Width = 69;
        // 
        // Shiny
        // 
        Shiny.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Shiny.DataPropertyName = "Shiny";
        Shiny.HeaderText = "Shiny";
        Shiny.Name = "Shiny";
        Shiny.ReadOnly = true;
        Shiny.Width = 61;
        // 
        // Ability
        // 
        Ability.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Ability.DataPropertyName = "Ability";
        Ability.HeaderText = "Ability";
        Ability.Name = "Ability";
        Ability.ReadOnly = true;
        Ability.Width = 66;
        // 
        // Nature
        // 
        Nature.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Nature.DataPropertyName = "Nature";
        Nature.HeaderText = "Nature";
        Nature.Name = "Nature";
        Nature.ReadOnly = true;
        Nature.Width = 68;
        // 
        // Gender
        // 
        Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Gender.DataPropertyName = "Gender";
        Gender.HeaderText = "Gender";
        Gender.Name = "Gender";
        Gender.ReadOnly = true;
        Gender.Width = 70;
        // 
        // H
        // 
        H.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        H.DataPropertyName = "H";
        H.HeaderText = "HP";
        H.Name = "H";
        H.ReadOnly = true;
        H.Width = 48;
        // 
        // A
        // 
        A.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        A.DataPropertyName = "A";
        A.HeaderText = "Atk";
        A.Name = "A";
        A.ReadOnly = true;
        A.Width = 50;
        // 
        // B
        // 
        B.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        B.DataPropertyName = "B";
        B.HeaderText = "Def";
        B.Name = "B";
        B.ReadOnly = true;
        B.Width = 50;
        // 
        // C
        // 
        C.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        C.DataPropertyName = "C";
        C.HeaderText = "SpA";
        C.Name = "C";
        C.ReadOnly = true;
        C.Width = 53;
        // 
        // D
        // 
        D.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        D.DataPropertyName = "D";
        D.HeaderText = "SpD";
        D.Name = "D";
        D.ReadOnly = true;
        D.Width = 53;
        // 
        // S
        // 
        S.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        S.DataPropertyName = "S";
        S.HeaderText = "Spe";
        S.Name = "S";
        S.ReadOnly = true;
        S.Width = 51;
        // 
        // EC
        // 
        EC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EC.DataPropertyName = "EC";
        EC.HeaderText = "EC";
        EC.Name = "EC";
        EC.ReadOnly = true;
        EC.Width = 46;
        // 
        // PID
        // 
        PID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PID.DataPropertyName = "PID";
        PID.HeaderText = "PID";
        PID.Name = "PID";
        PID.ReadOnly = true;
        PID.Width = 50;
        // 
        // Height
        // 
        Height.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Height.DataPropertyName = "Height";
        Height.HeaderText = "Height";
        Height.Name = "Height";
        Height.ReadOnly = true;
        Height.Width = 68;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Seed0";
        dataGridViewTextBoxColumn2.HeaderText = "Seed0";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 63;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Seed1";
        dataGridViewTextBoxColumn3.HeaderText = "Seed1";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 63;
        // 
        // ResultsSourcePokemon
        // 
        ResultsSourcePokemon.DataSource = typeof(Core.Interfaces.PokemonFrame);
        // 
        // GB_Filters
        // 
        GB_Filters.Controls.Add(L_Delay);
        GB_Filters.Controls.Add(NUD_Delay);
        GB_Filters.Controls.Add(NUD_Cluster);
        GB_Filters.Controls.Add(L_Cluster);
        GB_Filters.Controls.Add(CB_RareEC);
        GB_Filters.Controls.Add(CB_EnableFilters);
        GB_Filters.Controls.Add(L_Filter_Height);
        GB_Filters.Controls.Add(CB_Filter_Height);
        GB_Filters.Controls.Add(L_Filter_Shiny);
        GB_Filters.Controls.Add(CB_Filter_Shiny);
        GB_Filters.Controls.Add(B_Spe_Max);
        GB_Filters.Controls.Add(B_Spe_Min);
        GB_Filters.Controls.Add(L_Spe);
        GB_Filters.Controls.Add(L_SpeSpacer);
        GB_Filters.Controls.Add(NUD_Spe_Max);
        GB_Filters.Controls.Add(NUD_Spe_Min);
        GB_Filters.Controls.Add(B_SpD_Max);
        GB_Filters.Controls.Add(B_SpD_Min);
        GB_Filters.Controls.Add(L_SpD);
        GB_Filters.Controls.Add(L_SpDSpacer);
        GB_Filters.Controls.Add(NUD_SpD_Max);
        GB_Filters.Controls.Add(NUD_SpD_Min);
        GB_Filters.Controls.Add(B_SpA_Max);
        GB_Filters.Controls.Add(B_SpA_Min);
        GB_Filters.Controls.Add(L_SpA);
        GB_Filters.Controls.Add(L_SpASpacer);
        GB_Filters.Controls.Add(NUD_SpA_Max);
        GB_Filters.Controls.Add(NUD_SpA_Min);
        GB_Filters.Controls.Add(B_Def_Max);
        GB_Filters.Controls.Add(B_Def_Min);
        GB_Filters.Controls.Add(L_Def);
        GB_Filters.Controls.Add(L_DefSpacer);
        GB_Filters.Controls.Add(NUD_Def_Max);
        GB_Filters.Controls.Add(NUD_Def_Min);
        GB_Filters.Controls.Add(B_Atk_Max);
        GB_Filters.Controls.Add(B_Atk_Min);
        GB_Filters.Controls.Add(L_Atk);
        GB_Filters.Controls.Add(L_AtkSpacer);
        GB_Filters.Controls.Add(NUD_Atk_Max);
        GB_Filters.Controls.Add(NUD_Atk_Min);
        GB_Filters.Controls.Add(B_HP_Max);
        GB_Filters.Controls.Add(B_HP_Min);
        GB_Filters.Controls.Add(L_HP);
        GB_Filters.Controls.Add(L_HPSpacer);
        GB_Filters.Controls.Add(NUD_HP_Max);
        GB_Filters.Controls.Add(NUD_HP_Min);
        GB_Filters.Location = new Point(799, 3);
        GB_Filters.Name = "GB_Filters";
        GB_Filters.Size = new Size(229, 297);
        GB_Filters.TabIndex = 126;
        GB_Filters.TabStop = false;
        GB_Filters.Text = "Search Filters";
        // 
        // L_Delay
        // 
        L_Delay.AutoSize = true;
        L_Delay.Location = new Point(37, 245);
        L_Delay.Name = "L_Delay";
        L_Delay.Size = new Size(39, 15);
        L_Delay.TabIndex = 167;
        L_Delay.Text = "Delay:";
        // 
        // NUD_Delay
        // 
        NUD_Delay.Location = new Point(82, 243);
        NUD_Delay.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        NUD_Delay.Name = "NUD_Delay";
        NUD_Delay.Size = new Size(142, 23);
        NUD_Delay.TabIndex = 166;
        NUD_Delay.TextAlign = HorizontalAlignment.Right;
        NUD_Delay.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // NUD_Cluster
        // 
        NUD_Cluster.Location = new Point(82, 218);
        NUD_Cluster.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        NUD_Cluster.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NUD_Cluster.Name = "NUD_Cluster";
        NUD_Cluster.Size = new Size(142, 23);
        NUD_Cluster.TabIndex = 26;
        NUD_Cluster.TextAlign = HorizontalAlignment.Right;
        NUD_Cluster.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // L_Cluster
        // 
        L_Cluster.AutoSize = true;
        L_Cluster.Location = new Point(2, 220);
        L_Cluster.Name = "L_Cluster";
        L_Cluster.Size = new Size(74, 15);
        L_Cluster.TabIndex = 165;
        L_Cluster.Text = "Min. Cluster:";
        // 
        // CB_RareEC
        // 
        CB_RareEC.AutoSize = true;
        CB_RareEC.CheckAlign = ContentAlignment.MiddleRight;
        CB_RareEC.Location = new Point(43, 274);
        CB_RareEC.Name = "CB_RareEC";
        CB_RareEC.Size = new Size(71, 19);
        CB_RareEC.TabIndex = 27;
        CB_RareEC.Tag = "";
        CB_RareEC.Text = "Rare EC?";
        CB_RareEC.UseVisualStyleBackColor = true;
        // 
        // CB_EnableFilters
        // 
        CB_EnableFilters.AutoSize = true;
        CB_EnableFilters.CheckAlign = ContentAlignment.MiddleRight;
        CB_EnableFilters.Checked = true;
        CB_EnableFilters.CheckState = CheckState.Checked;
        CB_EnableFilters.Location = new Point(117, 276);
        CB_EnableFilters.Name = "CB_EnableFilters";
        CB_EnableFilters.Size = new Size(107, 19);
        CB_EnableFilters.TabIndex = 28;
        CB_EnableFilters.Tag = "";
        CB_EnableFilters.Text = "Filters Enabled?";
        CB_EnableFilters.UseVisualStyleBackColor = true;
        // 
        // L_Filter_Height
        // 
        L_Filter_Height.AutoSize = true;
        L_Filter_Height.Location = new Point(30, 196);
        L_Filter_Height.Name = "L_Filter_Height";
        L_Filter_Height.Size = new Size(46, 15);
        L_Filter_Height.TabIndex = 163;
        L_Filter_Height.Text = "Height:";
        // 
        // CB_Filter_Height
        // 
        CB_Filter_Height.FormattingEnabled = true;
        CB_Filter_Height.Items.AddRange(new object[] { "Ignore", "XXXS", "XXS", "XS", "S", "M", "L", "XL", "XXL", "XXXL", "XXXS or XXXL" });
        CB_Filter_Height.Location = new Point(82, 193);
        CB_Filter_Height.Name = "CB_Filter_Height";
        CB_Filter_Height.Size = new Size(142, 23);
        CB_Filter_Height.TabIndex = 25;
        // 
        // L_Filter_Shiny
        // 
        L_Filter_Shiny.AutoSize = true;
        L_Filter_Shiny.Location = new Point(37, 171);
        L_Filter_Shiny.Name = "L_Filter_Shiny";
        L_Filter_Shiny.Size = new Size(39, 15);
        L_Filter_Shiny.TabIndex = 162;
        L_Filter_Shiny.Text = "Shiny:";
        // 
        // CB_Filter_Shiny
        // 
        CB_Filter_Shiny.FormattingEnabled = true;
        CB_Filter_Shiny.Items.AddRange(new object[] { "Ignore", "Star/Square", "Square Only", "Star Only", "Not Shiny" });
        CB_Filter_Shiny.Location = new Point(82, 168);
        CB_Filter_Shiny.Name = "CB_Filter_Shiny";
        CB_Filter_Shiny.Size = new Size(142, 23);
        CB_Filter_Shiny.TabIndex = 24;
        // 
        // B_Spe_Max
        // 
        B_Spe_Max.Location = new Point(197, 142);
        B_Spe_Max.Name = "B_Spe_Max";
        B_Spe_Max.Size = new Size(27, 25);
        B_Spe_Max.TabIndex = 23;
        B_Spe_Max.Text = "31";
        B_Spe_Max.UseVisualStyleBackColor = true;
        B_Spe_Max.Click += B_IV_Max_Click;
        // 
        // B_Spe_Min
        // 
        B_Spe_Min.Location = new Point(168, 142);
        B_Spe_Min.Name = "B_Spe_Min";
        B_Spe_Min.Size = new Size(27, 25);
        B_Spe_Min.TabIndex = 22;
        B_Spe_Min.Text = "0";
        B_Spe_Min.UseVisualStyleBackColor = true;
        B_Spe_Min.Click += B_IV_Min_Click;
        // 
        // L_Spe
        // 
        L_Spe.AutoSize = true;
        L_Spe.Location = new Point(47, 147);
        L_Spe.Name = "L_Spe";
        L_Spe.Size = new Size(29, 15);
        L_Spe.TabIndex = 161;
        L_Spe.Text = "Spe:";
        L_Spe.Click += IV_Label_Click;
        // 
        // L_SpeSpacer
        // 
        L_SpeSpacer.AutoSize = true;
        L_SpeSpacer.Location = new Point(115, 145);
        L_SpeSpacer.Name = "L_SpeSpacer";
        L_SpeSpacer.Size = new Size(15, 15);
        L_SpeSpacer.TabIndex = 11;
        L_SpeSpacer.Text = "~";
        L_SpeSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Spe_Max
        // 
        NUD_Spe_Max.Location = new Point(131, 143);
        NUD_Spe_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Max.Name = "NUD_Spe_Max";
        NUD_Spe_Max.Size = new Size(32, 23);
        NUD_Spe_Max.TabIndex = 140;
        NUD_Spe_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Spe_Min
        // 
        NUD_Spe_Min.Location = new Point(82, 143);
        NUD_Spe_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Min.Name = "NUD_Spe_Min";
        NUD_Spe_Min.Size = new Size(32, 23);
        NUD_Spe_Min.TabIndex = 10;
        // 
        // B_SpD_Max
        // 
        B_SpD_Max.Location = new Point(197, 117);
        B_SpD_Max.Name = "B_SpD_Max";
        B_SpD_Max.Size = new Size(27, 25);
        B_SpD_Max.TabIndex = 21;
        B_SpD_Max.Text = "31";
        B_SpD_Max.UseVisualStyleBackColor = true;
        B_SpD_Max.Click += B_IV_Max_Click;
        // 
        // B_SpD_Min
        // 
        B_SpD_Min.Location = new Point(168, 117);
        B_SpD_Min.Name = "B_SpD_Min";
        B_SpD_Min.Size = new Size(27, 25);
        B_SpD_Min.TabIndex = 20;
        B_SpD_Min.Text = "0";
        B_SpD_Min.UseVisualStyleBackColor = true;
        B_SpD_Min.Click += B_IV_Min_Click;
        // 
        // L_SpD
        // 
        L_SpD.AutoSize = true;
        L_SpD.Location = new Point(45, 123);
        L_SpD.Name = "L_SpD";
        L_SpD.Size = new Size(31, 15);
        L_SpD.TabIndex = 160;
        L_SpD.Text = "SpD:";
        L_SpD.Click += IV_Label_Click;
        // 
        // L_SpDSpacer
        // 
        L_SpDSpacer.AutoSize = true;
        L_SpDSpacer.Location = new Point(115, 120);
        L_SpDSpacer.Name = "L_SpDSpacer";
        L_SpDSpacer.Size = new Size(15, 15);
        L_SpDSpacer.TabIndex = 9;
        L_SpDSpacer.Text = "~";
        L_SpDSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_SpD_Max
        // 
        NUD_SpD_Max.Location = new Point(131, 118);
        NUD_SpD_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Max.Name = "NUD_SpD_Max";
        NUD_SpD_Max.Size = new Size(32, 23);
        NUD_SpD_Max.TabIndex = 137;
        NUD_SpD_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpD_Min
        // 
        NUD_SpD_Min.Location = new Point(82, 118);
        NUD_SpD_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Min.Name = "NUD_SpD_Min";
        NUD_SpD_Min.Size = new Size(32, 23);
        NUD_SpD_Min.TabIndex = 8;
        // 
        // B_SpA_Max
        // 
        B_SpA_Max.Location = new Point(197, 92);
        B_SpA_Max.Name = "B_SpA_Max";
        B_SpA_Max.Size = new Size(27, 25);
        B_SpA_Max.TabIndex = 19;
        B_SpA_Max.Text = "31";
        B_SpA_Max.UseVisualStyleBackColor = true;
        B_SpA_Max.Click += B_IV_Max_Click;
        // 
        // B_SpA_Min
        // 
        B_SpA_Min.Location = new Point(168, 92);
        B_SpA_Min.Name = "B_SpA_Min";
        B_SpA_Min.Size = new Size(27, 25);
        B_SpA_Min.TabIndex = 18;
        B_SpA_Min.Text = "0";
        B_SpA_Min.UseVisualStyleBackColor = true;
        B_SpA_Min.Click += B_IV_Min_Click;
        // 
        // L_SpA
        // 
        L_SpA.AutoSize = true;
        L_SpA.Location = new Point(45, 95);
        L_SpA.Name = "L_SpA";
        L_SpA.Size = new Size(31, 15);
        L_SpA.TabIndex = 156;
        L_SpA.Text = "SpA:";
        L_SpA.Click += IV_Label_Click;
        // 
        // L_SpASpacer
        // 
        L_SpASpacer.AutoSize = true;
        L_SpASpacer.Location = new Point(115, 95);
        L_SpASpacer.Name = "L_SpASpacer";
        L_SpASpacer.Size = new Size(15, 15);
        L_SpASpacer.TabIndex = 134;
        L_SpASpacer.Text = "~";
        L_SpASpacer.Click += IV_Spacer_Click;
        // 
        // NUD_SpA_Max
        // 
        NUD_SpA_Max.Location = new Point(131, 93);
        NUD_SpA_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Max.Name = "NUD_SpA_Max";
        NUD_SpA_Max.Size = new Size(32, 23);
        NUD_SpA_Max.TabIndex = 7;
        NUD_SpA_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpA_Min
        // 
        NUD_SpA_Min.Location = new Point(82, 93);
        NUD_SpA_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Min.Name = "NUD_SpA_Min";
        NUD_SpA_Min.Size = new Size(32, 23);
        NUD_SpA_Min.TabIndex = 6;
        // 
        // B_Def_Max
        // 
        B_Def_Max.Location = new Point(197, 67);
        B_Def_Max.Name = "B_Def_Max";
        B_Def_Max.Size = new Size(27, 25);
        B_Def_Max.TabIndex = 17;
        B_Def_Max.Text = "31";
        B_Def_Max.UseVisualStyleBackColor = true;
        B_Def_Max.Click += B_IV_Max_Click;
        // 
        // B_Def_Min
        // 
        B_Def_Min.Location = new Point(168, 67);
        B_Def_Min.Name = "B_Def_Min";
        B_Def_Min.Size = new Size(27, 25);
        B_Def_Min.TabIndex = 16;
        B_Def_Min.Text = "0";
        B_Def_Min.UseVisualStyleBackColor = true;
        B_Def_Min.Click += B_IV_Min_Click;
        // 
        // L_Def
        // 
        L_Def.AutoSize = true;
        L_Def.Location = new Point(48, 70);
        L_Def.Name = "L_Def";
        L_Def.Size = new Size(28, 15);
        L_Def.TabIndex = 149;
        L_Def.Text = "Def:";
        L_Def.Click += IV_Label_Click;
        // 
        // L_DefSpacer
        // 
        L_DefSpacer.AutoSize = true;
        L_DefSpacer.Location = new Point(115, 70);
        L_DefSpacer.Name = "L_DefSpacer";
        L_DefSpacer.Size = new Size(15, 15);
        L_DefSpacer.TabIndex = 129;
        L_DefSpacer.Text = "~";
        L_DefSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Def_Max
        // 
        NUD_Def_Max.Location = new Point(131, 68);
        NUD_Def_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Max.Name = "NUD_Def_Max";
        NUD_Def_Max.Size = new Size(32, 23);
        NUD_Def_Max.TabIndex = 5;
        NUD_Def_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Def_Min
        // 
        NUD_Def_Min.Location = new Point(82, 68);
        NUD_Def_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Min.Name = "NUD_Def_Min";
        NUD_Def_Min.Size = new Size(32, 23);
        NUD_Def_Min.TabIndex = 4;
        // 
        // B_Atk_Max
        // 
        B_Atk_Max.Location = new Point(197, 42);
        B_Atk_Max.Name = "B_Atk_Max";
        B_Atk_Max.Size = new Size(27, 25);
        B_Atk_Max.TabIndex = 15;
        B_Atk_Max.Text = "31";
        B_Atk_Max.UseVisualStyleBackColor = true;
        B_Atk_Max.Click += B_IV_Max_Click;
        // 
        // B_Atk_Min
        // 
        B_Atk_Min.Location = new Point(168, 42);
        B_Atk_Min.Name = "B_Atk_Min";
        B_Atk_Min.Size = new Size(27, 25);
        B_Atk_Min.TabIndex = 14;
        B_Atk_Min.Text = "0";
        B_Atk_Min.UseVisualStyleBackColor = true;
        B_Atk_Min.Click += B_IV_Min_Click;
        // 
        // L_Atk
        // 
        L_Atk.AutoSize = true;
        L_Atk.Location = new Point(48, 45);
        L_Atk.Name = "L_Atk";
        L_Atk.Size = new Size(28, 15);
        L_Atk.TabIndex = 142;
        L_Atk.Text = "Atk:";
        L_Atk.Click += IV_Label_Click;
        // 
        // L_AtkSpacer
        // 
        L_AtkSpacer.AutoSize = true;
        L_AtkSpacer.Location = new Point(115, 45);
        L_AtkSpacer.Name = "L_AtkSpacer";
        L_AtkSpacer.Size = new Size(15, 15);
        L_AtkSpacer.TabIndex = 126;
        L_AtkSpacer.Text = "~";
        L_AtkSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Atk_Max
        // 
        NUD_Atk_Max.Location = new Point(131, 43);
        NUD_Atk_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Max.Name = "NUD_Atk_Max";
        NUD_Atk_Max.Size = new Size(32, 23);
        NUD_Atk_Max.TabIndex = 3;
        NUD_Atk_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Atk_Min
        // 
        NUD_Atk_Min.Location = new Point(82, 43);
        NUD_Atk_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Min.Name = "NUD_Atk_Min";
        NUD_Atk_Min.Size = new Size(32, 23);
        NUD_Atk_Min.TabIndex = 2;
        // 
        // B_HP_Max
        // 
        B_HP_Max.Location = new Point(197, 17);
        B_HP_Max.Name = "B_HP_Max";
        B_HP_Max.Size = new Size(27, 25);
        B_HP_Max.TabIndex = 13;
        B_HP_Max.Text = "31";
        B_HP_Max.UseVisualStyleBackColor = true;
        B_HP_Max.Click += B_IV_Max_Click;
        // 
        // B_HP_Min
        // 
        B_HP_Min.Location = new Point(168, 17);
        B_HP_Min.Name = "B_HP_Min";
        B_HP_Min.Size = new Size(27, 25);
        B_HP_Min.TabIndex = 12;
        B_HP_Min.Text = "0";
        B_HP_Min.UseVisualStyleBackColor = true;
        B_HP_Min.Click += B_IV_Min_Click;
        // 
        // L_HP
        // 
        L_HP.AutoSize = true;
        L_HP.Location = new Point(50, 20);
        L_HP.Name = "L_HP";
        L_HP.Size = new Size(26, 15);
        L_HP.TabIndex = 132;
        L_HP.Text = "HP:";
        L_HP.Click += IV_Label_Click;
        // 
        // L_HPSpacer
        // 
        L_HPSpacer.AutoSize = true;
        L_HPSpacer.Location = new Point(115, 20);
        L_HPSpacer.Name = "L_HPSpacer";
        L_HPSpacer.Size = new Size(15, 15);
        L_HPSpacer.TabIndex = 130;
        L_HPSpacer.Text = "~";
        L_HPSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_HP_Max
        // 
        NUD_HP_Max.Location = new Point(131, 18);
        NUD_HP_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Max.Name = "NUD_HP_Max";
        NUD_HP_Max.Size = new Size(32, 23);
        NUD_HP_Max.TabIndex = 1;
        NUD_HP_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_HP_Min
        // 
        NUD_HP_Min.Location = new Point(82, 18);
        NUD_HP_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Min.Name = "NUD_HP_Min";
        NUD_HP_Min.Size = new Size(32, 23);
        NUD_HP_Min.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(L_MonAdv);
        groupBox1.Controls.Add(L_MonInitial);
        groupBox1.Controls.Add(TB_MonAdv);
        groupBox1.Controls.Add(TB_MonInitial);
        groupBox1.Controls.Add(B_ReadChainSpecies);
        groupBox1.Controls.Add(B_ReadChainCount);
        groupBox1.Controls.Add(L_Area);
        groupBox1.Controls.Add(CB_Area);
        groupBox1.Controls.Add(L_Species);
        groupBox1.Controls.Add(CB_Species);
        groupBox1.Controls.Add(L_Lead);
        groupBox1.Controls.Add(CB_Lead);
        groupBox1.Controls.Add(L_ChainCount);
        groupBox1.Controls.Add(NUD_ChainCount);
        groupBox1.Controls.Add(L_Patch);
        groupBox1.Controls.Add(CB_Patch);
        groupBox1.Location = new Point(566, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(227, 273);
        groupBox1.TabIndex = 129;
        groupBox1.TabStop = false;
        groupBox1.Text = "Generation Criteria";
        // 
        // L_MonAdv
        // 
        L_MonAdv.AutoSize = true;
        L_MonAdv.Location = new Point(49, 236);
        L_MonAdv.Name = "L_MonAdv";
        L_MonAdv.Size = new Size(15, 15);
        L_MonAdv.TabIndex = 137;
        L_MonAdv.Text = "+";
        // 
        // L_MonInitial
        // 
        L_MonInitial.AutoSize = true;
        L_MonInitial.Location = new Point(7, 214);
        L_MonInitial.Name = "L_MonInitial";
        L_MonInitial.Size = new Size(57, 15);
        L_MonInitial.TabIndex = 136;
        L_MonInitial.Text = "Init. Adv.:";
        // 
        // TB_MonAdv
        // 
        TB_MonAdv.CharacterCasing = CharacterCasing.Upper;
        TB_MonAdv.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_MonAdv.Location = new Point(70, 234);
        TB_MonAdv.MaxLength = 16;
        TB_MonAdv.Name = "TB_MonAdv";
        TB_MonAdv.Size = new Size(151, 22);
        TB_MonAdv.TabIndex = 135;
        TB_MonAdv.Text = "5000000";
        TB_MonAdv.TextAlign = HorizontalAlignment.Right;
        TB_MonAdv.KeyDown += Dec_HandlePaste;
        TB_MonAdv.KeyPress += AllowOnlyNumerical_KeyPress;
        // 
        // TB_MonInitial
        // 
        TB_MonInitial.CharacterCasing = CharacterCasing.Upper;
        TB_MonInitial.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_MonInitial.Location = new Point(70, 210);
        TB_MonInitial.MaxLength = 16;
        TB_MonInitial.Name = "TB_MonInitial";
        TB_MonInitial.Size = new Size(151, 22);
        TB_MonInitial.TabIndex = 134;
        TB_MonInitial.Text = "0";
        TB_MonInitial.TextAlign = HorizontalAlignment.Right;
        TB_MonInitial.KeyDown += Dec_HandlePaste;
        TB_MonInitial.KeyPress += AllowOnlyNumerical_KeyPress;
        // 
        // B_ReadChainSpecies
        // 
        B_ReadChainSpecies.Enabled = false;
        B_ReadChainSpecies.Location = new Point(8, 149);
        B_ReadChainSpecies.Name = "B_ReadChainSpecies";
        B_ReadChainSpecies.Size = new Size(213, 25);
        B_ReadChainSpecies.TabIndex = 5;
        B_ReadChainSpecies.Text = "Read Species from RAM";
        B_ReadChainSpecies.UseVisualStyleBackColor = true;
        B_ReadChainSpecies.Click += B_ReadChainSpecies_Click;
        // 
        // B_ReadChainCount
        // 
        B_ReadChainCount.Enabled = false;
        B_ReadChainCount.Location = new Point(8, 72);
        B_ReadChainCount.Name = "B_ReadChainCount";
        B_ReadChainCount.Size = new Size(213, 25);
        B_ReadChainCount.TabIndex = 2;
        B_ReadChainCount.Text = "Read Chain Count from RAM";
        B_ReadChainCount.UseVisualStyleBackColor = true;
        B_ReadChainCount.Click += B_ReadChainCount_Click;
        // 
        // L_Area
        // 
        L_Area.AutoSize = true;
        L_Area.Location = new Point(8, 102);
        L_Area.Name = "L_Area";
        L_Area.Size = new Size(56, 15);
        L_Area.TabIndex = 133;
        L_Area.Text = "Location:";
        // 
        // CB_Area
        // 
        CB_Area.FormattingEnabled = true;
        CB_Area.Items.AddRange(new object[] { "(None)", "Synchronize", "Other" });
        CB_Area.Location = new Point(70, 99);
        CB_Area.Name = "CB_Area";
        CB_Area.Size = new Size(151, 23);
        CB_Area.TabIndex = 3;
        CB_Area.SelectedIndexChanged += CB_Area_SelectedIndexChanged;
        // 
        // L_Species
        // 
        L_Species.AutoSize = true;
        L_Species.Location = new Point(8, 127);
        L_Species.Name = "L_Species";
        L_Species.Size = new Size(49, 15);
        L_Species.TabIndex = 131;
        L_Species.Text = "Species:";
        // 
        // CB_Species
        // 
        CB_Species.FormattingEnabled = true;
        CB_Species.Items.AddRange(new object[] { "(None)", "Synchronize", "Other" });
        CB_Species.Location = new Point(70, 124);
        CB_Species.Name = "CB_Species";
        CB_Species.Size = new Size(151, 23);
        CB_Species.TabIndex = 4;
        // 
        // L_Lead
        // 
        L_Lead.AutoSize = true;
        L_Lead.Location = new Point(8, 184);
        L_Lead.Name = "L_Lead";
        L_Lead.Size = new Size(35, 15);
        L_Lead.TabIndex = 129;
        L_Lead.Text = "Lead:";
        // 
        // CB_Lead
        // 
        CB_Lead.FormattingEnabled = true;
        CB_Lead.Items.AddRange(new object[] { "(None)", "Synchronize", "Other" });
        CB_Lead.Location = new Point(70, 181);
        CB_Lead.Name = "CB_Lead";
        CB_Lead.Size = new Size(151, 23);
        CB_Lead.TabIndex = 6;
        // 
        // L_ChainCount
        // 
        L_ChainCount.AutoSize = true;
        L_ChainCount.Location = new Point(8, 52);
        L_ChainCount.Name = "L_ChainCount";
        L_ChainCount.Size = new Size(77, 15);
        L_ChainCount.TabIndex = 127;
        L_ChainCount.Text = "Chain Count:";
        // 
        // NUD_ChainCount
        // 
        NUD_ChainCount.Location = new Point(183, 47);
        NUD_ChainCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_ChainCount.Name = "NUD_ChainCount";
        NUD_ChainCount.Size = new Size(38, 23);
        NUD_ChainCount.TabIndex = 1;
        NUD_ChainCount.Value = new decimal(new int[] { 99, 0, 0, 0 });
        // 
        // L_Patch
        // 
        L_Patch.AutoSize = true;
        L_Patch.Location = new Point(8, 25);
        L_Patch.Name = "L_Patch";
        L_Patch.Size = new Size(40, 15);
        L_Patch.TabIndex = 125;
        L_Patch.Text = "Patch:";
        // 
        // CB_Patch
        // 
        CB_Patch.FormattingEnabled = true;
        CB_Patch.Items.AddRange(new object[] { "Normal", "Shiny", "Hidden Ability" });
        CB_Patch.Location = new Point(70, 22);
        CB_Patch.Name = "CB_Patch";
        CB_Patch.Size = new Size(151, 23);
        CB_Patch.TabIndex = 0;
        // 
        // B_ReadWildPokemon
        // 
        B_ReadWildPokemon.Location = new Point(1034, 200);
        B_ReadWildPokemon.Name = "B_ReadWildPokemon";
        B_ReadWildPokemon.Size = new Size(181, 25);
        B_ReadWildPokemon.TabIndex = 9;
        B_ReadWildPokemon.Text = "Read Encounter";
        B_ReadWildPokemon.UseVisualStyleBackColor = true;
        B_ReadWildPokemon.Click += B_ReadWildPokemon_Click;
        // 
        // TB_Wild
        // 
        TB_Wild.Location = new Point(1034, 12);
        TB_Wild.Multiline = true;
        TB_Wild.Name = "TB_Wild";
        TB_Wild.ReadOnly = true;
        TB_Wild.Size = new Size(181, 186);
        TB_Wild.TabIndex = 8;
        TB_Wild.TabStop = false;
        TB_Wild.Text = "Shiny - Species (Gender) @ Item\r\nEC: WWWWWWWW\r\nPID: WWWWWWWW\r\nWWWWWWW Nature\r\nAbility: WWWWWWWWWW\r\nIVs: 22/22/22/22/22/22\r\nHeight: 255 (XXXL)\r\nMark: WWWWWWWWWW\r\n- Move 1\r\n- Move 2\r\n- Move 3\r\n- Move 4";
        // 
        // B_Left
        // 
        B_Left.Location = new Point(1234, 226);
        B_Left.Name = "B_Left";
        B_Left.Size = new Size(25, 25);
        B_Left.TabIndex = 17;
        B_Left.Text = "←";
        B_Left.UseVisualStyleBackColor = true;
        B_Left.Visible = false;
        B_Left.Click += B_Left_Click;
        // 
        // B_Right
        // 
        B_Right.Location = new Point(1280, 226);
        B_Right.Name = "B_Right";
        B_Right.Size = new Size(25, 25);
        B_Right.TabIndex = 16;
        B_Right.Text = "→";
        B_Right.UseVisualStyleBackColor = true;
        B_Right.Visible = false;
        B_Right.Click += B_Right_Click;
        // 
        // B_Up
        // 
        B_Up.Location = new Point(1257, 203);
        B_Up.Name = "B_Up";
        B_Up.Size = new Size(25, 25);
        B_Up.TabIndex = 15;
        B_Up.Text = "↑";
        B_Up.UseVisualStyleBackColor = true;
        B_Up.Visible = false;
        B_Up.Click += B_Up_Click;
        // 
        // B_Down
        // 
        B_Down.Location = new Point(1257, 249);
        B_Down.Name = "B_Down";
        B_Down.Size = new Size(25, 25);
        B_Down.TabIndex = 18;
        B_Down.Text = "↓";
        B_Down.UseVisualStyleBackColor = true;
        B_Down.Visible = false;
        B_Down.Click += B_Down_Click;
        // 
        // B_B
        // 
        B_B.Location = new Point(1334, 249);
        B_B.Name = "B_B";
        B_B.Size = new Size(25, 25);
        B_B.TabIndex = 22;
        B_B.Text = "B";
        B_B.UseVisualStyleBackColor = true;
        B_B.Visible = false;
        B_B.Click += B_B_Click;
        // 
        // B_X
        // 
        B_X.Location = new Point(1334, 203);
        B_X.Name = "B_X";
        B_X.Size = new Size(25, 25);
        B_X.TabIndex = 19;
        B_X.Text = "X";
        B_X.UseVisualStyleBackColor = true;
        B_X.Visible = false;
        B_X.Click += B_X_Click;
        // 
        // B_A
        // 
        B_A.Location = new Point(1357, 226);
        B_A.Name = "B_A";
        B_A.Size = new Size(25, 25);
        B_A.TabIndex = 20;
        B_A.Text = "A";
        B_A.UseVisualStyleBackColor = true;
        B_A.Visible = false;
        B_A.Click += B_A_Click;
        // 
        // B_Y
        // 
        B_Y.Location = new Point(1311, 226);
        B_Y.Name = "B_Y";
        B_Y.Size = new Size(25, 25);
        B_Y.TabIndex = 21;
        B_Y.Text = "Y";
        B_Y.UseVisualStyleBackColor = true;
        B_Y.Visible = false;
        B_Y.Click += B_Y_Click;
        // 
        // B_Minus
        // 
        B_Minus.Location = new Point(1234, 180);
        B_Minus.Name = "B_Minus";
        B_Minus.Size = new Size(25, 25);
        B_Minus.TabIndex = 14;
        B_Minus.Text = "-";
        B_Minus.UseVisualStyleBackColor = true;
        B_Minus.Visible = false;
        B_Minus.Click += B_Minus_Click;
        // 
        // TB_Input
        // 
        TB_Input.CharacterCasing = CharacterCasing.Upper;
        TB_Input.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Input.Location = new Point(1234, 278);
        TB_Input.MaxLength = 16;
        TB_Input.Name = "TB_Input";
        TB_Input.Size = new Size(148, 22);
        TB_Input.TabIndex = 23;
        TB_Input.TextAlign = HorizontalAlignment.Right;
        TB_Input.Visible = false;
        TB_Input.KeyDown += TB_Input_KeyDown;
        // 
        // menuStrip1
        // 
        menuStrip1.Dock = DockStyle.Bottom;
        menuStrip1.Items.AddRange(new ToolStripItem[] { shortcutsToolStripMenuItem });
        menuStrip1.Location = new Point(0, 603);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1479, 24);
        menuStrip1.TabIndex = 139;
        menuStrip1.Text = "menuStrip1";
        // 
        // shortcutsToolStripMenuItem
        // 
        shortcutsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findSafeAdvanceToolStripMenuItem });
        shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
        shortcutsToolStripMenuItem.Size = new Size(69, 20);
        shortcutsToolStripMenuItem.Text = "Shortcuts";
        // 
        // findSafeAdvanceToolStripMenuItem
        // 
        findSafeAdvanceToolStripMenuItem.Enabled = false;
        findSafeAdvanceToolStripMenuItem.Name = "findSafeAdvanceToolStripMenuItem";
        findSafeAdvanceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
        findSafeAdvanceToolStripMenuItem.Size = new Size(214, 22);
        findSafeAdvanceToolStripMenuItem.Text = "Find Safe Advance";
        findSafeAdvanceToolStripMenuItem.Click += findSafeAdvanceToolStripMenuItem_Click;
        // 
        // B_CalcDelayAuto
        // 
        B_CalcDelayAuto.Location = new Point(1034, 278);
        B_CalcDelayAuto.Name = "B_CalcDelayAuto";
        B_CalcDelayAuto.Size = new Size(181, 25);
        B_CalcDelayAuto.TabIndex = 140;
        B_CalcDelayAuto.Text = "Calculate Delay (Automatic)";
        B_CalcDelayAuto.UseVisualStyleBackColor = true;
        B_CalcDelayAuto.Click += B_CalcDelay_Click;
        // 
        // TB_SafeDistance3
        // 
        TB_SafeDistance3.CharacterCasing = CharacterCasing.Upper;
        TB_SafeDistance3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SafeDistance3.Location = new Point(434, 278);
        TB_SafeDistance3.MaxLength = 16;
        TB_SafeDistance3.Name = "TB_SafeDistance3";
        TB_SafeDistance3.ReadOnly = true;
        TB_SafeDistance3.Size = new Size(84, 22);
        TB_SafeDistance3.TabIndex = 141;
        TB_SafeDistance3.TextAlign = HorizontalAlignment.Right;
        // 
        // TB_SafeDistance2
        // 
        TB_SafeDistance2.CharacterCasing = CharacterCasing.Upper;
        TB_SafeDistance2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SafeDistance2.Location = new Point(332, 278);
        TB_SafeDistance2.MaxLength = 16;
        TB_SafeDistance2.Name = "TB_SafeDistance2";
        TB_SafeDistance2.ReadOnly = true;
        TB_SafeDistance2.Size = new Size(84, 22);
        TB_SafeDistance2.TabIndex = 142;
        TB_SafeDistance2.TextAlign = HorizontalAlignment.Right;
        // 
        // TB_SafeDistance1
        // 
        TB_SafeDistance1.CharacterCasing = CharacterCasing.Upper;
        TB_SafeDistance1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SafeDistance1.Location = new Point(230, 278);
        TB_SafeDistance1.MaxLength = 16;
        TB_SafeDistance1.Name = "TB_SafeDistance1";
        TB_SafeDistance1.ReadOnly = true;
        TB_SafeDistance1.Size = new Size(84, 22);
        TB_SafeDistance1.TabIndex = 143;
        TB_SafeDistance1.TextAlign = HorizontalAlignment.Right;
        // 
        // B_CalcDelayManual
        // 
        B_CalcDelayManual.Location = new Point(1034, 251);
        B_CalcDelayManual.Name = "B_CalcDelayManual";
        B_CalcDelayManual.Size = new Size(181, 25);
        B_CalcDelayManual.TabIndex = 144;
        B_CalcDelayManual.Text = "Calculate Delay (Manual)";
        B_CalcDelayManual.UseVisualStyleBackColor = true;
        B_CalcDelayManual.Click += B_CalcDelayManual_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1479, 627);
        Controls.Add(B_CalcDelayManual);
        Controls.Add(TB_SafeDistance1);
        Controls.Add(TB_SafeDistance2);
        Controls.Add(TB_SafeDistance3);
        Controls.Add(B_CalcDelayAuto);
        Controls.Add(TB_Input);
        Controls.Add(B_Minus);
        Controls.Add(B_B);
        Controls.Add(B_X);
        Controls.Add(B_A);
        Controls.Add(B_Y);
        Controls.Add(B_Down);
        Controls.Add(B_Up);
        Controls.Add(B_Right);
        Controls.Add(B_Left);
        Controls.Add(TB_Wild);
        Controls.Add(B_ReadWildPokemon);
        Controls.Add(groupBox1);
        Controls.Add(GB_Filters);
        Controls.Add(DGV_ResultsPokemon);
        Controls.Add(B_PokemonSearch);
        Controls.Add(label6);
        Controls.Add(NUD_ActionTimes);
        Controls.Add(label5);
        Controls.Add(CB_Action);
        Controls.Add(label4);
        Controls.Add(CB_Rate);
        Controls.Add(L_SafeDistance);
        Controls.Add(TB_SafeDistance);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(TB_FailsTotal);
        Controls.Add(TB_FailsNext);
        Controls.Add(L_Static_Advances);
        Controls.Add(L_Static_Initial);
        Controls.Add(TB_Advances);
        Controls.Add(TB_Initial);
        Controls.Add(B_Search);
        Controls.Add(DGV_ResultsContinuation);
        Controls.Add(B_Forecast);
        Controls.Add(L_SafeNum);
        Controls.Add(NUD_SafeNum);
        Controls.Add(GB_Seed);
        Controls.Add(GB_Connection);
        Controls.Add(GB_SAVInfo);
        Controls.Add(menuStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        Name = "MainWindow";
        FormClosing += MainWindow_FormClosing;
        Load += MainWindow_Load;
        GB_Connection.ResumeLayout(false);
        GB_Connection.PerformLayout();
        GB_Seed.ResumeLayout(false);
        GB_Seed.PerformLayout();
        GB_SAVInfo.ResumeLayout(false);
        GB_SAVInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_SafeNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)DGV_ResultsContinuation).EndInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSourceContinuation).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ActionTimes).EndInit();
        ((System.ComponentModel.ISupportInitialize)DGV_ResultsPokemon).EndInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSourcePokemon).EndInit();
        GB_Filters.ResumeLayout(false);
        GB_Filters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Delay).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Cluster).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Min).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_ChainCount).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox GB_Connection;
    private TextBox TB_AdvancesIncrease;
    private Button B_CopyToInitial;
    private Label L_CurrentS1;
    private TextBox TB_Status;
    private Label L_CurrentS0;
    private TextBox TB_CurrentS1;
    private Label L_Status;
    private TextBox TB_CurrentS0;
    public TextBox TB_CurrentAdvances;
    private Label L_CurrentAdvances;
    private Button B_Disconnect;
    private Button B_Connect;
    private Label L_SwitchIP;
    private TextBox TB_SwitchIP;
    private GroupBox GB_Seed;
    private Label L_Seed1;
    private Label L_Seed0;
    public TextBox TB_Seed1;
    public TextBox TB_Seed0;
    private GroupBox GB_SAVInfo;
    private Label L_Game;
    public ComboBox CB_Game;
    private Label L_SID;
    private Label L_TID;
    public TextBox TB_SID;
    public TextBox TB_TID;
    private NumericUpDown NUD_SafeNum;
    private Label L_SafeNum;
    private Button B_Forecast;
    private DataGridView DGV_ResultsContinuation;
    private BindingSource ResultsSourceContinuation;
    private Button B_Search;
    private Label L_Static_Advances;
    private Label L_Static_Initial;
    private TextBox TB_Advances;
    private TextBox TB_Initial;
    private TextBox TB_FailsNext;
    private TextBox TB_FailsTotal;
    private Label label1;
    private Label label2;
    private TextBox TB_SafeDistance;
    private Label L_SafeDistance;
    public ComboBox CB_Rate;
    private Label label4;
    public ComboBox CB_Action;
    private Label label5;
    private NumericUpDown NUD_ActionTimes;
    private Label label6;
    private Button B_PokemonSearch;
    private DataGridView DGV_ResultsPokemon;
    private BindingSource ResultsSourcePokemon;
    private GroupBox GB_Filters;
    public CheckBox CB_RareEC;
    private CheckBox CB_EnableFilters;
    private Label L_Filter_Height;
    public ComboBox CB_Filter_Height;
    private Label L_Filter_Shiny;
    private ComboBox CB_Filter_Shiny;
    private Button B_Spe_Max;
    private Button B_Spe_Min;
    private Label L_Spe;
    private Label L_SpeSpacer;
    private NumericUpDown NUD_Spe_Max;
    private NumericUpDown NUD_Spe_Min;
    private Button B_SpD_Max;
    private Button B_SpD_Min;
    private Label L_SpD;
    private Label L_SpDSpacer;
    private NumericUpDown NUD_SpD_Max;
    private NumericUpDown NUD_SpD_Min;
    private Button B_SpA_Max;
    private Button B_SpA_Min;
    private Label L_SpA;
    private Label L_SpASpacer;
    private NumericUpDown NUD_SpA_Max;
    private NumericUpDown NUD_SpA_Min;
    private Button B_Def_Max;
    private Button B_Def_Min;
    private Label L_Def;
    private Label L_DefSpacer;
    private NumericUpDown NUD_Def_Max;
    private NumericUpDown NUD_Def_Min;
    private Button B_Atk_Max;
    private Button B_Atk_Min;
    private Label L_Atk;
    private Label L_AtkSpacer;
    private NumericUpDown NUD_Atk_Max;
    private NumericUpDown NUD_Atk_Min;
    private Button B_HP_Max;
    private Button B_HP_Min;
    private Label L_HP;
    private Label L_HPSpacer;
    private NumericUpDown NUD_HP_Max;
    private NumericUpDown NUD_HP_Min;
    private GroupBox groupBox1;
    private Label L_Patch;
    private ComboBox CB_Patch;
    private Label L_ChainCount;
    private NumericUpDown NUD_ChainCount;
    private Label L_Lead;
    private ComboBox CB_Lead;
    private Label L_Species;
    private ComboBox CB_Species;
    private Label L_Area;
    private ComboBox CB_Area;
    private Button B_ReadChainCount;
    private Button B_ReadChainSpecies;
    private Label L_Cluster;
    private NumericUpDown NUD_Cluster;
    private Button B_ReadWildPokemon;
    private TextBox TB_Wild;
    private Button B_CalcDelayManual;
    private Button B_Left;
    private Button B_Right;
    private Button B_Up;
    private Button B_Down;
    private Button B_B;
    private Button B_X;
    private Button B_A;
    private Button B_Y;
    private Button B_Minus;
    private TextBox TB_Input;
    private DataGridViewTextBoxColumn advancesDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn seed0DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn seed1DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn failDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn rollDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn Cluster;
    private DataGridViewTextBoxColumn Shiny;
    private DataGridViewTextBoxColumn Ability;
    private DataGridViewTextBoxColumn Nature;
    private DataGridViewTextBoxColumn Gender;
    private DataGridViewTextBoxColumn H;
    private DataGridViewTextBoxColumn A;
    private DataGridViewTextBoxColumn B;
    private DataGridViewTextBoxColumn C;
    private DataGridViewTextBoxColumn D;
    private DataGridViewTextBoxColumn S;
    private DataGridViewTextBoxColumn EC;
    private DataGridViewTextBoxColumn PID;
    private DataGridViewTextBoxColumn Height;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private Label L_MonAdv;
    private Label L_MonInitial;
    private TextBox TB_MonAdv;
    private TextBox TB_MonInitial;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem shortcutsToolStripMenuItem;
    private ToolStripMenuItem findSafeAdvanceToolStripMenuItem;
    private Button B_CalcDelayAuto;
    private TextBox TB_SafeDistance3;
    private TextBox TB_SafeDistance2;
    private TextBox TB_SafeDistance1;
    private Label L_Delay;
    private NumericUpDown NUD_Delay;
}

