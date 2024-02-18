using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tremblr.HeartBeatBT;

namespace Tremblr.TremblrControl
{
    public static class Commands
    {
        

        static SemaphoreSlim semaphoreHackRFCommand = new SemaphoreSlim(1, 1);
        static SemaphoreSlim semaphoreCommand = new SemaphoreSlim(1, 1);

        static public async Task StartMachine(string reason) 
        {
            await semaphoreCommand.WaitAsync();
            try
            {
                if (!StaticObjects.SettingsAndFunctions.running)
                {
                    StaticObjects.SettingsAndFunctions.WriteStats();
                    await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t startstop2");
                    WriteLine("Starting because " + reason, Color.Green);
                    StaticObjects.SettingsAndFunctions.latestStartStopEvent = DateTime.Now;
                    StaticObjects.SettingsAndFunctions.running = true;
                }
            }
            catch (Exception) { }

            semaphoreCommand.Release();

        }

        static public async Task StopMachine(string reason)
        {
            await semaphoreCommand.WaitAsync();
            try
            {
                if (StaticObjects.SettingsAndFunctions.running)
                {
                    StaticObjects.SettingsAndFunctions.WriteStats();
                    WriteLine("Stopping because " + reason, Color.Orange);
                    await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t startstop2");
                    StaticObjects.SettingsAndFunctions.latestStartStopEvent = DateTime.Now;
                    StaticObjects.SettingsAndFunctions.running = false;
                }
            }
           
            catch (Exception) { }

            semaphoreCommand.Release();
        }

        static public async Task SetSpeed(int targetSpeed = 0)
        {
            await semaphoreCommand.WaitAsync();
            try
            {
                if (targetSpeed >= 0 && targetSpeed <= 3)
                {
                    while (StaticObjects.SettingsAndFunctions.speedUp != targetSpeed)
                    {
                        if (StaticObjects.SettingsAndFunctions.speedUp > targetSpeed)
                        {
                            await SpeedDown();
                        }
                        else
                        {
                            await SpeedUp();
                        }
                    }
                }

                StaticObjects.form1.UpdateStats();
            }
            
            catch (Exception) { }

            semaphoreCommand.Release();
        }

        static public async Task SetSuck(int suckLevel = 0)
        {
            await semaphoreCommand.WaitAsync();
            try
            {

                if (suckLevel >= 0 && suckLevel <= 3)
                {
                    while (StaticObjects.SettingsAndFunctions.suck != suckLevel)
                    {
                        if (StaticObjects.SettingsAndFunctions.suck > suckLevel)
                        {
                            await SuckDown();
                        }
                        else
                        {
                            await SuckUp();
                        }
                    }
                }

                StaticObjects.form1.UpdateStats();
            }
            catch (Exception) { }

            semaphoreCommand.Release();

        }

        static private async Task SpeedUp()
        {
            try
            {
                if (StaticObjects.SettingsAndFunctions.speedUp < 3)
                {
                    StaticObjects.SettingsAndFunctions.speedUp++;
                }
                WriteLine("SpeedUp");
                await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t SpeedUp");
                StaticObjects.SettingsAndFunctions.LatestSpeedUp = DateTime.Now;
            }
            
            catch (Exception) { }

        }

        

        static private async Task SpeedDown()
        {
            try
            {
                if (StaticObjects.SettingsAndFunctions.speedUp > 0)
                {
                    StaticObjects.SettingsAndFunctions.speedUp--;
                }
                WriteLine("SpeedDown");
                await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t SpeedDown");
                await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t SpeedDown");
                //StaticObjects.SettingsAndFunctions.latestStartStopEvent = DateTime.Now;
            }
            catch (Exception) { }
        }

        static private async Task SuckUp()
        {
            try
            {
                if (StaticObjects.SettingsAndFunctions.suck < 3)
                {

                    StaticObjects.SettingsAndFunctions.suck++;
                }
                WriteLine("SuckUp");
                await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t suckup2");

                //StaticObjects.SettingsAndFunctions.latestStartStopEvent = DateTime.Now;
            }
            catch (Exception) { }

        }

        static private async Task SuckDown()
        {
            try
            {
                if (StaticObjects.SettingsAndFunctions.suck > 0)
                {

                    StaticObjects.SettingsAndFunctions.suck--;
                }
                WriteLine("suckdown");
                await SendCommand("hackrf_transfer.exe -s 2000000 -f 433920000 -x 47 -a 1 -t suckdown");
            }
            catch(Exception) { }

        }

        static public void WriteLine(string line, Color? c = null)
        {
            line = DateTime.Now.ToString("yyyy-MM-mm HH:mm:ss") + ": " + line;
            /*
            Console.ForegroundColor = c;
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-mm HH:mm:ss")+": "+ line);
            Console.ForegroundColor = Color.White;
            */
            if(c == null)
            {
                c = Color.White;
            }
            StaticObjects.form1.Addtext(line, (Color) c);
            try
            {
                File.AppendAllText(StaticObjects.SettingsAndFunctions.logFileName,DateTime.Now.ToString("yyyy-MM-mm HH:mm:ss") + ": " + line+"\n");
            }
            catch(Exception e) {

                StaticObjects.form1.Addtext(""+e,Color.Red);
            }
        }

        static public async Task SendCommand(string command)
        {
            await semaphoreHackRFCommand.WaitAsync();
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(StaticObjects.SettingsAndFunctions.cd);
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            //Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            cmd.Dispose();

            semaphoreHackRFCommand.Release();
        }
       
    }
}
