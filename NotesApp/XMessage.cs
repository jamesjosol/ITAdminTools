using CustomMessageBox;
using System.Windows.Forms;

namespace AdminTools
{
    public class XMessage
    {
        public void warn(string message)
        {
            RJMessageBox.Show(message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void warn(string message, string caption)
        {
            RJMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void err(string message)
        {
            RJMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void err(string message, string caption)
        {
            RJMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void scs(string message)
        {
            RJMessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void info(string message)
        {
            RJMessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
