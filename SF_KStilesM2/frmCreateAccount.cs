using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used for creating customer accounts.
    /// </summary>
    public partial class frmCreateAccount : Form
    {
        //Variables
        clsImage img = new clsImage();

        public string fileName = "null";

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            pnlCreate.AutoScroll = false;
            pnlCreate.HorizontalScroll.Enabled = false;
            pnlCreate.HorizontalScroll.Visible = false;
            pnlCreate.HorizontalScroll.Maximum = 0;
            pnlCreate.AutoScroll = true;
            clsSQL.PopulateAllQuestions(cbxFirstChallengeQuestion, cbxSecondChallengeQuestion, cbxThirdChallengeQuestion);
        }

        //Used to clear all info inputted
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxTitle.ResetText();
            tbxFirstName.ResetText();
            tbxMiddleName.ResetText();
            tbxLastName.ResetText();
            tbxSuffix.ResetText();
            tbxAddress.ResetText();
            tbxCity.ResetText();
            tbxZipCode.ResetText();
            tbxState.ResetText();
            tbxEmail.ResetText();
            tbxPhonePrimary.ResetText();
            tbxPhoneSecondary.ResetText();
            tbxCreateUsername.ResetText();
            tbxCreatePassword.ResetText();
            cbxFirstChallengeQuestion.SelectedIndex = -1;
            tbxFirstChallengeAnswer.ResetText();
            cbxSecondChallengeQuestion.SelectedIndex = -1;
            tbxSecondChallengeAnswer.ResetText();
            cbxThirdChallengeQuestion.SelectedIndex = -1;
            tbxThirdChallengeAnswer.ResetText();
        }

        //Takes user back to login page
        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmLogon().Show();
            this.Dispose();
        }

        //Validates and creates account based on user inputted info
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateName(tbxFirstName, tbxLastName) && clsValidation.ValidateAddress(tbxAddress.Text))
            {
                if (clsValidation.ValidateCity(tbxCity.Text)
                && clsValidation.ValidateZip(tbxZipCode.Text)
                && clsValidation.ValidateState(tbxState.Text)
                && clsValidation.ValidateEmail(tbxEmail.Text)
                && clsValidation.ValidatePhone(tbxPhonePrimary.Text)
                && clsValidation.ValidatePhone(tbxPhoneSecondary.Text))
                {
                    if (clsValidation.ValidateUser(tbxCreateUsername.Text)
                    && clsValidation.ValidatePassword(tbxCreatePassword.Text)
                    && clsValidation.ValidateQuestions(cbxFirstChallengeQuestion, cbxSecondChallengeQuestion, cbxThirdChallengeQuestion)
                    && clsValidation.ValidateAnswers(tbxFirstChallengeAnswer.Text, tbxSecondChallengeAnswer.Text, tbxThirdChallengeAnswer.Text))
                    {
                        List<string> addresses = new List<string>();
                        if (tbxAddress.Text.Contains("\n"))
                        {
                            foreach (string address in tbxAddress.Text.Split('\n'))
                            {
                                addresses.Add(address);
                            }
                            if (addresses.Count < 3)
                            {
                                addresses.Add("null");
                            }
                        }
                        else
                        {
                            addresses.Add(tbxAddress.Text);
                            addresses.Add("null");
                            addresses.Add("null");
                        }

                        clsSQL.CreateAccount(
                            clsValidation.CheckEmpty(tbxTitle.Text),
                            tbxFirstName.Text,
                            clsValidation.CheckEmpty(tbxMiddleName.Text),
                            tbxLastName.Text,
                            clsValidation.CheckEmpty(tbxSuffix.Text),
                            addresses[0],
                            addresses[1],
                            addresses[2],
                            tbxCity.Text,
                            tbxZipCode.Text,
                            tbxState.Text,
                            clsValidation.CheckEmpty(tbxEmail.Text),
                            clsValidation.CheckEmpty(tbxPhonePrimary.Text),
                            clsValidation.CheckEmpty(tbxPhoneSecondary.Text),
                            fileName,
                            1001,
                            tbxCreateUsername.Text,
                            tbxCreatePassword.Text,
                            cbxFirstChallengeQuestion.SelectedIndex + 100,
                            tbxFirstChallengeAnswer.Text,
                            cbxSecondChallengeQuestion.SelectedIndex + 100,
                            tbxSecondChallengeAnswer.Text,
                            cbxThirdChallengeQuestion.SelectedIndex + 100,
                            tbxThirdChallengeAnswer.Text,
                            "Customer"
                        );

                        new frmLogon().Show();
                        this.Dispose();
                    }
                    else if (clsValidation.ValidateUser(tbxCreateUsername.Text) == false)
                    {
                        tbxCreateUsername.Focus();
                    }
                    else if (clsValidation.ValidatePassword(tbxCreatePassword.Text) == false)
                    {
                        tbxCreatePassword.Focus();
                    }
                    else if (clsValidation.ValidateQuestions(cbxFirstChallengeQuestion, cbxSecondChallengeQuestion, cbxThirdChallengeQuestion) == false)
                    {
                        if (cbxFirstChallengeQuestion.SelectedIndex < -1)
                        {
                            cbxFirstChallengeQuestion.Focus();
                        }
                        else if (cbxSecondChallengeQuestion.SelectedIndex < -1)
                        {
                            cbxSecondChallengeQuestion.Focus();
                        }
                        else if (cbxThirdChallengeQuestion.SelectedIndex < -1)
                        {
                            cbxThirdChallengeQuestion.Focus();
                        }
                    }
                    else if (clsValidation.ValidateAnswers(tbxFirstChallengeAnswer.Text, tbxSecondChallengeAnswer.Text, tbxThirdChallengeAnswer.Text) == false)
                    {
                        if (string.IsNullOrEmpty(tbxFirstChallengeAnswer.Text))
                        {
                            tbxFirstChallengeAnswer.Focus();
                        }
                        else if (string.IsNullOrEmpty(tbxSecondChallengeAnswer.Text))
                        {
                            tbxSecondChallengeAnswer.Focus();
                        }
                        else if (string.IsNullOrEmpty(tbxThirdChallengeAnswer.Text))
                        {
                            tbxThirdChallengeAnswer.Focus();
                        }
                    }
                }
                else if (clsValidation.ValidateCity(tbxCity.Text) == false)
                {
                    tbxCity.Focus();
                }
                else if (clsValidation.ValidateZip(tbxZipCode.Text) == false)
                {
                    tbxZipCode.Focus();
                }
                else if (clsValidation.ValidateCity(tbxState.Text) == false)
                {
                    tbxState.Focus();
                }
                else if (clsValidation.ValidateCity(tbxEmail.Text) == false)
                {
                    tbxEmail.Focus();
                }
                else if (clsValidation.ValidatePhone(tbxPhonePrimary.Text) == false)
                {
                    tbxPhonePrimary.Focus();
                }
                else if (clsValidation.ValidatePhone(tbxPhoneSecondary.Text) == false)
                {
                    tbxPhoneSecondary.Focus();
                }
            }
            else if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                tbxFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                tbxLastName.Focus();
            }
            else if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                tbxAddress.Focus();
            }         
        }

        //Allows user to add image to account
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;

                if (clsValidation.ValidateImage(fileName) == false)
                {
                    fileName = "null";
                }
            }
        }

        //Allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpCreateAccount.HelpNamespace);
        }

        //Checks for address changes and validity
        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            lblValidAddress.Visible = true;

            if (clsValidation.ValidateAddress(tbxAddress.Text))
            {
                lblValidAddress.ForeColor = Color.Green;
                lblValidAddress.Text = "O";
            }
            else
            {
                lblValidAddress.ForeColor = Color.Red;
                lblValidAddress.Text = "X";
            }
        }

        //Checks for city changes and validity
        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            lblValidCity.Visible = true;

            if (clsValidation.ValidateCity(tbxCity.Text))
            {
                lblValidCity.ForeColor = Color.Green;
                lblValidCity.Text = "O";
            }
            else
            {
                lblValidCity.ForeColor = Color.Red;
                lblValidCity.Text = "X";
            }
        }

        //Only allows certain keys to be pressed for zipcode
        private void tbxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (int)e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Checks for zipcode changes and validity
        private void tbxZipCode_TextChanged(object sender, EventArgs e)
        {
            lblValidZipcode.Visible = true;

            if (clsValidation.ValidateZip(tbxZipCode.Text))
            {
                lblValidZipcode.ForeColor = Color.Green;
                lblValidZipcode.Text = "O";
            }
            else
            {
                lblValidZipcode.ForeColor = Color.Red;
                lblValidZipcode.Text = "X";
            }
        }

        //Only allows certain keys to be pressed for state
        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Checks for state changes and validity
        private void tbxState_TextChanged(object sender, EventArgs e)
        {
            lblValidState.Visible = true;

            if (clsValidation.ValidateState(tbxState.Text))
            {
                lblValidState.ForeColor = Color.Green;
                lblValidState.Text = "O";
            }
            else
            {
                lblValidState.ForeColor = Color.Red;
                lblValidState.Text = "X";
            }
        }

        //Checks for email changes and validity
        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            lblValidEmail.Visible = true;

            if (clsValidation.ValidateEmail(tbxEmail.Text))
            {
                lblValidEmail.ForeColor = Color.Green;
                lblValidEmail.Text = "O";
            }
            else
            {
                lblValidEmail.ForeColor = Color.Red;
                lblValidEmail.Text = "X";
            }
        }

        //Only allows certain keys to be pressed for Primary Phone
        private void tbxPhonePrimary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Checks for primary phone number changes and validity
        private void tbxPhonePrimary_TextChanged(object sender, EventArgs e)
        {
            lblValidPhonePrimary.Visible = true;

            if (clsValidation.ValidatePhone(tbxPhonePrimary.Text))
            {
                lblValidPhonePrimary.ForeColor = Color.Green;
                lblValidPhonePrimary.Text = "O";
            }
            else
            {
                lblValidPhonePrimary.ForeColor = Color.Red;
                lblValidPhonePrimary.Text = "X";
            }
        }

        //Only allows certain keys to be pressed for Secondary Phone
        private void tbxPhoneSecondary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Checks for secondary phone number changes and validity
        private void tbxPhoneSecondary_TextChanged(object sender, EventArgs e)
        {
            lblValidPhoneSecondary.Visible = true;
            if (clsValidation.ValidatePhone(tbxPhoneSecondary.Text))
            {
                lblValidPhoneSecondary.ForeColor = Color.Green;
                lblValidPhoneSecondary.Text = "O";
            }
            else
            {
                lblValidPhoneSecondary.ForeColor = Color.Red;
                lblValidPhoneSecondary.Text = "X";
            }
        }

        //Checks for username changes and validity
        private void tbxCreateUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateUser(tbxCreateUsername.Text))
            {
                lblValidUsername.ForeColor = Color.Green;
                lblValidUsername.Text = "O";
            }
            else
            {
                lblValidUsername.ForeColor = Color.Red;
                lblValidUsername.Text = "X";
            }
        }

        //Checks for password changes and validity
        private void tbxCreatePassword_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePassword(tbxCreatePassword.Text))
            {
                lblValidPassword.ForeColor = Color.Green;
                lblValidPassword.Text = "O";
            }
            else
            {
                lblValidPassword.ForeColor = Color.Red;
                lblValidPassword.Text = "X";
            }
        }

        //Only allows for certain keys to be pressed for first challenge answer
        private void tbxFirstChallengeAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Only allows for certain keys to be pressed for second challenge answer
        private void tbxSecondChallengeAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Only allows for certain keys to be pressed for third challenge answer
        private void tbxThirdChallengeAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void frmCreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
