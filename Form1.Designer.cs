namespace Tremblr
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_LastError = new System.Windows.Forms.Label();
            this.lbl_Running = new System.Windows.Forms.Label();
            this.lbl_MinutesRun = new System.Windows.Forms.Label();
            this.lbl_MaxMinutes = new System.Windows.Forms.Label();
            this.lbl_TargetBPM = new System.Windows.Forms.Label();
            this.lbl_CurrentBPM = new System.Windows.Forms.Label();
            this.lbl_LatestBPMs = new System.Windows.Forms.Label();
            this.lbl_MaxBPM = new System.Windows.Forms.Label();
            this.lbl_MediumBPM = new System.Windows.Forms.Label();
            this.lbl_MediumIncreaseBPM = new System.Windows.Forms.Label();
            this.lbl_LowestBPM = new System.Windows.Forms.Label();
            this.lbl_Multiplier = new System.Windows.Forms.Label();
            this.lbl_MaxMultiplier = new System.Windows.Forms.Label();
            this.lbl_SuckUp = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.lbl_SpeedUpDate = new System.Windows.Forms.Label();
            this.txtBox_LogOutPut = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_MaxRuntime = new System.Windows.Forms.Label();
            this.txtbox_RuntimeBeforeMilking = new System.Windows.Forms.TextBox();
            this.lbl_changeTargetBPM = new System.Windows.Forms.Label();
            this.txtbox_ChangeTargetBPM = new System.Windows.Forms.TextBox();
            this.lbl_ChangeMaxMultiplier = new System.Windows.Forms.Label();
            this.txtbox_ChangeMaxMultiplier = new System.Windows.Forms.TextBox();
            this.lbl_DelayMinWaitToStartAboveTarget = new System.Windows.Forms.Label();
            this.txt_delayMinWaitToStartAboveTarget = new System.Windows.Forms.TextBox();
            this.lbl_delayMaxWaitToStopAboveTarget = new System.Windows.Forms.Label();
            this.txt_delayMaxWaitToStopAboveTarget = new System.Windows.Forms.TextBox();
            this.lbl_delayMaxWaitToStartLowTarget = new System.Windows.Forms.Label();
            this.txt_delayMaxWaitToStartLowTarget = new System.Windows.Forms.TextBox();
            this.lbl_delayMinWaitToStopLowTarget = new System.Windows.Forms.Label();
            this.txt_delayMinWaitToStopLowTarget = new System.Windows.Forms.TextBox();
            this.lbl_milksettings = new System.Windows.Forms.Label();
            this.txt_MilkSettings = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.btn_SpeedUp = new System.Windows.Forms.Button();
            this.btn_SpeedDown = new System.Windows.Forms.Button();
            this.btn_SuckUp = new System.Windows.Forms.Button();
            this.btn_SuckDown = new System.Windows.Forms.Button();
            this.btn_StartMachine = new System.Windows.Forms.Button();
            this.btn_StopMachine = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_LogOutPut, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Controls.Add(this.lbl_LastError);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Running);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MinutesRun);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MaxMinutes);
            this.flowLayoutPanel1.Controls.Add(this.lbl_TargetBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_CurrentBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_LatestBPMs);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MaxBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MediumBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MediumIncreaseBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_LowestBPM);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Multiplier);
            this.flowLayoutPanel1.Controls.Add(this.lbl_MaxMultiplier);
            this.flowLayoutPanel1.Controls.Add(this.lbl_SuckUp);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Speed);
            this.flowLayoutPanel1.Controls.Add(this.lbl_SpeedUpDate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 280);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_LastError
            // 
            this.lbl_LastError.AutoSize = true;
            this.lbl_LastError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LastError.Location = new System.Drawing.Point(3, 0);
            this.lbl_LastError.Name = "lbl_LastError";
            this.lbl_LastError.Size = new System.Drawing.Size(49, 13);
            this.lbl_LastError.TabIndex = 20;
            this.lbl_LastError.Text = "LastError";
            // 
            // lbl_Running
            // 
            this.lbl_Running.AutoSize = true;
            this.lbl_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Running.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Running.Location = new System.Drawing.Point(3, 13);
            this.lbl_Running.Name = "lbl_Running";
            this.lbl_Running.Size = new System.Drawing.Size(129, 20);
            this.lbl_Running.TabIndex = 2;
            this.lbl_Running.Text = "MachineRunning";
            // 
            // lbl_MinutesRun
            // 
            this.lbl_MinutesRun.AutoSize = true;
            this.lbl_MinutesRun.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MinutesRun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MinutesRun.Location = new System.Drawing.Point(3, 33);
            this.lbl_MinutesRun.Name = "lbl_MinutesRun";
            this.lbl_MinutesRun.Size = new System.Drawing.Size(82, 13);
            this.lbl_MinutesRun.TabIndex = 22;
            this.lbl_MinutesRun.Text = "MinutesRunned";
            // 
            // lbl_MaxMinutes
            // 
            this.lbl_MaxMinutes.AutoSize = true;
            this.lbl_MaxMinutes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MaxMinutes.Location = new System.Drawing.Point(3, 46);
            this.lbl_MaxMinutes.Name = "lbl_MaxMinutes";
            this.lbl_MaxMinutes.Size = new System.Drawing.Size(64, 13);
            this.lbl_MaxMinutes.TabIndex = 23;
            this.lbl_MaxMinutes.Text = "MaxMinutes";
            // 
            // lbl_TargetBPM
            // 
            this.lbl_TargetBPM.AutoSize = true;
            this.lbl_TargetBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TargetBPM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_TargetBPM.Location = new System.Drawing.Point(3, 69);
            this.lbl_TargetBPM.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_TargetBPM.Name = "lbl_TargetBPM";
            this.lbl_TargetBPM.Size = new System.Drawing.Size(81, 18);
            this.lbl_TargetBPM.TabIndex = 2;
            this.lbl_TargetBPM.Text = "TargetBpm";
            // 
            // lbl_CurrentBPM
            // 
            this.lbl_CurrentBPM.AutoSize = true;
            this.lbl_CurrentBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentBPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CurrentBPM.Location = new System.Drawing.Point(3, 87);
            this.lbl_CurrentBPM.Name = "lbl_CurrentBPM";
            this.lbl_CurrentBPM.Size = new System.Drawing.Size(96, 20);
            this.lbl_CurrentBPM.TabIndex = 13;
            this.lbl_CurrentBPM.Text = "CurrentBPM";
            // 
            // lbl_LatestBPMs
            // 
            this.lbl_LatestBPMs.AutoSize = true;
            this.lbl_LatestBPMs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LatestBPMs.Location = new System.Drawing.Point(3, 107);
            this.lbl_LatestBPMs.Name = "lbl_LatestBPMs";
            this.lbl_LatestBPMs.Size = new System.Drawing.Size(60, 13);
            this.lbl_LatestBPMs.TabIndex = 4;
            this.lbl_LatestBPMs.Text = "latestBPMs";
            // 
            // lbl_MaxBPM
            // 
            this.lbl_MaxBPM.AutoSize = true;
            this.lbl_MaxBPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MaxBPM.Location = new System.Drawing.Point(3, 120);
            this.lbl_MaxBPM.Name = "lbl_MaxBPM";
            this.lbl_MaxBPM.Size = new System.Drawing.Size(53, 13);
            this.lbl_MaxBPM.TabIndex = 5;
            this.lbl_MaxBPM.Text = "Max BPM";
            // 
            // lbl_MediumBPM
            // 
            this.lbl_MediumBPM.AutoSize = true;
            this.lbl_MediumBPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MediumBPM.Location = new System.Drawing.Point(3, 133);
            this.lbl_MediumBPM.Name = "lbl_MediumBPM";
            this.lbl_MediumBPM.Size = new System.Drawing.Size(67, 13);
            this.lbl_MediumBPM.TabIndex = 6;
            this.lbl_MediumBPM.Text = "MediumBPM";
            // 
            // lbl_MediumIncreaseBPM
            // 
            this.lbl_MediumIncreaseBPM.AutoSize = true;
            this.lbl_MediumIncreaseBPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MediumIncreaseBPM.Location = new System.Drawing.Point(3, 146);
            this.lbl_MediumIncreaseBPM.Name = "lbl_MediumIncreaseBPM";
            this.lbl_MediumIncreaseBPM.Size = new System.Drawing.Size(107, 13);
            this.lbl_MediumIncreaseBPM.TabIndex = 7;
            this.lbl_MediumIncreaseBPM.Text = "mediumIncreaseBPM";
            // 
            // lbl_LowestBPM
            // 
            this.lbl_LowestBPM.AutoSize = true;
            this.lbl_LowestBPM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LowestBPM.Location = new System.Drawing.Point(3, 159);
            this.lbl_LowestBPM.Name = "lbl_LowestBPM";
            this.lbl_LowestBPM.Size = new System.Drawing.Size(64, 13);
            this.lbl_LowestBPM.TabIndex = 8;
            this.lbl_LowestBPM.Text = "LowestBPM";
            // 
            // lbl_Multiplier
            // 
            this.lbl_Multiplier.AutoSize = true;
            this.lbl_Multiplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Multiplier.Location = new System.Drawing.Point(3, 182);
            this.lbl_Multiplier.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_Multiplier.Name = "lbl_Multiplier";
            this.lbl_Multiplier.Size = new System.Drawing.Size(48, 13);
            this.lbl_Multiplier.TabIndex = 14;
            this.lbl_Multiplier.Text = "Multiplier";
            // 
            // lbl_MaxMultiplier
            // 
            this.lbl_MaxMultiplier.AutoSize = true;
            this.lbl_MaxMultiplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MaxMultiplier.Location = new System.Drawing.Point(3, 195);
            this.lbl_MaxMultiplier.Name = "lbl_MaxMultiplier";
            this.lbl_MaxMultiplier.Size = new System.Drawing.Size(68, 13);
            this.lbl_MaxMultiplier.TabIndex = 21;
            this.lbl_MaxMultiplier.Text = "MaxMultiplier";
            // 
            // lbl_SuckUp
            // 
            this.lbl_SuckUp.AutoSize = true;
            this.lbl_SuckUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_SuckUp.Location = new System.Drawing.Point(3, 208);
            this.lbl_SuckUp.Name = "lbl_SuckUp";
            this.lbl_SuckUp.Size = new System.Drawing.Size(44, 13);
            this.lbl_SuckUp.TabIndex = 10;
            this.lbl_SuckUp.Text = "Suckup";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Speed.Location = new System.Drawing.Point(3, 221);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(38, 13);
            this.lbl_Speed.TabIndex = 11;
            this.lbl_Speed.Text = "Speed";
            // 
            // lbl_SpeedUpDate
            // 
            this.lbl_SpeedUpDate.AutoSize = true;
            this.lbl_SpeedUpDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_SpeedUpDate.Location = new System.Drawing.Point(3, 234);
            this.lbl_SpeedUpDate.Name = "lbl_SpeedUpDate";
            this.lbl_SpeedUpDate.Size = new System.Drawing.Size(75, 13);
            this.lbl_SpeedUpDate.TabIndex = 19;
            this.lbl_SpeedUpDate.Text = "SpeedUpDate";
            // 
            // txtBox_LogOutPut
            // 
            this.txtBox_LogOutPut.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_LogOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_LogOutPut.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBox_LogOutPut.Location = new System.Drawing.Point(3, 289);
            this.txtBox_LogOutPut.Name = "txtBox_LogOutPut";
            this.txtBox_LogOutPut.Size = new System.Drawing.Size(412, 281);
            this.txtBox_LogOutPut.TabIndex = 1;
            this.txtBox_LogOutPut.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lbl_MaxRuntime);
            this.flowLayoutPanel2.Controls.Add(this.txtbox_RuntimeBeforeMilking);
            this.flowLayoutPanel2.Controls.Add(this.lbl_changeTargetBPM);
            this.flowLayoutPanel2.Controls.Add(this.txtbox_ChangeTargetBPM);
            this.flowLayoutPanel2.Controls.Add(this.lbl_ChangeMaxMultiplier);
            this.flowLayoutPanel2.Controls.Add(this.txtbox_ChangeMaxMultiplier);
            this.flowLayoutPanel2.Controls.Add(this.lbl_DelayMinWaitToStartAboveTarget);
            this.flowLayoutPanel2.Controls.Add(this.txt_delayMinWaitToStartAboveTarget);
            this.flowLayoutPanel2.Controls.Add(this.lbl_delayMaxWaitToStopAboveTarget);
            this.flowLayoutPanel2.Controls.Add(this.txt_delayMaxWaitToStopAboveTarget);
            this.flowLayoutPanel2.Controls.Add(this.lbl_delayMaxWaitToStartLowTarget);
            this.flowLayoutPanel2.Controls.Add(this.txt_delayMaxWaitToStartLowTarget);
            this.flowLayoutPanel2.Controls.Add(this.lbl_delayMinWaitToStopLowTarget);
            this.flowLayoutPanel2.Controls.Add(this.txt_delayMinWaitToStopLowTarget);
            this.flowLayoutPanel2.Controls.Add(this.lbl_milksettings);
            this.flowLayoutPanel2.Controls.Add(this.txt_MilkSettings);
            this.flowLayoutPanel2.Controls.Add(this.btn_save);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(421, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(412, 280);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lbl_MaxRuntime
            // 
            this.lbl_MaxRuntime.AutoSize = true;
            this.lbl_MaxRuntime.Location = new System.Drawing.Point(3, 0);
            this.lbl_MaxRuntime.Name = "lbl_MaxRuntime";
            this.lbl_MaxRuntime.Size = new System.Drawing.Size(114, 13);
            this.lbl_MaxRuntime.TabIndex = 24;
            this.lbl_MaxRuntime.Text = "RunTimeBeforeMilking";
            // 
            // txtbox_RuntimeBeforeMilking
            // 
            this.txtbox_RuntimeBeforeMilking.Location = new System.Drawing.Point(3, 16);
            this.txtbox_RuntimeBeforeMilking.Name = "txtbox_RuntimeBeforeMilking";
            this.txtbox_RuntimeBeforeMilking.Size = new System.Drawing.Size(100, 20);
            this.txtbox_RuntimeBeforeMilking.TabIndex = 25;
            this.txtbox_RuntimeBeforeMilking.Text = "40";
            // 
            // lbl_changeTargetBPM
            // 
            this.lbl_changeTargetBPM.AutoSize = true;
            this.lbl_changeTargetBPM.Location = new System.Drawing.Point(3, 49);
            this.lbl_changeTargetBPM.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_changeTargetBPM.Name = "lbl_changeTargetBPM";
            this.lbl_changeTargetBPM.Size = new System.Drawing.Size(98, 13);
            this.lbl_changeTargetBPM.TabIndex = 0;
            this.lbl_changeTargetBPM.Text = "ChangeTargetBPM";
            // 
            // txtbox_ChangeTargetBPM
            // 
            this.txtbox_ChangeTargetBPM.Location = new System.Drawing.Point(3, 65);
            this.txtbox_ChangeTargetBPM.Name = "txtbox_ChangeTargetBPM";
            this.txtbox_ChangeTargetBPM.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ChangeTargetBPM.TabIndex = 1;
            this.txtbox_ChangeTargetBPM.Text = "75";
            // 
            // lbl_ChangeMaxMultiplier
            // 
            this.lbl_ChangeMaxMultiplier.AutoSize = true;
            this.lbl_ChangeMaxMultiplier.Location = new System.Drawing.Point(3, 98);
            this.lbl_ChangeMaxMultiplier.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_ChangeMaxMultiplier.Name = "lbl_ChangeMaxMultiplier";
            this.lbl_ChangeMaxMultiplier.Size = new System.Drawing.Size(105, 13);
            this.lbl_ChangeMaxMultiplier.TabIndex = 2;
            this.lbl_ChangeMaxMultiplier.Text = "ChangeMaxMultiplier";
            // 
            // txtbox_ChangeMaxMultiplier
            // 
            this.txtbox_ChangeMaxMultiplier.Location = new System.Drawing.Point(3, 114);
            this.txtbox_ChangeMaxMultiplier.Name = "txtbox_ChangeMaxMultiplier";
            this.txtbox_ChangeMaxMultiplier.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ChangeMaxMultiplier.TabIndex = 3;
            this.txtbox_ChangeMaxMultiplier.Text = "2";
            // 
            // lbl_DelayMinWaitToStartAboveTarget
            // 
            this.lbl_DelayMinWaitToStartAboveTarget.AutoSize = true;
            this.lbl_DelayMinWaitToStartAboveTarget.Location = new System.Drawing.Point(3, 147);
            this.lbl_DelayMinWaitToStartAboveTarget.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_DelayMinWaitToStartAboveTarget.Name = "lbl_DelayMinWaitToStartAboveTarget";
            this.lbl_DelayMinWaitToStartAboveTarget.Size = new System.Drawing.Size(170, 13);
            this.lbl_DelayMinWaitToStartAboveTarget.TabIndex = 26;
            this.lbl_DelayMinWaitToStartAboveTarget.Text = "DelayMinWaitToStartAboveTarget";
            this.lbl_DelayMinWaitToStartAboveTarget.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_delayMinWaitToStartAboveTarget
            // 
            this.txt_delayMinWaitToStartAboveTarget.Location = new System.Drawing.Point(3, 163);
            this.txt_delayMinWaitToStartAboveTarget.Name = "txt_delayMinWaitToStartAboveTarget";
            this.txt_delayMinWaitToStartAboveTarget.Size = new System.Drawing.Size(100, 20);
            this.txt_delayMinWaitToStartAboveTarget.TabIndex = 27;
            this.txt_delayMinWaitToStartAboveTarget.Text = "3";
            // 
            // lbl_delayMaxWaitToStopAboveTarget
            // 
            this.lbl_delayMaxWaitToStopAboveTarget.AutoSize = true;
            this.lbl_delayMaxWaitToStopAboveTarget.Location = new System.Drawing.Point(3, 196);
            this.lbl_delayMaxWaitToStopAboveTarget.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_delayMaxWaitToStopAboveTarget.Name = "lbl_delayMaxWaitToStopAboveTarget";
            this.lbl_delayMaxWaitToStopAboveTarget.Size = new System.Drawing.Size(173, 13);
            this.lbl_delayMaxWaitToStopAboveTarget.TabIndex = 28;
            this.lbl_delayMaxWaitToStopAboveTarget.Text = "DelayMaxWaitToStopAboveTarget";
            // 
            // txt_delayMaxWaitToStopAboveTarget
            // 
            this.txt_delayMaxWaitToStopAboveTarget.Location = new System.Drawing.Point(3, 212);
            this.txt_delayMaxWaitToStopAboveTarget.Name = "txt_delayMaxWaitToStopAboveTarget";
            this.txt_delayMaxWaitToStopAboveTarget.Size = new System.Drawing.Size(100, 20);
            this.txt_delayMaxWaitToStopAboveTarget.TabIndex = 29;
            this.txt_delayMaxWaitToStopAboveTarget.Text = "6";
            // 
            // lbl_delayMaxWaitToStartLowTarget
            // 
            this.lbl_delayMaxWaitToStartLowTarget.AutoSize = true;
            this.lbl_delayMaxWaitToStartLowTarget.Location = new System.Drawing.Point(3, 235);
            this.lbl_delayMaxWaitToStartLowTarget.Name = "lbl_delayMaxWaitToStartLowTarget";
            this.lbl_delayMaxWaitToStartLowTarget.Size = new System.Drawing.Size(162, 13);
            this.lbl_delayMaxWaitToStartLowTarget.TabIndex = 30;
            this.lbl_delayMaxWaitToStartLowTarget.Text = "DelayMaxWaitToStartLowTarget";
            // 
            // txt_delayMaxWaitToStartLowTarget
            // 
            this.txt_delayMaxWaitToStartLowTarget.Location = new System.Drawing.Point(3, 251);
            this.txt_delayMaxWaitToStartLowTarget.Name = "txt_delayMaxWaitToStartLowTarget";
            this.txt_delayMaxWaitToStartLowTarget.Size = new System.Drawing.Size(100, 20);
            this.txt_delayMaxWaitToStartLowTarget.TabIndex = 31;
            this.txt_delayMaxWaitToStartLowTarget.Text = "5";
            // 
            // lbl_delayMinWaitToStopLowTarget
            // 
            this.lbl_delayMinWaitToStopLowTarget.AutoSize = true;
            this.lbl_delayMinWaitToStopLowTarget.Location = new System.Drawing.Point(182, 10);
            this.lbl_delayMinWaitToStopLowTarget.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_delayMinWaitToStopLowTarget.Name = "lbl_delayMinWaitToStopLowTarget";
            this.lbl_delayMinWaitToStopLowTarget.Size = new System.Drawing.Size(159, 13);
            this.lbl_delayMinWaitToStopLowTarget.TabIndex = 32;
            this.lbl_delayMinWaitToStopLowTarget.Text = "DelayMinWaitToStopLowTarget";
            // 
            // txt_delayMinWaitToStopLowTarget
            // 
            this.txt_delayMinWaitToStopLowTarget.Location = new System.Drawing.Point(182, 26);
            this.txt_delayMinWaitToStopLowTarget.Name = "txt_delayMinWaitToStopLowTarget";
            this.txt_delayMinWaitToStopLowTarget.Size = new System.Drawing.Size(100, 20);
            this.txt_delayMinWaitToStopLowTarget.TabIndex = 33;
            this.txt_delayMinWaitToStopLowTarget.Text = "3";
            // 
            // lbl_milksettings
            // 
            this.lbl_milksettings.AutoSize = true;
            this.lbl_milksettings.Location = new System.Drawing.Point(182, 59);
            this.lbl_milksettings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_milksettings.Name = "lbl_milksettings";
            this.lbl_milksettings.Size = new System.Drawing.Size(64, 13);
            this.lbl_milksettings.TabIndex = 34;
            this.lbl_milksettings.Text = "MilkSettings";
            // 
            // txt_MilkSettings
            // 
            this.txt_MilkSettings.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_MilkSettings.Location = new System.Drawing.Point(182, 75);
            this.txt_MilkSettings.Name = "txt_MilkSettings";
            this.txt_MilkSettings.Size = new System.Drawing.Size(221, 172);
            this.txt_MilkSettings.TabIndex = 35;
            this.txt_MilkSettings.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(182, 253);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.save_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.btn_StartStop);
            this.flowLayoutPanel3.Controls.Add(this.btn_SpeedUp);
            this.flowLayoutPanel3.Controls.Add(this.btn_SpeedDown);
            this.flowLayoutPanel3.Controls.Add(this.btn_SuckUp);
            this.flowLayoutPanel3.Controls.Add(this.btn_SuckDown);
            this.flowLayoutPanel3.Controls.Add(this.btn_StartMachine);
            this.flowLayoutPanel3.Controls.Add(this.btn_StopMachine);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(421, 289);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(412, 281);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.AutoSize = true;
            this.btn_StartStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StartStop.Location = new System.Drawing.Point(3, 3);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(100, 23);
            this.btn_StartStop.TabIndex = 6;
            this.btn_StartStop.Text = "Enable Automatic";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // btn_SpeedUp
            // 
            this.btn_SpeedUp.Location = new System.Drawing.Point(109, 3);
            this.btn_SpeedUp.Name = "btn_SpeedUp";
            this.btn_SpeedUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SpeedUp.TabIndex = 7;
            this.btn_SpeedUp.Text = "SpeedUp";
            this.btn_SpeedUp.UseVisualStyleBackColor = true;
            this.btn_SpeedUp.Click += new System.EventHandler(this.btn_SpeedUp_Click);
            // 
            // btn_SpeedDown
            // 
            this.btn_SpeedDown.Location = new System.Drawing.Point(190, 3);
            this.btn_SpeedDown.Name = "btn_SpeedDown";
            this.btn_SpeedDown.Size = new System.Drawing.Size(75, 23);
            this.btn_SpeedDown.TabIndex = 8;
            this.btn_SpeedDown.Text = "SpeedDown";
            this.btn_SpeedDown.UseVisualStyleBackColor = true;
            this.btn_SpeedDown.Click += new System.EventHandler(this.btn_SpeedDown_Click);
            // 
            // btn_SuckUp
            // 
            this.btn_SuckUp.Location = new System.Drawing.Point(271, 3);
            this.btn_SuckUp.Name = "btn_SuckUp";
            this.btn_SuckUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SuckUp.TabIndex = 9;
            this.btn_SuckUp.Text = "SuckUp";
            this.btn_SuckUp.UseVisualStyleBackColor = true;
            this.btn_SuckUp.Click += new System.EventHandler(this.btn_SuckUp_Click);
            // 
            // btn_SuckDown
            // 
            this.btn_SuckDown.Location = new System.Drawing.Point(3, 32);
            this.btn_SuckDown.Name = "btn_SuckDown";
            this.btn_SuckDown.Size = new System.Drawing.Size(75, 23);
            this.btn_SuckDown.TabIndex = 10;
            this.btn_SuckDown.Text = "SuckDown";
            this.btn_SuckDown.UseVisualStyleBackColor = true;
            this.btn_SuckDown.Click += new System.EventHandler(this.btn_SuckDown_Click);
            // 
            // btn_StartMachine
            // 
            this.btn_StartMachine.Location = new System.Drawing.Point(84, 32);
            this.btn_StartMachine.Name = "btn_StartMachine";
            this.btn_StartMachine.Size = new System.Drawing.Size(91, 23);
            this.btn_StartMachine.TabIndex = 11;
            this.btn_StartMachine.Text = "StartMachine";
            this.btn_StartMachine.UseVisualStyleBackColor = true;
            this.btn_StartMachine.Click += new System.EventHandler(this.btn_StartMachine_Click);
            // 
            // btn_StopMachine
            // 
            this.btn_StopMachine.Location = new System.Drawing.Point(181, 32);
            this.btn_StopMachine.Name = "btn_StopMachine";
            this.btn_StopMachine.Size = new System.Drawing.Size(84, 23);
            this.btn_StopMachine.TabIndex = 12;
            this.btn_StopMachine.Text = "StopMachine";
            this.btn_StopMachine.UseVisualStyleBackColor = true;
            this.btn_StopMachine.Click += new System.EventHandler(this.btn_StopMachine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tremblr Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
       // private System.Windows.Forms.Label lbl_CurrentValues;
        private System.Windows.Forms.Label lbl_Running;
        private System.Windows.Forms.Label lbl_CurrentBPM;
        private System.Windows.Forms.Label lbl_LatestBPMs;
        private System.Windows.Forms.Label lbl_MaxBPM;
        private System.Windows.Forms.Label lbl_MediumBPM;
        private System.Windows.Forms.Label lbl_MediumIncreaseBPM;
        private System.Windows.Forms.Label lbl_LowestBPM;
        private System.Windows.Forms.Label lbl_TargetBPM;
        private System.Windows.Forms.Label lbl_SuckUp;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label lbl_Multiplier;
        private System.Windows.Forms.Label lbl_SpeedUpDate;
        private System.Windows.Forms.Label lbl_LastError;
        private System.Windows.Forms.RichTextBox txtBox_LogOutPut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_changeTargetBPM;
        private System.Windows.Forms.Label lbl_MaxMultiplier;
        private System.Windows.Forms.TextBox txtbox_ChangeTargetBPM;
        private System.Windows.Forms.Label lbl_ChangeMaxMultiplier;
        private System.Windows.Forms.TextBox txtbox_ChangeMaxMultiplier;
        private System.Windows.Forms.Label lbl_MinutesRun;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.Button btn_SpeedUp;
        private System.Windows.Forms.Label lbl_MaxMinutes;
        private System.Windows.Forms.Label lbl_MaxRuntime;
        private System.Windows.Forms.TextBox txtbox_RuntimeBeforeMilking;
        private System.Windows.Forms.Button btn_SpeedDown;
        private System.Windows.Forms.Button btn_SuckUp;
        private System.Windows.Forms.Button btn_SuckDown;
        private System.Windows.Forms.Button btn_StartMachine;
        private System.Windows.Forms.Button btn_StopMachine;
        private System.Windows.Forms.Label lbl_DelayMinWaitToStartAboveTarget;
        private System.Windows.Forms.TextBox txt_delayMinWaitToStartAboveTarget;
        private System.Windows.Forms.Label lbl_delayMaxWaitToStopAboveTarget;
        private System.Windows.Forms.TextBox txt_delayMaxWaitToStopAboveTarget;
        private System.Windows.Forms.Label lbl_delayMaxWaitToStartLowTarget;
        private System.Windows.Forms.TextBox txt_delayMaxWaitToStartLowTarget;
        private System.Windows.Forms.Label lbl_delayMinWaitToStopLowTarget;
        private System.Windows.Forms.TextBox txt_delayMinWaitToStopLowTarget;
        private System.Windows.Forms.Label lbl_milksettings;
        private System.Windows.Forms.RichTextBox txt_MilkSettings;
    }
}

