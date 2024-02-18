using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tremblr.TremblrControl
{
    public  class MilkSettings
    {
        public int suck = 0;
        public int speed = 0;
        public int delayInSeconds = 60;
        public int machineOn = 0;
        public MilkSettings(int suck, int speed, int delayInSeconds, int machineOn)
        {
            this.suck = suck;
            this.speed = speed;
            this.delayInSeconds = delayInSeconds;
            this.machineOn = machineOn;
        }
    }
}
