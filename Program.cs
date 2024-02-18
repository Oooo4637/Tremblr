using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tremblr.HeartBeatBT;
using Tremblr.TremblrControl;

namespace Tremblr
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IHeartRateService service = new HeartRateService();
            service.HeartRateUpdated += StaticObjects.UpdateBpm;
            Thread heartbeat = new Thread(service.InitiateDefault);
            //Task.Factory.StartNew(service.InitiateDefault);
            heartbeat.IsBackground = true;
            heartbeat.Start();
            HeartRateServiceWatchdog _watchdog = new HeartRateServiceWatchdog(TimeSpan.FromSeconds(1), service);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
