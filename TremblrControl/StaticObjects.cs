using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tremblr.HeartBeatBT;

namespace Tremblr.TremblrControl
{
    public static class StaticObjects
    {

        public static GeneralSettingsAndFunctions SettingsAndFunctions = new GeneralSettingsAndFunctions();

        public static Random r = new Random();
        public static Form1 form1 = new Form1();

        public static void UpdateBpm(HeartRateReading reading)
        {
            //Console.WriteLine(JsonConvert.SerializeObject(reading,Formatting.Indented));
            try
            {
                StaticObjects.form1.UpdateBPM(reading);
                //form1.Addtext(JsonConvert.SerializeObject(reading, Formatting.Indented), Color.LightCyan);
                if (reading.BeatsPerMinute > 30 && !reading.IsError)
                {
                    SettingsAndFunctions.latestReading = reading;

                    if (SettingsAndFunctions.bpms.Count > 10)
                    {
                        SettingsAndFunctions.bpms.RemoveAt(0);
                    }

                    SettingsAndFunctions.bpms.Add(SettingsAndFunctions.latestReading.BeatsPerMinute);

                    if (DateTime.Now.Subtract(SettingsAndFunctions.lastCheck).TotalSeconds > 10)
                    {
                        SettingsAndFunctions.multiplier = 1 + ((SettingsAndFunctions.maxMultiplier - 1) * (DateTime.Now.Subtract(SettingsAndFunctions.runTime).TotalMinutes / SettingsAndFunctions.milkingStartTimeInMinutes));
                        SettingsAndFunctions.latestMax = SettingsAndFunctions.bpms.Max();
                        SettingsAndFunctions.mediumIncrease = (int)Math.Round(SettingsAndFunctions.bpms.Average() - SettingsAndFunctions.latestMedium);
                        SettingsAndFunctions.latestMedium = (int)Math.Round(SettingsAndFunctions.bpms.Average());
                        SettingsAndFunctions.latestMin = SettingsAndFunctions.bpms.Min();
                        SettingsAndFunctions.lastCheck = DateTime.Now;
                        form1.UpdateStats();
                    }
                }

            }
            catch (Exception e)
            {
                //form1.Addtext(JsonConvert.SerializeObject(" "+e, Formatting.Indented), Color.LightCyan);
            }

        }

    }
}
