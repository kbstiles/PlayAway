namespace SF_KStilesM2
{
    partial class frmManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerHome));
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnCodes = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.hlpManagerHome = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(552, 10);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(88, 39);
            this.lblHelp.TabIndex = 15;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(12, 7);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(148, 48);
            this.btnInventory.TabIndex = 62;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagers.Location = new System.Drawing.Point(178, 7);
            this.btnManagers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(148, 48);
            this.btnManagers.TabIndex = 63;
            this.btnManagers.Text = "Managers";
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Doppio One", 18.75F);
            this.btnCustomers.Location = new System.Drawing.Point(344, 7);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(148, 48);
            this.btnCustomers.TabIndex = 64;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(12, 65);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(148, 48);
            this.btnPOS.TabIndex = 65;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnCodes
            // 
            this.btnCodes.Font = new System.Drawing.Font("Doppio One", 12F);
            this.btnCodes.Location = new System.Drawing.Point(178, 65);
            this.btnCodes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Size = new System.Drawing.Size(148, 48);
            this.btnCodes.TabIndex = 66;
            this.btnCodes.Text = "Discount/Promo Codes";
            this.btnCodes.UseVisualStyleBackColor = true;
            this.btnCodes.Click += new System.EventHandler(this.btnCodes_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnReports.Location = new System.Drawing.Point(344, 65);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(148, 48);
            this.btnReports.TabIndex = 67;
            this.btnReports.Text = "Sales Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Doppio One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(521, 65);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 48);
            this.btnLogout.TabIndex = 68;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // hlpManagerHome
            // 
            this.hlpManagerHome.HelpNamespace = "Manager.chm";
            // 
            // frmManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(680, 120);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCodes);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblHelp);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.HelpProvider hlpManagerHome;
    }
}