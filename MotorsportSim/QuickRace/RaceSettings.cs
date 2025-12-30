namespace MotorsportSim.QuickRace
{
    public class RaceSettings
    {
        private int lapCount;

        public RaceSettings(int laps)
        {
            LapCount = laps;
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }
    }
}