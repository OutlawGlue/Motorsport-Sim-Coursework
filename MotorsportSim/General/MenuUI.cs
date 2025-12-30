using System.Drawing;
using System.Windows.Forms;

namespace MotorsportSim.General
{
    internal class MenuUI
    {
        private static readonly Color PrimaryColour = Color.FromArgb(13, 19, 33);
        private static readonly Color SecondaryColour = Color.FromArgb(29, 45, 68);
        private static readonly Color TertiaryColour = Color.FromArgb(116, 140, 171);
        private static readonly Color AlternateColour = Color.FromArgb(62, 92, 118);
        private static readonly Color TextColour = Color.FromArgb(240, 235, 216);
        private static readonly Color Transparent = Color.Transparent;
        private static readonly Font HeadingFont = new Font("Audiowide", 12, FontStyle.Bold);
        private static readonly Font BodyFont = new Font("Audiowide", 10);

        //Form Styles:
        public static void Form(Form frm)
        {
            //Visual Styles:
            frm.BackColor = TertiaryColour;
            frm.ForeColor = TextColour;
            frm.Font = BodyFont;

            //Use DPI scaling so forms scale correctly on different displays:
            frm.AutoScaleMode = AutoScaleMode.Dpi;

            //Form Size and Positioning: (not forced, just using a minimum)
            frm.MinimumSize = new Size(685, 400);
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.WindowState = FormWindowState.Maximized;
        }

        //Panel Styles:
        public static void Panel(Panel pnl)
        {
            pnl.BackColor = PrimaryColour;
        }

        public static void SecondaryPanel(Panel pnl)
        {
            pnl.BackColor = SecondaryColour;
        }

        //Label Styles:
        public static void HeadingLabel(Label lbl)
        {
            lbl.Font = HeadingFont;
            lbl.BackColor = Transparent;
            lbl.ForeColor = TextColour;
        }

        public static void BodyLabel(Label lbl)
        {
            lbl.Font = BodyFont;
            lbl.ForeColor = TextColour;
        }

        public static void LinkLabel(Label lbl)
        {
            lbl.Font = BodyFont;
            lbl.ForeColor = AlternateColour;
            lbl.Cursor = Cursors.Hand;
        }

        //TextBox Styles:
        public static void TextBox(TextBox txt)
        {
            txt.BackColor = TextColour;
            txt.ForeColor = Color.Black;
            txt.Font = BodyFont;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Cursor = Cursors.IBeam;
        }

        //Button Styles:
        public static void Button(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Transparent;
            btn.ForeColor = TextColour;
            btn.Font = HeadingFont;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;
        }

        public static void UnselectedButton(Button btn)
        {
            Button(btn);
            btn.Font = BodyFont;
        }

        public static void BodyButton(Button btn)
        {
            Button(btn);
            btn.BackColor = AlternateColour;
        }

        public static void ComboBox(ComboBox cbx)
        {
            cbx.BackColor = TextColour;
            cbx.ForeColor = Color.Black;
            cbx.Font = BodyFont;
            cbx.FlatStyle = FlatStyle.Flat;
            cbx.Cursor = Cursors.Hand;
        }

        public static void DataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = SecondaryColour;
            dgv.ForeColor = TextColour;
            dgv.Font = BodyFont;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColour;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextColour;
            dgv.RowHeadersDefaultCellStyle.BackColor = PrimaryColour;
            dgv.RowHeadersDefaultCellStyle.ForeColor = TextColour;
            dgv.GridColor = TertiaryColour;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 30;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
        }
    }
}