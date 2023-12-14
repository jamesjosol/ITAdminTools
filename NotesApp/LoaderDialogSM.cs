using System.Windows.Forms;

namespace AdminTools
{
    public partial class LoaderDialogSM : Form
    {
        public LoaderDialogSM(string text)
        {
            InitializeComponent();
            labelTitle.Text = text;
        }
    }
}
