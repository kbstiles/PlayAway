namespace SF_KStilesM2
{
    partial class frmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordReset));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFirstChallengeQuestion = new System.Windows.Forms.Label();
            this.tbxFirstChallengeAnswer = new System.Windows.Forms.TextBox();
            this.lblFirstChallengeAnswer = new System.Windows.Forms.Label();
            this.tbxSecondChallengeAnswer = new System.Windows.Forms.TextBox();
            this.lblSecondChallengeAnswer = new System.Windows.Forms.Label();
            this.tbxSecondChallengeQuestion = new System.Windows.Forms.TextBox();
            this.lblSecondChallengeQuestion = new System.Windows.Forms.Label();
            this.tbxThirdChallengeAnswer = new System.Windows.Forms.TextBox();
            this.lblThirdChallengeAnswer = new System.Windows.Forms.Label();
            this.tbxThirdChallengeQuestion = new System.Windows.Forms.TextBox();
            this.lblThirdChallengeQuestion = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.tbxFirstChallengeQuestion = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pnlReset = new System.Windows.Forms.Panel();
            this.tbxUsernameViewer = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxValidMatch = new System.Windows.Forms.TextBox();
            this.tbxMatchPassword = new System.Windows.Forms.TextBox();
            this.lblMatchPassword = new System.Windows.Forms.Label();
            this.tbxValidPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxResetPassword = new System.Windows.Forms.TextBox();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.tbxValidUser = new System.Windows.Forms.TextBox();
            this.hlpPasswordReset = new System.Windows.Forms.HelpProvider();
            this.tmrUsername = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnBack.Location = new System.Drawing.Point(139, 331);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 48);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Clear";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Doppio One", 15F);
            this.btnNext.Location = new System.Drawing.Point(251, 331);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 48);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFirstChallengeQuestion
            // 
            this.lblFirstChallengeQuestion.AutoSize = true;
            this.lblFirstChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblFirstChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblFirstChallengeQuestion.Location = new System.Drawing.Point(17, 66);
            this.lblFirstChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstChallengeQuestion.Name = "lblFirstChallengeQuestion";
            this.lblFirstChallengeQuestion.Size = new System.Drawing.Size(211, 25);
            this.lblFirstChallengeQuestion.TabIndex = 33;
            this.lblFirstChallengeQuestion.Text = "Challenge Question 1:";
            // 
            // tbxFirstChallengeAnswer
            // 
            this.tbxFirstChallengeAnswer.Enabled = false;
            this.tbxFirstChallengeAnswer.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxFirstChallengeAnswer.Location = new System.Drawing.Point(230, 106);
            this.tbxFirstChallengeAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxFirstChallengeAnswer.Name = "tbxFirstChallengeAnswer";
            this.tbxFirstChallengeAnswer.Size = new System.Drawing.Size(175, 23);
            this.tbxFirstChallengeAnswer.TabIndex = 2;
            // 
            // lblFirstChallengeAnswer
            // 
            this.lblFirstChallengeAnswer.AutoSize = true;
            this.lblFirstChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblFirstChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblFirstChallengeAnswer.Location = new System.Drawing.Point(32, 103);
            this.lblFirstChallengeAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstChallengeAnswer.Name = "lblFirstChallengeAnswer";
            this.lblFirstChallengeAnswer.Size = new System.Drawing.Size(196, 25);
            this.lblFirstChallengeAnswer.TabIndex = 51;
            this.lblFirstChallengeAnswer.Text = "Challenge Answer 1:";
            // 
            // tbxSecondChallengeAnswer
            // 
            this.tbxSecondChallengeAnswer.Enabled = false;
            this.tbxSecondChallengeAnswer.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxSecondChallengeAnswer.Location = new System.Drawing.Point(230, 203);
            this.tbxSecondChallengeAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSecondChallengeAnswer.Name = "tbxSecondChallengeAnswer";
            this.tbxSecondChallengeAnswer.Size = new System.Drawing.Size(175, 23);
            this.tbxSecondChallengeAnswer.TabIndex = 3;
            // 
            // lblSecondChallengeAnswer
            // 
            this.lblSecondChallengeAnswer.AutoSize = true;
            this.lblSecondChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSecondChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblSecondChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSecondChallengeAnswer.Location = new System.Drawing.Point(29, 200);
            this.lblSecondChallengeAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecondChallengeAnswer.Name = "lblSecondChallengeAnswer";
            this.lblSecondChallengeAnswer.Size = new System.Drawing.Size(199, 25);
            this.lblSecondChallengeAnswer.TabIndex = 55;
            this.lblSecondChallengeAnswer.Text = "Challenge Answer 2:";
            // 
            // tbxSecondChallengeQuestion
            // 
            this.tbxSecondChallengeQuestion.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxSecondChallengeQuestion.Location = new System.Drawing.Point(230, 166);
            this.tbxSecondChallengeQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSecondChallengeQuestion.Name = "tbxSecondChallengeQuestion";
            this.tbxSecondChallengeQuestion.ReadOnly = true;
            this.tbxSecondChallengeQuestion.Size = new System.Drawing.Size(235, 23);
            this.tbxSecondChallengeQuestion.TabIndex = 54;
            // 
            // lblSecondChallengeQuestion
            // 
            this.lblSecondChallengeQuestion.AutoSize = true;
            this.lblSecondChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSecondChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblSecondChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSecondChallengeQuestion.Location = new System.Drawing.Point(14, 163);
            this.lblSecondChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondChallengeQuestion.Name = "lblSecondChallengeQuestion";
            this.lblSecondChallengeQuestion.Size = new System.Drawing.Size(214, 25);
            this.lblSecondChallengeQuestion.TabIndex = 53;
            this.lblSecondChallengeQuestion.Text = "Challenge Question 2:";
            // 
            // tbxThirdChallengeAnswer
            // 
            this.tbxThirdChallengeAnswer.Enabled = false;
            this.tbxThirdChallengeAnswer.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxThirdChallengeAnswer.Location = new System.Drawing.Point(230, 297);
            this.tbxThirdChallengeAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxThirdChallengeAnswer.Name = "tbxThirdChallengeAnswer";
            this.tbxThirdChallengeAnswer.Size = new System.Drawing.Size(173, 23);
            this.tbxThirdChallengeAnswer.TabIndex = 4;
            // 
            // lblThirdChallengeAnswer
            // 
            this.lblThirdChallengeAnswer.AutoSize = true;
            this.lblThirdChallengeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblThirdChallengeAnswer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblThirdChallengeAnswer.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblThirdChallengeAnswer.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblThirdChallengeAnswer.Location = new System.Drawing.Point(30, 294);
            this.lblThirdChallengeAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblThirdChallengeAnswer.Name = "lblThirdChallengeAnswer";
            this.lblThirdChallengeAnswer.Size = new System.Drawing.Size(198, 25);
            this.lblThirdChallengeAnswer.TabIndex = 59;
            this.lblThirdChallengeAnswer.Text = "Challenge Answer 3:";
            // 
            // tbxThirdChallengeQuestion
            // 
            this.tbxThirdChallengeQuestion.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxThirdChallengeQuestion.Location = new System.Drawing.Point(230, 259);
            this.tbxThirdChallengeQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.tbxThirdChallengeQuestion.Name = "tbxThirdChallengeQuestion";
            this.tbxThirdChallengeQuestion.ReadOnly = true;
            this.tbxThirdChallengeQuestion.Size = new System.Drawing.Size(234, 23);
            this.tbxThirdChallengeQuestion.TabIndex = 58;
            // 
            // lblThirdChallengeQuestion
            // 
            this.lblThirdChallengeQuestion.AutoSize = true;
            this.lblThirdChallengeQuestion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblThirdChallengeQuestion.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblThirdChallengeQuestion.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblThirdChallengeQuestion.Location = new System.Drawing.Point(15, 256);
            this.lblThirdChallengeQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThirdChallengeQuestion.Name = "lblThirdChallengeQuestion";
            this.lblThirdChallengeQuestion.Size = new System.Drawing.Size(213, 25);
            this.lblThirdChallengeQuestion.TabIndex = 57;
            this.lblThirdChallengeQuestion.Text = "Challenge Question 3:";
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Underline);
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(386, 343);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(57, 26);
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // tbxFirstChallengeQuestion
            // 
            this.tbxFirstChallengeQuestion.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxFirstChallengeQuestion.Location = new System.Drawing.Point(230, 69);
            this.tbxFirstChallengeQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.tbxFirstChallengeQuestion.Name = "tbxFirstChallengeQuestion";
            this.tbxFirstChallengeQuestion.ReadOnly = true;
            this.tbxFirstChallengeQuestion.Size = new System.Drawing.Size(235, 23);
            this.tbxFirstChallengeQuestion.TabIndex = 50;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblUser.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblUser.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblUser.Location = new System.Drawing.Point(116, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(112, 25);
            this.lblUser.TabIndex = 63;
            this.lblUser.Text = "Username:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.tbxUsername.Location = new System.Drawing.Point(230, 12);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(176, 23);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // pnlReset
            // 
            this.pnlReset.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.pnlReset.Controls.Add(this.tbxUsernameViewer);
            this.pnlReset.Controls.Add(this.lblUsername);
            this.pnlReset.Controls.Add(this.tbxValidMatch);
            this.pnlReset.Controls.Add(this.tbxMatchPassword);
            this.pnlReset.Controls.Add(this.lblMatchPassword);
            this.pnlReset.Controls.Add(this.tbxValidPassword);
            this.pnlReset.Controls.Add(this.label12);
            this.pnlReset.Controls.Add(this.label14);
            this.pnlReset.Controls.Add(this.textBox1);
            this.pnlReset.Controls.Add(this.label1);
            this.pnlReset.Controls.Add(this.tbxResetPassword);
            this.pnlReset.Controls.Add(this.lblResetPassword);
            this.pnlReset.Controls.Add(this.lblInstruction1);
            this.pnlReset.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlReset.Enabled = false;
            this.pnlReset.Location = new System.Drawing.Point(12, 9);
            this.pnlReset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlReset.Name = "pnlReset";
            this.pnlReset.Size = new System.Drawing.Size(453, 312);
            this.pnlReset.TabIndex = 65;
            this.pnlReset.Visible = false;
            // 
            // tbxUsernameViewer
            // 
            this.tbxUsernameViewer.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsernameViewer.Location = new System.Drawing.Point(198, 207);
            this.tbxUsernameViewer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxUsernameViewer.MaxLength = 20;
            this.tbxUsernameViewer.Name = "tbxUsernameViewer";
            this.tbxUsernameViewer.ReadOnly = true;
            this.tbxUsernameViewer.Size = new System.Drawing.Size(202, 20);
            this.tbxUsernameViewer.TabIndex = 82;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblUsername.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblUsername.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblUsername.Location = new System.Drawing.Point(74, 202);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 25);
            this.lblUsername.TabIndex = 83;
            this.lblUsername.Text = "Username:";
            // 
            // tbxValidMatch
            // 
            this.tbxValidMatch.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxValidMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValidMatch.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxValidMatch.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValidMatch.ForeColor = System.Drawing.Color.Red;
            this.tbxValidMatch.Location = new System.Drawing.Point(412, 281);
            this.tbxValidMatch.Margin = new System.Windows.Forms.Padding(6);
            this.tbxValidMatch.MaxLength = 20;
            this.tbxValidMatch.Name = "tbxValidMatch";
            this.tbxValidMatch.ReadOnly = true;
            this.tbxValidMatch.Size = new System.Drawing.Size(22, 19);
            this.tbxValidMatch.TabIndex = 81;
            this.tbxValidMatch.Text = "X";
            // 
            // tbxMatchPassword
            // 
            this.tbxMatchPassword.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatchPassword.Location = new System.Drawing.Point(198, 279);
            this.tbxMatchPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbxMatchPassword.MaxLength = 20;
            this.tbxMatchPassword.Name = "tbxMatchPassword";
            this.tbxMatchPassword.Size = new System.Drawing.Size(202, 20);
            this.tbxMatchPassword.TabIndex = 10;
            this.tbxMatchPassword.TextChanged += new System.EventHandler(this.tbxMatchPassword_TextChanged);
            // 
            // lblMatchPassword
            // 
            this.lblMatchPassword.AutoSize = true;
            this.lblMatchPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMatchPassword.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblMatchPassword.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblMatchPassword.Location = new System.Drawing.Point(18, 274);
            this.lblMatchPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMatchPassword.Name = "lblMatchPassword";
            this.lblMatchPassword.Size = new System.Drawing.Size(168, 25);
            this.lblMatchPassword.TabIndex = 79;
            this.lblMatchPassword.Text = "Password Verify:";
            // 
            // tbxValidPassword
            // 
            this.tbxValidPassword.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxValidPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValidPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxValidPassword.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValidPassword.ForeColor = System.Drawing.Color.Red;
            this.tbxValidPassword.Location = new System.Drawing.Point(412, 243);
            this.tbxValidPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbxValidPassword.MaxLength = 20;
            this.tbxValidPassword.Name = "tbxValidPassword";
            this.tbxValidPassword.ReadOnly = true;
            this.tbxValidPassword.Size = new System.Drawing.Size(22, 19);
            this.tbxValidPassword.TabIndex = 78;
            this.tbxValidPassword.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(440, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 73;
            this.label12.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(418, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 71;
            this.label14.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(226, 472);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.label1.Location = new System.Drawing.Point(8, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Challenge Answer 3:";
            // 
            // tbxResetPassword
            // 
            this.tbxResetPassword.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResetPassword.Location = new System.Drawing.Point(198, 242);
            this.tbxResetPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbxResetPassword.MaxLength = 20;
            this.tbxResetPassword.Name = "tbxResetPassword";
            this.tbxResetPassword.Size = new System.Drawing.Size(202, 20);
            this.tbxResetPassword.TabIndex = 9;
            this.tbxResetPassword.TextChanged += new System.EventHandler(this.tbxResetPassword_TextChanged);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblResetPassword.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lblResetPassword.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblResetPassword.Location = new System.Drawing.Point(80, 237);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(106, 25);
            this.lblResetPassword.TabIndex = 44;
            this.lblResetPassword.Text = "Password:";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.BackColor = System.Drawing.Color.White;
            this.lblInstruction1.Font = new System.Drawing.Font("Doppio One", 12F);
            this.lblInstruction1.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction1.Location = new System.Drawing.Point(55, 11);
            this.lblInstruction1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(343, 182);
            this.lblInstruction1.TabIndex = 77;
            this.lblInstruction1.Text = resources.GetString("lblInstruction1.Text");
            // 
            // tbxValidUser
            // 
            this.tbxValidUser.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxValidUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValidUser.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxValidUser.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValidUser.ForeColor = System.Drawing.Color.Red;
            this.tbxValidUser.Location = new System.Drawing.Point(421, 9);
            this.tbxValidUser.Margin = new System.Windows.Forms.Padding(6);
            this.tbxValidUser.MaxLength = 20;
            this.tbxValidUser.Name = "tbxValidUser";
            this.tbxValidUser.ReadOnly = true;
            this.tbxValidUser.Size = new System.Drawing.Size(22, 19);
            this.tbxValidUser.TabIndex = 79;
            this.tbxValidUser.TabStop = false;
            this.tbxValidUser.Text = "X";
            // 
            // hlpPasswordReset
            // 
            this.hlpPasswordReset.HelpNamespace = "Logon.chm";
            // 
            // tmrUsername
            // 
            this.tmrUsername.Interval = 3000;
            this.tmrUsername.Tick += new System.EventHandler(this.tmrUsername_Tick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Doppio One", 20F);
            this.btnHome.Location = new System.Drawing.Point(12, 327);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(97, 56);
            this.btnHome.TabIndex = 80;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(479, 389);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pnlReset);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.tbxThirdChallengeAnswer);
            this.Controls.Add(this.lblThirdChallengeAnswer);
            this.Controls.Add(this.tbxThirdChallengeQuestion);
            this.Controls.Add(this.lblThirdChallengeQuestion);
            this.Controls.Add(this.tbxSecondChallengeAnswer);
            this.Controls.Add(this.lblSecondChallengeAnswer);
            this.Controls.Add(this.tbxSecondChallengeQuestion);
            this.Controls.Add(this.lblSecondChallengeQuestion);
            this.Controls.Add(this.tbxFirstChallengeAnswer);
            this.Controls.Add(this.lblFirstChallengeAnswer);
            this.Controls.Add(this.tbxFirstChallengeQuestion);
            this.Controls.Add(this.lblFirstChallengeQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbxValidUser);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.hlpPasswordReset.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPasswordReset";
            this.hlpPasswordReset.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPasswordReset_FormClosing);
            this.pnlReset.ResumeLayout(false);
            this.pnlReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFirstChallengeQuestion;
        private System.Windows.Forms.TextBox tbxFirstChallengeAnswer;
        private System.Windows.Forms.Label lblFirstChallengeAnswer;
        private System.Windows.Forms.TextBox tbxSecondChallengeAnswer;
        private System.Windows.Forms.Label lblSecondChallengeAnswer;
        private System.Windows.Forms.TextBox tbxSecondChallengeQuestion;
        private System.Windows.Forms.Label lblSecondChallengeQuestion;
        private System.Windows.Forms.TextBox tbxThirdChallengeAnswer;
        private System.Windows.Forms.Label lblThirdChallengeAnswer;
        private System.Windows.Forms.TextBox tbxThirdChallengeQuestion;
        private System.Windows.Forms.Label lblThirdChallengeQuestion;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.TextBox tbxFirstChallengeQuestion;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Panel pnlReset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxResetPassword;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.TextBox tbxValidPassword;
        private System.Windows.Forms.TextBox tbxValidUser;
        private System.Windows.Forms.TextBox tbxValidMatch;
        private System.Windows.Forms.TextBox tbxMatchPassword;
        private System.Windows.Forms.Label lblMatchPassword;
        private System.Windows.Forms.HelpProvider hlpPasswordReset;
        private System.Windows.Forms.Timer tmrUsername;
        private System.Windows.Forms.TextBox tbxUsernameViewer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnHome;
    }
}