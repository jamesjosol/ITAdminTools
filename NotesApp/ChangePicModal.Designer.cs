
namespace AdminTools
{
    partial class ChangePicModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePicModal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.uploadBtn = new FontAwesome.Sharp.IconButton();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(16, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(128)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.uploadBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.uploadBtn.IconColor = System.Drawing.Color.MediumPurple;
            this.uploadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.uploadBtn.IconSize = 32;
            this.uploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadBtn.Location = new System.Drawing.Point(131, 21);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.uploadBtn.Size = new System.Drawing.Size(250, 43);
            this.uploadBtn.TabIndex = 2;
            this.uploadBtn.Text = "    Upload Image";
            this.uploadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.saveBtn.IconColor = System.Drawing.Color.Lavender;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 32;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(131, 77);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.saveBtn.Size = new System.Drawing.Size(112, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "   Save";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeBtn.IconColor = System.Drawing.Color.Lavender;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 22;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(269, 77);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.closeBtn.Size = new System.Drawing.Size(112, 43);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "   Close";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ChangePicModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(407, 132);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePicModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePicModal";
            this.Load += new System.EventHandler(this.ChangePicModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private FontAwesome.Sharp.IconButton uploadBtn;
        private FontAwesome.Sharp.IconButton saveBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
    }
}