
namespace AdminTools
{
    partial class LoaderDialogSM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderDialogSM));
            this.labelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AllowParentOverrides = false;
            this.labelTitle.AutoEllipsis = false;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTitle.ForeColor = System.Drawing.Color.Silver;
            this.labelTitle.Location = new System.Drawing.Point(63, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitle.Size = new System.Drawing.Size(33, 21);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "TEXT";
            this.labelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(12, 10);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(40, 41);
            this.bunifuLoader1.Speed = 5;
            this.bunifuLoader1.TabIndex = 3;
            this.bunifuLoader1.Text = "bunifuLoader1";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 6;
            this.bunifuLoader1.Transparent = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoaderDialogSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(160, 59);
            this.Controls.Add(this.bunifuLoader1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaderDialogSM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoaderDialogSM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel labelTitle;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}