namespace MotorsportSim.Career
{
    partial class Results
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
            this.Lbl_season = new System.Windows.Forms.Label();
            this.Cbx_season = new System.Windows.Forms.ComboBox();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_load = new System.Windows.Forms.Button();
            this.Dgv_results = new System.Windows.Forms.DataGridView();
            this.Lbl_race = new System.Windows.Forms.Label();
            this.Cbx_race = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_season
            // 
            this.Lbl_season.AutoSize = true;
            this.Lbl_season.Location = new System.Drawing.Point(150, 100);
            this.Lbl_season.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_season.Name = "Lbl_season";
            this.Lbl_season.Size = new System.Drawing.Size(68, 20);
            this.Lbl_season.TabIndex = 26;
            this.Lbl_season.Text = "Season:";
            // 
            // Cbx_season
            // 
            this.Cbx_season.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_season.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_season.DropDownWidth = 100;
            this.Cbx_season.FormattingEnabled = true;
            this.Cbx_season.Location = new System.Drawing.Point(260, 100);
            this.Cbx_season.Name = "Cbx_season";
            this.Cbx_season.Size = new System.Drawing.Size(100, 28);
            this.Cbx_season.TabIndex = 27;
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(25, 575);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(100, 50);
            this.Btn_back.TabIndex = 30;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.Location = new System.Drawing.Point(720, 90);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(100, 50);
            this.Btn_load.TabIndex = 31;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Dgv_results
            // 
            this.Dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_results.Location = new System.Drawing.Point(150, 150);
            this.Dgv_results.Name = "Dgv_results";
            this.Dgv_results.RowHeadersWidth = 62;
            this.Dgv_results.RowTemplate.Height = 28;
            this.Dgv_results.Size = new System.Drawing.Size(670, 400);
            this.Dgv_results.TabIndex = 32;
            // 
            // Lbl_race
            // 
            this.Lbl_race.AutoSize = true;
            this.Lbl_race.Location = new System.Drawing.Point(420, 100);
            this.Lbl_race.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_race.Name = "Lbl_race";
            this.Lbl_race.Size = new System.Drawing.Size(51, 20);
            this.Lbl_race.TabIndex = 33;
            this.Lbl_race.Text = "Race:";
            // 
            // Cbx_race
            // 
            this.Cbx_race.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_race.DropDownWidth = 180;
            this.Cbx_race.FormattingEnabled = true;
            this.Cbx_race.Location = new System.Drawing.Point(520, 100);
            this.Cbx_race.Name = "Cbx_race";
            this.Cbx_race.Size = new System.Drawing.Size(180, 28);
            this.Cbx_race.TabIndex = 34;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 644);
            this.Controls.Add(this.Cbx_race);
            this.Controls.Add(this.Lbl_race);
            this.Controls.Add(this.Dgv_results);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Cbx_season);
            this.Controls.Add(this.Lbl_season);
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_season;
        private System.Windows.Forms.ComboBox Cbx_season;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.DataGridView Dgv_results;
        private System.Windows.Forms.Label Lbl_race;
        private System.Windows.Forms.ComboBox Cbx_race;
    }
}