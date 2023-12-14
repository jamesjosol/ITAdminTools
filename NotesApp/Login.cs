using System;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace AdminTools
{
    public partial class Login : Form
    {
        private DA DA = new DA();
        private XMessage x = new XMessage();
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            useridTxt.KeyDown += Enter_Login;
            passwordTxt.KeyDown += Enter_Login;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (string.IsNullOrEmpty(useridTxt.Text))
            {
                x.err("User ID is required.");
                return;
            }
            else if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                x.err("Password is required.");
                return;
            }
            try
            {
                var loadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(ShowLoader));
                loadingThread.Start();
                BO.User user = DA.Auth(useridTxt.Text.ToUpper(), passwordTxt.Text.ToUpper());

                if (user != null)
                {
                    Session.UserID = user.UserID;
                    Session.Username = user.Username;

                    this.Hide();
                    Form1 f1 = new Form1();
                    CloseLoadingDialog();
                    f1.Show();  
                }
                else
                {
                    CloseLoadingDialog();
                    loadingThread.Abort();
                    x.err("Incorrect User ID or Password.", "Invalid");

                }
            }
            catch (Exception ex)
            {
                CloseLoadingDialog();
                x.err(ex.Message, "Error - " + ex.GetType().Name);
                throw;
            }
        }

        private void Enter_Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void ShowLoader()
        {
            LoaderDialogSM loader = new LoaderDialogSM("Logging In...");
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

        private void Login_Load(object sender, EventArgs e)
        {
            #region "=========== RUN UPDATER ==========="

            var appSettings = ConfigurationManager.AppSettings;
            string[] args = Environment.GetCommandLineArgs();

            // Application is running
            // Process command line args
            bool update_flag = false;
            if (args != null && args.Length > 1) update_flag = bool.Parse(args[1]);

            /// <summary>
            ///     If Update_Flag is False then run the Updater.exe to update the existing program with the latest update found in the server
            /// </summary>
            if (update_flag == false)
            {
                string exePath = System.IO.Directory.GetCurrentDirectory() + "\\Updater.exe"; //Get the Updater.exe folder path
                if (System.IO.File.Exists(exePath))
                {
                    System.Diagnostics.Process.Start(exePath, "\"" + appSettings["update_folder"].ToString() + "\"" + " " + appSettings["app_name"].ToString()); //Start the updater.exe
                    Application.Exit(); //close this program    
                }
            }

            #endregion
        }
    }
}
