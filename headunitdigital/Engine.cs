using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headunitdigital
{
    class Engine
    {
        int speed = 0;
        int fuel = 100;
        double rpm = 0;
        public void speedUp()
        {
            rpm += rpm+ 0.5;
            speed++;
            if (fuel > 1)
            {
                fuel--;
            }
        }
        public void speedDown()
        {
            if (speed > 1)
            {
                speed--;
            }

            if(fuel > 1)
            {
                fuel--;
            }
            if (rpm > 0.5)
            {
                rpm -= rpm - 0.5;
            }
        }
        public int getCurrentSpeed()
        {
            return speed;
        }
        public int getCUrrentFuel()
        {
            return fuel;
        }
        public double getCurrentRpm()
        {
            return rpm;
        }
    }
}
