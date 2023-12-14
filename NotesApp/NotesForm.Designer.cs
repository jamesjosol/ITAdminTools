
using AdminTools.CustomControls;

namespace AdminTools
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.rjTextBox1 = new RJTextBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dataTable);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 51);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1062, 546);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // dataTable
            // 
            this.dataTable.AllowCustomTheming = false;
            this.dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.ColumnHeadersHeight = 40;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataTable.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dataTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataTable.CurrentTheme.Name = null;
            this.dataTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataTable.HeaderForeColor = System.Drawing.Color.White;
            this.dataTable.Location = new System.Drawing.Point(0, 3);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTable.RowTemplate.Height = 40;
            this.dataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(1059, 543);
            this.dataTable.TabIndex = 0;
            this.dataTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "NAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "EMAIL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PHONE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ADDRESS";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "COMPANY";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.dataTable;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1077, 54);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(19, 543);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 1;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(103)))), ((int)(((byte)(167)))));
            this.bunifuVScrollBar1.ThumbLength = 53;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox1.Location = new System.Drawing.Point(13, 15);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 5;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1108, 609);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.bunifuPanel1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataTable;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private RJTextBox rjTextBox1;
    }
}