using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MotorsportSim.RaceSim
{
    public class Tyre
    {
        private readonly char compound; //e.g., Soft, Medium, Hard.
        private readonly double maxGrip; //Actual grip is maxGrip * (currentHealth / 100)
        private readonly float wearRate; //How much the tyre degrades per corner (* corner severity)
        private readonly double minWater;
        private readonly double maxWater;
        private float wear = 0f;

        public Tyre(char compound, double maxGrip, float wearRate, double minWater, double maxWater)
        {
            this.compound = compound;
            this.maxGrip = maxGrip;
            this.wearRate = wearRate;
            this.minWater = minWater;
            this.maxWater = maxWater;
        }

        //Getters and setters:
        public char Compound
        {
            get { return compound; }
        }

        public double Wear
        {
            get { return wear; }
        }

        //Methods:
        public void Degrade(int factor)
        {
            //Amount will be 1 if normal deg rate, >1 if incident (eg. lockup)
            wear += (float)(wearRate * factor) / 100;
            wear = Math.Max(0f, Math.Min(1f, wear));
            if (wear < 0) wear = 0;
        }
    }
}