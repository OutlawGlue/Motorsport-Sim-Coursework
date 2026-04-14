using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorsportSim.Career
{
    public partial class Results : Form
    {
        private readonly CareerSave save;
        private List<DriverResult> results = new List<DriverResult>();
        public Results(CareerSave save)
        {
            LoadForm();

            this.save = save;
            LoadOptions();
        }

        public Results(List<DriverResult> results)
        {
            LoadForm();

            this.results = results;

            LoadDGV();
        }

        private void LoadForm()
        {
            InitializeComponent();

            MenuUI.Form(this);

            MenuUI.HeadingLabel(Lbl_season);
            MenuUI.ComboBox(Cbx_season);
            MenuUI.HeadingLabel(Lbl_race);
            MenuUI.ComboBox(Cbx_race);
            MenuUI.BodyButton(Btn_load);

            MenuUI.DataGridView(Dgv_results);
            MenuUI.BodyButton(Btn_back);

            Dgv_results.AutoGenerateColumns = false;
            Dgv_results.Columns.Clear();
            Dgv_results.Columns.Add("Driver", "Driver");
            Dgv_results.Columns.Add("Position", "Position");
            Dgv_results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadOptions()
        {
            Cbx_season.Items.Clear();
            Cbx_race.Items.Clear();

            foreach (Season season in save.Seasons)
            {
                Cbx_season.Items.Add(season.Year);

                foreach (RaceWeekend weekend in season.Schedule)
                {
                    Cbx_race.Items.Add(weekend.TrackName);
                }
            }
            Cbx_season.SelectedIndex = 0;
            
            Cbx_race.SelectedIndex = 0;
        }

        public List<DriverResult> GetResults(int year, int race)
        {
            RaceWeekend weekend = save.GetSeasonResult(year, race);
            return weekend.Result;
        }

        private void LoadDGV()
        {
            Dgv_results.Rows.Clear();

            int year = Cbx_season.SelectedIndex;
            int race = Cbx_race.SelectedIndex;

            if (results.Count == 0)
            {
                //If loading from career menu:
                results = GetResults(year, race);
            }

            foreach (DriverResult result in results)
            {
                Dgv_results.Rows.Add(result.DriverName, result.Position);
            }
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
