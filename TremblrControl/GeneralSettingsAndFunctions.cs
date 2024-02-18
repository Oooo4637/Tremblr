using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tremblr.HeartBeatBT;

namespace Tremblr.TremblrControl
{
    public class GeneralSettingsAndFunctions
    {
        public  DateTime latestLowTarget;
        public  DateTime latestHighTarget;
        public  int maxTargetBPM = 120;
        public  int dynamicTargetBPM = 0;
        public  int originalTargetBPM = 0;
        public  int delayMinWaitToStartAboveTarget = 5;
        public  int delayMaxWaitToStopAboveTarget = 12;
        public  int delayMaxWaitToStartLowTarget = 10;
        public  int delayMinWaitToStopLowTarget = 20;
        public  double maxMultiplier = 4;
        public  double multiplier = 1;
        public  double timePunishment = 2;
        public  int delay = 1000;
        public  int latestMax = 0;
        public  int latestMedium = 0;
        public  int mediumIncrease = 0;
        public  int latestMin = 0;
        public  int milkingStartTimeInMinutes = 60;
        public  List<int> bpms = new List<int>();
        public  bool running = false;
        public  bool programRunning = false;
        public  bool confirmedStopped = true;
        public  HeartRateReading latestReading;

        public  DateTime lastCheck;
        public  DateTime runTime = DateTime.Now;


        public  DateTime LatestSpeedUp = new DateTime();

        public  int speedUp = 0;
        public  int suck = 0;

        public  string cd = "cd HackRF tools\"";
        public  string logFileName = "test.txt";

        public  DateTime latestStartStopEvent;
        public List<MilkSettings> milkSettings = new List<MilkSettings>();


        public GeneralSettingsAndFunctions()
        {
            latestMax = dynamicTargetBPM;
            latestMedium = dynamicTargetBPM;
            latestMin = dynamicTargetBPM;
            milkSettings.Add(new MilkSettings(0,0,30,1));
            milkSettings.Add(new MilkSettings(1, 0, 30,1));
            milkSettings.Add(new MilkSettings(0, 0, 10, 0));
        }


        

        public void WriteStats()
        { 

            Commands.WriteLine("Running: " + running, Color.LightBlue);
            Commands.WriteLine("IsLatestMessageError: " + latestReading.IsError, Color.Yellow);
            Commands.WriteLine("Suckup: " + suck, Color.Yellow);
            Commands.WriteLine("Speedup: " + speedUp, Color.Yellow);
            Commands.WriteLine("Speedup date: " + LatestSpeedUp.ToString("HH:mm:ss"), Color.Yellow);
            Commands.WriteLine("BPMs: " + latestReading.BeatsPerMinute + " " + JsonConvert.SerializeObject(bpms), Color.Yellow);
            Commands.WriteLine("MediumBPM: " + latestMedium, Color.Yellow);
            Commands.WriteLine("mediumIncreaseBPM since " + lastCheck.ToString("HH:mm:ss") + " is " + mediumIncrease, Color.Yellow);
            Commands.WriteLine("Max BPM: " + latestMax, Color.Yellow);
            Commands.WriteLine("Multiplier: " + Math.Round(multiplier, 3), Color.Yellow);
            Commands.WriteLine("dynamicTargetBPM: " + dynamicTargetBPM, Color.Yellow);

        }

        public void Config()
        {
            logFileName = DateTime.Now.ToString("yyyyMMdd HHmmss") + ".txt";
            /*
            Commands.WriteLine("Enter default milkingStartTimeInMinutes", Color.Cyan);
            while (milkingStartTimeInMinutes < 1)
            {
                try
                {
                    milkingStartTimeInMinutes = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Commands.WriteLine("You must enter a positive minute value", Color.Red);
                }
            }
            Commands.WriteLine("Enter target BPM", Color.Cyan);
            while (originalTargetBPM < 30)
            {
                try
                {
                    originalTargetBPM = int.Parse(Console.ReadLine());
                    dynamicTargetBPM = originalTargetBPM;
                }
                catch (Exception)
                {
                    Commands.WriteLine("You must enter a positive BPM higher then 30", Color.Red);
                }
            }
            */
            latestMax = dynamicTargetBPM;
            latestMedium = dynamicTargetBPM;
            latestMin = dynamicTargetBPM;
            bpms = new List<int>
            {
                dynamicTargetBPM
            };
            latestReading = new HeartRateReading();
            latestReading.IsError = true;
            latestReading.BeatsPerMinute = dynamicTargetBPM;
            lastCheck = DateTime.Now;
            latestStartStopEvent = DateTime.Now;
            //milkingStartTimeInMinutes = StaticObjects.SettingsAndFunctions.r.Next(milkingStartTimeInMinutes, milkingStartTimeInMinutes * 2);
        }
    }
}
