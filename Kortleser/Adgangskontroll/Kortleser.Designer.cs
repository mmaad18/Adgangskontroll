namespace Adgangskontroll
{
    partial class Kortleser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kortleser));
            this.groupKodePanel = new System.Windows.Forms.GroupBox();
            this.pbAlarm = new System.Windows.Forms.PictureBox();
            this.pbOpenCLosed = new System.Windows.Forms.PictureBox();
            this.btCode0 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCode2 = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCode3 = new System.Windows.Forms.Button();
            this.btCode1 = new System.Windows.Forms.Button();
            this.kortnummerLabel = new System.Windows.Forms.Label();
            this.txtbKortnummer = new System.Windows.Forms.TextBox();
            this.btScanKort = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelLockTimer = new System.Windows.Forms.Label();
            this.labelAlarmType = new System.Windows.Forms.Label();
            this.labelDoorTimer = new System.Windows.Forms.Label();
            this.labelLockStatus = new System.Windows.Forms.Label();
            this.labelAlarmStatus = new System.Windows.Forms.Label();
            this.labelDoorStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btSerialConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbSerialBaud = new System.Windows.Forms.TextBox();
            this.comboBSerialPort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btTcpDisconnect = new System.Windows.Forms.Button();
            this.btTcpConnect = new System.Windows.Forms.Button();
            this.txtbTcpPort = new System.Windows.Forms.TextBox();
            this.txtbTcpIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbKortleserPlassering = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbKortleserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbPot1 = new System.Windows.Forms.TextBox();
            this.cbDO5 = new System.Windows.Forms.CheckBox();
            this.cbDO6 = new System.Windows.Forms.CheckBox();
            this.cbDO7 = new System.Windows.Forms.CheckBox();
            this.cbDO4 = new System.Windows.Forms.CheckBox();
            this.cbDI5 = new System.Windows.Forms.CheckBox();
            this.cbDI6 = new System.Windows.Forms.CheckBox();
            this.cbDI7 = new System.Windows.Forms.CheckBox();
            this.cbDI4 = new System.Windows.Forms.CheckBox();
            this.cbDI1 = new System.Windows.Forms.CheckBox();
            this.cbDI2 = new System.Windows.Forms.CheckBox();
            this.cbDI3 = new System.Windows.Forms.CheckBox();
            this.cbDO0 = new System.Windows.Forms.CheckBox();
            this.cbDO1 = new System.Windows.Forms.CheckBox();
            this.cbDO2 = new System.Windows.Forms.CheckBox();
            this.cbDO3 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDI0 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbPot2 = new System.Windows.Forms.TextBox();
            this.Potensiometer = new System.Windows.Forms.Label();
            this.txtbLog = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerAdgangsforsok = new System.Windows.Forms.Timer(this.components);
            this.timerGuiUpdater = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.timerReset7seg = new System.Windows.Forms.Timer(this.components);
            this.timerInnloggingOK = new System.Windows.Forms.Timer(this.components);
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupKodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenCLosed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupKodePanel
            // 
            this.groupKodePanel.AutoSize = true;
            this.groupKodePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKodePanel.Controls.Add(this.pbAlarm);
            this.groupKodePanel.Controls.Add(this.sevenSegmentArray1);
            this.groupKodePanel.Controls.Add(this.pbOpenCLosed);
            this.groupKodePanel.Controls.Add(this.btCode0);
            this.groupKodePanel.Controls.Add(this.btClear);
            this.groupKodePanel.Controls.Add(this.btCode2);
            this.groupKodePanel.Controls.Add(this.btOK);
            this.groupKodePanel.Controls.Add(this.btCode3);
            this.groupKodePanel.Controls.Add(this.btCode1);
            this.groupKodePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupKodePanel.Enabled = false;
            this.groupKodePanel.Location = new System.Drawing.Point(6, 39);
            this.groupKodePanel.Name = "groupKodePanel";
            this.groupKodePanel.Size = new System.Drawing.Size(230, 228);
            this.groupKodePanel.TabIndex = 12;
            this.groupKodePanel.TabStop = false;
            // 
            // pbAlarm
            // 
            this.pbAlarm.Location = new System.Drawing.Point(62, 159);
            this.pbAlarm.Name = "pbAlarm";
            this.pbAlarm.Size = new System.Drawing.Size(50, 50);
            this.pbAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarm.TabIndex = 11;
            this.pbAlarm.TabStop = false;
            // 
            // pbOpenCLosed
            // 
            this.pbOpenCLosed.Location = new System.Drawing.Point(6, 159);
            this.pbOpenCLosed.Name = "pbOpenCLosed";
            this.pbOpenCLosed.Size = new System.Drawing.Size(50, 50);
            this.pbOpenCLosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpenCLosed.TabIndex = 10;
            this.pbOpenCLosed.TabStop = false;
            // 
            // btCode0
            // 
            this.btCode0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCode0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCode0.Location = new System.Drawing.Point(6, 103);
            this.btCode0.Name = "btCode0";
            this.btCode0.Size = new System.Drawing.Size(50, 50);
            this.btCode0.TabIndex = 1;
            this.btCode0.Text = "0";
            this.btCode0.UseVisualStyleBackColor = true;
            this.btCode0.Click += new System.EventHandler(this.Kode_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(118, 159);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(50, 50);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCode2
            // 
            this.btCode2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCode2.Location = new System.Drawing.Point(118, 103);
            this.btCode2.Name = "btCode2";
            this.btCode2.Size = new System.Drawing.Size(50, 50);
            this.btCode2.TabIndex = 2;
            this.btCode2.Text = "2";
            this.btCode2.UseVisualStyleBackColor = true;
            this.btCode2.Click += new System.EventHandler(this.Kode_Click);
            // 
            // btOK
            // 
            this.btOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(174, 159);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(50, 50);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCode3
            // 
            this.btCode3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCode3.Location = new System.Drawing.Point(174, 103);
            this.btCode3.Name = "btCode3";
            this.btCode3.Size = new System.Drawing.Size(50, 50);
            this.btCode3.TabIndex = 3;
            this.btCode3.Text = "3";
            this.btCode3.UseVisualStyleBackColor = true;
            this.btCode3.Click += new System.EventHandler(this.Kode_Click);
            // 
            // btCode1
            // 
            this.btCode1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCode1.Location = new System.Drawing.Point(62, 103);
            this.btCode1.Name = "btCode1";
            this.btCode1.Size = new System.Drawing.Size(50, 50);
            this.btCode1.TabIndex = 4;
            this.btCode1.Text = "1";
            this.btCode1.UseVisualStyleBackColor = true;
            this.btCode1.Click += new System.EventHandler(this.Kode_Click);
            // 
            // kortnummerLabel
            // 
            this.kortnummerLabel.AutoSize = true;
            this.kortnummerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kortnummerLabel.Location = new System.Drawing.Point(2, 10);
            this.kortnummerLabel.Name = "kortnummerLabel";
            this.kortnummerLabel.Size = new System.Drawing.Size(100, 20);
            this.kortnummerLabel.TabIndex = 14;
            this.kortnummerLabel.Text = "Kortnummer:";
            // 
            // txtbKortnummer
            // 
            this.txtbKortnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbKortnummer.Location = new System.Drawing.Point(105, 7);
            this.txtbKortnummer.MaxLength = 4;
            this.txtbKortnummer.Name = "txtbKortnummer";
            this.txtbKortnummer.Size = new System.Drawing.Size(41, 26);
            this.txtbKortnummer.TabIndex = 15;
            this.txtbKortnummer.Text = "1234";
            this.txtbKortnummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbKortnummer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kortnummerTxt_KeyDown);
            // 
            // btScanKort
            // 
            this.btScanKort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScanKort.Location = new System.Drawing.Point(152, 7);
            this.btScanKort.Name = "btScanKort";
            this.btScanKort.Size = new System.Drawing.Size(84, 26);
            this.btScanKort.TabIndex = 16;
            this.btScanKort.Text = "SCAN";
            this.btScanKort.UseVisualStyleBackColor = true;
            this.btScanKort.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabSetup);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 342);
            this.tabControl1.TabIndex = 18;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabMain.Controls.Add(this.labelLockTimer);
            this.tabMain.Controls.Add(this.labelAlarmType);
            this.tabMain.Controls.Add(this.labelDoorTimer);
            this.tabMain.Controls.Add(this.labelLockStatus);
            this.tabMain.Controls.Add(this.labelAlarmStatus);
            this.tabMain.Controls.Add(this.labelDoorStatus);
            this.tabMain.Controls.Add(this.label9);
            this.tabMain.Controls.Add(this.label8);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Controls.Add(this.groupKodePanel);
            this.tabMain.Controls.Add(this.kortnummerLabel);
            this.tabMain.Controls.Add(this.btScanKort);
            this.tabMain.Controls.Add(this.txtbKortnummer);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(244, 316);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Kortleser";
            // 
            // labelLockTimer
            // 
            this.labelLockTimer.Location = new System.Drawing.Point(196, 283);
            this.labelLockTimer.Name = "labelLockTimer";
            this.labelLockTimer.Size = new System.Drawing.Size(40, 13);
            this.labelLockTimer.TabIndex = 25;
            this.labelLockTimer.Text = "Timer";
            this.labelLockTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAlarmType
            // 
            this.labelAlarmType.Location = new System.Drawing.Point(162, 296);
            this.labelAlarmType.Name = "labelAlarmType";
            this.labelAlarmType.Size = new System.Drawing.Size(74, 13);
            this.labelAlarmType.TabIndex = 24;
            this.labelAlarmType.Text = "Alarmtype";
            this.labelAlarmType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDoorTimer
            // 
            this.labelDoorTimer.Location = new System.Drawing.Point(196, 270);
            this.labelDoorTimer.Name = "labelDoorTimer";
            this.labelDoorTimer.Size = new System.Drawing.Size(40, 13);
            this.labelDoorTimer.TabIndex = 19;
            this.labelDoorTimer.Text = "Timer";
            this.labelDoorTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLockStatus
            // 
            this.labelLockStatus.Location = new System.Drawing.Point(76, 283);
            this.labelLockStatus.Name = "labelLockStatus";
            this.labelLockStatus.Size = new System.Drawing.Size(40, 13);
            this.labelLockStatus.TabIndex = 22;
            this.labelLockStatus.Text = "Åpen";
            this.labelLockStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAlarmStatus
            // 
            this.labelAlarmStatus.Location = new System.Drawing.Point(76, 296);
            this.labelAlarmStatus.Name = "labelAlarmStatus";
            this.labelAlarmStatus.Size = new System.Drawing.Size(40, 13);
            this.labelAlarmStatus.TabIndex = 21;
            this.labelAlarmStatus.Text = "False";
            this.labelAlarmStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDoorStatus
            // 
            this.labelDoorStatus.Location = new System.Drawing.Point(76, 270);
            this.labelDoorStatus.Name = "labelDoorStatus";
            this.labelDoorStatus.Size = new System.Drawing.Size(40, 13);
            this.labelDoorStatus.TabIndex = 20;
            this.labelDoorStatus.Text = "Åpen";
            this.labelDoorStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lås status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alarmstatus :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dørstatus :";
            // 
            // tabSetup
            // 
            this.tabSetup.BackColor = System.Drawing.SystemColors.Control;
            this.tabSetup.Controls.Add(this.groupBox4);
            this.tabSetup.Controls.Add(this.groupBox3);
            this.tabSetup.Controls.Add(this.groupBox2);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(244, 316);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Instillinger";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.btSerialConnect);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtbSerialBaud);
            this.groupBox4.Controls.Add(this.comboBSerialPort);
            this.groupBox4.Location = new System.Drawing.Point(3, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 111);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serieport";
            // 
            // btSerialConnect
            // 
            this.btSerialConnect.Location = new System.Drawing.Point(154, 69);
            this.btSerialConnect.Name = "btSerialConnect";
            this.btSerialConnect.Size = new System.Drawing.Size(75, 23);
            this.btSerialConnect.TabIndex = 8;
            this.btSerialConnect.Text = "Koble Til";
            this.btSerialConnect.UseVisualStyleBackColor = true;
            this.btSerialConnect.Click += new System.EventHandler(this.btSerialConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Baud :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comport :";
            // 
            // txtbSerialBaud
            // 
            this.txtbSerialBaud.Location = new System.Drawing.Point(189, 46);
            this.txtbSerialBaud.Name = "txtbSerialBaud";
            this.txtbSerialBaud.Size = new System.Drawing.Size(40, 20);
            this.txtbSerialBaud.TabIndex = 7;
            this.txtbSerialBaud.Text = "9600";
            this.txtbSerialBaud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBSerialPort
            // 
            this.comboBSerialPort.FormattingEnabled = true;
            this.comboBSerialPort.Items.AddRange(new object[] {
            "COM0"});
            this.comboBSerialPort.Location = new System.Drawing.Point(169, 19);
            this.comboBSerialPort.Name = "comboBSerialPort";
            this.comboBSerialPort.Size = new System.Drawing.Size(60, 21);
            this.comboBSerialPort.TabIndex = 6;
            this.comboBSerialPort.Text = "COM#";
            this.comboBSerialPort.MouseEnter += new System.EventHandler(this.comboBSerialPort_MouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.btTcpDisconnect);
            this.groupBox3.Controls.Add(this.btTcpConnect);
            this.groupBox3.Controls.Add(this.txtbTcpPort);
            this.groupBox3.Controls.Add(this.txtbTcpIP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sentral";
            // 
            // btTcpDisconnect
            // 
            this.btTcpDisconnect.Enabled = false;
            this.btTcpDisconnect.Location = new System.Drawing.Point(151, 65);
            this.btTcpDisconnect.Name = "btTcpDisconnect";
            this.btTcpDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btTcpDisconnect.TabIndex = 6;
            this.btTcpDisconnect.Text = "Koble fra...";
            this.btTcpDisconnect.UseVisualStyleBackColor = true;
            this.btTcpDisconnect.Visible = false;
            this.btTcpDisconnect.Click += new System.EventHandler(this.btTcpDisconnect_Click);
            // 
            // btTcpConnect
            // 
            this.btTcpConnect.Location = new System.Drawing.Point(151, 65);
            this.btTcpConnect.Name = "btTcpConnect";
            this.btTcpConnect.Size = new System.Drawing.Size(75, 23);
            this.btTcpConnect.TabIndex = 5;
            this.btTcpConnect.Text = "Koble Til";
            this.btTcpConnect.UseVisualStyleBackColor = true;
            this.btTcpConnect.Click += new System.EventHandler(this.btTcpConnect_Click);
            // 
            // txtbTcpPort
            // 
            this.txtbTcpPort.Location = new System.Drawing.Point(186, 39);
            this.txtbTcpPort.MaxLength = 5;
            this.txtbTcpPort.Name = "txtbTcpPort";
            this.txtbTcpPort.Size = new System.Drawing.Size(40, 20);
            this.txtbTcpPort.TabIndex = 4;
            this.txtbTcpPort.Text = "9090";
            this.txtbTcpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbTcpIP
            // 
            this.txtbTcpIP.Location = new System.Drawing.Point(105, 13);
            this.txtbTcpIP.Name = "txtbTcpIP";
            this.txtbTcpIP.Size = new System.Drawing.Size(121, 20);
            this.txtbTcpIP.TabIndex = 3;
            this.txtbTcpIP.Text = "127.0.0.1";
            this.txtbTcpIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Portnummer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP-Adresse :";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.txtbKortleserPlassering);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbKortleserID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kortleser ID";
            // 
            // txtbKortleserPlassering
            // 
            this.txtbKortleserPlassering.Location = new System.Drawing.Point(108, 39);
            this.txtbKortleserPlassering.Name = "txtbKortleserPlassering";
            this.txtbKortleserPlassering.Size = new System.Drawing.Size(121, 20);
            this.txtbKortleserPlassering.TabIndex = 2;
            this.txtbKortleserPlassering.Text = "Ytterdør";
            this.txtbKortleserPlassering.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbKortleserPlassering.TextChanged += new System.EventHandler(this.txtbKortleserPlassering_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plassering :";
            // 
            // txtbKortleserID
            // 
            this.txtbKortleserID.Location = new System.Drawing.Point(189, 13);
            this.txtbKortleserID.MaxLength = 4;
            this.txtbKortleserID.Name = "txtbKortleserID";
            this.txtbKortleserID.Size = new System.Drawing.Size(40, 20);
            this.txtbKortleserID.TabIndex = 1;
            this.txtbKortleserID.Text = "1234";
            this.txtbKortleserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbKortleserID.TextChanged += new System.EventHandler(this.txtbKortleserID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nummer :";
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.SystemColors.Control;
            this.tabLog.Controls.Add(this.groupBox1);
            this.tabLog.Controls.Add(this.txtbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(244, 316);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtbPot1);
            this.groupBox1.Controls.Add(this.cbDO5);
            this.groupBox1.Controls.Add(this.cbDO6);
            this.groupBox1.Controls.Add(this.cbDO7);
            this.groupBox1.Controls.Add(this.cbDO4);
            this.groupBox1.Controls.Add(this.cbDI5);
            this.groupBox1.Controls.Add(this.cbDI6);
            this.groupBox1.Controls.Add(this.cbDI7);
            this.groupBox1.Controls.Add(this.cbDI4);
            this.groupBox1.Controls.Add(this.cbDI1);
            this.groupBox1.Controls.Add(this.cbDI2);
            this.groupBox1.Controls.Add(this.cbDI3);
            this.groupBox1.Controls.Add(this.cbDO0);
            this.groupBox1.Controls.Add(this.cbDO1);
            this.groupBox1.Controls.Add(this.cbDO2);
            this.groupBox1.Controls.Add(this.cbDO3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbDI0);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtbPot2);
            this.groupBox1.Controls.Add(this.Potensiometer);
            this.groupBox1.Location = new System.Drawing.Point(3, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SimSimStatus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(164, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Potmeter 2:";
            // 
            // txtbPot1
            // 
            this.txtbPot1.Location = new System.Drawing.Point(167, 32);
            this.txtbPot1.Margin = new System.Windows.Forms.Padding(1);
            this.txtbPot1.Name = "txtbPot1";
            this.txtbPot1.ReadOnly = true;
            this.txtbPot1.Size = new System.Drawing.Size(58, 20);
            this.txtbPot1.TabIndex = 47;
            this.txtbPot1.Text = "1234";
            this.txtbPot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDO5
            // 
            this.cbDO5.AutoCheck = false;
            this.cbDO5.AutoSize = true;
            this.cbDO5.Checked = true;
            this.cbDO5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO5.Location = new System.Drawing.Point(111, 51);
            this.cbDO5.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO5.Name = "cbDO5";
            this.cbDO5.Size = new System.Drawing.Size(32, 17);
            this.cbDO5.TabIndex = 46;
            this.cbDO5.Text = "5";
            this.cbDO5.UseVisualStyleBackColor = true;
            // 
            // cbDO6
            // 
            this.cbDO6.AutoCheck = false;
            this.cbDO6.AutoSize = true;
            this.cbDO6.Checked = true;
            this.cbDO6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO6.Location = new System.Drawing.Point(111, 70);
            this.cbDO6.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO6.Name = "cbDO6";
            this.cbDO6.Size = new System.Drawing.Size(32, 17);
            this.cbDO6.TabIndex = 45;
            this.cbDO6.Text = "6";
            this.cbDO6.UseVisualStyleBackColor = true;
            // 
            // cbDO7
            // 
            this.cbDO7.AutoCheck = false;
            this.cbDO7.AutoSize = true;
            this.cbDO7.Checked = true;
            this.cbDO7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO7.Location = new System.Drawing.Point(111, 90);
            this.cbDO7.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO7.Name = "cbDO7";
            this.cbDO7.Size = new System.Drawing.Size(32, 17);
            this.cbDO7.TabIndex = 44;
            this.cbDO7.Text = "7";
            this.cbDO7.UseVisualStyleBackColor = true;
            // 
            // cbDO4
            // 
            this.cbDO4.AutoCheck = false;
            this.cbDO4.AutoSize = true;
            this.cbDO4.Checked = true;
            this.cbDO4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO4.Location = new System.Drawing.Point(111, 32);
            this.cbDO4.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO4.Name = "cbDO4";
            this.cbDO4.Size = new System.Drawing.Size(32, 17);
            this.cbDO4.TabIndex = 43;
            this.cbDO4.Text = "4";
            this.cbDO4.UseVisualStyleBackColor = true;
            // 
            // cbDI5
            // 
            this.cbDI5.AutoCheck = false;
            this.cbDI5.AutoSize = true;
            this.cbDI5.Checked = true;
            this.cbDI5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI5.Location = new System.Drawing.Point(43, 51);
            this.cbDI5.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI5.Name = "cbDI5";
            this.cbDI5.Size = new System.Drawing.Size(32, 17);
            this.cbDI5.TabIndex = 42;
            this.cbDI5.Text = "5";
            this.cbDI5.UseVisualStyleBackColor = true;
            // 
            // cbDI6
            // 
            this.cbDI6.AutoCheck = false;
            this.cbDI6.AutoSize = true;
            this.cbDI6.Checked = true;
            this.cbDI6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI6.Location = new System.Drawing.Point(43, 70);
            this.cbDI6.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI6.Name = "cbDI6";
            this.cbDI6.Size = new System.Drawing.Size(32, 17);
            this.cbDI6.TabIndex = 41;
            this.cbDI6.Text = "6";
            this.cbDI6.UseVisualStyleBackColor = true;
            // 
            // cbDI7
            // 
            this.cbDI7.AutoCheck = false;
            this.cbDI7.AutoSize = true;
            this.cbDI7.Checked = true;
            this.cbDI7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI7.Location = new System.Drawing.Point(43, 90);
            this.cbDI7.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI7.Name = "cbDI7";
            this.cbDI7.Size = new System.Drawing.Size(32, 17);
            this.cbDI7.TabIndex = 40;
            this.cbDI7.Text = "7";
            this.cbDI7.UseVisualStyleBackColor = true;
            // 
            // cbDI4
            // 
            this.cbDI4.AutoCheck = false;
            this.cbDI4.AutoSize = true;
            this.cbDI4.Checked = true;
            this.cbDI4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI4.Location = new System.Drawing.Point(43, 32);
            this.cbDI4.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI4.Name = "cbDI4";
            this.cbDI4.Size = new System.Drawing.Size(32, 17);
            this.cbDI4.TabIndex = 39;
            this.cbDI4.Text = "4";
            this.cbDI4.UseVisualStyleBackColor = true;
            // 
            // cbDI1
            // 
            this.cbDI1.AutoCheck = false;
            this.cbDI1.AutoSize = true;
            this.cbDI1.Checked = true;
            this.cbDI1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI1.Location = new System.Drawing.Point(9, 51);
            this.cbDI1.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI1.Name = "cbDI1";
            this.cbDI1.Size = new System.Drawing.Size(32, 17);
            this.cbDI1.TabIndex = 38;
            this.cbDI1.Text = "1";
            this.cbDI1.UseVisualStyleBackColor = true;
            // 
            // cbDI2
            // 
            this.cbDI2.AutoCheck = false;
            this.cbDI2.AutoSize = true;
            this.cbDI2.Checked = true;
            this.cbDI2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI2.Location = new System.Drawing.Point(9, 70);
            this.cbDI2.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI2.Name = "cbDI2";
            this.cbDI2.Size = new System.Drawing.Size(32, 17);
            this.cbDI2.TabIndex = 37;
            this.cbDI2.Text = "2";
            this.cbDI2.UseVisualStyleBackColor = true;
            // 
            // cbDI3
            // 
            this.cbDI3.AutoCheck = false;
            this.cbDI3.AutoSize = true;
            this.cbDI3.Checked = true;
            this.cbDI3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI3.Location = new System.Drawing.Point(9, 90);
            this.cbDI3.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI3.Name = "cbDI3";
            this.cbDI3.Size = new System.Drawing.Size(32, 17);
            this.cbDI3.TabIndex = 36;
            this.cbDI3.Text = "3";
            this.cbDI3.UseVisualStyleBackColor = true;
            // 
            // cbDO0
            // 
            this.cbDO0.AutoCheck = false;
            this.cbDO0.AutoSize = true;
            this.cbDO0.Checked = true;
            this.cbDO0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO0.Location = new System.Drawing.Point(77, 32);
            this.cbDO0.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO0.Name = "cbDO0";
            this.cbDO0.Size = new System.Drawing.Size(32, 17);
            this.cbDO0.TabIndex = 35;
            this.cbDO0.Text = "0";
            this.cbDO0.UseVisualStyleBackColor = true;
            // 
            // cbDO1
            // 
            this.cbDO1.AutoCheck = false;
            this.cbDO1.AutoSize = true;
            this.cbDO1.Checked = true;
            this.cbDO1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO1.Location = new System.Drawing.Point(77, 51);
            this.cbDO1.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO1.Name = "cbDO1";
            this.cbDO1.Size = new System.Drawing.Size(32, 17);
            this.cbDO1.TabIndex = 34;
            this.cbDO1.Text = "1";
            this.cbDO1.UseVisualStyleBackColor = true;
            // 
            // cbDO2
            // 
            this.cbDO2.AutoCheck = false;
            this.cbDO2.AutoSize = true;
            this.cbDO2.Checked = true;
            this.cbDO2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO2.Location = new System.Drawing.Point(77, 70);
            this.cbDO2.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO2.Name = "cbDO2";
            this.cbDO2.Size = new System.Drawing.Size(32, 17);
            this.cbDO2.TabIndex = 33;
            this.cbDO2.Text = "2";
            this.cbDO2.UseVisualStyleBackColor = true;
            // 
            // cbDO3
            // 
            this.cbDO3.AutoCheck = false;
            this.cbDO3.AutoSize = true;
            this.cbDO3.Checked = true;
            this.cbDO3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDO3.Location = new System.Drawing.Point(77, 89);
            this.cbDO3.Margin = new System.Windows.Forms.Padding(1);
            this.cbDO3.Name = "cbDO3";
            this.cbDO3.Size = new System.Drawing.Size(32, 17);
            this.cbDO3.TabIndex = 32;
            this.cbDO3.Text = "3";
            this.cbDO3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "DI:";
            // 
            // cbDI0
            // 
            this.cbDI0.AutoCheck = false;
            this.cbDI0.AutoSize = true;
            this.cbDI0.Checked = true;
            this.cbDI0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDI0.Location = new System.Drawing.Point(9, 32);
            this.cbDI0.Margin = new System.Windows.Forms.Padding(1);
            this.cbDI0.Name = "cbDI0";
            this.cbDI0.Size = new System.Drawing.Size(32, 17);
            this.cbDI0.TabIndex = 30;
            this.cbDI0.Text = "0";
            this.cbDI0.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "DO:";
            // 
            // txtbPot2
            // 
            this.txtbPot2.Location = new System.Drawing.Point(167, 70);
            this.txtbPot2.Margin = new System.Windows.Forms.Padding(1);
            this.txtbPot2.Name = "txtbPot2";
            this.txtbPot2.ReadOnly = true;
            this.txtbPot2.Size = new System.Drawing.Size(58, 20);
            this.txtbPot2.TabIndex = 22;
            this.txtbPot2.Text = "1234";
            this.txtbPot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Potensiometer
            // 
            this.Potensiometer.AutoSize = true;
            this.Potensiometer.Location = new System.Drawing.Point(164, 16);
            this.Potensiometer.Name = "Potensiometer";
            this.Potensiometer.Size = new System.Drawing.Size(61, 13);
            this.Potensiometer.TabIndex = 21;
            this.Potensiometer.Text = "Potmeter 1:";
            // 
            // txtbLog
            // 
            this.txtbLog.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtbLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLog.ForeColor = System.Drawing.Color.Lime;
            this.txtbLog.Location = new System.Drawing.Point(3, 3);
            this.txtbLog.Multiline = true;
            this.txtbLog.Name = "txtbLog";
            this.txtbLog.ReadOnly = true;
            this.txtbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbLog.Size = new System.Drawing.Size(238, 197);
            this.txtbLog.TabIndex = 19;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Location = new System.Drawing.Point(170, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 19);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Dato";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerAdgangsforsok
            // 
            this.timerAdgangsforsok.Interval = 1000;
            this.timerAdgangsforsok.Tick += new System.EventHandler(this.timerAdgangsforsok_Tick);
            // 
            // timerGuiUpdater
            // 
            this.timerGuiUpdater.Interval = 50;
            this.timerGuiUpdater.Tick += new System.EventHandler(this.timerGuiUpdater_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // timerReset7seg
            // 
            this.timerReset7seg.Interval = 1000;
            this.timerReset7seg.Tick += new System.EventHandler(this.timerReset7seg_Tick);
            // 
            // timerInnloggingOK
            // 
            this.timerInnloggingOK.Interval = 1000;
            this.timerInnloggingOK.Tick += new System.EventHandler(this.timerInnloggingOK_Tick);
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 4;
            this.sevenSegmentArray1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = false;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(6, 19);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(218, 78);
            this.sevenSegmentArray1.TabIndex = 6;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "1337";
            // 
            // Kortleser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(287, 381);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kortleser";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Text = "Kortleser";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Kortleser_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kortleser_FormClosing);
            this.groupKodePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenCLosed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupKodePanel;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.PictureBox pbOpenCLosed;
        private System.Windows.Forms.Button btCode0;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCode2;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCode3;
        private System.Windows.Forms.Button btCode1;
        private System.Windows.Forms.Label kortnummerLabel;
        private System.Windows.Forms.TextBox txtbKortnummer;
        private System.Windows.Forms.Button btScanKort;
        private System.Windows.Forms.PictureBox pbAlarm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TextBox txtbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbKortleserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbKortleserPlassering;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbTcpPort;
        private System.Windows.Forms.TextBox txtbTcpIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbSerialBaud;
        private System.Windows.Forms.ComboBox comboBSerialPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTcpConnect;
        private System.Windows.Forms.Button btSerialConnect;
        private System.Windows.Forms.Label labelLockStatus;
        private System.Windows.Forms.Label labelAlarmStatus;
        private System.Windows.Forms.Label labelDoorStatus;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerAdgangsforsok;
        private System.Windows.Forms.Timer timerGuiUpdater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbPot2;
        private System.Windows.Forms.Label Potensiometer;
        private System.Windows.Forms.CheckBox cbDI1;
        private System.Windows.Forms.CheckBox cbDI2;
        private System.Windows.Forms.CheckBox cbDI3;
        private System.Windows.Forms.CheckBox cbDO0;
        private System.Windows.Forms.CheckBox cbDO1;
        private System.Windows.Forms.CheckBox cbDO2;
        private System.Windows.Forms.CheckBox cbDO3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbDI0;
        private System.Windows.Forms.CheckBox cbDO5;
        private System.Windows.Forms.CheckBox cbDO6;
        private System.Windows.Forms.CheckBox cbDO7;
        private System.Windows.Forms.CheckBox cbDO4;
        private System.Windows.Forms.CheckBox cbDI5;
        private System.Windows.Forms.CheckBox cbDI6;
        private System.Windows.Forms.CheckBox cbDI7;
        private System.Windows.Forms.CheckBox cbDI4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbPot1;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Label labelDoorTimer;
        private System.Windows.Forms.Label labelAlarmType;
        private System.Windows.Forms.Button btTcpDisconnect;
        private System.Windows.Forms.Label labelLockTimer;
        private System.Windows.Forms.Timer timerReset7seg;
        private System.Windows.Forms.Timer timerInnloggingOK;
    }
}

