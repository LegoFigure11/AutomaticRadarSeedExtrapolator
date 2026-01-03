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
        DGV_Results = new DataGridView();
        advancesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        seed0DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        seed1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        failDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        rollDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ResultsSource = new BindingSource(components);
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
        B_Up = new Button();
        button1 = new Button();
        button3 = new Button();
        button4 = new Button();
        button2 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        label7 = new Label();
        textBox1 = new TextBox();
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();
        button13 = new Button();
        button14 = new Button();
        TB_FlipTarget = new TextBox();
        label8 = new Label();
        GB_Connection.SuspendLayout();
        GB_Seed.SuspendLayout();
        GB_SAVInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_SafeNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DGV_Results).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ActionTimes).BeginInit();
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
        // DGV_Results
        // 
        DGV_Results.AllowUserToAddRows = false;
        DGV_Results.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
        DGV_Results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        DGV_Results.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DGV_Results.AutoGenerateColumns = false;
        DGV_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DGV_Results.Columns.AddRange(new DataGridViewColumn[] { advancesDataGridViewTextBoxColumn, seed0DataGridViewTextBoxColumn, seed1DataGridViewTextBoxColumn, failDataGridViewTextBoxColumn, rollDataGridViewTextBoxColumn });
        DGV_Results.DataSource = ResultsSource;
        DGV_Results.Location = new Point(12, 306);
        DGV_Results.Name = "DGV_Results";
        DGV_Results.ReadOnly = true;
        DGV_Results.RowHeadersVisible = false;
        DGV_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DGV_Results.Size = new Size(690, 309);
        DGV_Results.TabIndex = 8;
        DGV_Results.CellFormatting += DGV_Results_CellFormatting;
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
        // ResultsSource
        // 
        ResultsSource.DataSource = typeof(Core.Interfaces.RadarContinuationFrame);
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
        // B_Up
        // 
        B_Up.Location = new Point(554, 29);
        B_Up.Name = "B_Up";
        B_Up.Size = new Size(25, 25);
        B_Up.TabIndex = 74;
        B_Up.Text = "↑";
        B_Up.UseVisualStyleBackColor = true;
        B_Up.Click += B_Up_Click;
        // 
        // button1
        // 
        button1.Location = new Point(554, 81);
        button1.Name = "button1";
        button1.Size = new Size(25, 25);
        button1.TabIndex = 75;
        button1.Text = "↓";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button3
        // 
        button3.Location = new Point(527, 55);
        button3.Name = "button3";
        button3.Size = new Size(25, 25);
        button3.TabIndex = 77;
        button3.Text = "←";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(580, 55);
        button4.Name = "button4";
        button4.Size = new Size(25, 25);
        button4.TabIndex = 78;
        button4.Text = "→";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button2
        // 
        button2.Location = new Point(674, 55);
        button2.Name = "button2";
        button2.Size = new Size(25, 25);
        button2.TabIndex = 82;
        button2.Text = "A";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button5
        // 
        button5.Location = new Point(648, 29);
        button5.Name = "button5";
        button5.Size = new Size(25, 25);
        button5.TabIndex = 81;
        button5.Text = "X";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new Point(648, 81);
        button6.Name = "button6";
        button6.Size = new Size(25, 25);
        button6.TabIndex = 80;
        button6.Text = "B";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Location = new Point(621, 55);
        button7.Name = "button7";
        button7.Size = new Size(25, 25);
        button7.TabIndex = 79;
        button7.Text = "Y";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // button8
        // 
        button8.Location = new Point(580, 1);
        button8.Name = "button8";
        button8.Size = new Size(25, 25);
        button8.TabIndex = 83;
        button8.Text = "-";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // button9
        // 
        button9.Location = new Point(554, 1);
        button9.Name = "button9";
        button9.Size = new Size(25, 25);
        button9.TabIndex = 84;
        button9.Text = "⇑";
        button9.UseVisualStyleBackColor = true;
        button9.Click += button9_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(526, 256);
        label7.Name = "label7";
        label7.Size = new Size(49, 15);
        label7.TabIndex = 86;
        label7.Text = "Seed[0]:";
        // 
        // textBox1
        // 
        textBox1.CharacterCasing = CharacterCasing.Upper;
        textBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(581, 254);
        textBox1.MaxLength = 16;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(118, 22);
        textBox1.TabIndex = 85;
        textBox1.Text = "0123456789ABCDEF";
        // 
        // button10
        // 
        button10.Location = new Point(524, 277);
        button10.Name = "button10";
        button10.Size = new Size(175, 25);
        button10.TabIndex = 87;
        button10.Text = "Search";
        button10.UseVisualStyleBackColor = true;
        button10.Click += button10_Click;
        // 
        // button11
        // 
        button11.Location = new Point(600, 29);
        button11.Name = "button11";
        button11.Size = new Size(25, 25);
        button11.TabIndex = 88;
        button11.Text = "🏠";
        button11.UseVisualStyleBackColor = true;
        button11.Click += button11_Click;
        // 
        // button12
        // 
        button12.Location = new Point(674, 1);
        button12.Name = "button12";
        button12.Size = new Size(25, 25);
        button12.TabIndex = 89;
        button12.Text = "R";
        button12.UseVisualStyleBackColor = true;
        button12.Click += button12_Click;
        // 
        // button13
        // 
        button13.Location = new Point(527, 142);
        button13.Name = "button13";
        button13.Size = new Size(78, 25);
        button13.TabIndex = 90;
        button13.Text = "Dex Flip";
        button13.UseVisualStyleBackColor = true;
        button13.Click += button13_Click;
        // 
        // button14
        // 
        button14.Location = new Point(621, 142);
        button14.Name = "button14";
        button14.Size = new Size(78, 25);
        button14.TabIndex = 91;
        button14.Text = "Stop Flip";
        button14.UseVisualStyleBackColor = true;
        button14.Click += button14_Click;
        // 
        // TB_FlipTarget
        // 
        TB_FlipTarget.CharacterCasing = CharacterCasing.Upper;
        TB_FlipTarget.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_FlipTarget.Location = new Point(600, 116);
        TB_FlipTarget.MaxLength = 16;
        TB_FlipTarget.Name = "TB_FlipTarget";
        TB_FlipTarget.Size = new Size(99, 22);
        TB_FlipTarget.TabIndex = 92;
        TB_FlipTarget.Text = "0";
        TB_FlipTarget.TextAlign = HorizontalAlignment.Right;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(530, 120);
        label8.Name = "label8";
        label8.Size = new Size(43, 15);
        label8.TabIndex = 93;
        label8.Text = "Flip to:";
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(714, 627);
        Controls.Add(label8);
        Controls.Add(TB_FlipTarget);
        Controls.Add(button14);
        Controls.Add(button13);
        Controls.Add(button12);
        Controls.Add(button11);
        Controls.Add(button10);
        Controls.Add(label7);
        Controls.Add(textBox1);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button2);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button7);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button1);
        Controls.Add(B_Up);
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
        Controls.Add(DGV_Results);
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
        ((System.ComponentModel.ISupportInitialize)DGV_Results).EndInit();
        ((System.ComponentModel.ISupportInitialize)ResultsSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_ActionTimes).EndInit();
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
    private DataGridView DGV_Results;
    private BindingSource ResultsSource;
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
    private Button B_Up;
    private Button button1;
    private Button button3;
    private Button button4;
    private Button button2;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Label label7;
    public TextBox textBox1;
    private Button button10;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private TextBox TB_FlipTarget;
    private Label label8;
}

