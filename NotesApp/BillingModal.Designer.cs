
namespace AdminTools
{
    partial class BillingModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingModal));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sourcecodeTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dataTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folder_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sourcecodeTxt
            // 
            this.sourcecodeTxt.AcceptsReturn = false;
            this.sourcecodeTxt.AcceptsTab = false;
            this.sourcecodeTxt.AnimationSpeed = 200;
            this.sourcecodeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sourcecodeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sourcecodeTxt.BackColor = System.Drawing.Color.Transparent;
            this.sourcecodeTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sourcecodeTxt.BackgroundImage")));
            this.sourcecodeTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.sourcecodeTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sourcecodeTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sourcecodeTxt.BorderColorIdle = System.Drawing.Color.DarkSlateBlue;
            this.sourcecodeTxt.BorderRadius = 1;
            this.sourcecodeTxt.BorderThickness = 1;
            this.sourcecodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sourcecodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourcecodeTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcecodeTxt.DefaultText = "";
            this.sourcecodeTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sourcecodeTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.sourcecodeTxt.HideSelection = true;
            this.sourcecodeTxt.IconLeft = null;
            this.sourcecodeTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sourcecodeTxt.IconPadding = 10;
            this.sourcecodeTxt.IconRight = null;
            this.sourcecodeTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sourcecodeTxt.Lines = new string[0];
            this.sourcecodeTxt.Location = new System.Drawing.Point(26, 12);
            this.sourcecodeTxt.MaxLength = 32767;
            this.sourcecodeTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.sourcecodeTxt.Modified = false;
            this.sourcecodeTxt.Multiline = false;
            this.sourcecodeTxt.Name = "sourcecodeTxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourcecodeTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.sourcecodeTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourcecodeTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkSlateBlue;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            stateProperties4.ForeColor = System.Drawing.Color.Gainsboro;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sourcecodeTxt.OnIdleState = stateProperties4;
            this.sourcecodeTxt.Padding = new System.Windows.Forms.Padding(3);
            this.sourcecodeTxt.PasswordChar = '\0';
            this.sourcecodeTxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sourcecodeTxt.PlaceholderText = "";
            this.sourcecodeTxt.ReadOnly = false;
            this.sourcecodeTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sourcecodeTxt.SelectedText = "";
            this.sourcecodeTxt.SelectionLength = 0;
            this.sourcecodeTxt.SelectionStart = 0;
            this.sourcecodeTxt.ShortcutsEnabled = true;
            this.sourcecodeTxt.Size = new System.Drawing.Size(230, 36);
            this.sourcecodeTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.sourcecodeTxt.TabIndex = 7;
            this.sourcecodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sourcecodeTxt.TextMarginBottom = 0;
            this.sourcecodeTxt.TextMarginLeft = 3;
            this.sourcecodeTxt.TextMarginTop = 0;
            this.sourcecodeTxt.TextPlaceholder = "";
            this.sourcecodeTxt.UseSystemPasswordChar = false;
            this.sourcecodeTxt.WordWrap = true;
            this.sourcecodeTxt.TextChanged += new System.EventHandler(this.sourcecodeTxt_TextChanged);
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
            this.code,
            this.name,
            this.term,
            this.folder_id});
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataTable.HeaderForeColor = System.Drawing.Color.White;
            this.dataTable.Location = new System.Drawing.Point(26, 54);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTable.RowTemplate.Height = 40;
            this.dataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(560, 331);
            this.dataTable.TabIndex = 8;
            this.dataTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dataTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentDoubleClick);
            this.dataTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataTable_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(576, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // term
            // 
            this.term.DataPropertyName = "term";
            this.term.HeaderText = "Term";
            this.term.Name = "term";
            this.term.Visible = false;
            // 
            // folder_id
            // 
            this.folder_id.DataPropertyName = "folder_id";
            this.folder_id.HeaderText = "FolderId";
            this.folder_id.Name = "folder_id";
            this.folder_id.Visible = false;
            // 
            // BillingModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(40)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.sourcecodeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BillingModal";
            this.Load += new System.EventHandler(this.BillingModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox sourcecodeTxt;
        private Bunifu.UI.WinForms.BunifuDataGridView dataTable;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewTextBoxColumn folder_id;
    }
}