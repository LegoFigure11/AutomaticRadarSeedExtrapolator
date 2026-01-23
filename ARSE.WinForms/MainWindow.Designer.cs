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
        label3 = new Label();
        CB_Rate = new ComboBox();
        label4 = new Label();
        CB_Action = new ComboBox();
        label5 = new Label();
        NUD_ActionTimes = new NumericUpDown();
        label6 = new Label();
        B_PokemonSearch = new Button();
        DGV_ResultsPokemon = new DataGridView();
        ResultsSourcePokemon = new BindingSource(components);
        GB_Filters = new GroupBox();
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
        button1 = new Button();
        button2 = new Button();
        groupBox1 = new GroupBox();
        button4 = new Button();
        button3 = new Button();
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
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
        CB_Game.TabIndex = 4;
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
        TB_SID.TabIndex = 3;
        TB_SID.Text = "54321";
        // 
        // TB_TID
        // 
        TB_TID.CharacterCasing = CharacterCasing.Upper;
        TB_TID.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_TID.Location = new Point(71, 16);
        TB_TID.MaxLength = 5;
        TB_TID.Name = "TB_TID";
        TB_TID.Size = new Size(41, 22);
        TB_TID.TabIndex = 2;
        TB_TID.Text = "12345";
        // 
        // NUD_SafeNum
        // 
        NUD_SafeNum.Location = new Point(480, 29);
        NUD_SafeNum.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        NUD_SafeNum.Name = "NUD_SafeNum";
        NUD_SafeNum.Size = new Size(38, 23);
        NUD_SafeNum.TabIndex = 5;
        NUD_SafeNum.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // L_SafeNum
        // 
        L_SafeNum.AutoSize = true;
        L_SafeNum.Location = new Point(230, 31);
        L_SafeNum.Name = "L_SafeNum";
        L_SafeNum.Size = new Size(113, 15);
        L_SafeNum.TabIndex = 6;
        L_SafeNum.Text = "Min. Safe Advances:";
        // 
        // B_Forecast
        // 
        B_Forecast.Enabled = false;
        B_Forecast.Location = new Point(230, 79);
        B_Forecast.Name = "B_Forecast";
        B_Forecast.Size = new Size(288, 25);
        B_Forecast.TabIndex = 7;
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
        DGV_ResultsContinuation.Size = new Size(506, 309);
        DGV_ResultsContinuation.TabIndex = 8;
        DGV_ResultsContinuation.CellFormatting += DGV_ResultsContinuation_CellFormatting;
        // 
        // advancesDataGridViewTextBoxColumn
        // 
        advancesDataGridViewTextBoxColumn.DataPropertyName = "Advances";
        advancesDataGridViewTextBoxColumn.HeaderText = "Advances";
        advancesDataGridViewTextBoxColumn.Name = "advancesDataGridViewTextBoxColumn";
        advancesDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // seed0DataGridViewTextBoxColumn
        // 
        seed0DataGridViewTextBoxColumn.DataPropertyName = "Seed0";
        seed0DataGridViewTextBoxColumn.HeaderText = "Seed0";
        seed0DataGridViewTextBoxColumn.Name = "seed0DataGridViewTextBoxColumn";
        seed0DataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // seed1DataGridViewTextBoxColumn
        // 
        seed1DataGridViewTextBoxColumn.DataPropertyName = "Seed1";
        seed1DataGridViewTextBoxColumn.HeaderText = "Seed1";
        seed1DataGridViewTextBoxColumn.Name = "seed1DataGridViewTextBoxColumn";
        seed1DataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // failDataGridViewTextBoxColumn
        // 
        failDataGridViewTextBoxColumn.DataPropertyName = "Fail";
        failDataGridViewTextBoxColumn.HeaderText = "Fail";
        failDataGridViewTextBoxColumn.Name = "failDataGridViewTextBoxColumn";
        failDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // rollDataGridViewTextBoxColumn
        // 
        rollDataGridViewTextBoxColumn.DataPropertyName = "Roll";
        rollDataGridViewTextBoxColumn.HeaderText = "Roll";
        rollDataGridViewTextBoxColumn.Name = "rollDataGridViewTextBoxColumn";
        rollDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // ResultsSourceContinuation
        // 
        ResultsSourceContinuation.DataSource = typeof(Core.Interfaces.RadarContinuationFrame);
        // 
        // B_Search
        // 
        B_Search.Location = new Point(230, 197);
        B_Search.Name = "B_Search";
        B_Search.Size = new Size(288, 25);
        B_Search.TabIndex = 9;
        B_Search.Text = "Generate";
        B_Search.UseVisualStyleBackColor = true;
        B_Search.Click += B_Search_Click;
        // 
        // L_Static_Advances
        // 
        L_Static_Advances.AutoSize = true;
        L_Static_Advances.Location = new Point(324, 171);
        L_Static_Advances.Name = "L_Static_Advances";
        L_Static_Advances.Size = new Size(15, 15);
        L_Static_Advances.TabIndex = 61;
        L_Static_Advances.Text = "+";
        // 
        // L_Static_Initial
        // 
        L_Static_Initial.AutoSize = true;
        L_Static_Initial.Location = new Point(246, 147);
        L_Static_Initial.Name = "L_Static_Initial";
        L_Static_Initial.Size = new Size(93, 15);
        L_Static_Initial.TabIndex = 60;
        L_Static_Initial.Text = "Initial Advances:";
        // 
        // TB_Advances
        // 
        TB_Advances.CharacterCasing = CharacterCasing.Upper;
        TB_Advances.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Advances.Location = new Point(345, 169);
        TB_Advances.MaxLength = 16;
        TB_Advances.Name = "TB_Advances";
        TB_Advances.Size = new Size(173, 22);
        TB_Advances.TabIndex = 59;
        TB_Advances.Text = "500";
        TB_Advances.TextAlign = HorizontalAlignment.Right;
        // 
        // TB_Initial
        // 
        TB_Initial.CharacterCasing = CharacterCasing.Upper;
        TB_Initial.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_Initial.Location = new Point(345, 145);
        TB_Initial.MaxLength = 16;
        TB_Initial.Name = "TB_Initial";
        TB_Initial.Size = new Size(173, 22);
        TB_Initial.TabIndex = 58;
        TB_Initial.Text = "0";
        TB_Initial.TextAlign = HorizontalAlignment.Right;
        // 
        // TB_FailsNext
        // 
        TB_FailsNext.CharacterCasing = CharacterCasing.Upper;
        TB_FailsNext.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_FailsNext.Location = new Point(434, 231);
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
        TB_FailsTotal.Location = new Point(434, 254);
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
        label1.Location = new Point(230, 232);
        label1.Name = "label1";
        label1.Size = new Size(162, 15);
        label1.TabIndex = 64;
        label1.Text = "Failures in next 100 advances:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(230, 256);
        label2.Name = "label2";
        label2.Size = new Size(100, 15);
        label2.TabIndex = 65;
        label2.Text = "Failures in results:";
        // 
        // TB_SafeDistance
        // 
        TB_SafeDistance.CharacterCasing = CharacterCasing.Upper;
        TB_SafeDistance.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SafeDistance.Location = new Point(434, 278);
        TB_SafeDistance.MaxLength = 16;
        TB_SafeDistance.Name = "TB_SafeDistance";
        TB_SafeDistance.ReadOnly = true;
        TB_SafeDistance.Size = new Size(84, 22);
        TB_SafeDistance.TabIndex = 66;
        TB_SafeDistance.TextAlign = HorizontalAlignment.Right;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(230, 280);
        label3.Name = "label3";
        label3.Size = new Size(180, 15);
        label3.TabIndex = 67;
        label3.Text = "Next safe advance (100 in a row):";
        // 
        // CB_Rate
        // 
        CB_Rate.FormattingEnabled = true;
        CB_Rate.Items.AddRange(new object[] { "53%", "63%", "73%", "83%", "93%" });
        CB_Rate.Location = new Point(345, 120);
        CB_Rate.Name = "CB_Rate";
        CB_Rate.Size = new Size(173, 23);
        CB_Rate.TabIndex = 21;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(254, 123);
        label4.Name = "label4";
        label4.Size = new Size(85, 15);
        label4.TabIndex = 69;
        label4.Text = "Continue Rate:";
        // 
        // CB_Action
        // 
        CB_Action.FormattingEnabled = true;
        CB_Action.Items.AddRange(new object[] { "(None)", "Press A", "Press HOME" });
        CB_Action.Location = new Point(345, 54);
        CB_Action.Name = "CB_Action";
        CB_Action.Size = new Size(116, 23);
        CB_Action.TabIndex = 70;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(246, 57);
        label5.Name = "label5";
        label5.Size = new Size(93, 15);
        label5.TabIndex = 71;
        label5.Text = "Action at Target:";
        // 
        // NUD_ActionTimes
        // 
        NUD_ActionTimes.Location = new Point(480, 55);
        NUD_ActionTimes.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        NUD_ActionTimes.Name = "NUD_ActionTimes";
        NUD_ActionTimes.Size = new Size(38, 23);
        NUD_ActionTimes.TabIndex = 72;
        NUD_ActionTimes.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(467, 57);
        label6.Name = "label6";
        label6.Size = new Size(13, 15);
        label6.TabIndex = 73;
        label6.Text = "x";
        // 
        // B_PokemonSearch
        // 
        B_PokemonSearch.Location = new Point(566, 243);
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
        DGV_ResultsPokemon.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Shiny, Ability, Nature, Gender, H, A, B, C, D, S, EC, PID, Height, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        DGV_ResultsPokemon.DataSource = ResultsSourcePokemon;
        DGV_ResultsPokemon.Location = new Point(545, 306);
        DGV_ResultsPokemon.Name = "DGV_ResultsPokemon";
        DGV_ResultsPokemon.ReadOnly = true;
        DGV_ResultsPokemon.RowHeadersVisible = false;
        DGV_ResultsPokemon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DGV_ResultsPokemon.Size = new Size(821, 309);
        DGV_ResultsPokemon.TabIndex = 125;
        // 
        // ResultsSourcePokemon
        // 
        ResultsSourcePokemon.DataSource = typeof(Core.Interfaces.PokemonFrame);
        // 
        // GB_Filters
        // 
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
        GB_Filters.Location = new Point(799, 27);
        GB_Filters.Name = "GB_Filters";
        GB_Filters.Size = new Size(314, 259);
        GB_Filters.TabIndex = 126;
        GB_Filters.TabStop = false;
        GB_Filters.Text = "Search Filters";
        // 
        // CB_RareEC
        // 
        CB_RareEC.AutoSize = true;
        CB_RareEC.CheckAlign = ContentAlignment.MiddleRight;
        CB_RareEC.Location = new Point(73, 220);
        CB_RareEC.Name = "CB_RareEC";
        CB_RareEC.Size = new Size(71, 19);
        CB_RareEC.TabIndex = 158;
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
        CB_EnableFilters.Location = new Point(147, 222);
        CB_EnableFilters.Name = "CB_EnableFilters";
        CB_EnableFilters.Size = new Size(107, 19);
        CB_EnableFilters.TabIndex = 159;
        CB_EnableFilters.Tag = "";
        CB_EnableFilters.Text = "Filters Enabled?";
        CB_EnableFilters.UseVisualStyleBackColor = true;
        // 
        // L_Filter_Height
        // 
        L_Filter_Height.AutoSize = true;
        L_Filter_Height.Location = new Point(60, 196);
        L_Filter_Height.Name = "L_Filter_Height";
        L_Filter_Height.Size = new Size(46, 15);
        L_Filter_Height.TabIndex = 163;
        L_Filter_Height.Text = "Height:";
        // 
        // CB_Filter_Height
        // 
        CB_Filter_Height.FormattingEnabled = true;
        CB_Filter_Height.Items.AddRange(new object[] { "Ignore", "XXXS", "XXS", "XS", "S", "M", "L", "XL", "XXL", "XXXL", "XXXS or XXXL" });
        CB_Filter_Height.Location = new Point(112, 193);
        CB_Filter_Height.Name = "CB_Filter_Height";
        CB_Filter_Height.Size = new Size(142, 23);
        CB_Filter_Height.TabIndex = 157;
        // 
        // L_Filter_Shiny
        // 
        L_Filter_Shiny.AutoSize = true;
        L_Filter_Shiny.Location = new Point(67, 171);
        L_Filter_Shiny.Name = "L_Filter_Shiny";
        L_Filter_Shiny.Size = new Size(39, 15);
        L_Filter_Shiny.TabIndex = 162;
        L_Filter_Shiny.Text = "Shiny:";
        // 
        // CB_Filter_Shiny
        // 
        CB_Filter_Shiny.FormattingEnabled = true;
        CB_Filter_Shiny.Items.AddRange(new object[] { "Ignore", "Star/Square", "Square Only", "Star Only", "Not Shiny" });
        CB_Filter_Shiny.Location = new Point(112, 168);
        CB_Filter_Shiny.Name = "CB_Filter_Shiny";
        CB_Filter_Shiny.Size = new Size(142, 23);
        CB_Filter_Shiny.TabIndex = 155;
        // 
        // B_Spe_Max
        // 
        B_Spe_Max.Location = new Point(227, 142);
        B_Spe_Max.Name = "B_Spe_Max";
        B_Spe_Max.Size = new Size(27, 25);
        B_Spe_Max.TabIndex = 154;
        B_Spe_Max.Text = "31";
        B_Spe_Max.UseVisualStyleBackColor = true;
        B_Spe_Max.Click += B_IV_Max_Click;
        // 
        // B_Spe_Min
        // 
        B_Spe_Min.Location = new Point(198, 142);
        B_Spe_Min.Name = "B_Spe_Min";
        B_Spe_Min.Size = new Size(27, 25);
        B_Spe_Min.TabIndex = 153;
        B_Spe_Min.Text = "0";
        B_Spe_Min.UseVisualStyleBackColor = true;
        B_Spe_Min.Click += B_IV_Min_Click;
        // 
        // L_Spe
        // 
        L_Spe.AutoSize = true;
        L_Spe.Location = new Point(77, 147);
        L_Spe.Name = "L_Spe";
        L_Spe.Size = new Size(29, 15);
        L_Spe.TabIndex = 161;
        L_Spe.Text = "Spe:";
        L_Spe.Click += IV_Label_Click;
        // 
        // L_SpeSpacer
        // 
        L_SpeSpacer.AutoSize = true;
        L_SpeSpacer.Location = new Point(145, 145);
        L_SpeSpacer.Name = "L_SpeSpacer";
        L_SpeSpacer.Size = new Size(15, 15);
        L_SpeSpacer.TabIndex = 139;
        L_SpeSpacer.Text = "~";
        L_SpeSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Spe_Max
        // 
        NUD_Spe_Max.Location = new Point(161, 143);
        NUD_Spe_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Max.Name = "NUD_Spe_Max";
        NUD_Spe_Max.Size = new Size(32, 23);
        NUD_Spe_Max.TabIndex = 140;
        NUD_Spe_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Spe_Min
        // 
        NUD_Spe_Min.Location = new Point(112, 143);
        NUD_Spe_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Min.Name = "NUD_Spe_Min";
        NUD_Spe_Min.Size = new Size(32, 23);
        NUD_Spe_Min.TabIndex = 138;
        // 
        // B_SpD_Max
        // 
        B_SpD_Max.Location = new Point(227, 117);
        B_SpD_Max.Name = "B_SpD_Max";
        B_SpD_Max.Size = new Size(27, 25);
        B_SpD_Max.TabIndex = 152;
        B_SpD_Max.Text = "31";
        B_SpD_Max.UseVisualStyleBackColor = true;
        B_SpD_Max.Click += B_IV_Max_Click;
        // 
        // B_SpD_Min
        // 
        B_SpD_Min.Location = new Point(198, 117);
        B_SpD_Min.Name = "B_SpD_Min";
        B_SpD_Min.Size = new Size(27, 25);
        B_SpD_Min.TabIndex = 151;
        B_SpD_Min.Text = "0";
        B_SpD_Min.UseVisualStyleBackColor = true;
        B_SpD_Min.Click += B_IV_Min_Click;
        // 
        // L_SpD
        // 
        L_SpD.AutoSize = true;
        L_SpD.Location = new Point(75, 123);
        L_SpD.Name = "L_SpD";
        L_SpD.Size = new Size(31, 15);
        L_SpD.TabIndex = 160;
        L_SpD.Text = "SpD:";
        L_SpD.Click += IV_Label_Click;
        // 
        // L_SpDSpacer
        // 
        L_SpDSpacer.AutoSize = true;
        L_SpDSpacer.Location = new Point(145, 120);
        L_SpDSpacer.Name = "L_SpDSpacer";
        L_SpDSpacer.Size = new Size(15, 15);
        L_SpDSpacer.TabIndex = 136;
        L_SpDSpacer.Text = "~";
        L_SpDSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_SpD_Max
        // 
        NUD_SpD_Max.Location = new Point(161, 118);
        NUD_SpD_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Max.Name = "NUD_SpD_Max";
        NUD_SpD_Max.Size = new Size(32, 23);
        NUD_SpD_Max.TabIndex = 137;
        NUD_SpD_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpD_Min
        // 
        NUD_SpD_Min.Location = new Point(112, 118);
        NUD_SpD_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Min.Name = "NUD_SpD_Min";
        NUD_SpD_Min.Size = new Size(32, 23);
        NUD_SpD_Min.TabIndex = 135;
        // 
        // B_SpA_Max
        // 
        B_SpA_Max.Location = new Point(227, 92);
        B_SpA_Max.Name = "B_SpA_Max";
        B_SpA_Max.Size = new Size(27, 25);
        B_SpA_Max.TabIndex = 150;
        B_SpA_Max.Text = "31";
        B_SpA_Max.UseVisualStyleBackColor = true;
        B_SpA_Max.Click += B_IV_Max_Click;
        // 
        // B_SpA_Min
        // 
        B_SpA_Min.Location = new Point(198, 92);
        B_SpA_Min.Name = "B_SpA_Min";
        B_SpA_Min.Size = new Size(27, 25);
        B_SpA_Min.TabIndex = 148;
        B_SpA_Min.Text = "0";
        B_SpA_Min.UseVisualStyleBackColor = true;
        B_SpA_Min.Click += B_IV_Min_Click;
        // 
        // L_SpA
        // 
        L_SpA.AutoSize = true;
        L_SpA.Location = new Point(75, 95);
        L_SpA.Name = "L_SpA";
        L_SpA.Size = new Size(31, 15);
        L_SpA.TabIndex = 156;
        L_SpA.Text = "SpA:";
        L_SpA.Click += IV_Label_Click;
        // 
        // L_SpASpacer
        // 
        L_SpASpacer.AutoSize = true;
        L_SpASpacer.Location = new Point(145, 95);
        L_SpASpacer.Name = "L_SpASpacer";
        L_SpASpacer.Size = new Size(15, 15);
        L_SpASpacer.TabIndex = 134;
        L_SpASpacer.Text = "~";
        L_SpASpacer.Click += IV_Spacer_Click;
        // 
        // NUD_SpA_Max
        // 
        NUD_SpA_Max.Location = new Point(161, 93);
        NUD_SpA_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Max.Name = "NUD_SpA_Max";
        NUD_SpA_Max.Size = new Size(32, 23);
        NUD_SpA_Max.TabIndex = 133;
        NUD_SpA_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpA_Min
        // 
        NUD_SpA_Min.Location = new Point(112, 93);
        NUD_SpA_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Min.Name = "NUD_SpA_Min";
        NUD_SpA_Min.Size = new Size(32, 23);
        NUD_SpA_Min.TabIndex = 131;
        // 
        // B_Def_Max
        // 
        B_Def_Max.Location = new Point(227, 67);
        B_Def_Max.Name = "B_Def_Max";
        B_Def_Max.Size = new Size(27, 25);
        B_Def_Max.TabIndex = 147;
        B_Def_Max.Text = "31";
        B_Def_Max.UseVisualStyleBackColor = true;
        B_Def_Max.Click += B_IV_Max_Click;
        // 
        // B_Def_Min
        // 
        B_Def_Min.Location = new Point(198, 67);
        B_Def_Min.Name = "B_Def_Min";
        B_Def_Min.Size = new Size(27, 25);
        B_Def_Min.TabIndex = 146;
        B_Def_Min.Text = "0";
        B_Def_Min.UseVisualStyleBackColor = true;
        B_Def_Min.Click += B_IV_Min_Click;
        // 
        // L_Def
        // 
        L_Def.AutoSize = true;
        L_Def.Location = new Point(78, 70);
        L_Def.Name = "L_Def";
        L_Def.Size = new Size(28, 15);
        L_Def.TabIndex = 149;
        L_Def.Text = "Def:";
        L_Def.Click += IV_Label_Click;
        // 
        // L_DefSpacer
        // 
        L_DefSpacer.AutoSize = true;
        L_DefSpacer.Location = new Point(145, 70);
        L_DefSpacer.Name = "L_DefSpacer";
        L_DefSpacer.Size = new Size(15, 15);
        L_DefSpacer.TabIndex = 129;
        L_DefSpacer.Text = "~";
        L_DefSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Def_Max
        // 
        NUD_Def_Max.Location = new Point(161, 68);
        NUD_Def_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Max.Name = "NUD_Def_Max";
        NUD_Def_Max.Size = new Size(32, 23);
        NUD_Def_Max.TabIndex = 128;
        NUD_Def_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Def_Min
        // 
        NUD_Def_Min.Location = new Point(112, 68);
        NUD_Def_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Min.Name = "NUD_Def_Min";
        NUD_Def_Min.Size = new Size(32, 23);
        NUD_Def_Min.TabIndex = 127;
        // 
        // B_Atk_Max
        // 
        B_Atk_Max.Location = new Point(227, 42);
        B_Atk_Max.Name = "B_Atk_Max";
        B_Atk_Max.Size = new Size(27, 25);
        B_Atk_Max.TabIndex = 145;
        B_Atk_Max.Text = "31";
        B_Atk_Max.UseVisualStyleBackColor = true;
        B_Atk_Max.Click += B_IV_Max_Click;
        // 
        // B_Atk_Min
        // 
        B_Atk_Min.Location = new Point(198, 42);
        B_Atk_Min.Name = "B_Atk_Min";
        B_Atk_Min.Size = new Size(27, 25);
        B_Atk_Min.TabIndex = 144;
        B_Atk_Min.Text = "0";
        B_Atk_Min.UseVisualStyleBackColor = true;
        B_Atk_Min.Click += B_IV_Min_Click;
        // 
        // L_Atk
        // 
        L_Atk.AutoSize = true;
        L_Atk.Location = new Point(78, 45);
        L_Atk.Name = "L_Atk";
        L_Atk.Size = new Size(28, 15);
        L_Atk.TabIndex = 142;
        L_Atk.Text = "Atk:";
        L_Atk.Click += IV_Label_Click;
        // 
        // L_AtkSpacer
        // 
        L_AtkSpacer.AutoSize = true;
        L_AtkSpacer.Location = new Point(145, 45);
        L_AtkSpacer.Name = "L_AtkSpacer";
        L_AtkSpacer.Size = new Size(15, 15);
        L_AtkSpacer.TabIndex = 126;
        L_AtkSpacer.Text = "~";
        L_AtkSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_Atk_Max
        // 
        NUD_Atk_Max.Location = new Point(161, 43);
        NUD_Atk_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Max.Name = "NUD_Atk_Max";
        NUD_Atk_Max.Size = new Size(32, 23);
        NUD_Atk_Max.TabIndex = 125;
        NUD_Atk_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Atk_Min
        // 
        NUD_Atk_Min.Location = new Point(112, 43);
        NUD_Atk_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Min.Name = "NUD_Atk_Min";
        NUD_Atk_Min.Size = new Size(32, 23);
        NUD_Atk_Min.TabIndex = 124;
        // 
        // B_HP_Max
        // 
        B_HP_Max.Location = new Point(227, 17);
        B_HP_Max.Name = "B_HP_Max";
        B_HP_Max.Size = new Size(27, 25);
        B_HP_Max.TabIndex = 143;
        B_HP_Max.Text = "31";
        B_HP_Max.UseVisualStyleBackColor = true;
        B_HP_Max.Click += B_IV_Max_Click;
        // 
        // B_HP_Min
        // 
        B_HP_Min.Location = new Point(198, 17);
        B_HP_Min.Name = "B_HP_Min";
        B_HP_Min.Size = new Size(27, 25);
        B_HP_Min.TabIndex = 141;
        B_HP_Min.Text = "0";
        B_HP_Min.UseVisualStyleBackColor = true;
        B_HP_Min.Click += B_IV_Min_Click;
        // 
        // L_HP
        // 
        L_HP.AutoSize = true;
        L_HP.Location = new Point(80, 20);
        L_HP.Name = "L_HP";
        L_HP.Size = new Size(26, 15);
        L_HP.TabIndex = 132;
        L_HP.Text = "HP:";
        L_HP.Click += IV_Label_Click;
        // 
        // L_HPSpacer
        // 
        L_HPSpacer.AutoSize = true;
        L_HPSpacer.Location = new Point(145, 20);
        L_HPSpacer.Name = "L_HPSpacer";
        L_HPSpacer.Size = new Size(15, 15);
        L_HPSpacer.TabIndex = 130;
        L_HPSpacer.Text = "~";
        L_HPSpacer.Click += IV_Spacer_Click;
        // 
        // NUD_HP_Max
        // 
        NUD_HP_Max.Location = new Point(161, 18);
        NUD_HP_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Max.Name = "NUD_HP_Max";
        NUD_HP_Max.Size = new Size(32, 23);
        NUD_HP_Max.TabIndex = 123;
        NUD_HP_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_HP_Min
        // 
        NUD_HP_Min.Location = new Point(112, 18);
        NUD_HP_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Min.Name = "NUD_HP_Min";
        NUD_HP_Min.Size = new Size(32, 23);
        NUD_HP_Min.TabIndex = 122;
        // 
        // button1
        // 
        button1.Location = new Point(230, -1);
        button1.Name = "button1";
        button1.Size = new Size(288, 25);
        button1.TabIndex = 127;
        button1.Text = "Show Wild Generator >>";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(545, -1);
        button2.Name = "button2";
        button2.Size = new Size(288, 25);
        button2.TabIndex = 128;
        button2.Text = "<< Hide Wild Generator";
        button2.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button4);
        groupBox1.Controls.Add(button3);
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
        groupBox1.Location = new Point(566, 27);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(227, 210);
        groupBox1.TabIndex = 129;
        groupBox1.TabStop = false;
        groupBox1.Text = "Generation Criteria";
        // 
        // button4
        // 
        button4.Enabled = false;
        button4.Location = new Point(8, 149);
        button4.Name = "button4";
        button4.Size = new Size(213, 25);
        button4.TabIndex = 135;
        button4.Text = "Read Species from RAM";
        button4.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Enabled = false;
        button3.Location = new Point(8, 72);
        button3.Name = "button3";
        button3.Size = new Size(213, 25);
        button3.TabIndex = 134;
        button3.Text = "Read Chain Count from RAM";
        button3.UseVisualStyleBackColor = true;
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
        CB_Area.TabIndex = 132;
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
        CB_Species.TabIndex = 130;
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
        CB_Lead.TabIndex = 128;
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
        NUD_ChainCount.TabIndex = 126;
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
        CB_Patch.TabIndex = 124;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Advances";
        dataGridViewTextBoxColumn1.HeaderText = "Advances";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // Shiny
        // 
        Shiny.DataPropertyName = "Shiny";
        Shiny.HeaderText = "Shiny";
        Shiny.Name = "Shiny";
        Shiny.ReadOnly = true;
        // 
        // Ability
        // 
        Ability.DataPropertyName = "Ability";
        Ability.HeaderText = "Ability";
        Ability.Name = "Ability";
        Ability.ReadOnly = true;
        // 
        // Nature
        // 
        Nature.DataPropertyName = "Nature";
        Nature.HeaderText = "Nature";
        Nature.Name = "Nature";
        Nature.ReadOnly = true;
        // 
        // Gender
        // 
        Gender.DataPropertyName = "Gender";
        Gender.HeaderText = "Gender";
        Gender.Name = "Gender";
        Gender.ReadOnly = true;
        // 
        // H
        // 
        H.DataPropertyName = "H";
        H.HeaderText = "H";
        H.Name = "H";
        H.ReadOnly = true;
        // 
        // A
        // 
        A.DataPropertyName = "A";
        A.HeaderText = "A";
        A.Name = "A";
        A.ReadOnly = true;
        // 
        // B
        // 
        B.DataPropertyName = "B";
        B.HeaderText = "B";
        B.Name = "B";
        B.ReadOnly = true;
        // 
        // C
        // 
        C.DataPropertyName = "C";
        C.HeaderText = "C";
        C.Name = "C";
        C.ReadOnly = true;
        // 
        // D
        // 
        D.DataPropertyName = "D";
        D.HeaderText = "D";
        D.Name = "D";
        D.ReadOnly = true;
        // 
        // S
        // 
        S.DataPropertyName = "S";
        S.HeaderText = "S";
        S.Name = "S";
        S.ReadOnly = true;
        // 
        // EC
        // 
        EC.DataPropertyName = "EC";
        EC.HeaderText = "EC";
        EC.Name = "EC";
        EC.ReadOnly = true;
        // 
        // PID
        // 
        PID.DataPropertyName = "PID";
        PID.HeaderText = "PID";
        PID.Name = "PID";
        PID.ReadOnly = true;
        // 
        // Height
        // 
        Height.DataPropertyName = "Height";
        Height.HeaderText = "Height";
        Height.Name = "Height";
        Height.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.DataPropertyName = "Seed0";
        dataGridViewTextBoxColumn2.HeaderText = "Seed0";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.DataPropertyName = "Seed1";
        dataGridViewTextBoxColumn3.HeaderText = "Seed1";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1378, 627);
        Controls.Add(groupBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(GB_Filters);
        Controls.Add(DGV_ResultsPokemon);
        Controls.Add(B_PokemonSearch);
        Controls.Add(label6);
        Controls.Add(NUD_ActionTimes);
        Controls.Add(label5);
        Controls.Add(CB_Action);
        Controls.Add(label4);
        Controls.Add(CB_Rate);
        Controls.Add(label3);
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
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainWindow";
        Text = "Automatic Radar Seed Extrapolator";
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
    private DataGridViewTextBoxColumn advancesDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn seed0DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn seed1DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn failDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn rollDataGridViewTextBoxColumn;
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
    private Label label3;
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
    private Button button1;
    private Button button2;
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
    private Button button3;
    private Button button4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
}

