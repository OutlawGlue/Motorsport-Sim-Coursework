namespace MotorsportSim.Career
{
    internal class CareerSave
    {
        private string careerName;
        private readonly int raceCount;
        private int currentRaceIndex;
        private int lapCount;
        private int carCount;
        private int managedTeamIndex;

        public CareerSave(string givenCareerName)
        {
            careerName = givenCareerName;
            // TEMPORARY HARDCODED VALUES:
            lapCount = 5;
            carCount = 4;
            managedTeamIndex = 0;
        }

        //Validation should be done when career is set up, so no setters needed here
        public string CareerName
        {
            get { return careerName; }
        }

        public int LapCount
        {
            get { return lapCount; }
        }

        public int CarCount
        {
            get { return carCount; }
        }

        public int ManagedTeamIndex
        {
            get { return managedTeamIndex; }
        }
    }
}