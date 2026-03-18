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
        private Timer timer;
        private Timer leaderboardTimer;
        private bool fullSecond = true;
        private int raceTimeSeconds = -1;
        private RaceSim sim;
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
            sim = builder.BuildRace(raceConfig);
            sim.LeaderLapChanged += LapChanged;

            Lbl_driver1name.Text = sim.ManagedCars[0].DriverName;
            Lbl_driver2name.Text = sim.ManagedCars[1].DriverName;
        }

        private void SetupTimers()
        {
            timer = new Timer { Interval = 16 }; // roughly 60 FPS (16)
            timer.Tick += TimerTick;
            timer.Start();

            leaderboardTimer = new Timer { Interval = 500 }; // Update leaderboard every 0.5 seconds
            leaderboardTimer.Tick += LeaderboardTimerTick;
            leaderboardTimer.Start();

            LapChanged(sim.CurrentLap);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            sim.Update(timer.Interval / 1000f);
            Pnl_track.Invalidate(); //Add a condition to pause race
        }

        private void LeaderboardTimerTick(object sender, EventArgs e)
        {
            List<Car> sortedCars = sim.SortCarsOrder();
            Dgv_standings.Rows.Clear();
            for (int i = 0; i < sortedCars.Count; i++)
            {
                Dgv_standings.Rows.Add(i + 1, sortedCars[i].DriverNumber);
            }

            if (fullSecond)
            {
                fullSecond = false;
                raceTimeSeconds++;
                Lbl_raceTime.Text = TimeSpan
                    .FromSeconds(raceTimeSeconds)
                    .ToString(@"mm\:ss");
            }
            else
            {
                fullSecond = true;
            }

            //Stop condition:
            if (sim.RaceFinished())
            {
                timer.Stop();
                leaderboardTimer.Stop();
            }
        }

        private void LapChanged(int lap)
        {
            if (lap <= sim.LapCount)
            {
                Lbl_laps.Text = $"Lap {lap} / {sim.LapCount}";
            }
            else
            {
                Lbl_laps.Text = "Finished!";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sim.LeaderLapChanged -= LapChanged;
            timer?.Stop();
            timer?.Dispose();
            leaderboardTimer?.Stop();
            leaderboardTimer?.Dispose();
            base.OnFormClosing(e);
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                leaderboardTimer.Stop();
                Btn_pause.BackgroundImage = Properties.Resources.play;
            }
            else
            {
                timer.Start();
                leaderboardTimer.Start();
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
            foreach (Vector waypoint in sim.Waypoints)
            {
                g.FillEllipse(Brushes.Green, waypoint.X - WaypointSize / 2, waypoint.Y - WaypointSize / 2, WaypointSize, WaypointSize);
            }
            // Draw cars
            foreach (Car car in sim.Cars)
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