namespace SF_KStilesM2
{
    partial class frmSalesReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReports));
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblTimeFrameLabel = new System.Windows.Forms.Label();
            this.cbxTimeFrameActual = new System.Windows.Forms.ComboBox();
            this.lblStartDateLabel = new System.Windows.Forms.Label();
            this.lblEndDateLabel = new System.Windows.Forms.Label();
            this.dtpStartDateActual = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtpEndDateActual = new System.Windows.Forms.DateTimePicker();
            this.btnPrintSales = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMiddle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonePrimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneSecondary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hlpSalesReports = new System.Windows.Forms.HelpProvider();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.SalePersonID,
            this.PersonName,
            this.OrderDate,
            this.CC_Number,
            this.InventoryID,
            this.ItemName,
            this.Quantity,
            this.RowTotal});
            this.dgvSales.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvSales.Location = new System.Drawing.Point(986, 80);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Doppio One", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1197, 535);
            this.dgvSales.TabIndex = 110;
            // 
            // lblTimeFrameLabel
            // 
            this.lblTimeFrameLabel.AutoSize = true;
            this.lblTimeFrameLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTimeFrameLabel.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblTimeFrameLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTimeFrameLabel.Location = new System.Drawing.Point(978, 17);
            this.lblTimeFrameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeFrameLabel.Name = "lblTimeFrameLabel";
            this.lblTimeFrameLabel.Size = new System.Drawing.Size(142, 29);
            this.lblTimeFrameLabel.TabIndex = 183;
            this.lblTimeFrameLabel.Text = "Time Frame:";
            // 
            // cbxTimeFrameActual
            // 
            this.cbxTimeFrameActual.DropDownHeight = 95;
            this.cbxTimeFrameActual.Font = new System.Drawing.Font("Doppio One", 15F);
            this.cbxTimeFrameActual.FormattingEnabled = true;
            this.cbxTimeFrameActual.IntegralHeight = false;
            this.cbxTimeFrameActual.Items.AddRange(new object[] {
            "All",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cbxTimeFrameActual.Location = new System.Drawing.Point(1200, 17);
            this.cbxTimeFrameActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTimeFrameActual.Name = "cbxTimeFrameActual";
            this.cbxTimeFrameActual.Size = new System.Drawing.Size(204, 33);
            this.cbxTimeFrameActual.TabIndex = 184;
            this.cbxTimeFrameActual.Text = "Time Frame";
            this.cbxTimeFrameActual.SelectedIndexChanged += new System.EventHandler(this.cbxTimeFrameActual_SelectedIndexChanged);
            // 
            // lblStartDateLabel
            // 
            this.lblStartDateLabel.AutoSize = true;
            this.lblStartDateLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblStartDateLabel.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblStartDateLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblStartDateLabel.Location = new System.Drawing.Point(980, 628);
            this.lblStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDateLabel.Name = "lblStartDateLabel";
            this.lblStartDateLabel.Size = new System.Drawing.Size(127, 29);
            this.lblStartDateLabel.TabIndex = 186;
            this.lblStartDateLabel.Text = "Start Date:";
            // 
            // lblEndDateLabel
            // 
            this.lblEndDateLabel.AutoSize = true;
            this.lblEndDateLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEndDateLabel.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblEndDateLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEndDateLabel.Location = new System.Drawing.Point(1602, 628);
            this.lblEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDateLabel.Name = "lblEndDateLabel";
            this.lblEndDateLabel.Size = new System.Drawing.Size(112, 29);
            this.lblEndDateLabel.TabIndex = 188;
            this.lblEndDateLabel.Text = "End Date:";
            // 
            // dtpStartDateActual
            // 
            this.dtpStartDateActual.CalendarFont = new System.Drawing.Font("Doppio One", 12F);
            this.dtpStartDateActual.Font = new System.Drawing.Font("Doppio One", 11F);
            this.dtpStartDateActual.Location = new System.Drawing.Point(1167, 631);
            this.dtpStartDateActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStartDateActual.Name = "dtpStartDateActual";
            this.dtpStartDateActual.Size = new System.Drawing.Size(409, 26);
            this.dtpStartDateActual.TabIndex = 189;
            this.dtpStartDateActual.Value = new System.DateTime(2024, 7, 23, 0, 0, 0, 0);
            this.dtpStartDateActual.ValueChanged += new System.EventHandler(this.dtpStartDateActual_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnSearch.Location = new System.Drawing.Point(651, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 62);
            this.btnSearch.TabIndex = 196;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnReset.Location = new System.Drawing.Point(818, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 62);
            this.btnReset.TabIndex = 195;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxSearch.Location = new System.Drawing.Point(134, 14);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(506, 32);
            this.tbxSearch.TabIndex = 194;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSearch.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblSearch.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSearch.Location = new System.Drawing.Point(3, 15);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 193;
            this.lblSearch.Text = "Search:";
            // 
            // dtpEndDateActual
            // 
            this.dtpEndDateActual.CalendarFont = new System.Drawing.Font("Doppio One", 12F);
            this.dtpEndDateActual.Enabled = false;
            this.dtpEndDateActual.Font = new System.Drawing.Font("Doppio One", 11F);
            this.dtpEndDateActual.Location = new System.Drawing.Point(1766, 631);
            this.dtpEndDateActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEndDateActual.Name = "dtpEndDateActual";
            this.dtpEndDateActual.Size = new System.Drawing.Size(410, 26);
            this.dtpEndDateActual.TabIndex = 197;
            this.dtpEndDateActual.Value = new System.DateTime(2024, 7, 23, 0, 0, 0, 0);
            // 
            // btnPrintSales
            // 
            this.btnPrintSales.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSales.Location = new System.Drawing.Point(1624, 6);
            this.btnPrintSales.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrintSales.Name = "btnPrintSales";
            this.btnPrintSales.Size = new System.Drawing.Size(184, 69);
            this.btnPrintSales.TabIndex = 200;
            this.btnPrintSales.Text = "Print";
            this.btnPrintSales.UseVisualStyleBackColor = true;
            this.btnPrintSales.Click += new System.EventHandler(this.btnPrintSales_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(1844, 6);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(184, 69);
            this.btnMain.TabIndex = 199;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(2062, 14);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(72, 32);
            this.lblHelp.TabIndex = 198;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.BackgroundColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.Title,
            this.NameFirst,
            this.NameMiddle,
            this.NameLast,
            this.Suffix,
            this.Address1,
            this.Address2,
            this.Address3,
            this.City,
            this.Zipcode,
            this.State,
            this.Email,
            this.PhonePrimary,
            this.PhoneSecondary,
            this.PersonDeleted});
            this.dgvCustomers.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvCustomers.Location = new System.Drawing.Point(18, 80);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Doppio One", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(945, 592);
            this.dgvCustomers.TabIndex = 201;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // PersonID
            // 
            this.PersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonID.Width = 87;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Title.Width = 54;
            // 
            // NameFirst
            // 
            this.NameFirst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameFirst.DataPropertyName = "NameFirst";
            this.NameFirst.HeaderText = "First Name";
            this.NameFirst.Name = "NameFirst";
            this.NameFirst.ReadOnly = true;
            this.NameFirst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameFirst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameFirst.Width = 97;
            // 
            // NameMiddle
            // 
            this.NameMiddle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameMiddle.DataPropertyName = "NameMiddle";
            this.NameMiddle.HeaderText = "Middle Name";
            this.NameMiddle.Name = "NameMiddle";
            this.NameMiddle.ReadOnly = true;
            this.NameMiddle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameMiddle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameMiddle.Width = 111;
            // 
            // NameLast
            // 
            this.NameLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameLast.DataPropertyName = "NameLast";
            this.NameLast.HeaderText = "Last Name";
            this.NameLast.Name = "NameLast";
            this.NameLast.ReadOnly = true;
            this.NameLast.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameLast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameLast.Width = 94;
            // 
            // Suffix
            // 
            this.Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Suffix.DataPropertyName = "Suffix";
            this.Suffix.HeaderText = "Suffix";
            this.Suffix.Name = "Suffix";
            this.Suffix.ReadOnly = true;
            this.Suffix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Suffix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Suffix.Width = 61;
            // 
            // Address1
            // 
            this.Address1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address 1";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            this.Address1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address1.Width = 84;
            // 
            // Address2
            // 
            this.Address2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address2.DataPropertyName = "Address2";
            this.Address2.HeaderText = "Address 2";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            this.Address2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address2.Width = 87;
            // 
            // Address3
            // 
            this.Address3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address3.DataPropertyName = "Address3";
            this.Address3.HeaderText = "Address 3";
            this.Address3.Name = "Address3";
            this.Address3.ReadOnly = true;
            this.Address3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address3.Width = 87;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.City.Width = 49;
            // 
            // Zipcode
            // 
            this.Zipcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Zipcode.DataPropertyName = "Zipcode";
            this.Zipcode.HeaderText = "Zipcode";
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.ReadOnly = true;
            this.Zipcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Zipcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Zipcode.Width = 83;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.State.Width = 61;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Width = 61;
            // 
            // PhonePrimary
            // 
            this.PhonePrimary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhonePrimary.DataPropertyName = "PhonePrimary";
            this.PhonePrimary.HeaderText = "Phone Primary";
            this.PhonePrimary.Name = "PhonePrimary";
            this.PhonePrimary.ReadOnly = true;
            this.PhonePrimary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhonePrimary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PhonePrimary.Width = 126;
            // 
            // PhoneSecondary
            // 
            this.PhoneSecondary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneSecondary.DataPropertyName = "PhoneSecondary";
            this.PhoneSecondary.HeaderText = "Phone Secondary";
            this.PhoneSecondary.Name = "PhoneSecondary";
            this.PhoneSecondary.ReadOnly = true;
            this.PhoneSecondary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhoneSecondary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PhoneSecondary.Width = 146;
            // 
            // PersonDeleted
            // 
            this.PersonDeleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonDeleted.DataPropertyName = "PersonDeleted";
            this.PersonDeleted.HeaderText = "Person Deleted";
            this.PersonDeleted.Name = "PersonDeleted";
            this.PersonDeleted.ReadOnly = true;
            this.PersonDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonDeleted.Width = 130;
            // 
            // hlpSalesReports
            // 
            this.hlpSalesReports.HelpNamespace = "Manager.chm";
            // 
            // OrderID
            // 
            this.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderID.Width = 84;
            // 
            // SalePersonID
            // 
            this.SalePersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalePersonID.DataPropertyName = "PersonID";
            this.SalePersonID.HeaderText = "Person ID";
            this.SalePersonID.Name = "SalePersonID";
            this.SalePersonID.ReadOnly = true;
            this.SalePersonID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalePersonID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SalePersonID.Width = 97;
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "Person Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonName.Width = 114;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderDate.Width = 96;
            // 
            // CC_Number
            // 
            this.CC_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CC_Number.DataPropertyName = "CC_Number";
            this.CC_Number.HeaderText = "CC Number";
            this.CC_Number.Name = "CC_Number";
            this.CC_Number.ReadOnly = true;
            this.CC_Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CC_Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CC_Number.Width = 96;
            // 
            // InventoryID
            // 
            this.InventoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryID.DataPropertyName = "InventoryID";
            this.InventoryID.HeaderText = "Inventory ID";
            this.InventoryID.Name = "InventoryID";
            this.InventoryID.ReadOnly = true;
            this.InventoryID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InventoryID.Width = 109;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemName.Width = 96;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 91;
            // 
            // RowTotal
            // 
            this.RowTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RowTotal.DataPropertyName = "RowTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.RowTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowTotal.HeaderText = "Row Total";
            this.RowTotal.Name = "RowTotal";
            this.RowTotal.ReadOnly = true;
            this.RowTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RowTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RowTotal.Width = 89;
            // 
            // frmSalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(1940, 685);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnPrintSales);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.dtpEndDateActual);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dtpStartDateActual);
            this.Controls.Add(this.lblEndDateLabel);
            this.Controls.Add(this.cbxTimeFrameActual);
            this.Controls.Add(this.lblTimeFrameLabel);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblStartDateLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSalesReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesReports_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.frmSalesReports_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblTimeFrameLabel;
        private System.Windows.Forms.ComboBox cbxTimeFrameActual;
        private System.Windows.Forms.Label lblStartDateLabel;
        private System.Windows.Forms.Label lblEndDateLabel;
        private System.Windows.Forms.DateTimePicker dtpStartDateActual;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDateActual;
        private System.Windows.Forms.Button btnPrintSales;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.HelpProvider hlpSalesReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMiddle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address3;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonePrimary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneSecondary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowTotal;
    }
}