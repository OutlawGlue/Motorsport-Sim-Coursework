using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class Driver
    {
        private string name;
        private int number;

        public Driver(string givenName, int givenNumber)
        {
            name = givenName;
            number = givenNumber;
        }

        public string Name
        {
            get { return name; }
        }

        public int Number
        {
            get { return number; }
        }
    }
}