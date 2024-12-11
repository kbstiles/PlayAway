namespace SF_KStilesM2
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequiredInstructions = new System.Windows.Forms.Label();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.lblValidPassword = new System.Windows.Forms.Label();
            this.lblValidUsername = new System.Windows.Forms.Label();
            this.lblValidPhoneSecondary = new System.Windows.Forms.Label();
            this.lblValidPhonePrimary = new System.Windows.Forms.Label();
            this.lblValidEmail = new System.Windows.Forms.Label();
            this.lblValidState = new System.Windows.Forms.Label();
            this.lblValidZipcode = new System.Windows.Forms.Label();
            this.lblValidCity = new System.Windows.Forms.Label();
            this.lblValidAddress = new System.Windows.Forms.Label();
            this.tbxPhoneSecondary = new System.Windows.Forms.TextBox();
            this.tbxPhonePrimary = new System.Windows.Forms.TextBox();
            this.cbxThirdChallengeQuestion = new System.Windows.Forms.ComboBox();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.cbxSecondChallengeQuestion = new System.Windows.Forms.ComboBox();
            this.lblRequired6 = new System.Windows.Forms.Label();
            this.cbxFirstChallengeQuestion = new System.Windows.Forms.ComboBox();
            this.lblRequired5 = new System.Windows.Forms.Label();
            this.lblRequired14 = new System.Windows.Forms.Label();
            this.lblRequired4 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblRequired13 = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPhoneSecondary = new System.Windows.Forms.Label();
            this.tbxThirdChallengeAnswer = new System.Windows.Forms.TextBox();
            this.lblPhonePrimary = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblThirdChallengeAnswer = new System.Windows.Forms.Label();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblThirdChallengeQuestion = new System.Windows.Forms.Label();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblRequired12 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRequired11 = new System.Windows.Forms.Label();
            this.tbxSecondChallengeAnswer = new System.Windows.Forms.TextBox();
            this.lblSecondChallengeAnswer = new System.Windows.Forms.Label();
            this.lblSecondChallengeQuestion = new System.Windows.Forms.Label();
            this.lblRequired10 = new System.Windows.Forms.Label();
            this.llRequired9 = new System.Windows.Forms.Label();
            this.lblRequired8 = new System.Windows.Forms.Label();
            this.lblRequired7 = new System.Windows.Forms.Label();
            this.lblCreateUsername = new System.Windows.Forms.Label();
            this.tbxFirstChallengeAnswer = new System.Windows.Forms.TextBox();
            this.tbxCreateUsername = new System.Windows.Forms.TextBox();
            this.lblFirstChallengeAnswer = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblFirstChallengeQuestion = new System.Windows.Forms.Label();
            this.tbxCreatePassword = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.hlpCreateAccount = new System.Windows.Forms.HelpProvider();
            this.pnlCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Font = new System.Drawing.Font("Doppio One", 17.25F);
            this.lblTitle.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTitle.Location = new System.Drawing.Point(4, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTitle.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxTitle.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitle.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxTitle.Location = new System.Drawing.Point(78, 6);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitle.MaxLength = 15;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(182, 32);
            this.tbxTitle.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxFirstName.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxFirstName.Location = new System.Drawing.Point(146, 45);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(229, 32);
            this.tbxFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstName.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblFirstName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblFirstName.Location = new System.Drawing.Point(4, 44);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(134, 29);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxMiddleName.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMiddleName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxMiddleName.Location = new System.Drawing.Point(167, 85);
            this.tbxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(231, 32);
            this.tbxMiddleName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMiddleName.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblMiddleName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblMiddleName.Location = new System.Drawing.Point(4, 84);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(155, 29);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxLastName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxLastName.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxLastName.Location = new System.Drawing.Point(143, 125);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(233, 32);
            this.tbxLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastName.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblLastName.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblLastName.Location = new System.Drawing.Point(4, 124);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(131, 29);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSuffix.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxSuffix.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxSuffix.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSuffix.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxSuffix.Location = new System.Drawing.Point(96, 165);
            this.tbxSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSuffix.MaxLength = 20;
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(240, 32);
            this.tbxSuffix.TabIndex = 9;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSuffix.Font = new System.Drawing.Font("Doppio One", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSuffix.Location = new System.Drawing.Point(4, 164);
            this.lblSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(84, 29);
            this.lblSuffix.TabIndex = 8;
            this.lblSuffix.Text = "Suffix:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddress.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddress.Location = new System.Drawing.Point(113, 205);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.MaxLength = 92;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(372, 84);
            this.tbxAddress.TabIndex = 11;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddress.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblAddress.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddress.Location = new System.Drawing.Point(4, 204);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(101, 29);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Doppio One", 20F);
            this.btnBack.Location = new System.Drawing.Point(199, 532);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 46);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Doppio One", 20F);
            this.btnAdd.Location = new System.Drawing.Point(297, 532);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 46);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Doppio One", 20F);
            this.btnClear.Location = new System.Drawing.Point(11, 525);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 60);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear PAGE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired1.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(381, 48);
            this.lblRequired1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired1.Name = "lblRequired1";
            this.hlpCreateAccount.SetShowHelp(this.lblRequired1, false);
            this.lblRequired1.Size = new System.Drawing.Size(18, 24);
            this.lblRequired1.TabIndex = 33;
            this.lblRequired1.Text = "*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired2.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(382, 128);
            this.lblRequired2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(18, 24);
            this.lblRequired2.TabIndex = 35;
            this.lblRequired2.Text = "*";
            // 
            // lblRequiredInstructions
            // 
            this.lblRequiredInstructions.BackColor = System.Drawing.Color.White;
            this.lblRequiredInstructions.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblRequiredInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredInstructions.Location = new System.Drawing.Point(400, 539);
            this.lblRequiredInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequiredInstructions.Name = "lblRequiredInstructions";
            this.lblRequiredInstructions.Size = new System.Drawing.Size(119, 32);
            this.lblRequiredInstructions.TabIndex = 42;
            this.lblRequiredInstructions.Text = "* REQUIRED";
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.pnlCreate.Controls.Add(this.lblValidPassword);
            this.pnlCreate.Controls.Add(this.lblValidUsername);
            this.pnlCreate.Controls.Add(this.lblValidPhoneSecondary);
            this.pnlCreate.Controls.Add(this.lblValidPhonePrimary);
            this.pnlCreate.Controls.Add(this.lblValidEmail);
            this.pnlCreate.Controls.Add(this.lblValidState);
            this.pnlCreate.Controls.Add(this.lblValidZipcode);
            this.pnlCreate.Controls.Add(this.lblValidCity);
            this.pnlCreate.Controls.Add(this.lblValidAddress);
            this.pnlCreate.Controls.Add(this.tbxPhoneSecondary);
            this.pnlCreate.Controls.Add(this.tbxPhonePrimary);
            this.pnlCreate.Controls.Add(this.cbxThirdChallengeQuestion);
            this.pnlCreate.Controls.Add(this.lblRequired3);
            this.pnlCreate.Controls.Add(this.cbxSecondChallengeQuestion);
            this.pnlCreate.Controls.Add(this.tbxTitle);
            this.pnlCreate.Controls.Add(this.lblRequired6);
            this.pnlCreate.Controls.Add(this.cbxFirstChallengeQuestion);
            this.pnlCreate.Controls.Add(this.lblRequired5);
            this.pnlCreate.Controls.Add(this.lblRequired14);
            this.pnlCreate.Controls.Add(this.lblRequired4);
            this.pnlCreate.Controls.Add(this.lblTitle);
            this.pnlCreate.Controls.Add(this.btnImage);
            this.pnlCreate.Controls.Add(this.lblRequired13);
            this.pnlCreate.Controls.Add(this.lblImage);
            this.pnlCreate.Controls.Add(this.lblRequired2);
            this.pnlCreate.Controls.Add(this.lblPhoneSecondary);
            this.pnlCreate.Controls.Add(this.tbxThirdChallengeAnswer);
            this.pnlCreate.Controls.Add(this.lblPhonePrimary);
            this.pnlCreate.Controls.Add(this.lblFirstName);
            this.pnlCreate.Controls.Add(this.tbxEmail);
            this.pnlCreate.Controls.Add(this.lblEmail);
            this.pnlCreate.Controls.Add(this.lblThirdChallengeAnswer);
            this.pnlCreate.Controls.Add(this.tbxState);
            this.pnlCreate.Controls.Add(this.tbxFirstName);
            this.pnlCreate.Controls.Add(this.lblState);
            this.pnlCreate.Controls.Add(this.lblThirdChallengeQuestion);
            this.pnlCreate.Controls.Add(this.tbxZipCode);
            this.pnlCreate.Controls.Add(this.lblRequired1);
            this.pnlCreate.Controls.Add(this.lblZipCode);
            this.pnlCreate.Controls.Add(this.lblRequired12);
            this.pnlCreate.Controls.Add(this.tbxCity);
            this.pnlCreate.Controls.Add(this.lblMiddleName);
            this.pnlCreate.Controls.Add(this.lblCity);
            this.pnlCreate.Controls.Add(this.lblRequired11);
            this.pnlCreate.Controls.Add(this.tbxMiddleName);
            this.pnlCreate.Controls.Add(this.tbxSecondChallengeAnswer);
            this.pnlCreate.Controls.Add(this.lblLastName);
            this.pnlCreate.Controls.Add(this.lblSecondChallengeAnswer);
            this.pnlCreate.Controls.Add(this.tbxLastName);
            this.pnlCreate.Controls.Add(this.lblSecondChallengeQuestion);
            this.pnlCreate.Controls.Add(this.lblSuffix);
            this.pnlCreate.Controls.Add(this.lblRequired10);
            this.pnlCreate.Controls.Add(this.tbxSuffix);
            this.pnlCreate.Controls.Add(this.llRequired9);
            this.pnlCreate.Controls.Add(this.lblAddress);
            this.pnlCreate.Controls.Add(this.lblRequired8);
            this.pnlCreate.Controls.Add(this.tbxAddress);
            this.pnlCreate.Controls.Add(this.lblRequired7);
            this.pnlCreate.Controls.Add(this.lblCreateUsername);
            this.pnlCreate.Controls.Add(this.tbxFirstChallengeAnswer);
            this.pnlCreate.Controls.Add(this.tbxCreateUsername);
            this.pnlCreate.Controls.Add(this.lblFirstChallengeAnswer);
            this.pnlCreate.Controls.Add(this.lblCreatePassword);
            this.pnlCreate.Controls.Add(this.lblFirstChallengeQuestion);
            this.pnlCreate.Controls.Add(this.tbxCreatePassword);
            this.pnlCreate.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlCreate.Font = new System.Drawing.Font("Doppio One", 12F);
            this.pnlCreate.Location = new System.Drawing.Point(16, 8);
            this.pnlCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(582, 511);
            this.pnlCreate.TabIndex = 43;
            // 
            // lblValidPassword
            // 
            this.lblValidPassword.AutoSize = true;
            this.lblValidPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblValidPassword.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblValidPassword.Location = new System.Drawing.Point(361, 542);
            this.lblValidPassword.Name = "lblValidPassword";
            this.lblValidPassword.Size = new System.Drawing.Size(30, 34);
            this.lblValidPassword.TabIndex = 121;
            this.lblValidPassword.Text = "X";
            // 
            // lblValidUsername
            // 
            this.lblValidUsername.AutoSize = true;
            this.lblValidUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblValidUsername.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidUsername.ForeColor = System.Drawing.Color.Red;
            this.lblValidUsername.Location = new System.Drawing.Point(367, 499);
            this.lblValidUsername.Name = "lblValidUsername";
            this.lblValidUsername.Size = new System.Drawing.Size(30, 34);
            this.lblValidUsername.TabIndex = 117;
            this.lblValidUsername.Text = "X";
            // 
            // lblValidPhoneSecondary
            // 
            this.lblValidPhoneSecondary.AutoSize = true;
            this.lblValidPhoneSecondary.BackColor = System.Drawing.Color.Transparent;
            this.lblValidPhoneSecondary.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidPhoneSecondary.ForeColor = System.Drawing.Color.Green;
            this.lblValidPhoneSecondary.Location = new System.Drawing.Point(440, 458);
            this.lblValidPhoneSecondary.Name = "lblValidPhoneSecondary";
            this.lblValidPhoneSecondary.Size = new System.Drawing.Size(30, 34);
            this.lblValidPhoneSecondary.TabIndex = 113;
            this.lblValidPhoneSecondary.Text = "O";
            this.lblValidPhoneSecondary.Visible = false;
            // 
            // lblValidPhonePrimary
            // 
            this.lblValidPhonePrimary.AutoSize = true;
            this.lblValidPhonePrimary.BackColor = System.Drawing.Color.Transparent;
            this.lblValidPhonePrimary.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidPhonePrimary.ForeColor = System.Drawing.Color.Green;
            this.lblValidPhonePrimary.Location = new System.Drawing.Point(415, 417);
            this.lblValidPhonePrimary.Name = "lblValidPhonePrimary";
            this.lblValidPhonePrimary.Size = new System.Drawing.Size(30, 34);
            this.lblValidPhonePrimary.TabIndex = 110;
            this.lblValidPhonePrimary.Text = "O";
            this.lblValidPhonePrimary.Visible = false;
            // 
            // lblValidEmail
            // 
            this.lblValidEmail.AutoSize = true;
            this.lblValidEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEmail.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidEmail.ForeColor = System.Drawing.Color.Green;
            this.lblValidEmail.Location = new System.Drawing.Point(541, 375);
            this.lblValidEmail.Name = "lblValidEmail";
            this.lblValidEmail.Size = new System.Drawing.Size(30, 34);
            this.lblValidEmail.TabIndex = 106;
            this.lblValidEmail.Text = "O";
            this.lblValidEmail.Visible = false;
            // 
            // lblValidState
            // 
            this.lblValidState.AutoSize = true;
            this.lblValidState.BackColor = System.Drawing.Color.Transparent;
            this.lblValidState.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidState.ForeColor = System.Drawing.Color.Red;
            this.lblValidState.Location = new System.Drawing.Point(447, 337);
            this.lblValidState.Name = "lblValidState";
            this.lblValidState.Size = new System.Drawing.Size(30, 34);
            this.lblValidState.TabIndex = 91;
            this.lblValidState.Text = "X";
            // 
            // lblValidZipcode
            // 
            this.lblValidZipcode.AutoSize = true;
            this.lblValidZipcode.BackColor = System.Drawing.Color.Transparent;
            this.lblValidZipcode.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidZipcode.ForeColor = System.Drawing.Color.Red;
            this.lblValidZipcode.Location = new System.Drawing.Point(248, 337);
            this.lblValidZipcode.Name = "lblValidZipcode";
            this.lblValidZipcode.Size = new System.Drawing.Size(30, 34);
            this.lblValidZipcode.TabIndex = 90;
            this.lblValidZipcode.Text = "X";
            // 
            // lblValidCity
            // 
            this.lblValidCity.AutoSize = true;
            this.lblValidCity.BackColor = System.Drawing.Color.Transparent;
            this.lblValidCity.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidCity.ForeColor = System.Drawing.Color.Red;
            this.lblValidCity.Location = new System.Drawing.Point(432, 293);
            this.lblValidCity.Name = "lblValidCity";
            this.lblValidCity.Size = new System.Drawing.Size(30, 34);
            this.lblValidCity.TabIndex = 89;
            this.lblValidCity.Text = "X";
            // 
            // lblValidAddress
            // 
            this.lblValidAddress.AutoSize = true;
            this.lblValidAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddress.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidAddress.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddress.Location = new System.Drawing.Point(489, 201);
            this.lblValidAddress.Name = "lblValidAddress";
            this.lblValidAddress.Size = new System.Drawing.Size(30, 34);
            this.lblValidAddress.TabIndex = 88;
            this.lblValidAddress.Text = "X";
            // 
            // tbxPhoneSecondary
            // 
            this.tbxPhoneSecondary.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxPhoneSecondary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhoneSecondary.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxPhoneSecondary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxPhoneSecondary.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneSecondary.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxPhoneSecondary.Location = new System.Drawing.Point(207, 462);
            this.tbxPhoneSecondary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhoneSecondary.MaxLength = 10;
            this.tbxPhoneSecondary.Name = "tbxPhoneSecondary";
            this.tbxPhoneSecondary.Size = new System.Drawing.Size(229, 32);
            this.tbxPhoneSecondary.TabIndex = 87;
            this.tbxPhoneSecondary.TextChanged += new System.EventHandler(this.tbxPhoneSecondary_TextChanged);
            this.tbxPhoneSecondary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneSecondary_KeyPress);
            // 
            // tbxPhonePrimary
            // 
            this.tbxPhonePrimary.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxPhonePrimary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhonePrimary.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxPhonePrimary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxPhonePrimary.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhonePrimary.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxPhonePrimary.Location = new System.Drawing.Point(183, 421);
            this.tbxPhonePrimary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhonePrimary.MaxLength = 10;
            this.tbxPhonePrimary.Name = "tbxPhonePrimary";
            this.tbxPhonePrimary.Size = new System.Drawing.Size(229, 32);
            this.tbxPhonePrimary.TabIndex = 86;
            this.tbxPhonePrimary.TextChanged += new System.EventHandler(this.tbxPhonePrimary_TextChanged);
            this.tbxPhonePrimary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhonePrimary_KeyPress);
            // 
            // cbxThirdChallengeQuestion
            // 
            this.cbxThirdChallengeQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThirdChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThirdChallengeQuestion.FormattingEnabled = true;
            this.cbxThirdChallengeQuestion.Location = new System.Drawing.Point(245, 755);
            this.cbxThirdChallengeQuestion.Name = "cbxThirdChallengeQuestion";
            this.cbxThirdChallengeQuestion.Size = new System.Drawing.Size(287, 33);
            this.cbxThirdChallengeQuestion.TabIndex = 79;
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired3.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired3.ForeColor = System.Drawing.Color.Red;
            this.lblRequired3.Location = new System.Drawing.Point(522, 209);
            this.lblRequired3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(18, 24);
            this.lblRequired3.TabIndex = 36;
            this.lblRequired3.Text = "*";
            // 
            // cbxSecondChallengeQuestion
            // 
            this.cbxSecondChallengeQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSecondChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSecondChallengeQuestion.FormattingEnabled = true;
            this.cbxSecondChallengeQuestion.Location = new System.Drawing.Point(245, 672);
            this.cbxSecondChallengeQuestion.Name = "cbxSecondChallengeQuestion";
            this.cbxSecondChallengeQuestion.Size = new System.Drawing.Size(287, 33);
            this.cbxSecondChallengeQuestion.TabIndex = 78;
            // 
            // lblRequired6
            // 
            this.lblRequired6.AutoSize = true;
            this.lblRequired6.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired6.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired6.ForeColor = System.Drawing.Color.Red;
            this.lblRequired6.Location = new System.Drawing.Point(479, 343);
            this.lblRequired6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired6.Name = "lblRequired6";
            this.lblRequired6.Size = new System.Drawing.Size(18, 24);
            this.lblRequired6.TabIndex = 58;
            this.lblRequired6.Text = "*";
            // 
            // cbxFirstChallengeQuestion
            // 
            this.cbxFirstChallengeQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFirstChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFirstChallengeQuestion.FormattingEnabled = true;
            this.cbxFirstChallengeQuestion.Location = new System.Drawing.Point(245, 589);
            this.cbxFirstChallengeQuestion.Name = "cbxFirstChallengeQuestion";
            this.cbxFirstChallengeQuestion.Size = new System.Drawing.Size(287, 33);
            this.cbxFirstChallengeQuestion.TabIndex = 77;
            // 
            // lblRequired5
            // 
            this.lblRequired5.AutoSize = true;
            this.lblRequired5.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired5.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired5.ForeColor = System.Drawing.Color.Red;
            this.lblRequired5.Location = new System.Drawing.Point(277, 342);
            this.lblRequired5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired5.Name = "lblRequired5";
            this.lblRequired5.Size = new System.Drawing.Size(18, 24);
            this.lblRequired5.TabIndex = 57;
            this.lblRequired5.Text = "*";
            // 
            // lblRequired14
            // 
            this.lblRequired14.AutoSize = true;
            this.lblRequired14.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired14.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired14.ForeColor = System.Drawing.Color.Red;
            this.lblRequired14.Location = new System.Drawing.Point(464, 799);
            this.lblRequired14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired14.Name = "lblRequired14";
            this.lblRequired14.Size = new System.Drawing.Size(18, 24);
            this.lblRequired14.TabIndex = 73;
            this.lblRequired14.Text = "*";
            // 
            // lblRequired4
            // 
            this.lblRequired4.AutoSize = true;
            this.lblRequired4.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired4.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired4.ForeColor = System.Drawing.Color.Red;
            this.lblRequired4.Location = new System.Drawing.Point(464, 301);
            this.lblRequired4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired4.Name = "lblRequired4";
            this.lblRequired4.Size = new System.Drawing.Size(18, 24);
            this.lblRequired4.TabIndex = 56;
            this.lblRequired4.Text = "*";
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Doppio One", 13F);
            this.btnImage.Location = new System.Drawing.Point(100, 839);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(118, 39);
            this.btnImage.TabIndex = 55;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblRequired13
            // 
            this.lblRequired13.AutoSize = true;
            this.lblRequired13.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired13.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired13.ForeColor = System.Drawing.Color.Red;
            this.lblRequired13.Location = new System.Drawing.Point(537, 759);
            this.lblRequired13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired13.Name = "lblRequired13";
            this.lblRequired13.Size = new System.Drawing.Size(18, 24);
            this.lblRequired13.TabIndex = 71;
            this.lblRequired13.Text = "*";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblImage.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblImage.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblImage.Location = new System.Drawing.Point(7, 842);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(89, 29);
            this.lblImage.TabIndex = 54;
            this.lblImage.Text = "Image: ";
            // 
            // lblPhoneSecondary
            // 
            this.lblPhoneSecondary.AutoSize = true;
            this.lblPhoneSecondary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPhoneSecondary.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblPhoneSecondary.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblPhoneSecondary.Location = new System.Drawing.Point(4, 461);
            this.lblPhoneSecondary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneSecondary.Name = "lblPhoneSecondary";
            this.lblPhoneSecondary.Size = new System.Drawing.Size(195, 29);
            this.lblPhoneSecondary.TabIndex = 52;
            this.lblPhoneSecondary.Text = "Phone Secondary:";
            // 
            // tbxThirdChallengeAnswer
            // 
            this.tbxThirdChallengeAnswer.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxThirdChallengeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxThirdChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxThirdChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxThirdChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThirdChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxThirdChallengeAnswer.Location = new System.Drawing.Point(224, 795);
            this.tbxThirdChallengeAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxThirdChallengeAnswer.MaxLength = 20;
            this.tbxThirdChallengeAnswer.Name = "tbxThirdChallengeAnswer";
            this.tbxThirdChallengeAnswer.Size = new System.Drawing.Size(229, 32);
            this.tbxThirdChallengeAnswer.TabIndex = 70;
            this.tbxThirdChallengeAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxThirdChallengeAnswer_KeyPress);
            // 
            // lblPhonePrimary
            // 
            this.lblPhonePrimary.AutoSize = true;
            this.lblPhonePrimary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPhonePrimary.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblPhonePrimary.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblPhonePrimary.Location = new System.Drawing.Point(4, 420);
            this.lblPhonePrimary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhonePrimary.Name = "lblPhonePrimary";
            this.lblPhonePrimary.Size = new System.Drawing.Size(171, 29);
            this.lblPhonePrimary.TabIndex = 50;
            this.lblPhonePrimary.Text = "Phone Primary:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEmail.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEmail.Location = new System.Drawing.Point(89, 380);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(449, 32);
            this.tbxEmail.TabIndex = 49;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEmail.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblEmail.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEmail.Location = new System.Drawing.Point(4, 379);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 29);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email:";
            // 
            // lblThirdChallengeAnswer
            // 
            this.lblThirdChallengeAnswer.AutoSize = true;
            this.lblThirdChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblThirdChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblThirdChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblThirdChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblThirdChallengeAnswer.Location = new System.Drawing.Point(4, 795);
            this.lblThirdChallengeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThirdChallengeAnswer.Name = "lblThirdChallengeAnswer";
            this.lblThirdChallengeAnswer.Size = new System.Drawing.Size(221, 29);
            this.lblThirdChallengeAnswer.TabIndex = 69;
            this.lblThirdChallengeAnswer.Text = "Challenge Answer 3:";
            // 
            // tbxState
            // 
            this.tbxState.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxState.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxState.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxState.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxState.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxState.Location = new System.Drawing.Point(389, 339);
            this.tbxState.Margin = new System.Windows.Forms.Padding(4);
            this.tbxState.MaxLength = 2;
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(54, 32);
            this.tbxState.TabIndex = 47;
            this.tbxState.TextChanged += new System.EventHandler(this.tbxState_TextChanged);
            this.tbxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxState_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblState.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblState.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblState.Location = new System.Drawing.Point(306, 339);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(75, 29);
            this.lblState.TabIndex = 46;
            this.lblState.Text = "State:";
            // 
            // lblThirdChallengeQuestion
            // 
            this.lblThirdChallengeQuestion.AutoSize = true;
            this.lblThirdChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblThirdChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblThirdChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblThirdChallengeQuestion.Location = new System.Drawing.Point(4, 755);
            this.lblThirdChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThirdChallengeQuestion.Name = "lblThirdChallengeQuestion";
            this.lblThirdChallengeQuestion.Size = new System.Drawing.Size(238, 29);
            this.lblThirdChallengeQuestion.TabIndex = 68;
            this.lblThirdChallengeQuestion.Text = "Challenge Question 3:";
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxZipCode.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxZipCode.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxZipCode.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZipCode.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxZipCode.Location = new System.Drawing.Point(120, 339);
            this.tbxZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxZipCode.MaxLength = 10;
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(126, 32);
            this.tbxZipCode.TabIndex = 45;
            this.tbxZipCode.TextChanged += new System.EventHandler(this.tbxZipCode_TextChanged);
            this.tbxZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZipCode_KeyPress);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblZipCode.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblZipCode.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblZipCode.Location = new System.Drawing.Point(4, 339);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(108, 29);
            this.lblZipCode.TabIndex = 44;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // lblRequired12
            // 
            this.lblRequired12.AutoSize = true;
            this.lblRequired12.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired12.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired12.ForeColor = System.Drawing.Color.Red;
            this.lblRequired12.Location = new System.Drawing.Point(464, 715);
            this.lblRequired12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired12.Name = "lblRequired12";
            this.lblRequired12.Size = new System.Drawing.Size(18, 24);
            this.lblRequired12.TabIndex = 67;
            this.lblRequired12.Text = "*";
            // 
            // tbxCity
            // 
            this.tbxCity.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCity.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCity.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxCity.Location = new System.Drawing.Point(72, 298);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(356, 32);
            this.tbxCity.TabIndex = 43;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCity.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblCity.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCity.Location = new System.Drawing.Point(4, 297);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 29);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "City:";
            // 
            // lblRequired11
            // 
            this.lblRequired11.AutoSize = true;
            this.lblRequired11.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired11.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired11.ForeColor = System.Drawing.Color.Red;
            this.lblRequired11.Location = new System.Drawing.Point(537, 677);
            this.lblRequired11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired11.Name = "lblRequired11";
            this.lblRequired11.Size = new System.Drawing.Size(18, 24);
            this.lblRequired11.TabIndex = 65;
            this.lblRequired11.Text = "*";
            // 
            // tbxSecondChallengeAnswer
            // 
            this.tbxSecondChallengeAnswer.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxSecondChallengeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSecondChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxSecondChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxSecondChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSecondChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxSecondChallengeAnswer.Location = new System.Drawing.Point(229, 711);
            this.tbxSecondChallengeAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSecondChallengeAnswer.MaxLength = 20;
            this.tbxSecondChallengeAnswer.Name = "tbxSecondChallengeAnswer";
            this.tbxSecondChallengeAnswer.Size = new System.Drawing.Size(229, 32);
            this.tbxSecondChallengeAnswer.TabIndex = 64;
            this.tbxSecondChallengeAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSecondChallengeAnswer_KeyPress);
            // 
            // lblSecondChallengeAnswer
            // 
            this.lblSecondChallengeAnswer.AutoSize = true;
            this.lblSecondChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSecondChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblSecondChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSecondChallengeAnswer.Location = new System.Drawing.Point(4, 711);
            this.lblSecondChallengeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondChallengeAnswer.Name = "lblSecondChallengeAnswer";
            this.lblSecondChallengeAnswer.Size = new System.Drawing.Size(221, 29);
            this.lblSecondChallengeAnswer.TabIndex = 63;
            this.lblSecondChallengeAnswer.Text = "Challenge Answer 2:";
            // 
            // lblSecondChallengeQuestion
            // 
            this.lblSecondChallengeQuestion.AutoSize = true;
            this.lblSecondChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSecondChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblSecondChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSecondChallengeQuestion.Location = new System.Drawing.Point(4, 672);
            this.lblSecondChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondChallengeQuestion.Name = "lblSecondChallengeQuestion";
            this.lblSecondChallengeQuestion.Size = new System.Drawing.Size(238, 29);
            this.lblSecondChallengeQuestion.TabIndex = 62;
            this.lblSecondChallengeQuestion.Text = "Challenge Question 2:";
            // 
            // lblRequired10
            // 
            this.lblRequired10.AutoSize = true;
            this.lblRequired10.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired10.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired10.ForeColor = System.Drawing.Color.Red;
            this.lblRequired10.Location = new System.Drawing.Point(464, 633);
            this.lblRequired10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired10.Name = "lblRequired10";
            this.lblRequired10.Size = new System.Drawing.Size(18, 24);
            this.lblRequired10.TabIndex = 61;
            this.lblRequired10.Text = "*";
            // 
            // llRequired9
            // 
            this.llRequired9.AutoSize = true;
            this.llRequired9.BackColor = System.Drawing.Color.Transparent;
            this.llRequired9.Font = new System.Drawing.Font("Doppio One", 14F);
            this.llRequired9.ForeColor = System.Drawing.Color.Red;
            this.llRequired9.Location = new System.Drawing.Point(537, 593);
            this.llRequired9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llRequired9.Name = "llRequired9";
            this.llRequired9.Size = new System.Drawing.Size(18, 24);
            this.llRequired9.TabIndex = 58;
            this.llRequired9.Text = "*";
            // 
            // lblRequired8
            // 
            this.lblRequired8.AutoSize = true;
            this.lblRequired8.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired8.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired8.ForeColor = System.Drawing.Color.Red;
            this.lblRequired8.Location = new System.Drawing.Point(394, 550);
            this.lblRequired8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired8.Name = "lblRequired8";
            this.lblRequired8.Size = new System.Drawing.Size(18, 24);
            this.lblRequired8.TabIndex = 57;
            this.lblRequired8.Text = "*";
            // 
            // lblRequired7
            // 
            this.lblRequired7.AutoSize = true;
            this.lblRequired7.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired7.Font = new System.Drawing.Font("Doppio One", 14F);
            this.lblRequired7.ForeColor = System.Drawing.Color.Red;
            this.lblRequired7.Location = new System.Drawing.Point(399, 507);
            this.lblRequired7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired7.Name = "lblRequired7";
            this.lblRequired7.Size = new System.Drawing.Size(18, 24);
            this.lblRequired7.TabIndex = 56;
            this.lblRequired7.Text = "*";
            // 
            // lblCreateUsername
            // 
            this.lblCreateUsername.AutoSize = true;
            this.lblCreateUsername.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCreateUsername.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblCreateUsername.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCreateUsername.Location = new System.Drawing.Point(4, 502);
            this.lblCreateUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateUsername.Name = "lblCreateUsername";
            this.lblCreateUsername.Size = new System.Drawing.Size(123, 29);
            this.lblCreateUsername.TabIndex = 42;
            this.lblCreateUsername.Text = "Username:";
            // 
            // tbxFirstChallengeAnswer
            // 
            this.tbxFirstChallengeAnswer.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxFirstChallengeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFirstChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxFirstChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxFirstChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxFirstChallengeAnswer.Location = new System.Drawing.Point(229, 628);
            this.tbxFirstChallengeAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstChallengeAnswer.MaxLength = 20;
            this.tbxFirstChallengeAnswer.Name = "tbxFirstChallengeAnswer";
            this.tbxFirstChallengeAnswer.Size = new System.Drawing.Size(229, 32);
            this.tbxFirstChallengeAnswer.TabIndex = 49;
            this.tbxFirstChallengeAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstChallengeAnswer_KeyPress);
            // 
            // tbxCreateUsername
            // 
            this.tbxCreateUsername.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxCreateUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCreateUsername.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCreateUsername.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCreateUsername.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCreateUsername.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxCreateUsername.Location = new System.Drawing.Point(135, 503);
            this.tbxCreateUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCreateUsername.MaxLength = 20;
            this.tbxCreateUsername.Name = "tbxCreateUsername";
            this.tbxCreateUsername.Size = new System.Drawing.Size(229, 32);
            this.tbxCreateUsername.TabIndex = 43;
            this.tbxCreateUsername.TextChanged += new System.EventHandler(this.tbxCreateUsername_TextChanged);
            // 
            // lblFirstChallengeAnswer
            // 
            this.lblFirstChallengeAnswer.AutoSize = true;
            this.lblFirstChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblFirstChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblFirstChallengeAnswer.Location = new System.Drawing.Point(4, 628);
            this.lblFirstChallengeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstChallengeAnswer.Name = "lblFirstChallengeAnswer";
            this.lblFirstChallengeAnswer.Size = new System.Drawing.Size(217, 29);
            this.lblFirstChallengeAnswer.TabIndex = 48;
            this.lblFirstChallengeAnswer.Text = "Challenge Answer 1:";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCreatePassword.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblCreatePassword.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCreatePassword.Location = new System.Drawing.Point(4, 546);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(117, 29);
            this.lblCreatePassword.TabIndex = 44;
            this.lblCreatePassword.Text = "Password:";
            // 
            // lblFirstChallengeQuestion
            // 
            this.lblFirstChallengeQuestion.AutoSize = true;
            this.lblFirstChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblFirstChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblFirstChallengeQuestion.Location = new System.Drawing.Point(4, 589);
            this.lblFirstChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstChallengeQuestion.Name = "lblFirstChallengeQuestion";
            this.lblFirstChallengeQuestion.Size = new System.Drawing.Size(234, 29);
            this.lblFirstChallengeQuestion.TabIndex = 46;
            this.lblFirstChallengeQuestion.Text = "Challenge Question 1:";
            // 
            // tbxCreatePassword
            // 
            this.tbxCreatePassword.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxCreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCreatePassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCreatePassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxCreatePassword.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCreatePassword.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxCreatePassword.Location = new System.Drawing.Point(129, 544);
            this.tbxCreatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCreatePassword.MaxLength = 20;
            this.tbxCreatePassword.Name = "tbxCreatePassword";
            this.tbxCreatePassword.Size = new System.Drawing.Size(229, 32);
            this.tbxCreatePassword.TabIndex = 45;
            this.tbxCreatePassword.TextChanged += new System.EventHandler(this.tbxCreatePassword_TextChanged);
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(532, 534);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(76, 40);
            this.lblHelp.TabIndex = 61;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // hlpCreateAccount
            // 
            this.hlpCreateAccount.HelpNamespace = "Logon.chm";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(612, 593);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.lblRequiredInstructions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHelp);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.hlpCreateAccount.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateAccount";
            this.hlpCreateAccount.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateAccount_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequiredInstructions;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Label lblRequired6;
        private System.Windows.Forms.Label lblRequired5;
        private System.Windows.Forms.Label lblRequired4;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPhoneSecondary;
        private System.Windows.Forms.Label lblPhonePrimary;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label llRequired9;
        private System.Windows.Forms.Label lblRequired8;
        private System.Windows.Forms.Label lblRequired7;
        private System.Windows.Forms.TextBox tbxFirstChallengeAnswer;
        private System.Windows.Forms.Label lblFirstChallengeAnswer;
        private System.Windows.Forms.Label lblFirstChallengeQuestion;
        private System.Windows.Forms.TextBox tbxCreatePassword;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.TextBox tbxCreateUsername;
        private System.Windows.Forms.Label lblCreateUsername;
        private System.Windows.Forms.Label lblRequired14;
        private System.Windows.Forms.Label lblRequired13;
        private System.Windows.Forms.TextBox tbxThirdChallengeAnswer;
        private System.Windows.Forms.Label lblThirdChallengeAnswer;
        private System.Windows.Forms.Label lblThirdChallengeQuestion;
        private System.Windows.Forms.Label lblRequired12;
        private System.Windows.Forms.Label lblRequired11;
        private System.Windows.Forms.TextBox tbxSecondChallengeAnswer;
        private System.Windows.Forms.Label lblSecondChallengeAnswer;
        private System.Windows.Forms.Label lblSecondChallengeQuestion;
        private System.Windows.Forms.Label lblRequired10;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.ComboBox cbxThirdChallengeQuestion;
        private System.Windows.Forms.ComboBox cbxSecondChallengeQuestion;
        private System.Windows.Forms.ComboBox cbxFirstChallengeQuestion;
        private System.Windows.Forms.TextBox tbxPhoneSecondary;
        private System.Windows.Forms.TextBox tbxPhonePrimary;
        private System.Windows.Forms.HelpProvider hlpCreateAccount;
        private System.Windows.Forms.Label lblValidAddress;
        private System.Windows.Forms.Label lblValidCity;
        private System.Windows.Forms.Label lblValidZipcode;
        private System.Windows.Forms.Label lblValidState;
        private System.Windows.Forms.Label lblValidEmail;
        private System.Windows.Forms.Label lblValidPhonePrimary;
        private System.Windows.Forms.Label lblValidPhoneSecondary;
        private System.Windows.Forms.Label lblValidUsername;
        private System.Windows.Forms.Label lblValidPassword;
    }
}