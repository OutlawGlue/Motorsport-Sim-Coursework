using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MotorsportSim.Career;
using System.Linq;

namespace MotorsportSim.RaceSim
{
    public partial class Race : Form
    {
        private Timer simTimer;
        private Timer leaderboardTimer;
        private Stopwatch simWatch;
        private long lastTickTime;
        private RaceSim raceSim;
        private const int WaypointSize = 8;
        private float[] speeds = { 0.5f, 1.0f, 2.0f, 4.0f };
        private int speedIndex = 1;
        private CareerSave save;
        private int trackIndex;

        //TEMP:
        private List<Vector> editorWaypoints = new List<Vector>();

        public Race(RaceConfig raceConfig, CareerSave save = null)
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.DataGridView(Dgv_standings);

            //Panels:
            MenuUI.Panel(Pnl_sideBar);
            MenuUI.Panel(Pnl_raceTime);
            MenuUI.SecondaryPanel(Pnl_timeControls);

            MenuUI.Panel(Pnl_driver1);
            MenuUI.SecondaryPanel(Pnl_driver1Time);
            MenuUI.SecondaryPanel(Pnl_driver1Tyres);

            MenuUI.Panel(Pnl_driver2);
            MenuUI.SecondaryPanel(Pnl_driver2Time);
            MenuUI.SecondaryPanel(Pnl_driver2Tyres);


            //Labels:
            MenuUI.BodyLabel(Lbl_laps);
            MenuUI.BodyLabel(Lbl_raceTime);

            MenuUI.HeadingLabel(Lbl_driver1name);
            MenuUI.HeadingLabel(Lbl_driver1timetitle);
            MenuUI.BodyLabel(Lbl_driver1laptime);
            MenuUI.HeadingLabel(Lbl_driver1tyretitle);
            MenuUI.BodyLabel(Lbl_driver1tyrewear);

            MenuUI.HeadingLabel(Lbl_driver2name);
            MenuUI.HeadingLabel(Lbl_driver2timetitle);
            MenuUI.BodyLabel(Lbl_driver2laptime);
            MenuUI.HeadingLabel(Lbl_driver2tyretitle);
            MenuUI.BodyLabel(Lbl_driver2tyrewear);

            //Buttons:
            MenuUI.Button(Btn_pause);
            MenuUI.Button(Btn_slow);
            MenuUI.Button(Btn_fast);

            EnableDoubleBuffering(Pnl_track);
            Pnl_track.Paint += Pnl_track_Paint;

            //TEMP: for drawing waypoints. Remove later.
            //Pnl_track.MouseClick += Pnl_track_MouseClick;

            //Setup data grid view:
            Dgv_standings.AutoGenerateColumns = false;
            Dgv_standings.Columns.Clear();
            Dgv_standings.Columns.Add("Position", "Pos");
            Dgv_standings.Columns.Add("DriverNumber", "No.");
            Dgv_standings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DoubleBuffered = true; //Reduces flickering

            this.save = save;
            this.trackIndex = raceConfig.Track.Index;
            CreateSimulation(raceConfig);
            SetupTimers();
        }

        private void CreateSimulation(RaceConfig raceConfig)
        {
            RaceBuilder builder = new RaceBuilder();
            raceSim = builder.BuildRace(raceConfig);
            raceSim.LeaderLapChanged += LapChanged;

            Lbl_driver1name.Text = raceSim.ManagedCars[0].DriverName;
            Lbl_driver2name.Text = raceSim.ManagedCars[1].DriverName;
        }

        private void SetupTimers()
        {
            simTimer = new Timer { Interval = 16 }; //Roughly 60 FPS (16)
            simTimer.Tick += TimerTick;
            simTimer.Start();

            leaderboardTimer = new Timer { Interval = 500 }; //Update leaderboard every 0.5 seconds
            leaderboardTimer.Tick += LeaderboardTimerTick;
            leaderboardTimer.Start();

            simWatch = Stopwatch.StartNew();
            lastTickTime = simWatch.ElapsedMilliseconds;

            LapChanged(raceSim.CurrentLap);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            long currentTime = simWatch.ElapsedMilliseconds;
            float deltaT = (currentTime - lastTickTime) / 1000f;
            deltaT = Math.Min(deltaT, 0.05f); //Max 50ms
            lastTickTime = currentTime;

            raceSim.Update(deltaT);
            Lbl_raceTime.Text = raceSim.GetFormattedRaceTime();
            Pnl_track.Invalidate(); //Add a condition to pause race

            Lbl_driver1laptime.Text = raceSim.ManagedCars[0].GetFormattedLapTime();
            Lbl_driver2laptime.Text = raceSim.ManagedCars[1].GetFormattedLapTime();
        }

        private void LeaderboardTimerTick(object sender, EventArgs e)
        {
            List<Car> sortedCars = raceSim.SortCarsOrder();
            Dgv_standings.Rows.Clear();
            for (int i = 0; i < sortedCars.Count; i++)
            {
                Dgv_standings.Rows.Add(i + 1, sortedCars[i].DriverNumber);
            }

            //Get tyre wear:
            Lbl_driver1tyrewear.Text = raceSim.ManagedCars[0].GetFormattedTyreWear();
            Lbl_driver2tyrewear.Text = raceSim.ManagedCars[1].GetFormattedTyreWear();

            //Stop condition:
            if (raceSim.RaceFinished())
            {
                simTimer.Stop();
                leaderboardTimer.Stop();
                raceSim.Pause();
                Btn_pause.Enabled = false;

                if (save != null)
                {
                    //Build DriverResults:
                    List<DriverResult> allDriverResults = new List<DriverResult>();

                    for (int i = 0; i < sortedCars.Count; i++)
                    {
                        Car car = sortedCars[i];

                        DriverResult driverResult = 
                            new DriverResult(car.DriverName, car.DriverNumber, car.LapTimes, i + 1);

                        allDriverResults.Add(driverResult);
                    }

                    //Add the results to the save:
                    RaceWeekend raceWeekend = new RaceWeekend(trackIndex, true, allDriverResults);
                    save.AddResult(raceWeekend);
                }

                MsgBox.ShowInfo("Race Complete", "Press OK to continue");
                this.Close();
            }
        }

        private void LapChanged(int lap)
        {
            if (lap <= raceSim.LapCount)
            {
                Lbl_laps.Text = $"Lap {lap} / {raceSim.LapCount}";
            }
            else
            {
                Lbl_laps.Text = "Finished!";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            raceSim.LeaderLapChanged -= LapChanged;
            simTimer?.Stop();
            simTimer?.Dispose();
            leaderboardTimer?.Stop();
            leaderboardTimer?.Dispose();
            base.OnFormClosing(e);
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            if (raceSim.IsPaused)
            {
                raceSim.Resume();
                Btn_pause.BackgroundImage = Properties.Resources.play;
            }
            else
            {
                raceSim.Pause();
                Btn_pause.BackgroundImage = Properties.Resources.pause;
            }
        }

        private void EnableDoubleBuffering(Panel pnl)
        {
            typeof(Panel)
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)
                .SetValue(pnl, true, null);
        }

        private void Pnl_track_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            //Draw waypoints:
            foreach (Vector waypoint in raceSim.Waypoints)
            {
                g.FillEllipse(Brushes.Green, waypoint.X - WaypointSize / 2, waypoint.Y - WaypointSize / 2, WaypointSize, WaypointSize);
            }
            //Draw cars:
            foreach (Car car in raceSim.Cars)
            {
                car.ShowCar(g);
            }
        }

        //private void Pnl_track_MouseClick(object sender, MouseEventArgs e)
        //{
        //    editorWaypoints.Add(new Vector(e.X, e.Y));
        //    Pnl_track.Invalidate();
        //}

        private void SaveWaypoints(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var wp in editorWaypoints)
                {
                    writer.WriteLine($"{wp.X},{wp.Y}");
                }
            }
        }

        //TEMPORRARY
        private void button1_Click(object sender, EventArgs e)
        {
            SaveWaypoints("Monaco-wp.txt");
        }

        private void Btn_fast_Click(object sender, EventArgs e)
        {
            speedIndex++;
            if (speedIndex >= speeds.Length)
                speedIndex = speeds.Length - 1;

            raceSim.SetSpeed(speeds[speedIndex]);
            Lbl_speed.Text = speeds[speedIndex].ToString() + "x";
        }

        private void Btn_slow_Click(object sender, EventArgs e)
        {
            speedIndex--;
            if (speedIndex < 0)
                speedIndex = 0;

            raceSim.SetSpeed(speeds[speedIndex]);
            Lbl_speed.Text = speeds[speedIndex].ToString() + "x";
        }

    }
}