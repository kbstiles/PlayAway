using System;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used for logging in, to access account creation and settings.
    /// </summary>
    public partial class frmLogon : Form
    {
        //Variables
        public static bool isGuest;

        public frmLogon()
        {
            InitializeComponent();           
        }

        //Used to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpUserLogin.HelpNamespace);
        }

        //Takes user to settings form
        private void lblSettings_Click(object sender, EventArgs e)
        {            
            new frmSettings().Show();
            this.Hide();
        }

        //Allows user to unhide or hide password characters
        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '*')
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';
            }            
        }

        //Takes user to appropriate form based on account type
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.loggedInUserInfo.Clear();            

            try
            {
                clsLogon.Logon(tbxUsername.Text, tbxPassword.Text, Program.loggedInUserInfo);
                //Determines if account is disabled or not
                if (!Program.loggedInUserInfo[3].Equals("1"))
                {
                    if (Program.loggedInUserInfo[2].Equals("1001"))
                    {
                        isGuest = false;
                        new frmShop().Show();
                        this.Hide();

                    }
                    else if (Program.loggedInUserInfo[2].Equals("1002"))
                    {                        
                        new frmManagerHome().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Account Unavailable");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Account Unavailable");
            }
        }

        //Takes user to forgot password form
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            new frmPasswordReset().Show();
            this.Hide();
        }

        //Takes user to account creation form
        private void lblCreateAccount_Click(object sender, EventArgs e)
        { 
            new frmCreateAccount().Show();
            this.Hide();
        }

        //Ends the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            clsSQL.CloseDatabase();
            Application.Exit();
        }

        //Takes user to the shop as a guest
        private void btnGuest_Click(object sender, EventArgs e)
        {
            isGuest = true;
            new frmShop().Show();
            this.Hide();
        }

        private void frmLogon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
