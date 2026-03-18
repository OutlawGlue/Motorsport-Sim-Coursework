using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class TyreStint
    {
        private Tyre tyre;
        private int startLap;
        private int endLap = -1;
        private int lapsCompleted = -1;

        public TyreStint(Tyre tyre, int startLap)
        {
            this.tyre = tyre;
            this.startLap = startLap;
        }

        public void EndStint(int lap)
        {
            endLap = lap;
            lapsCompleted = (endLap == -1) ? 0 : Math.Max(0, endLap - startLap);
        }
    }
}