using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MotorsportSim.RaceSim
{
    public partial class Race : Form
    {
        private Timer simTimer;
        private Timer leaderboardTimer;
        private RaceSim raceSim;
        private const int WaypointSize = 8;

        //TEMP:
        private List<Vector> editorWaypoints = new List<Vector>();

        public Race(RaceConfig raceConfig)
        {
            //Might have a raceUI class, or just all use MenuUI but different methods
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_sideBar);
            MenuUI.SecondaryPanel(Pnl_driver1);
            MenuUI.SecondaryPanel(Pnl_driver2);
            MenuUI.SecondaryPanel(Pnl_timeControls);
            MenuUI.BodyLabel(Lbl_laps);
            MenuUI.DataGridView(Dgv_standings);
            MenuUI.BodyLabel(Lbl_driver1name);
            MenuUI.BodyLabel(Lbl_driver2name);
            MenuUI.BodyLabel(Lbl_raceTime);
            MenuUI.Button(Btn_pause);

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
            simTimer = new Timer { Interval = 16 }; // roughly 60 FPS (16)
            simTimer.Tick += TimerTick;
            simTimer.Start();

            leaderboardTimer = new Timer { Interval = 500 }; // Update leaderboard every 0.5 seconds
            leaderboardTimer.Tick += LeaderboardTimerTick;
            leaderboardTimer.Start();

            LapChanged(raceSim.CurrentLap);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            raceSim.Update(simTimer.Interval / 1000f);
            Lbl_raceTime.Text = raceSim.GetFormattedRaceTime();
            Pnl_track.Invalidate(); //Add a condition to pause race
        }

        private void LeaderboardTimerTick(object sender, EventArgs e)
        {
            List<Car> sortedCars = raceSim.SortCarsOrder();
            Dgv_standings.Rows.Clear();
            for (int i = 0; i < sortedCars.Count; i++)
            {
                Dgv_standings.Rows.Add(i + 1, sortedCars[i].DriverNumber);
            }

            //Stop condition:
            if (raceSim.RaceFinished())
            {
                simTimer.Stop();
                leaderboardTimer.Stop();
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
                raceSim.Pause();
                Btn_pause.BackgroundImage = Properties.Resources.play;
            }
            else
            {
                raceSim.Resume();
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
            // Draw waypoints
            foreach (Vector waypoint in raceSim.Waypoints)
            {
                g.FillEllipse(Brushes.Green, waypoint.X - WaypointSize / 2, waypoint.Y - WaypointSize / 2, WaypointSize, WaypointSize);
            }
            // Draw cars
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
    }
}