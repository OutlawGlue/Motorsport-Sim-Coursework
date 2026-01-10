using System.Collections.Generic;

namespace MotorsportSim.QuickRace
{
    public class RaceSettings
    {
        private int lapCount;
        private int carCount;
        private int managedTeamIndex; //Index in future team list

        public RaceSettings(int givenLaps, int givenCarCount, int givenManagedTeamIndex)
        {
            lapCount = givenLaps;
            carCount = givenCarCount;
            managedTeamIndex = givenManagedTeamIndex;
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }

        //Unused getters and setters:
        //Not using setters as validation will be in the setup class
        //Therefore can just set directly to variable
        public int CarCount
        {
            get { return carCount; }
            set { carCount = value; }
        }

        public int ManagedTeamIndex
        {
            get { return managedTeamIndex; }
            set { managedTeamIndex = value; }
        }
    }
}