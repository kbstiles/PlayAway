using System;
using System.Drawing;
using System.Windows.Forms;

namespace SF_KStilesM2
{   
    /// <summary>
    /// Form used to reset account passwords.
    /// </summary>
    public partial class frmPasswordReset : Form
    {
        public frmPasswordReset()
        {
            InitializeComponent();
        }

        //Checks for when username has stopped being changed for a couple seconds
        private void tmrUsername_Tick(object sender, EventArgs e)
        {
            tmrUsername.Stop();
            if (clsValidation.ValidateResetUser(tbxUsername))
            {
                tbxUsername.Enabled = false;
                tbxValidUser.ForeColor = Color.Green;
                tbxValidUser.Text = "O";
                clsSQL.PopulateUserQuestions(tbxUsername.Text, tbxFirstChallengeQuestion, tbxSecondChallengeQuestion, tbxThirdChallengeQuestion);
                tbxFirstChallengeAnswer.Enabled = true;
                tbxFirstChallengeAnswer.Focus();
                tbxSecondChallengeAnswer.Enabled = true;
                tbxThirdChallengeAnswer.Enabled = true;
            }
            else
            {
                tbxFirstChallengeAnswer.Enabled = false;
                tbxSecondChallengeAnswer.Enabled = false;
                tbxThirdChallengeAnswer.Enabled = false;
                tbxUsername.Focus();
                tbxValidUser.ForeColor = Color.Red;
                tbxValidUser.Text = "X";
            }
        }

        //Checks if username has been changed
        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            tmrUsername.Start();
        }

        //Clears info if on first page and moves back to first page if on second page
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tbxFirstChallengeAnswer.Enabled)
            {
                tbxFirstChallengeQuestion.ResetText();
                tbxFirstChallengeAnswer.ResetText();
                tbxFirstChallengeAnswer.Enabled = false;
                tbxSecondChallengeQuestion.ResetText();
                tbxSecondChallengeAnswer.ResetText();
                tbxSecondChallengeAnswer.Enabled = false;
                tbxThirdChallengeQuestion.ResetText();
                tbxThirdChallengeAnswer.ResetText();
                tbxThirdChallengeAnswer.Enabled = false;
                tbxUsername.ResetText();
                tbxUsername.Enabled = true;
                tbxValidUser.Text = "X";
                tbxValidUser.ForeColor = Color.Red;
            }
            else if (pnlReset.Visible)
            {
                tbxResetPassword.ResetText();
                tbxMatchPassword.ResetText();                
                btnNext.Text = "Next";
                btnNext.Enabled = true;
                tbxFirstChallengeAnswer.Enabled = true;
                tbxSecondChallengeAnswer.Enabled = true;
                tbxThirdChallengeAnswer.Enabled = true;
                pnlReset.Visible = false;
                pnlReset.Enabled = false;
                btnBack.Text = "Clear";
            }
        }

        //If on first page, validates and moves to second page. If on second page, validates password, changes password in database and takes user back to login form
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tbxFirstChallengeAnswer.Enabled)
            {
                if(clsValidation.ValidateResetAnswer(tbxUsername, tbxFirstChallengeAnswer, tbxSecondChallengeAnswer, tbxThirdChallengeAnswer))
                {
                    tbxFirstChallengeAnswer.Enabled = false;
                    tbxSecondChallengeAnswer.Enabled = false;
                    tbxThirdChallengeAnswer.Enabled = false;
                    tbxUsernameViewer.Text = tbxUsername.Text;
                    btnNext.Text = "Submit";
                    btnNext.Enabled = false;                    
                    pnlReset.Visible = true;
                    pnlReset.Enabled = true;
                    btnBack.Text = "Back";
                }
                else
                {
                    tbxFirstChallengeAnswer.Text = "One or more incorrect";
                    tbxSecondChallengeAnswer.ResetText();
                    tbxThirdChallengeAnswer.ResetText();
                }
            }
            if (pnlReset.Visible)
            {
                if (clsValidation.ValidatePassword(tbxResetPassword.Text) && clsValidation.ValidateMatch(tbxResetPassword.Text, tbxMatchPassword.Text))
                {
                    clsSQL.ResetPassword(tbxUsername.Text, tbxResetPassword.Text);
                    
                    new frmLogon().Show();
                    this.Dispose();
                }
            }
        }

        //Allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPasswordReset.HelpNamespace);
        }

        //Checks for new password changes and validity
        private void tbxResetPassword_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePassword(tbxResetPassword.Text))
            {
                tbxValidPassword.ForeColor = Color.Green;
                tbxValidPassword.Text = "O";
            }
            else
            {
                tbxValidPassword.ForeColor = Color.Red;
                tbxValidPassword.Text = "X";
            }
        }

        //Checks for confirmation password changes and validity
        private void tbxMatchPassword_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateMatch(tbxResetPassword.Text, tbxMatchPassword.Text))
            {
                tbxValidMatch.ForeColor = Color.Green;
                tbxValidMatch.Text = "O";
                btnNext.Enabled = true;
            }
            else
            {
                tbxValidMatch.ForeColor = Color.Red;
                tbxValidMatch.Text = "X";
                btnNext.Enabled = false;
            }
        }

        private void frmPasswordReset_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Takes user back to login form
        private void btnHome_Click(object sender, EventArgs e)
        {
            new frmLogon().Show();
            this.Dispose();
        }
    }
}
