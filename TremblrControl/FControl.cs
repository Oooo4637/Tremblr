using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

/*
static AudioGenerator audio = new AudioGenerator();

AudioGenerator.PrintOutputDevices();
StaticObjects.SettingsAndFunctions.WriteLine("Select what device to use", Color.Cyan);
int device = int.Parse(Console.ReadLine());
audio = new AudioGenerator(device,44100,2);
audio.Program2();
*/


namespace Tremblr.TremblrControl
{
    public static class FControl
    {
        static CancellationTokenSource cancelToken = new CancellationTokenSource();

        static async private Task HandleAboveTarget()
        {

            if (StaticObjects.SettingsAndFunctions.running)
            {
                if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes > StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes / 3)
                {
                    await Commands.SetSuck(1);
                    await Commands.SetSpeed(0);
                }
                else
                {
                    await Commands.SetSuck(0);
                    await Commands.SetSpeed(0);
                }

                if (StaticObjects.SettingsAndFunctions.mediumIncrease > 0)
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > ((StaticObjects.SettingsAndFunctions.delayMaxWaitToStopAboveTarget - StaticObjects.SettingsAndFunctions.mediumIncrease) * Math.Pow((double)StaticObjects.SettingsAndFunctions.dynamicTargetBPM / StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute,StaticObjects.SettingsAndFunctions.multiplier) * (1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes*StaticObjects.SettingsAndFunctions.timePunishment)))))
                    {
                        await Commands.StopMachine("BPM is above target, bpm is increasing, stopping");
                    }
                }
                else
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > StaticObjects.SettingsAndFunctions.delayMaxWaitToStopAboveTarget * Math.Pow((double)StaticObjects.SettingsAndFunctions.dynamicTargetBPM / StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute, StaticObjects.SettingsAndFunctions.multiplier) * (1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes*StaticObjects.SettingsAndFunctions.timePunishment))))
                    {
                        await Commands.StopMachine("BPM is above target, bpm is decreasing, stopping");
                    }
                }
            }
            else
            {
                if(StaticObjects.SettingsAndFunctions.mediumIncrease > 0)
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > ((StaticObjects.SettingsAndFunctions.delayMinWaitToStartAboveTarget + StaticObjects.SettingsAndFunctions.mediumIncrease) + (StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute-StaticObjects.SettingsAndFunctions.dynamicTargetBPM))*(1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes * StaticObjects.SettingsAndFunctions.timePunishment))))
                    {
                        await Commands.StartMachine("bpm is high but latest event is more then " + StaticObjects.SettingsAndFunctions.delayMinWaitToStartAboveTarget + " seconds");
                    }
                }
                else
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > (StaticObjects.SettingsAndFunctions.delayMinWaitToStartAboveTarget + (StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute - StaticObjects.SettingsAndFunctions.dynamicTargetBPM))*(1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes * StaticObjects.SettingsAndFunctions.timePunishment))))
                    {
                        await Commands.StartMachine("bpm is high but latest event is more then " + StaticObjects.SettingsAndFunctions.delayMinWaitToStartAboveTarget + " seconds");
                    }
                }
            }
        }

        static async private Task HandleBelowTarget()
        {
            if (StaticObjects.SettingsAndFunctions.running)
            {
                if (StaticObjects.SettingsAndFunctions.mediumIncrease > 0)
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > ((StaticObjects.SettingsAndFunctions.delayMinWaitToStopLowTarget - (StaticObjects.SettingsAndFunctions.mediumIncrease)) + (StaticObjects.SettingsAndFunctions.dynamicTargetBPM - StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute))* (1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes * StaticObjects.SettingsAndFunctions.timePunishment))))
                    {
                        await Commands.StopMachine("BPM is below target but it has been less then "+ StaticObjects.SettingsAndFunctions.delayMinWaitToStopLowTarget+" seconds");
                    }
                }
                else
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > (StaticObjects.SettingsAndFunctions.delayMinWaitToStopLowTarget + (StaticObjects.SettingsAndFunctions.dynamicTargetBPM - StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute))* (1 - (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes / (StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes * StaticObjects.SettingsAndFunctions.timePunishment))))
                    {
                        await Commands.StopMachine("BPM is below target but it has been less then " + StaticObjects.SettingsAndFunctions.delayMinWaitToStopLowTarget + " seconds");
                    }
                }
               
                if ((StaticObjects.SettingsAndFunctions.dynamicTargetBPM - StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute) < 12)
                {
                    await Commands.SetSpeed(0);
                    await Commands.SetSuck(1);
                }
                else
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.LatestSpeedUp).TotalMinutes > 5)
                    {
                        await Commands.SetSpeed(2);
                        await Commands.SetSuck(2);
                    }
                    else
                    {
                        await Commands.SetSpeed(1);
                        await Commands.SetSuck(1);
                    }
                }
            }

            else
            {
                if(StaticObjects.SettingsAndFunctions.mediumIncrease > 0)
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > (StaticObjects.SettingsAndFunctions.delayMaxWaitToStartLowTarget + (StaticObjects.SettingsAndFunctions.mediumIncrease)) - (StaticObjects.SettingsAndFunctions.dynamicTargetBPM-StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute) )
                    {
                        await Commands.StartMachine("BPM is below target and it has been more then " + StaticObjects.SettingsAndFunctions.delayMaxWaitToStartLowTarget + " seconds");
                    }
                }
                else
                {
                    if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestStartStopEvent).TotalSeconds > (StaticObjects.SettingsAndFunctions.delayMaxWaitToStartLowTarget - ( StaticObjects.SettingsAndFunctions.dynamicTargetBPM - StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute)))
                    {
                        await Commands.StartMachine("BPM is below target and it has been more then " + StaticObjects.SettingsAndFunctions.delayMaxWaitToStartLowTarget + " seconds");
                    }
                }
            }
        }

        static async public void StopProgram()
        {
            StaticObjects.SettingsAndFunctions.programRunning = false;
            cancelToken.Cancel();
            while (!StaticObjects.SettingsAndFunctions.confirmedStopped)
            {
                await Task.Delay(1000);
            }
        }

        static async public void StartProgram()
        {
            cancelToken = new CancellationTokenSource();
            StaticObjects.SettingsAndFunctions.Config();
            StaticObjects.SettingsAndFunctions.confirmedStopped = false;
            //Commands.WriteLine("Enter any key to start program",Color.Green);
            //Console.ReadKey();
            StaticObjects.SettingsAndFunctions.runTime = DateTime.Now;
            StaticObjects.SettingsAndFunctions.latestHighTarget = DateTime.Now;
            StaticObjects.SettingsAndFunctions.latestLowTarget = DateTime.Now;

            StaticObjects.form1.UpdateStats();
            Edging();
        }

        static async public void Edging()
        {
            Commands.WriteLine("Edging Phase", Color.Cyan);
            while (StaticObjects.SettingsAndFunctions.programRunning)
            {
                try
                {

                    if (StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute <= StaticObjects.SettingsAndFunctions.latestMax)
                    {
                        if (StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute > StaticObjects.SettingsAndFunctions.dynamicTargetBPM)
                        {
                            StaticObjects.SettingsAndFunctions.latestHighTarget = DateTime.Now;
                            if(DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestLowTarget).TotalSeconds>60)
                            {
                                StaticObjects.SettingsAndFunctions.latestLowTarget = DateTime.Now;
                                if (StaticObjects.SettingsAndFunctions.dynamicTargetBPM < 120)
                                {
                                    Commands.WriteLine("Been above target for more then one minute, increasing targetBPM",Color.Cyan);
                                    StaticObjects.SettingsAndFunctions.dynamicTargetBPM++;
                                }
                            }
                            await HandleAboveTarget();
                        }
                        else if (StaticObjects.SettingsAndFunctions.latestReading.BeatsPerMinute <= StaticObjects.SettingsAndFunctions.dynamicTargetBPM)
                        {
                            StaticObjects.SettingsAndFunctions.latestLowTarget = DateTime.Now;
                            if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.latestHighTarget).TotalSeconds > 30)
                            {
                                Commands.WriteLine("Been below target for more then 30 seconds, decreasing targetBPM", Color.Cyan);
                                StaticObjects.SettingsAndFunctions.latestHighTarget = DateTime.Now;
                                StaticObjects.SettingsAndFunctions.dynamicTargetBPM--;
                            }
                            await HandleBelowTarget();
                        }
                    }
                    else
                    {
                        if (StaticObjects.SettingsAndFunctions.running)
                        {
                            await Commands.StopMachine("BPM is higher then MAX");
                        }
                    }
                }
                catch (Exception ex) { Commands.WriteLine(ex + "\n", Color.Red); }


                await Task.Delay(1000);

                if (DateTime.Now.Subtract(StaticObjects.SettingsAndFunctions.runTime).TotalMinutes > StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes)
                {
                    await StartMilking();
                    StaticObjects.SettingsAndFunctions.runTime = DateTime.Now;
                    StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes = StaticObjects.r.Next(StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes /2, StaticObjects.SettingsAndFunctions.milkingStartTimeInMinutes);
                    StaticObjects.SettingsAndFunctions.logFileName = DateTime.Now.ToString("yyyyMMdd HHmmss")+".txt";
                    Commands.WriteLine("Edging Phase",Color.Cyan);
                }
            }
            await Commands.SetSuck(0);
            await Commands.SetSpeed(0);
            await Commands.StopMachine("Program aborted");
            Commands.WriteLine("Program ABORTED",Color.Orange);
            StaticObjects.SettingsAndFunctions.confirmedStopped = true;
        }

        static async public Task StartMilking()
        {
            try
            {
                Commands.WriteLine("Milking Phase", Color.Cyan);
                foreach(MilkSettings setting in StaticObjects.SettingsAndFunctions.milkSettings) 
                {
                    Commands.WriteLine(JsonConvert.SerializeObject(setting,Formatting.Indented), Color.Cyan);
                    if (setting.machineOn != 0)
                    {
                        await Commands.StartMachine("MilkSetting");
                    }
                    await Commands.SetSpeed(setting.speed);
                    await Commands.SetSuck(setting.suck);
                    if(setting.machineOn == 0)
                    {
                        await Commands.StopMachine("MilkSetting");
                    }
                    await Task.Delay(setting.delayInSeconds*1000, cancelToken.Token);
                }
            }
            catch (Exception e) { Commands.WriteLine("Failed\n" + e, Color.Red); }
        }
        
    }
}
