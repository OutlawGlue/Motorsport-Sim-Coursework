using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim.CarParts
{
    internal class Engine : CarPart
    {
        private double degRate = 0.01;
        private int temperature; //Starts at 80, once over 120 starts degrading faster;

        public Engine(int id, double health) : base(id, health)
        {
        }

        public void Degrade() //Implement call for this
        {
            Health -= degRate;
        }
    }
}