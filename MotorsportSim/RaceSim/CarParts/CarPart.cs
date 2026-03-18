using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim.CarParts
{
    internal class CarPart
    {
        private int id;
        private double health;
        private double degradationRate;

        public CarPart(int givenId, double givenHealth)
        {
            id = givenId;
            Health = health;
        }

        //Getters and setters:
        public double Health
        {
            get { return health; }
            set
            {
                if (value <= 1 && value >= 0) health = value;
            }
        }

        //Methods:

        //degradation method.
    }
}