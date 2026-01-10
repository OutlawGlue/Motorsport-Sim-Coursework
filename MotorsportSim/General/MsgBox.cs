using System.Windows.Forms;

namespace MotorsportSim.General
{
    internal class MsgBox
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