
namespace AdminTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUserManage = new FontAwesome.Sharp.IconButton();
            this.btnUpdateDebtor = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnUpdateSource = new FontAwesome.Sharp.IconButton();
            this.btnTodo = new FontAwesome.Sharp.IconButton();
            this.btnPackageGenerator = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.changePicBtn = new FontAwesome.Sharp.IconPictureBox();
            this.picbox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.framebox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.sessionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnUserManage);
            this.panelMenu.Controls.Add(this.btnUpdateDebtor);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnUpdateSource);
            this.panelMenu.Controls.Add(this.btnTodo);
            this.panelMenu.Controls.Add(this.btnPackageGenerator);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 633);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUserManage
            // 
            this.btnUserManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManage.FlatAppearance.BorderSize = 0;
            this.btnUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManage.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnUserManage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserManage.IconSize = 32;
            this.btnUserManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.Location = new System.Drawing.Point(0, 385);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUserManage.Size = new System.Drawing.Size(178, 60);
            this.btnUserManage.TabIndex = 5;
            this.btnUserManage.Text = "User Manage";
            this.btnUserManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnProfileSetting_Click);
            // 
            // btnUpdateDebtor
            // 
            this.btnUpdateDebtor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateDebtor.FlatAppearance.BorderSize = 0;
            this.btnUpdateDebtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDebtor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateDebtor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnUpdateDebtor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateDebtor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateDebtor.IconSize = 32;
            this.btnUpdateDebtor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDebtor.Location = new System.Drawing.Point(0, 325);
            this.btnUpdateDebtor.Name = "btnUpdateDebtor";
            this.btnUpdateDebtor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUpdateDebtor.Size = new System.Drawing.Size(178, 60);
            this.btnUpdateDebtor.TabIndex = 5;
            this.btnUpdateDebtor.Text = "Update Debtor";
            this.btnUpdateDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDebtor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateDebtor.UseVisualStyleBackColor = true;
            this.btnUpdateDebtor.Click += new System.EventHandler(this.btnUpdateDebtor_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 573);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(178, 60);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdateSource
            // 
            this.btnUpdateSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateSource.FlatAppearance.BorderSize = 0;
            this.btnUpdateSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSource.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSource.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnUpdateSource.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSource.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSource.IconSize = 32;
            this.btnUpdateSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSource.Location = new System.Drawing.Point(0, 265);
            this.btnUpdateSource.Name = "btnUpdateSource";
            this.btnUpdateSource.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUpdateSource.Size = new System.Drawing.Size(178, 60);
            this.btnUpdateSource.TabIndex = 3;
            this.btnUpdateSource.Text = "Update Source";
            this.btnUpdateSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateSource.UseVisualStyleBackColor = true;
            this.btnUpdateSource.Click += new System.EventHandler(this.btnUpdateSource_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTodo.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnTodo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTodo.IconSize = 32;
            this.btnTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodo.Location = new System.Drawing.Point(0, 205);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTodo.Size = new System.Drawing.Size(178, 60);
            this.btnTodo.TabIndex = 2;
            this.btnTodo.Text = "Update Clinician";
            this.btnTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnPackageGenerator
            // 
            this.btnPackageGenerator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPackageGenerator.FlatAppearance.BorderSize = 0;
            this.btnPackageGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackageGenerator.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPackageGenerator.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnPackageGenerator.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPackageGenerator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPackageGenerator.IconSize = 32;
            this.btnPackageGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackageGenerator.Location = new System.Drawing.Point(0, 145);
            this.btnPackageGenerator.Name = "btnPackageGenerator";
            this.btnPackageGenerator.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPackageGenerator.Size = new System.Drawing.Size(178, 60);
            this.btnPackageGenerator.TabIndex = 1;
            this.btnPackageGenerator.Text = "Package Generator";
            this.btnPackageGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackageGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPackageGenerator.UseVisualStyleBackColor = true;
            this.btnPackageGenerator.Click += new System.EventHandler(this.btnPackageGenerator_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.changePicBtn);
            this.panelLogo.Controls.Add(this.picbox);
            this.panelLogo.Controls.Add(this.framebox);
            this.panelLogo.Controls.Add(this.labelTitle2);
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(178, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // changePicBtn
            // 
            this.changePicBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePicBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.changePicBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.changePicBtn.IconColor = System.Drawing.Color.MediumPurple;
            this.changePicBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changePicBtn.IconSize = 15;
            this.changePicBtn.Location = new System.Drawing.Point(160, 4);
            this.changePicBtn.Name = "changePicBtn";
            this.changePicBtn.Size = new System.Drawing.Size(15, 18);
            this.changePicBtn.TabIndex = 7;
            this.changePicBtn.TabStop = false;
            this.changePicBtn.Click += new System.EventHandler(this.changePicBtn_Click);
            // 
            // picbox
            // 
            this.picbox.AllowFocused = false;
            this.picbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox.AutoSizeHeight = true;
            this.picbox.BackColor = System.Drawing.Color.Transparent;
            this.picbox.BorderRadius = 50;
            this.picbox.IsCircle = true;
            this.picbox.Location = new System.Drawing.Point(39, 11);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(100, 100);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picbox.Visible = false;
            this.picbox.MouseLeave += new System.EventHandler(this.picbox_MouseLeave);
            this.picbox.MouseHover += new System.EventHandler(this.picbox_MouseHover);
            // 
            // framebox
            // 
            this.framebox.AllowFocused = false;
            this.framebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.framebox.AutoSizeHeight = true;
            this.framebox.BorderRadius = 50;
            this.framebox.Image = global::AdminTools.Properties.Resources._14;
            this.framebox.IsCircle = true;
            this.framebox.Location = new System.Drawing.Point(41, 8);
            this.framebox.Name = "framebox";
            this.framebox.Size = new System.Drawing.Size(100, 100);
            this.framebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.framebox.TabIndex = 0;
            this.framebox.TabStop = false;
            this.framebox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.framebox.Visible = false;
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(228)))));
            this.labelTitle2.Location = new System.Drawing.Point(14, 108);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(150, 28);
            this.labelTitle2.TabIndex = 2;
            this.labelTitle2.Text = "IT ADMIN TOOL";
            this.labelTitle2.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(228)))));
            this.labelTitle.Location = new System.Drawing.Point(16, 93);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 28);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "IT ADMIN TOOL";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::AdminTools.Properties.Resources.product_development__1_;
            this.btnHome.Location = new System.Drawing.Point(56, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 75);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.sessionLabel);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(178, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(923, 66);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // sessionLabel
            // 
            this.sessionLabel.AllowParentOverrides = false;
            this.sessionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionLabel.AutoEllipsis = false;
            this.sessionLabel.AutoSize = false;
            this.sessionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.sessionLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.sessionLabel.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sessionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(228)))));
            this.sessionLabel.Location = new System.Drawing.Point(717, 38);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.sessionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sessionLabel.Size = new System.Drawing.Size(204, 27);
            this.sessionLabel.TabIndex = 6;
            this.sessionLabel.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.sessionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(890, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(855, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(818, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(55, 33);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(178, 66);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(923, 3);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(178, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(923, 564);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnPackageGenerator;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ImageList imageList1;
        private FontAwesome.Sharp.IconButton btnUpdateSource;
        private FontAwesome.Sharp.IconButton btnTodo;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuLabel sessionLabel;
        private FontAwesome.Sharp.IconButton btnUserManage;
        private FontAwesome.Sharp.IconButton btnUpdateDebtor;
        private Bunifu.UI.WinForms.BunifuPictureBox picbox;
        private System.Windows.Forms.Label labelTitle2;
        private Bunifu.UI.WinForms.BunifuPictureBox framebox;
        private FontAwesome.Sharp.IconPictureBox changePicBtn;
    }
}

