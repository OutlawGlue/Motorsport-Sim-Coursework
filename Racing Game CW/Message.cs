using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    internal class Message
    {
        public static void ShowError(string errorType, string message)
        {
            MessageBox.Show(message, errorType, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string infoType, string message)
        {
            MessageBox.Show(message, infoType, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
