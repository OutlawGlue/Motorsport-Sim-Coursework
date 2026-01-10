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
            this.Pnl_sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_laps
            // 
            this.Lbl_laps.AutoSize = true;
            this.Lbl_laps.Location = new System.Drawing.Point(60, 20);
            this.Lbl_laps.Name = "Lbl_laps";
            this.Lbl_laps.Size = new System.Drawing.Size(49, 20);
            this.Lbl_laps.TabIndex = 0;
            this.Lbl_laps.Text = "Lap 0";
            // 
            // Pnl_sideBar
            // 
            this.Pnl_sideBar.Controls.Add(this.Dgv_standings);
            this.Pnl_sideBar.Controls.Add(this.Lbl_laps);
            this.Pnl_sideBar.Location = new System.Drawing.Point(20, 20);
            this.Pnl_sideBar.Name = "Pnl_sideBar";
            this.Pnl_sideBar.Size = new System.Drawing.Size(200, 600);
            this.Pnl_sideBar.TabIndex = 1;
            // 
            // Dgv_standings
            // 
            this.Dgv_standings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_standings.Location = new System.Drawing.Point(0, 50);
            this.Dgv_standings.Name = "Dgv_standings";
            this.Dgv_standings.RowHeadersWidth = 62;
            this.Dgv_standings.RowTemplate.Height = 28;
            this.Dgv_standings.Size = new System.Drawing.Size(200, 500);
            this.Dgv_standings.TabIndex = 2;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Pnl_sideBar);
            this.Name = "Race";
            this.Text = "Race";
            this.Pnl_sideBar.ResumeLayout(false);
            this.Pnl_sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_laps;
        private System.Windows.Forms.Panel Pnl_sideBar;
        private System.Windows.Forms.DataGridView Dgv_standings;
    }
}