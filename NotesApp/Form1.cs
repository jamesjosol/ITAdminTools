using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdminTools
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Size formSize;
        private int boderSize = 2;
        private XMessage x = new XMessage();

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Padding = new Padding(boderSize);
            this.BackColor = Color.FromArgb(60, 57, 130);



            //this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MinimumSize = new Size(1117, 634);

            ActiveButton(btnPackageGenerator, RGBColors.color6);
            OpenChildForm(new PackageGenerator());

            this.Opacity = 0;

            if (Session.UserType != "SUPERADMIN") btnUserManage.Visible = false;

            if (Session.imageBytes != null && Session.imageBytes.Length > 0)
            {
                picbox.Image = ByteArrayToImage(Session.imageBytes);
                btnHome.Visible = false;
                labelTitle.Visible = false;
                picbox.Visible = true;
                labelTitle2.Visible = true;
            }
            else
            {
                btnHome.Visible = true;
                labelTitle.Visible = true;
                picbox.Visible = false;
                labelTitle2.Visible = false;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = Regex.Replace(childForm.Text, "([A-Z])", " $1").TrimStart();
            childForm.Size = panelDesktop.Size;
        }


        private void btnPackageGenerator_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new PackageGenerator());
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new UpdateClinician());
        }
        private void btnUpdateSource_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new UpdateSource());
        }
        private void btnUpdateDebtor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new UpdateDebtor());
        }
        private void btnProfileSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new UserManage());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Home";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Reset();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Overrided Methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                btnMaximize.IconChar = IconChar.WindowRestore;
            else
                btnMaximize.IconChar = IconChar.WindowMaximize;

            base.OnSizeChanged(e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 10; // milliseconds
            fadeInTimer.Tick += FadeInTimer_Tick;
            fadeInTimer.Start();

            sessionLabel.Text = Session.UserID;
            //this.framebox.Size = new Size(l, w);
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.05;
            }
            else
            {
                (sender as Timer).Stop();
            }
        }

        private void picbox_MouseHover(object sender, EventArgs e)
        {
            this.framebox.Visible = true;
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 10; // milliseconds
            fadeInTimer.Tick += sizeanimation_Tick;
            fadeInTimer.Start();
        }

        private void picbox_MouseLeave(object sender, EventArgs e)
        {
            this.framebox.Visible = false;
            //l = 100;
            //w = 100;
            startX = 39;
            startY = 11;
            startWidth = 100;
            startHeight = 100;
            this.framebox.Size = new Size(startWidth, startHeight);
            this.framebox.Location = new Point(startX, startY);
        }

        private int l = 100;
        private int w = 100;

        private int startX = 39;
        private int startY = 11;
        private int targetX = 17;
        private int targetY = -12;
        private int startWidth = 100;
        private int startHeight = 100;
        private int targetWidth = 144;
        private int targetHeight = 144;


        private void sizeanimation_Tick(object sender, EventArgs e)
        {
            //if (l < 144 && w < 144)
            //{
            //    l += 2;
            //    w += 2;
            //    this.framebox.Size = new Size(l, w);
            //}
            //else
            //{
            //    (sender as Timer).Stop();
            //}
            if (startWidth < targetWidth && startHeight < targetHeight)
            {
                startWidth += 2;
                startHeight += 2;

                int currentX = (int)(startX + (targetX - startX) * ((float)(startWidth - 100) / (targetWidth - 100)));
                int currentY = (int)(startY + (targetY - startY) * ((float)(startHeight - 100) / (targetHeight - 100)));

                this.framebox.Location = new Point(currentX, currentY);
                this.framebox.Size = new Size(startWidth, startHeight);
            }
            else
            {
                (sender as Timer).Stop();
            }
        }

        private void changePicBtn_Click(object sender, EventArgs e)
        {
            ChangePicModal changePic = new ChangePicModal();
            changePic.ShowDialog();
            if (changePic.isSaved)
            {
                x.scs("Image successfully changed.");
                btnHome.Visible = false;
                labelTitle.Visible = false;
                picbox.Visible = true;
                labelTitle2.Visible = true;

                picbox.Image = ByteArrayToImage(Session.imageBytes);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
