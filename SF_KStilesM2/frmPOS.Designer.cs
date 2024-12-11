namespace SF_KStilesM2
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.hlpPOS = new System.Windows.Forms.HelpProvider();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnSearch.Location = new System.Drawing.Point(437, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 40);
            this.btnSearch.TabIndex = 105;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnClear.Location = new System.Drawing.Point(548, 7);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 40);
            this.btnClear.TabIndex = 104;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxSearch.Location = new System.Drawing.Point(92, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(339, 32);
            this.tbxSearch.TabIndex = 103;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSearch.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblSearch.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSearch.Location = new System.Drawing.Point(5, 13);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 102;
            this.lblSearch.Text = "Search:";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(401, 415);
            this.btnMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(123, 45);
            this.btnMain.TabIndex = 107;
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
            this.lblHelp.Location = new System.Drawing.Point(553, 422);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(72, 32);
            this.lblHelp.TabIndex = 106;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.Enabled = false;
            this.btnChooseCustomer.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseCustomer.Location = new System.Drawing.Point(46, 415);
            this.btnChooseCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(227, 45);
            this.btnChooseCustomer.TabIndex = 108;
            this.btnChooseCustomer.Text = "Use Customer";
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvCustomers.Location = new System.Drawing.Point(7, 53);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Doppio One", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(630, 356);
            this.dgvCustomers.TabIndex = 111;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // hlpPOS
            // 
            this.hlpPOS.HelpNamespace = "Manager.chm";
            // 
            // PersonID
            // 
            this.PersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PersonID.Width = 97;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.NameFirst.HeaderText = "First Name";
            this.NameFirst.Name = "NameFirst";
            this.NameFirst.ReadOnly = true;
            this.NameFirst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameFirst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameFirst.Width = 108;
            // 
            // NameMiddle
            // 
            this.NameMiddle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameMiddle.HeaderText = "Middle Name";
            this.NameMiddle.Name = "NameMiddle";
            this.NameMiddle.ReadOnly = true;
            this.NameMiddle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameMiddle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameMiddle.Width = 123;
            // 
            // NameLast
            // 
            this.NameLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameLast.HeaderText = "Last Name";
            this.NameLast.Name = "NameLast";
            this.NameLast.ReadOnly = true;
            this.NameLast.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameLast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameLast.Width = 104;
            // 
            // Suffix
            // 
            this.Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.Address1.HeaderText = "Address 1";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            this.Address1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address1.Width = 93;
            // 
            // Address2
            // 
            this.Address2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address2.HeaderText = "Address 2";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            this.Address2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address2.Width = 96;
            // 
            // Address3
            // 
            this.Address3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address3.HeaderText = "Address 3";
            this.Address3.Name = "Address3";
            this.Address3.ReadOnly = true;
            this.Address3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address3.Width = 96;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.PersonDeleted.HeaderText = "Person Deleted";
            this.PersonDeleted.Name = "PersonDeleted";
            this.PersonDeleted.ReadOnly = true;
            this.PersonDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonDeleted.Width = 130;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(644, 466);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnChooseCustomer);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.VisibleChanged += new System.EventHandler(this.frmPOS_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnChooseCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.HelpProvider hlpPOS;
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
    }
}