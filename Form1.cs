using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tremblr.HeartBeatBT;
using Tremblr.TremblrControl;

namespace Tremblr
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StaticObjects.form1 = this;
            txt_MilkSettings.Text = JsonConvert.SerializeObject(StaticObjects.SettingsAndFunctions.milkSettings,Formatting.Indented);
            save_Click(this, EventArgs.Empty);

        }

        public void UpdateBPM(HeartRateReading reading)
        {
            if (lbl_LastError.InvokeRequired)
            {
                lbl_LastError.Invoke(new Action<HeartRateReading>(UpdateBPM), new object[] { reading });
                return;
            }
            try
            {
                if (StaticObjects.SettingsAndFunctions.running)
                {
                    lbl_Running.ForeColor = Color.Green;
                    lbl_Running.Text = "Machine is going";
                }
                else
                {
                    lbl_Running.ForeColor = Color.Orange;
                    lbl_Running.Text = "Machine has stopped";
                }

                if (reading.IsError)
                {
                    lbl_LastError.Visible = true;
                    lbl_LastError.ForeColor = Color.Red;
                    lbl_LastError.Text = "Current Error is: " + reading.Error;
                }
                else
                {
                    lbl_LastError.Visible = false;
                    if (StaticObjects.SettingsAndFunctions.dynamicTargetBPM < reading.BeatsPerMinute)
                    {
                        lbl_CurrentBPM.ForeColor = Color.Red;
                        lbl_CurrentBPM.Text = "Current BPM: " + reading.BeatsPerMinute + " (higher then target)";
                    }
                    else
                    {
                        lbl_CurrentBPM.ForeColor = Color.Green;
                        lbl_CurrentBPM.Text = "Current BPM: " + reading.BeatsPerMinute + " (lower or equal target)";
                    }
                }
            }
            catch(Exception e) { Addtext(""+e,Color.Red); }
            

            
        }

        public void UpdateStats()
        {
            try
            {
                if (lbl_LastError.InvokeRequired)
                {
                    lbl_LastError.Invoke(new Action(UpdateStats));
                    return;
                }

                lbl_LatestBPMs.Text = JsonConvert.SerializeObject(StaticObjects.SettingsAndFunctions.bpms);
                lbl_LowestBPM.Text = "Lowest BPM: " + StaticObjects.SettingsAndFunctions.latestMin;
                lbl_MaxBPM.Text = "Max BPM: " + StaticObjects.SettingsAndFunctions.latestMax;
                lbl_MediumBPM.Text = "Medium BPM: " + StaticObjects.SettingsAndFunctions.latestMedium;
                lbl_MediumIncreaseBPM.Text = "Medium increase BPM: " + StaticObjects.SettingsAndFunctions.mediumIncrease;
                lbl_Speed.Text = "Speed: " + StaticObjects.SettingsAndFunctions.speedUp;
                lbl_SpeedUpDate.Text = "Latest Speedup: " + StaticObjects.SettingsAndFunctions.LatestSpeedUp.ToString("HH:mm:ss");
                lbl_SuckUp.Text = "Suck up: " + StaticObjects.SettingsAndFunctions.suck;
                lbl_TargetBPM.Text = "Target BPM: " + StaticObjects.SettingsAndFunctions.dynamicTargetBPM;
                lbl_MaxMultiplier.Text = "Max Multiplier: " + StaticObjects.SettingsAndFunctions.maxMultiplier;
                if (StaticObjects.SettingsAndFunctions.programRunning)
                {

                    lbl_Multiplier.Text = "Current Multiplier: " + Math.Round(StaticObjects.SettingsAndFunctions.multiplier, 2);
                    lbl_MinutesRun.Text = "Run Minutes: " + Math.Round(DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes, 1);
                }
                lbl_MaxMinutes.Text = "Max edging minutes: " + StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes;
            }
            catch (Exception ex) { }
            
        }
        public void Addtext(string text, Color color , bool addNewLine=true)
        {
            if (txtBox_LogOutPut.InvokeRequired)
            {
                txtBox_LogOutPut.Invoke(new Action<string, Color, bool>(Addtext), new object[] { text, color, addNewLine });
                return;
            }
            txtBox_LogOutPut.SuspendLayout();
            txtBox_LogOutPut.SelectionColor = color;
            txtBox_LogOutPut.AppendText(addNewLine
                ? $"{text}{Environment.NewLine}"
                : text);
            txtBox_LogOutPut.ScrollToCaret();
            txtBox_LogOutPut.ResumeLayout();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtbox_RuntimeBeforeMilking.Text, out int i))
                {
                    StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes = i;
                }
                if (int.TryParse(txtbox_ChangeTargetBPM.Text, out int i2))
                {
                    StaticObjects.SettingsAndFunctions.dynamicTargetBPM = i2;
                    StaticObjects.SettingsAndFunctions.originalTargetBPM = i2;
                }
                if (int.TryParse(txtbox_ChangeMaxMultiplier.Text, out int i3))
                {
                    StaticObjects.SettingsAndFunctions.maxMultiplier = i3;
                }
                if (int.TryParse(txt_delayMaxWaitToStartLowTarget.Text, out int i4))
                {
                    StaticObjects.SettingsAndFunctions.delayMaxWaitToStartLowTarget = i4;
                }
                if (int.TryParse(txt_delayMaxWaitToStopAboveTarget.Text, out int i5))
                {
                    StaticObjects.SettingsAndFunctions.delayMaxWaitToStopAboveTarget = i5;
                }
                if (int.TryParse(txt_delayMinWaitToStartAboveTarget.Text, out int i6))
                {
                    StaticObjects.SettingsAndFunctions.delayMinWaitToStartAboveTarget = i6;
                }
                if (int.TryParse(txt_delayMinWaitToStopLowTarget.Text, out int i7))
                {
                    StaticObjects.SettingsAndFunctions.delayMinWaitToStopLowTarget = i7;
                }

                StaticObjects.SettingsAndFunctions.milkSettings = JsonConvert.DeserializeObject<List<MilkSettings>>(txt_MilkSettings.Text);
                Addtext("Successfully saved settings", Color.Green);
            }
            catch(Exception er) { Addtext("Failed to Save\n" + er, Color.Red); }
            

            UpdateStats();
        }

        Thread programA = new Thread(FControl.StartProgram);
        async private void btn_StartStop_Click(object sender, EventArgs e)
        {
            btn_StartStop.Text = "Wait...";
            btn_StartStop.BackColor = Color.Yellow;
            btn_StartStop.Enabled = false;
            if (StaticObjects.SettingsAndFunctions.programRunning)
            {
                FControl.StopProgram();
                btn_StartStop.Text = "Enable Automatic (Program is stopped)";
                btn_StartStop.BackColor = Color.Red;
            }
            else
            {
                if (int.TryParse(txtbox_RuntimeBeforeMilking.Text, out int i))
                {
                    StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes = i;
                }
                if (int.TryParse(txtbox_ChangeTargetBPM.Text, out i))
                {
                    StaticObjects.SettingsAndFunctions.dynamicTargetBPM = i;
                    StaticObjects.SettingsAndFunctions.originalTargetBPM = i;
                }
                if (int.TryParse(txtbox_ChangeMaxMultiplier.Text, out i))
                {
                    StaticObjects.SettingsAndFunctions.maxMultiplier = i;
                }
                StaticObjects.SettingsAndFunctions.Config();


                Thread a = new Thread(FControl.StartProgram);
                a.Start();
                StaticObjects.SettingsAndFunctions.programRunning = true;
                btn_StartStop.Text = "Disable Automatic (Its running)";
                btn_StartStop.BackColor = Color.Green;
            }
            btn_StartStop.Enabled = true;
        }

       

        private async void btn_StartMachine_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.StartMachine("User started machine");
            EnableAllButtons();
            UpdateStats();
        }

        private async void btn_StopMachine_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.StopMachine("User Stopped machine");
            EnableAllButtons();
            UpdateStats();
        }

        private async void btn_SpeedUp_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.SetSpeed(StaticObjects.SettingsAndFunctions.speedUp+1);
            EnableAllButtons();
        }
        private async void btn_SpeedDown_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.SetSpeed(StaticObjects.SettingsAndFunctions.speedUp-1);
            EnableAllButtons();
        }
        private async void btn_SuckUp_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.SetSuck(StaticObjects.SettingsAndFunctions.suck+1);
            EnableAllButtons();
        }
        private async void btn_SuckDown_Click(object sender, EventArgs e)
        {
            DisableAllButtons();
            await Commands.SetSuck(StaticObjects.SettingsAndFunctions.suck-1);

            EnableAllButtons();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisableAllButtons()
        {
            btn_SpeedDown.Enabled = false;
            btn_SpeedUp.Enabled = false;
            btn_SuckUp.Enabled = false;
            btn_SuckDown.Enabled = false;
            btn_StartMachine.Enabled = false;
            btn_StopMachine.Enabled = false;
            btn_StartStop.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btn_SpeedDown.Enabled = true;
            btn_SpeedUp.Enabled = true;
            btn_SuckUp.Enabled = true;
            btn_SuckDown.Enabled = true;
            btn_StartMachine.Enabled = true;
            btn_StopMachine.Enabled = true;
            btn_StartStop.Enabled = true;
        }
    }
}
