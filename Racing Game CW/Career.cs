using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Game_CW
{
    internal class Career
    {
        private readonly string CareerName;
        private readonly int RaceCount;
        private int CurrentRaceIndex;

        public Career(string careerName)
        {
            this.CareerName = careerName;
        }
    }
}