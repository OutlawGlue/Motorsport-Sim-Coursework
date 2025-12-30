namespace MotorsportSim.Career
{
    internal class CareerSave
    {
        private string careerName;
        private readonly int raceCount;
        private int currentRaceIndex;
        private int lapCount;

        public CareerSave(string careerName)
        {
            CareerName = careerName;
            LapCount = 5; // TEMPORARY HARDCODED VALUE
        }

        public string CareerName
        {
            get { return careerName; }
            set { careerName = value; }
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }
    }
}