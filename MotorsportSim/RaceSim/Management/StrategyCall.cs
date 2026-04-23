using MotorsportSim.RaceSim.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim.Management
{
    internal class StrategyCall
    {
        private readonly Car targetCar; //Just 0 or 1 for now, if AI uses this -> driver number
        private readonly char changeType; //eg. P for pitstop
        private readonly char changeTo; //eg. S for soft tyres
        private readonly int lapCount;
        private readonly bool isStart;

        public StrategyCall(Car targetCar, char changeType, char changeTo, int lapCount, bool isStart = true)
        {
            this.targetCar = targetCar;
            this.changeType = changeType;
            this.changeTo = changeTo;
            this.lapCount = lapCount;
            this.isStart = isStart;

            switch (changeType)
            {
                case 'P': TyreChange(targetCar, changeTo); break;
            }
        }

        private void TyreChange(Car target, char compound)
        {
            double maxGrip, minWater, maxWater;
            float wearRate;
            switch (compound)
            {
                case 'S':
                    maxGrip = 1.0; wearRate = 0.025f; minWater = 0.0; maxWater = 1.0; break;
                case 'M':
                    maxGrip = 0.9; wearRate = 0.02f; minWater = 0.0; maxWater = 1.0; break;
                case 'H':
                    maxGrip = 0.75; wearRate = 0.0125f; minWater = 0.0; maxWater = 1.0; break;
                case 'I':
                    maxGrip = 0.6; wearRate = 0.015f; minWater = 1.0; maxWater = 4.0; break;
                case 'W':
                    maxGrip = 0.5; wearRate = 0.015f; minWater = 4.0; maxWater = 8.0; break;
                default:
                    throw new ArgumentException("Invalid tyre compound type.");
            }
            Tyre newTyre = new Tyre(compound, maxGrip, wearRate * lapCount, minWater, maxWater);

            //Add logic to call driver.endTyreStint(), need access to driver
            if (isStart)
            {
                target.ChangeTyre(newTyre);
            }
            else
            {
                target.RequestPit(newTyre);
            }
        }
    }
}