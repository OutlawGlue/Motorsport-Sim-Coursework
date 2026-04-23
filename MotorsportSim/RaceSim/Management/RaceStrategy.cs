using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorsportSim.RaceSim.Management
{
    internal partial class RaceStrategy : Form
    {
        private int selectedCompound;
        private Car target;
        private int lapCount;

        public RaceStrategy(Car target, int lapCount)
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.HeadingLabel(Lbl_car);
            MenuUI.Panel(Pnl_tyres);
            MenuUI.BodyButton(Btn_save);

            this.target = target;

            Rbtn_soft.CheckedChanged += TyreSelectionChanged;
            Rbtn_medium.CheckedChanged += TyreSelectionChanged;
            Rbtn_hard.CheckedChanged += TyreSelectionChanged;
            Rbtn_inter.CheckedChanged += TyreSelectionChanged;
            Rbtn_wet.CheckedChanged += TyreSelectionChanged;

            Lbl_car.Text = $"{target.DriverName}'s pit call.";
        }

        private void TyreSelectionChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton; //Cast sender to RadioButton, allowing all buttons to use same code
            if (rb.Checked)
            {
                selectedCompound = rb.ImageIndex;
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            char tyreLetter = 'S';
            switch (selectedCompound)
            {
                case 0: tyreLetter = 'S'; break;
                case 1: tyreLetter = 'M'; break;
                case 2: tyreLetter = 'H'; break;
                case 3: tyreLetter = 'I'; break;
                case 4: tyreLetter = 'W'; break;
            }

            new StrategyCall(target, 'P', tyreLetter, lapCount, false);

            this.Close();
        }
    }
}