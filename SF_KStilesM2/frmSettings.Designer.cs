namespace SF_KStilesM2
{
    partial class frmSettings
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
            this.btnOK = new System.Windows.Forms.Button();
            this.gbxColors = new System.Windows.Forms.GroupBox();
            this.rbtnDefault = new System.Windows.Forms.RadioButton();
            this.rbtnDark = new System.Windows.Forms.RadioButton();
            this.rbtnLight = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.hlpSettings = new System.Windows.Forms.HelpProvider();
            this.gbxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.btnOK.Location = new System.Drawing.Point(95, 197);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 38);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbxColors
            // 
            this.gbxColors.BackColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.gbxColors.Controls.Add(this.rbtnDefault);
            this.gbxColors.Controls.Add(this.rbtnDark);
            this.gbxColors.Controls.Add(this.rbtnLight);
            this.gbxColors.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gbxColors.Font = new System.Drawing.Font("Doppio One", 15F);
            this.gbxColors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxColors.Location = new System.Drawing.Point(14, 30);
            this.gbxColors.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbxColors.Name = "gbxColors";
            this.gbxColors.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbxColors.Size = new System.Drawing.Size(153, 157);
            this.gbxColors.TabIndex = 3;
            this.gbxColors.TabStop = false;
            this.gbxColors.Text = "Color Scheme";
            // 
            // rbtnDefault
            // 
            this.rbtnDefault.AutoSize = true;
            this.rbtnDefault.Location = new System.Drawing.Point(16, 35);
            this.rbtnDefault.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnDefault.Name = "rbtnDefault";
            this.rbtnDefault.Size = new System.Drawing.Size(100, 29);
            this.rbtnDefault.TabIndex = 2;
            this.rbtnDefault.Tag = "";
            this.rbtnDefault.Text = "Default";
            this.rbtnDefault.UseVisualStyleBackColor = true;
            // 
            // rbtnDark
            // 
            this.rbtnDark.AutoSize = true;
            this.rbtnDark.Location = new System.Drawing.Point(16, 113);
            this.rbtnDark.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnDark.Name = "rbtnDark";
            this.rbtnDark.Size = new System.Drawing.Size(130, 29);
            this.rbtnDark.TabIndex = 1;
            this.rbtnDark.Tag = "";
            this.rbtnDark.Text = "Dark Mode";
            this.rbtnDark.UseVisualStyleBackColor = true;
            // 
            // rbtnLight
            // 
            this.rbtnLight.AutoSize = true;
            this.rbtnLight.Location = new System.Drawing.Point(16, 74);
            this.rbtnLight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnLight.Name = "rbtnLight";
            this.rbtnLight.Size = new System.Drawing.Size(134, 29);
            this.rbtnLight.TabIndex = 0;
            this.rbtnLight.Tag = "";
            this.rbtnLight.Text = "Light Mode";
            this.rbtnLight.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTitle.Location = new System.Drawing.Point(8, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Settings";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.btnClose.Location = new System.Drawing.Point(13, 197);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 13F, System.Drawing.FontStyle.Underline);
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(122, 3);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(49, 22);
            this.lblHelp.TabIndex = 7;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // hlpSettings
            // 
            this.hlpSettings.HelpNamespace = "Logon.chm";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(181, 245);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxColors);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Doppio One", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.hlpSettings.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSettings";
            this.hlpSettings.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbxColors.ResumeLayout(false);
            this.gbxColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbxColors;
        private System.Windows.Forms.RadioButton rbtnDefault;
        private System.Windows.Forms.RadioButton rbtnDark;
        private System.Windows.Forms.RadioButton rbtnLight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.HelpProvider hlpSettings;
    }
}