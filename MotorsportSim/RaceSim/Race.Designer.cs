namespace MotorsportSim.RaceSim
{
    partial class Race
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_laps = new System.Windows.Forms.Label();
            this.Pnl_sideBar = new System.Windows.Forms.Panel();
            this.Dgv_standings = new System.Windows.Forms.DataGridView();
            this.Pnl_driver1 = new System.Windows.Forms.Panel();
            this.Pnl_driver1Time = new System.Windows.Forms.Panel();
            this.Lbl_driver1timetitle = new System.Windows.Forms.Label();
            this.Lbl_driver1laptime = new System.Windows.Forms.Label();
            this.Pnl_driver1Tyres = new System.Windows.Forms.Panel();
            this.Lbl_driver1tyretitle = new System.Windows.Forms.Label();
            this.Lbl_driver1tyrewear = new System.Windows.Forms.Label();
            this.Lbl_driver1name = new System.Windows.Forms.Label();
            this.Pnl_driver2 = new System.Windows.Forms.Panel();
            this.Pnl_driver2Tyres = new System.Windows.Forms.Panel();
            this.Lbl_driver2tyretitle = new System.Windows.Forms.Label();
            this.Lbl_driver2tyrewear = new System.Windows.Forms.Label();
            this.Pnl_driver2Time = new System.Windows.Forms.Panel();
            this.Lbl_driver2timetitle = new System.Windows.Forms.Label();
            this.Lbl_driver2laptime = new System.Windows.Forms.Label();
            this.Lbl_driver2name = new System.Windows.Forms.Label();
            this.Pnl_timeControls = new System.Windows.Forms.Panel();
            this.Lbl_speed = new System.Windows.Forms.Label();
            this.Btn_fast = new System.Windows.Forms.Button();
            this.Btn_slow = new System.Windows.Forms.Button();
            this.Lbl_raceTime = new System.Windows.Forms.Label();
            this.Btn_pause = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_track = new System.Windows.Forms.Panel();
            this.Pnl_raceTime = new System.Windows.Forms.Panel();
            this.Pnl_sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).BeginInit();
            this.Pnl_driver1.SuspendLayout();
            this.Pnl_driver1Time.SuspendLayout();
            this.Pnl_driver1Tyres.SuspendLayout();
            this.Pnl_driver2.SuspendLayout();
            this.Pnl_driver2Tyres.SuspendLayout();
            this.Pnl_driver2Time.SuspendLayout();
            this.Pnl_timeControls.SuspendLayout();
            this.Pnl_raceTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_laps
            // 
            this.Lbl_laps.Location = new System.Drawing.Point(60, 15);
            this.Lbl_laps.Name = "Lbl_laps";
            this.Lbl_laps.Size = new System.Drawing.Size(80, 20);
            this.Lbl_laps.TabIndex = 0;
            this.Lbl_laps.Text = "Lap 0";
            this.Lbl_laps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_sideBar
            // 
            this.Pnl_sideBar.Controls.Add(this.Dgv_standings);
            this.Pnl_sideBar.Controls.Add(this.Lbl_laps);
            this.Pnl_sideBar.Location = new System.Drawing.Point(20, 20);
            this.Pnl_sideBar.Name = "Pnl_sideBar";
            this.Pnl_sideBar.Size = new System.Drawing.Size(200, 1000);
            this.Pnl_sideBar.TabIndex = 1;
            // 
            // Dgv_standings
            // 
            this.Dgv_standings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_standings.Location = new System.Drawing.Point(0, 50);
            this.Dgv_standings.Name = "Dgv_standings";
            this.Dgv_standings.RowHeadersWidth = 62;
            this.Dgv_standings.RowTemplate.Height = 28;
            this.Dgv_standings.Size = new System.Drawing.Size(200, 900);
            this.Dgv_standings.TabIndex = 2;
            // 
            // Pnl_driver1
            // 
            this.Pnl_driver1.Controls.Add(this.Pnl_driver1Time);
            this.Pnl_driver1.Controls.Add(this.Pnl_driver1Tyres);
            this.Pnl_driver1.Controls.Add(this.Lbl_driver1name);
            this.Pnl_driver1.Location = new System.Drawing.Point(350, 870);
            this.Pnl_driver1.Name = "Pnl_driver1";
            this.Pnl_driver1.Size = new System.Drawing.Size(400, 150);
            this.Pnl_driver1.TabIndex = 2;
            // 
            // Pnl_driver1Time
            // 
            this.Pnl_driver1Time.Controls.Add(this.Lbl_driver1timetitle);
            this.Pnl_driver1Time.Controls.Add(this.Lbl_driver1laptime);
            this.Pnl_driver1Time.Location = new System.Drawing.Point(5, 30);
            this.Pnl_driver1Time.Name = "Pnl_driver1Time";
            this.Pnl_driver1Time.Size = new System.Drawing.Size(193, 113);
            this.Pnl_driver1Time.TabIndex = 9;
            // 
            // Lbl_driver1timetitle
            // 
            this.Lbl_driver1timetitle.Location = new System.Drawing.Point(15, 30);
            this.Lbl_driver1timetitle.Name = "Lbl_driver1timetitle";
            this.Lbl_driver1timetitle.Size = new System.Drawing.Size(170, 30);
            this.Lbl_driver1timetitle.TabIndex = 8;
            this.Lbl_driver1timetitle.Text = "Current Laptime:";
            // 
            // Lbl_driver1laptime
            // 
            this.Lbl_driver1laptime.Location = new System.Drawing.Point(75, 70);
            this.Lbl_driver1laptime.Name = "Lbl_driver1laptime";
            this.Lbl_driver1laptime.Size = new System.Drawing.Size(50, 30);
            this.Lbl_driver1laptime.TabIndex = 9;
            this.Lbl_driver1laptime.Text = "0:00";
            // 
            // Pnl_driver1Tyres
            // 
            this.Pnl_driver1Tyres.Controls.Add(this.Lbl_driver1tyretitle);
            this.Pnl_driver1Tyres.Controls.Add(this.Lbl_driver1tyrewear);
            this.Pnl_driver1Tyres.Location = new System.Drawing.Point(202, 30);
            this.Pnl_driver1Tyres.Name = "Pnl_driver1Tyres";
            this.Pnl_driver1Tyres.Size = new System.Drawing.Size(193, 113);
            this.Pnl_driver1Tyres.TabIndex = 10;
            // 
            // Lbl_driver1tyretitle
            // 
            this.Lbl_driver1tyretitle.Location = new System.Drawing.Point(5, 30);
            this.Lbl_driver1tyretitle.Name = "Lbl_driver1tyretitle";
            this.Lbl_driver1tyretitle.Size = new System.Drawing.Size(185, 30);
            this.Lbl_driver1tyretitle.TabIndex = 8;
            this.Lbl_driver1tyretitle.Text = "Current Tyre Wear:";
            // 
            // Lbl_driver1tyrewear
            // 
            this.Lbl_driver1tyrewear.Location = new System.Drawing.Point(85, 70);
            this.Lbl_driver1tyrewear.Name = "Lbl_driver1tyrewear";
            this.Lbl_driver1tyrewear.Size = new System.Drawing.Size(50, 30);
            this.Lbl_driver1tyrewear.TabIndex = 9;
            this.Lbl_driver1tyrewear.Text = "0%";
            // 
            // Lbl_driver1name
            // 
            this.Lbl_driver1name.AutoSize = true;
            this.Lbl_driver1name.Location = new System.Drawing.Point(5, 5);
            this.Lbl_driver1name.Name = "Lbl_driver1name";
            this.Lbl_driver1name.Size = new System.Drawing.Size(59, 20);
            this.Lbl_driver1name.TabIndex = 8;
            this.Lbl_driver1name.Text = "Driver1";
            // 
            // Pnl_driver2
            // 
            this.Pnl_driver2.Controls.Add(this.Pnl_driver2Tyres);
            this.Pnl_driver2.Controls.Add(this.Pnl_driver2Time);
            this.Pnl_driver2.Controls.Add(this.Lbl_driver2name);
            this.Pnl_driver2.Location = new System.Drawing.Point(1250, 870);
            this.Pnl_driver2.Name = "Pnl_driver2";
            this.Pnl_driver2.Size = new System.Drawing.Size(400, 150);
            this.Pnl_driver2.TabIndex = 3;
            // 
            // Pnl_driver2Tyres
            // 
            this.Pnl_driver2Tyres.Controls.Add(this.Lbl_driver2tyretitle);
            this.Pnl_driver2Tyres.Controls.Add(this.Lbl_driver2tyrewear);
            this.Pnl_driver2Tyres.Location = new System.Drawing.Point(202, 30);
            this.Pnl_driver2Tyres.Name = "Pnl_driver2Tyres";
            this.Pnl_driver2Tyres.Size = new System.Drawing.Size(193, 113);
            this.Pnl_driver2Tyres.TabIndex = 12;
            // 
            // Lbl_driver2tyretitle
            // 
            this.Lbl_driver2tyretitle.Location = new System.Drawing.Point(5, 30);
            this.Lbl_driver2tyretitle.Name = "Lbl_driver2tyretitle";
            this.Lbl_driver2tyretitle.Size = new System.Drawing.Size(185, 30);
            this.Lbl_driver2tyretitle.TabIndex = 8;
            this.Lbl_driver2tyretitle.Text = "Current Tyre Wear:";
            // 
            // Lbl_driver2tyrewear
            // 
            this.Lbl_driver2tyrewear.Location = new System.Drawing.Point(85, 70);
            this.Lbl_driver2tyrewear.Name = "Lbl_driver2tyrewear";
            this.Lbl_driver2tyrewear.Size = new System.Drawing.Size(50, 30);
            this.Lbl_driver2tyrewear.TabIndex = 9;
            this.Lbl_driver2tyrewear.Text = "0%";
            // 
            // Pnl_driver2Time
            // 
            this.Pnl_driver2Time.Controls.Add(this.Lbl_driver2timetitle);
            this.Pnl_driver2Time.Controls.Add(this.Lbl_driver2laptime);
            this.Pnl_driver2Time.Location = new System.Drawing.Point(5, 30);
            this.Pnl_driver2Time.Name = "Pnl_driver2Time";
            this.Pnl_driver2Time.Size = new System.Drawing.Size(193, 113);
            this.Pnl_driver2Time.TabIndex = 11;
            // 
            // Lbl_driver2timetitle
            // 
            this.Lbl_driver2timetitle.Location = new System.Drawing.Point(15, 30);
            this.Lbl_driver2timetitle.Name = "Lbl_driver2timetitle";
            this.Lbl_driver2timetitle.Size = new System.Drawing.Size(170, 30);
            this.Lbl_driver2timetitle.TabIndex = 8;
            this.Lbl_driver2timetitle.Text = "Current Laptime:";
            // 
            // Lbl_driver2laptime
            // 
            this.Lbl_driver2laptime.Location = new System.Drawing.Point(75, 70);
            this.Lbl_driver2laptime.Name = "Lbl_driver2laptime";
            this.Lbl_driver2laptime.Size = new System.Drawing.Size(50, 30);
            this.Lbl_driver2laptime.TabIndex = 10;
            this.Lbl_driver2laptime.Text = "0:00";
            // 
            // Lbl_driver2name
            // 
            this.Lbl_driver2name.AutoSize = true;
            this.Lbl_driver2name.Location = new System.Drawing.Point(5, 5);
            this.Lbl_driver2name.Name = "Lbl_driver2name";
            this.Lbl_driver2name.Size = new System.Drawing.Size(59, 20);
            this.Lbl_driver2name.TabIndex = 9;
            this.Lbl_driver2name.Text = "Driver2";
            // 
            // Pnl_timeControls
            // 
            this.Pnl_timeControls.Controls.Add(this.Pnl_raceTime);
            this.Pnl_timeControls.Controls.Add(this.Lbl_speed);
            this.Pnl_timeControls.Controls.Add(this.Btn_fast);
            this.Pnl_timeControls.Controls.Add(this.Btn_slow);
            this.Pnl_timeControls.Controls.Add(this.Btn_pause);
            this.Pnl_timeControls.Location = new System.Drawing.Point(900, 870);
            this.Pnl_timeControls.Name = "Pnl_timeControls";
            this.Pnl_timeControls.Size = new System.Drawing.Size(200, 150);
            this.Pnl_timeControls.TabIndex = 5;
            // 
            // Lbl_speed
            // 
            this.Lbl_speed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_speed.AutoSize = true;
            this.Lbl_speed.Location = new System.Drawing.Point(85, 70);
            this.Lbl_speed.Name = "Lbl_speed";
            this.Lbl_speed.Size = new System.Drawing.Size(25, 20);
            this.Lbl_speed.TabIndex = 8;
            this.Lbl_speed.Text = "1x";
            this.Lbl_speed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_fast
            // 
            this.Btn_fast.BackgroundImage = global::MotorsportSim.Properties.Resources.speed;
            this.Btn_fast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_fast.FlatAppearance.BorderSize = 0;
            this.Btn_fast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_fast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_fast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fast.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_fast.Location = new System.Drawing.Point(140, 100);
            this.Btn_fast.Name = "Btn_fast";
            this.Btn_fast.Size = new System.Drawing.Size(50, 50);
            this.Btn_fast.TabIndex = 10;
            this.Btn_fast.UseVisualStyleBackColor = false;
            this.Btn_fast.Click += new System.EventHandler(this.Btn_fast_Click);
            // 
            // Btn_slow
            // 
            this.Btn_slow.BackgroundImage = global::MotorsportSim.Properties.Resources.slow2;
            this.Btn_slow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_slow.FlatAppearance.BorderSize = 0;
            this.Btn_slow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_slow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_slow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_slow.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_slow.Location = new System.Drawing.Point(5, 100);
            this.Btn_slow.Name = "Btn_slow";
            this.Btn_slow.Size = new System.Drawing.Size(50, 50);
            this.Btn_slow.TabIndex = 9;
            this.Btn_slow.UseVisualStyleBackColor = false;
            this.Btn_slow.Click += new System.EventHandler(this.Btn_slow_Click);
            // 
            // Lbl_raceTime
            // 
            this.Lbl_raceTime.Location = new System.Drawing.Point(75, 15);
            this.Lbl_raceTime.Name = "Lbl_raceTime";
            this.Lbl_raceTime.Size = new System.Drawing.Size(50, 20);
            this.Lbl_raceTime.TabIndex = 8;
            this.Lbl_raceTime.Text = "00:00";
            // 
            // Btn_pause
            // 
            this.Btn_pause.BackgroundImage = global::MotorsportSim.Properties.Resources.pause;
            this.Btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_pause.FlatAppearance.BorderSize = 0;
            this.Btn_pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pause.Location = new System.Drawing.Point(75, 100);
            this.Btn_pause.Name = "Btn_pause";
            this.Btn_pause.Size = new System.Drawing.Size(50, 50);
            this.Btn_pause.TabIndex = 4;
            this.Btn_pause.UseVisualStyleBackColor = false;
            this.Btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 920);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_track
            // 
            this.Pnl_track.BackgroundImage = global::MotorsportSim.Properties.Resources.Monaco;
            this.Pnl_track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pnl_track.Location = new System.Drawing.Point(250, 20);
            this.Pnl_track.Name = "Pnl_track";
            this.Pnl_track.Size = new System.Drawing.Size(1400, 800);
            this.Pnl_track.TabIndex = 6;
            // 
            // Pnl_raceTime
            // 
            this.Pnl_raceTime.Controls.Add(this.Lbl_raceTime);
            this.Pnl_raceTime.Location = new System.Drawing.Point(0, 0);
            this.Pnl_raceTime.Name = "Pnl_raceTime";
            this.Pnl_raceTime.Size = new System.Drawing.Size(200, 50);
            this.Pnl_raceTime.TabIndex = 8;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1044);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pnl_track);
            this.Controls.Add(this.Pnl_timeControls);
            this.Controls.Add(this.Pnl_driver2);
            this.Controls.Add(this.Pnl_driver1);
            this.Controls.Add(this.Pnl_sideBar);
            this.Name = "Race";
            this.Text = "Race";
            this.Pnl_sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).EndInit();
            this.Pnl_driver1.ResumeLayout(false);
            this.Pnl_driver1.PerformLayout();
            this.Pnl_driver1Time.ResumeLayout(false);
            this.Pnl_driver1Tyres.ResumeLayout(false);
            this.Pnl_driver2.ResumeLayout(false);
            this.Pnl_driver2.PerformLayout();
            this.Pnl_driver2Tyres.ResumeLayout(false);
            this.Pnl_driver2Time.ResumeLayout(false);
            this.Pnl_timeControls.ResumeLayout(false);
            this.Pnl_timeControls.PerformLayout();
            this.Pnl_raceTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_laps;
        private System.Windows.Forms.Panel Pnl_sideBar;
        private System.Windows.Forms.DataGridView Dgv_standings;
        private System.Windows.Forms.Panel Pnl_driver1;
        private System.Windows.Forms.Panel Pnl_driver2;
        private System.Windows.Forms.Button Btn_pause;
        private System.Windows.Forms.Panel Pnl_timeControls;
        private System.Windows.Forms.Panel Pnl_track;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_driver2name;
        private System.Windows.Forms.Label Lbl_raceTime;
        private System.Windows.Forms.Button Btn_fast;
        private System.Windows.Forms.Button Btn_slow;
        private System.Windows.Forms.Label Lbl_speed;
        private System.Windows.Forms.Label Lbl_driver1laptime;
        private System.Windows.Forms.Label Lbl_driver2laptime;
        private System.Windows.Forms.Label Lbl_driver1timetitle;
        private System.Windows.Forms.Label Lbl_driver1name;
        private System.Windows.Forms.Panel Pnl_driver1Time;
        private System.Windows.Forms.Panel Pnl_driver2Time;
        private System.Windows.Forms.Label Lbl_driver2timetitle;
        private System.Windows.Forms.Panel Pnl_driver1Tyres;
        private System.Windows.Forms.Label Lbl_driver1tyretitle;
        private System.Windows.Forms.Label Lbl_driver1tyrewear;
        private System.Windows.Forms.Panel Pnl_driver2Tyres;
        private System.Windows.Forms.Label Lbl_driver2tyretitle;
        private System.Windows.Forms.Label Lbl_driver2tyrewear;
        private System.Windows.Forms.Panel Pnl_raceTime;
    }
}