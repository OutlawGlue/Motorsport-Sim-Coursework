using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    public class DriverStanding
    {
        private int driverNumber;
        private int points;

        public DriverStanding(int driverNumber, int points)
        {
            this.driverNumber = driverNumber;
            this.points = points;
        }

        public int DriverNumber 
        {
            get { return driverNumber; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
