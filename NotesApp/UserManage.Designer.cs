
namespace AdminTools
{
    partial class UserManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtUserID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtUserType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtStatus = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.saveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowCustomTheming = false;
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.ColumnHeadersHeight = 40;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column1,
            this.Column7});
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataTable.HeaderForeColor = System.Drawing.Color.White;
            this.dataTable.Location = new System.Drawing.Point(12, 141);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowTemplate.Height = 40;
            this.dataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(903, 438);
            this.dataTable.TabIndex = 1;
            this.dataTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dataTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentDoubleClick);
            // 
            // txtUserID
            // 
            this.txtUserID.AcceptsReturn = false;
            this.txtUserID.AcceptsTab = false;
            this.txtUserID.AnimationSpeed = 200;
            this.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserID.BackColor = System.Drawing.Color.Transparent;
            this.txtUserID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUserID.BackgroundImage")));
            this.txtUserID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUserID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUserID.BorderColorIdle = System.Drawing.Color.DarkSlateBlue;
            this.txtUserID.BorderRadius = 1;
            this.txtUserID.BorderThickness = 1;
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUserID.DefaultText = "";
            this.txtUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtUserID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUserID.HideSelection = true;
            this.txtUserID.IconLeft = null;
            this.txtUserID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.IconPadding = 10;
            this.txtUserID.IconRight = null;
            this.txtUserID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.Lines = new string[0];
            this.txtUserID.Location = new System.Drawing.Point(92, 29);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUserID.Modified = false;
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkSlateBlue;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            stateProperties4.ForeColor = System.Drawing.Color.Gainsboro;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUserID.OnIdleState = stateProperties4;
            this.txtUserID.Padding = new System.Windows.Forms.Padding(3);
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.ShortcutsEnabled = true;
            this.txtUserID.Size = new System.Drawing.Size(188, 40);
            this.txtUserID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUserID.TabIndex = 95;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.TextMarginBottom = 0;
            this.txtUserID.TextMarginLeft = 3;
            this.txtUserID.TextMarginTop = 0;
            this.txtUserID.TextPlaceholder = "";
            this.txtUserID.UseSystemPasswordChar = false;
            this.txtUserID.WordWrap = true;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel6.Location = new System.Drawing.Point(12, 38);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(60, 21);
            this.bunifuLabel6.TabIndex = 94;
            this.bunifuLabel6.Text = "USER ID:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel1.Location = new System.Drawing.Point(294, 38);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(79, 21);
            this.bunifuLabel1.TabIndex = 96;
            this.bunifuLabel1.Text = "USER TYPE:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtUserType
            // 
            this.txtUserType.BackColor = System.Drawing.Color.Transparent;
            this.txtUserType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtUserType.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtUserType.BorderRadius = 1;
            this.txtUserType.Color = System.Drawing.Color.DarkSlateBlue;
            this.txtUserType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.txtUserType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUserType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUserType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.txtUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtUserType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.txtUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUserType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtUserType.FillDropDown = true;
            this.txtUserType.FillIndicator = false;
            this.txtUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserType.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUserType.FormattingEnabled = true;
            this.txtUserType.Icon = null;
            this.txtUserType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtUserType.IndicatorColor = System.Drawing.Color.LightGray;
            this.txtUserType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtUserType.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtUserType.ItemBorderColor = System.Drawing.Color.White;
            this.txtUserType.ItemForeColor = System.Drawing.Color.Gainsboro;
            this.txtUserType.ItemHeight = 32;
            this.txtUserType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.txtUserType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.txtUserType.Items.AddRange(new object[] {
            "USER",
            "ADMIN",
            "SUPERADMIN"});
            this.txtUserType.ItemTopMargin = 3;
            this.txtUserType.Location = new System.Drawing.Point(391, 31);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(203, 38);
            this.txtUserType.TabIndex = 139;
            this.txtUserType.Text = null;
            this.txtUserType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtUserType.TextLeftMargin = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtStatus.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtStatus.BorderRadius = 1;
            this.txtStatus.Color = System.Drawing.Color.DarkSlateBlue;
            this.txtStatus.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.txtStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtStatus.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.txtStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtStatus.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtStatus.FillDropDown = true;
            this.txtStatus.FillIndicator = false;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Icon = null;
            this.txtStatus.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtStatus.IndicatorColor = System.Drawing.Color.LightGray;
            this.txtStatus.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtStatus.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtStatus.ItemBorderColor = System.Drawing.Color.White;
            this.txtStatus.ItemForeColor = System.Drawing.Color.Gainsboro;
            this.txtStatus.ItemHeight = 32;
            this.txtStatus.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.txtStatus.ItemHighLightForeColor = System.Drawing.Color.White;
            this.txtStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.txtStatus.ItemTopMargin = 3;
            this.txtStatus.Location = new System.Drawing.Point(701, 31);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(190, 38);
            this.txtStatus.TabIndex = 140;
            this.txtStatus.Text = null;
            this.txtStatus.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtStatus.TextLeftMargin = 5;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(613, 38);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(58, 21);
            this.bunifuLabel2.TabIndex = 141;
            this.bunifuLabel2.Text = "STATUS:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // saveBtn
            // 
            this.saveBtn.AllowAnimations = true;
            this.saveBtn.AllowMouseEffects = true;
            this.saveBtn.AllowToggling = false;
            this.saveBtn.AnimationSpeed = 200;
            this.saveBtn.AutoGenerateColors = false;
            this.saveBtn.AutoRoundBorders = false;
            this.saveBtn.AutoSizeLeftIcon = true;
            this.saveBtn.AutoSizeRightIcon = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.ButtonText = "   SAVE";
            this.saveBtn.ButtonTextMarginLeft = 0;
            this.saveBtn.ColorContrastOnClick = 45;
            this.saveBtn.ColorContrastOnHover = 45;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.saveBtn.CustomizableEdges = borderEdges1;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveBtn.IconMarginLeft = 11;
            this.saveBtn.IconPadding = 10;
            this.saveBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveBtn.IconSize = 25;
            this.saveBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.IdleBorderRadius = 1;
            this.saveBtn.IdleBorderThickness = 1;
            this.saveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.IdleIconLeftImage = global::AdminTools.Properties.Resources.diskette__1_;
            this.saveBtn.IdleIconRightImage = null;
            this.saveBtn.IndicateFocus = false;
            this.saveBtn.Location = new System.Drawing.Point(780, 86);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBtn.OnDisabledState.BorderRadius = 1;
            this.saveBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnDisabledState.BorderThickness = 1;
            this.saveBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBtn.OnDisabledState.IconLeftImage = null;
            this.saveBtn.OnDisabledState.IconRightImage = null;
            this.saveBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveBtn.onHoverState.BorderRadius = 1;
            this.saveBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.onHoverState.BorderThickness = 1;
            this.saveBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.onHoverState.IconLeftImage = null;
            this.saveBtn.onHoverState.IconRightImage = null;
            this.saveBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.OnIdleState.BorderRadius = 1;
            this.saveBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnIdleState.BorderThickness = 1;
            this.saveBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.OnIdleState.IconLeftImage = global::AdminTools.Properties.Resources.diskette__1_;
            this.saveBtn.OnIdleState.IconRightImage = null;
            this.saveBtn.OnPressedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.OnPressedState.BorderRadius = 1;
            this.saveBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnPressedState.BorderThickness = 1;
            this.saveBtn.OnPressedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.OnPressedState.IconLeftImage = null;
            this.saveBtn.OnPressedState.IconRightImage = null;
            this.saveBtn.Size = new System.Drawing.Size(111, 34);
            this.saveBtn.TabIndex = 142;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.TextMarginLeft = 0;
            this.saveBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveBtn.UseDefaultRadiusAndThickness = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.clearBtn.IconColor = System.Drawing.Color.White;
            this.clearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearBtn.IconSize = 25;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(652, 86);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.clearBtn.Size = new System.Drawing.Size(107, 34);
            this.clearBtn.TabIndex = 139;
            this.clearBtn.Text = "  CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserID";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 95.65367F;
            this.Column2.HeaderText = "USER ID";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserType";
            this.Column3.FillWeight = 129.4518F;
            this.Column3.HeaderText = "USER TYPE";
            this.Column3.MinimumWidth = 120;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "UpdatedBy";
            this.Column6.FillWeight = 13.0249F;
            this.Column6.HeaderText = "UPDATED BY";
            this.Column6.MinimumWidth = 150;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UpdatedOn";
            this.Column1.FillWeight = 38.52614F;
            this.Column1.HeaderText = "UPDATED ON";
            this.Column1.MinimumWidth = 210;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Active";
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "STATUS";
            this.Column7.MinimumWidth = 70;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(927, 591);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.dataTable);
            this.Name = "UserManage";
            this.Text = "UserManage";
            this.Load += new System.EventHandler(this.UserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dataTable;
        private Bunifu.UI.WinForms.BunifuTextBox txtUserID;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown txtUserType;
        private Bunifu.UI.WinForms.BunifuDropdown txtStatus;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBtn;
        private FontAwesome.Sharp.IconButton clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}