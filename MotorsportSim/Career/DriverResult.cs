using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    public class DriverResult
    {
        //Driver related data:
        private string driverName;
        private int driverNumber;

        //Car related data:
        private List<float> lapTimes = new List<float>();
        private int position;

        public DriverResult(string driverName, int driverNumber, List<float> lapTimes, int position)
        {
            this.driverName = driverName;
            this.driverNumber = driverNumber;
            this.lapTimes = lapTimes;
            this.position = position;
        }

        public string DriverName
        {
            get { return driverName; }
        }

        public int DriverNumber
        {
            get { return driverNumber; }
        }

        public List<float> LapTimes
        {
            get { return lapTimes; }
        }

        public int Position
        {
            get { return position; }
        }
    }
}
