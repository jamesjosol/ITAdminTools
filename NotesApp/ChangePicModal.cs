using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class ChangePicModal : Form
    {
        public bool isSaved = false;
        private string selectedFilePath = null;
        private DA DA = new DA();
        private XMessage x = new XMessage();
        public ChangePicModal()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                { 
                    selectedFilePath = openFileDialog.FileName;

                    bunifuPictureBox1.ImageLocation = selectedFilePath;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
            loadingThread.Start();

            byte[] imageData;
            using (MemoryStream stream = new MemoryStream())
            {
                bunifuPictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = stream.ToArray();

                if (DA.UploadImage(Session.UserID, imageData))
                {
                    isSaved = true;
                    Session.imageBytes = imageData;
                    this.Close();
                }
            }
            CloseLoadingDialog();
        }

        private void ShowLoader()
        {
            LoaderDialogSM loader = new LoaderDialogSM("Loading...");
            loader.ShowDialog();
            loader.ShowInTaskbar = false;
        }

        private void CloseLoadingDialog()
        {
            try
            {
                if (Application.OpenForms["LoaderDialogSM"] != null)
                {
                    Application.OpenForms["LoaderDialogSM"].Invoke(new Action(() =>
                    {
                        Application.OpenForms["LoaderDialogSM"].Close();
                    }));
                }
            }
            catch (Exception e) { }
        }

        private void ChangePicModal_Load(object sender, EventArgs e)
        {

        }
    }
}
