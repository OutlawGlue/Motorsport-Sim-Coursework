using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    internal class MenuUI
    {
        private static readonly Color PrimaryColour = Color.FromArgb(13,19,33);
        private static readonly Color SecondaryColour = Color.FromArgb(29, 45, 68);
        private static readonly Color TertiaryColour = Color.FromArgb(116, 140, 171);
        private static readonly Color AlternateColour = Color.FromArgb(62, 92, 118);
        private static readonly Color TextColour = Color.FromArgb(240, 235, 216);
        private static readonly Font HeadingFont = new Font("Audiowide", 12, FontStyle.Bold);
        private static readonly Font BodyFont = new Font("Audiowide", 10);

        //Form Styles:
        public static void Form(Form frm)
        {
            frm.BackColor = TertiaryColour;
            frm.ForeColor = TextColour;
            frm.Font = BodyFont;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new Size(1800, 1000);
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
            lbl.ForeColor = TextColour;
        }
        public static void BodyLabel(Label lbl)
        {
            lbl.Font = BodyFont;
            lbl.ForeColor = TextColour;
        }

        //TextBox Styles:
        public static void TextBox(TextBox txt)
        {
            txt.BackColor = TextColour;
            txt.ForeColor = Color.Black;
            txt.Font = BodyFont;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        //Button Styles:
        public static void Button(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = SecondaryColour;
            btn.ForeColor = TextColour;
            btn.Font = HeadingFont;
            btn.TextAlign = ContentAlignment.MiddleCenter;
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
    }
}
