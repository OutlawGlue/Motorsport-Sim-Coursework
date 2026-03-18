using MotorsportSim.RaceSim.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    public class Driver
    {
        private string name;
        private int number;
        private List<TyreStint> tyreHistory; //This could be my own data structure. List that has lapNumber and tyre compound.

        public Driver(string name, int number)
        {
            this.name = name;
            this.number = number;

            tyreHistory = new List<TyreStint>();
        }

        public string Name
        {
            get { return name; }
        }

        public int Number
        {
            get { return number; }
        }

        public void StartTyreStint(Tyre tyre, int lap)
        {
            tyreHistory.Add(new TyreStint(tyre, lap));
        }

        public void EndTyreStint(int lap)
        {
            tyreHistory.Last().EndStint(lap);
        }
    }
}