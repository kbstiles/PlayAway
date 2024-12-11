using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;


namespace SF_KStilesM2
{
    /// <summary>
    /// Form that is used to view, add, edit and remove managers.
    /// </summary>
    public partial class frmManagers : Form
    {
        //Variables
        public System.Windows.Forms.Timer managersTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public Thread managersDataThread;

        DataRow chosenRow = null;

        public string fileName = "null";

        public bool editTitleChangedBool = false,
            editTitleValidBool = true,
            editFirstNameChangedBool = false,
            editFirstNameValidBool = true,
            editMiddleNameChangedBool = false,
            editMiddleNameValidBool = true,
            editLastNameChangedBool = false,
            editLastNameValidBool = true,
            editSuffixChangedBool = false,
            editSuffixValidBool = true,
            editAddressChangedBool = false,
            editAddressValidBool = true,
            editCityChangedBool = false,
            editCityValidBool = true,
            editZipcodeChangedBool = false,
            editZipcodeValidBool = true,
            editStateChangedBool = false,
            editStateValidBool = true,
            editEmailChangedBool = false,
            editEmailValidBool = true,
            editPhonePrimaryChangedBool = false,
            editPhonePrimaryValidBool = true,
            editPhoneSecondaryChangedBool = false,
            editPhoneSecondaryValidBool = true,
            editImageChangedBool = false,
            editImageValidBool = true,
            addFirstNameValidBool = false,
            addLastNameValidBool = false,
            addSuffixValidBool = true,
            addAddressValidBool = false,
            addCityValidBool = false,
            addZipcodeValidBool = false,
            addStateValidBool = false,
            addEmailValidBool = true,
            addEmailChangedBool = false,
            addPhonePrimaryValidBool = true,
            addPhoneSecondaryValidBool = true,
            addImageValidBool = true,
            addUsernameValidBool = false,
            addPasswordValidBool = false,
            addSecurityQuestionValidBool = false,
            addSecurityAnswersValidBool = false;

        public List<string> addresses = new List<string>();

        private double ZOOMFACTOR = 1.75;

        private int MINMAX = 2;

        bool mousePressed = false;

        float shiftedX,
            shiftedY;

        int usedX,
            usedY;

        public DataRow row = null;

        public frmManagers()
        {
            InitializeComponent();
        }

        private void frmManagers_Load(object sender, EventArgs e)
        {
            clsSQL.PopulateAllQuestions(cbxAddFirstChallengeQuestionActual, cbxAddSecondChallengeQuestionActual, cbxAddThirdChallengeQuestionActual);
        }

        //if form is visible starts timer
        private void frmManagers_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                dgvManagers.ClearSelection();

                managersTimer.Interval = 500;
                managersTimer.Tick += new EventHandler(managersTimer_Tick);

                displayTimer.Interval = 250;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                displayTimer.Start();
            }
        }

        public void managersTimer_Tick(object sender, EventArgs e)
        {
            managersTimer.Stop();
            SetAllTrue();            
            managersTimer.Dispose();
        }

        public void displayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();
            SetAllFalse();
            ManagersRefresh();            
            displayTimer.Dispose();
        }        

        /// <summary>
        /// Used to refresh data grid view.
        /// </summary>
        private void ManagersRefresh()
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                managersDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeManagerDgvSetup();
                }));

                managersTimer.Stop();
                managersDataThread.Start();
                managersTimer.Start();
            });
        }       

        /// <summary>
        /// Checks if invoking is need to make threading safe.
        /// </summary>
        public void SafeManagerDgvSetup()
        {
            if (this.dgvManagers.InvokeRequired)
            {
                Action safeWrite = delegate { SafeManagerDgvSetup(); };
                this.dgvManagers.Invoke(safeWrite);
            }
            else
            {
                ManagersDgvSetup();
            }
        }        

        /// <summary>
        /// Used to setup and link data grid view with manager info.
        /// </summary>
        private void ManagersDgvSetup()
        {
            dgvManagers.AutoGenerateColumns = false;

            if (dgvManagers.DataSource == null)
            {
                dgvManagers.DataSource = Program._bsManagers;
            }

            dgvManagers.ClearSelection();
            dgvManagers.Rows[0].Selected = true;
            byte[] bytes = null;
            row = clsSQL.DTManagersTable.Rows[0];

            pbxManagerImage.Width = pnlImage.Width;
            pbxManagerImage.Height = pnlImage.Height;

            if (row["Image"] != DBNull.Value)
            {
                bytes = (byte[])row["Image"];

                if (pbxManagerImage.Image != null)
                {
                    pbxManagerImage.Image.Dispose();
                }

                pbxManagerImage.Image = clsImage.ByteArrayToImage(bytes);
            }
            else
            {
                pbxManagerImage.Image = null;
            }
        }       

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnAddManager.Enabled = false;
            btnModifyManager.Enabled = false;
            btnRemoveManager.Enabled = false;
            btnPrintManagers.Enabled = false;
            btnMain.Enabled = false;
        }        

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnAddManager.Enabled = true;
            btnPrintManagers.Enabled = true;
            btnMain.Enabled = true;
        }        

        //shows user the add manager page
        private void btnAddManager_Click(object sender, EventArgs e)
        {
            dgvManagers.ClearSelection();
            pbxManagerImage.Image = null;
            btnPrintManagers.Enabled = false;
            btnMain.Enabled = false;
            pnlAdd.Visible = true;
            pnlAdd.AutoScroll = false;
            pnlAdd.HorizontalScroll.Enabled = false;
            pnlAdd.HorizontalScroll.Visible = false;
            pnlAdd.HorizontalScroll.Maximum = 0;
            pnlAdd.AutoScroll = true;
            
        }

        //checks if new manager has been selected and updates image
        private void dgvManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] bytes = null;
            try
            {
                for (int i = 0; i < clsSQL.DTManagersTable.Rows.Count; i++)
                {
                
                    chosenRow = clsSQL.DTManagersTable.Rows[i];
                    if (Convert.ToInt32(dgvManagers[0, e.RowIndex].Value) == Convert.ToInt32(chosenRow.Field<Int64>("PersonID").ToString()))
                    {
                        btnModifyManager.Enabled = true;
                        btnRemoveManager.Enabled = true;

                        pbxManagerImage.Width = pnlImage.Width;
                        pbxManagerImage.Height = pnlImage.Height;

                        if (chosenRow["Image"] != DBNull.Value)
                        {
                            bytes = (byte[])chosenRow["Image"];

                            pbxManagerImage.Image = clsImage.ByteArrayToImage(bytes);
                        }
                        else
                        {
                            pbxManagerImage.Image = null;
                        }

                        break;
                    }
                }                
            }
            catch (Exception)
            {
                Console.WriteLine("You chose a header");
            }
        }

        /// <summary>
        /// Used to zoom into an image.
        /// </summary>
        private void ZoomIn()
        {
            if ((pbxManagerImage.Width < (MINMAX * pnlImage.Width)) && (pbxManagerImage.Height < (MINMAX * pnlImage.Height)))
            {
                pbxManagerImage.Width = Convert.ToInt32(pbxManagerImage.Width * ZOOMFACTOR);
                pbxManagerImage.Height = Convert.ToInt32(pbxManagerImage.Height * ZOOMFACTOR);

                pbxManagerImage.Location = new Point(-Convert.ToInt32(shiftedX), -Convert.ToInt32(shiftedY));
            }
        }

        /// <summary>
        /// Used to zoom out of an image.
        /// </summary>
        private void ZoomOut()
        {
            if ((pbxManagerImage.Width > (pnlImage.Width / MINMAX)) && (pbxManagerImage.Height > (pnlImage.Height / MINMAX)))
            {
                pbxManagerImage.Width = Convert.ToInt32(pbxManagerImage.Width / ZOOMFACTOR);
                pbxManagerImage.Height = Convert.ToInt32(pbxManagerImage.Height / ZOOMFACTOR);

                pbxManagerImage.Location = new Point(0, 0);
            }
        }

        //checks if mouse button is pressed and zooms in on image
        private void pbxManagerImage_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
            ZoomIn();
        }

        //checks if mouse has moved and moves image accordingly
        private void pbxManagerImage_MouseMove(object sender, MouseEventArgs e)
        {
            int cursX = this.PointToClient(Cursor.Position).X - pnlImage.Location.X,
                cursY = this.PointToClient(Cursor.Position).Y - pnlImage.Location.Y;

            if (mousePressed)
            {
                if (cursX > 0 && cursX < pnlImage.Width && cursY > 0 && cursY < pnlImage.Height)
                {
                    //calculates where mouse is in pbxItemImage
                    Point imageMouse = new Point(cursX, cursY);

                    //grabs zoomed in coordinates
                    shiftedX = imageMouse.X * .75f;
                    shiftedY = imageMouse.Y * .75f;

                    //sets used coordinates
                    usedX = -Convert.ToInt32(shiftedX);
                    usedY = -Convert.ToInt32(shiftedY);

                    //sets location of image                
                    pbxManagerImage.Location = new Point(usedX, usedY);
                }
            }
        }

        //checks if mouse button has been released and zooms out of image
        private void pbxManagerImage_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            ZoomOut();
        }

        //checks for changes in address and validity
        private void tbxAddAddressActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateAddress(tbxAddAddressActual.Text))
            {
                lblValidAddAddress.ForeColor = Color.Green;
                lblValidAddAddress.Text = "O";
                addAddressValidBool = true;
            }
            else
            {
                lblValidAddAddress.ForeColor = Color.Red;
                lblValidAddAddress.Text = "X";
                addAddressValidBool = false;
            }
        }

        //checks for changes in city and validity
        private void tbxAddCityActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCity(tbxAddCityActual.Text))
            {
                lblValidAddCity.ForeColor = Color.Green;
                lblValidAddCity.Text = "O";
                addCityValidBool = true;
            }
            else
            {
                lblValidAddCity.ForeColor = Color.Red;
                lblValidAddCity.Text = "X";
                addCityValidBool = false;
            }
        }

        //only allows certain keys to be pressed for zipcode
        private void tbxAddZipcodeActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in zipcode and validity
        private void tbxAddZipcodeActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateZip(tbxAddZipcodeActual.Text))
            {
                lblValidAddZipcode.ForeColor = Color.Green;
                lblValidAddZipcode.Text = "O";
                addZipcodeValidBool = true;
            }
            else
            {
                lblValidAddZipcode.ForeColor = Color.Red;
                lblValidAddZipcode.Text = "X";
                addZipcodeValidBool = false;
            }
        }

        //only allows certain keys to be pressed for state
        private void tbxAddStateActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in state and validity
        private void tbxAddStateActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateState(tbxAddStateActual.Text))
            {
                lblValidAddState.ForeColor = Color.Green;
                lblValidAddState.Text = "O";
                addStateValidBool = true;
            }
            else
            {
                lblValidAddState.ForeColor = Color.Red;
                lblValidAddState.Text = "X";
                addStateValidBool = false;
            }
        }

        //checks for changes in email and validity
        private void tbxAddEmailActual_TextChanged(object sender, EventArgs e)
        {
            lblValidAddEmail.Visible = true;

            if (clsValidation.ValidateEmail(tbxAddEmailActual.Text))
            {
                lblValidAddEmail.ForeColor = Color.Green;
                lblValidAddEmail.Text = "O";
                addEmailValidBool = true;
            }
            else
            {
                lblValidAddEmail.ForeColor = Color.Red;
                lblValidAddEmail.Text = "X";
                addEmailValidBool = false;
            }
        }

        //only allows certain keys to be pressed for primary phone number
        private void tbxAddPhonePrimaryActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in primary phone number and validity
        private void tbxAddPhonePrimaryActual_TextChanged(object sender, EventArgs e)
        {
            lblValidAddPhonePrimary.Visible = true;

            if (clsValidation.ValidatePhone(tbxAddPhonePrimaryActual.Text))
            {
                lblValidAddPhonePrimary.ForeColor = Color.Green;
                lblValidAddPhonePrimary.Text = "O";
                addPhonePrimaryValidBool = true;
            }
            else
            {
                lblValidAddPhonePrimary.ForeColor = Color.Red;
                lblValidAddPhonePrimary.Text = "X";
                addPhonePrimaryValidBool = false;
            }
        }

        //only allows certain keys to be pressed for secondary phone number
        private void tbxAddPhoneSecondaryActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in secondary phone number and validity
        private void tbxAddPhoneSecondaryActual_TextChanged(object sender, EventArgs e)
        {
            lblValidAddPhoneSecondary.Visible = true;

            if (clsValidation.ValidatePhone(tbxAddPhoneSecondaryActual.Text))
            {
                lblValidAddPhoneSecondary.ForeColor = Color.Green;
                lblValidAddPhoneSecondary.Text = "O";
                addPhoneSecondaryValidBool = true;
            }
            else
            {
                lblValidAddPhoneSecondary.ForeColor = Color.Red;
                lblValidAddPhoneSecondary.Text = "X";
                addPhoneSecondaryValidBool = false;
            }
        }

        //checks for changes in username and validity
        private void tbxAddUsernameActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateUser(tbxAddUsernameActual.Text))
            {
                lblValidAddUsername.ForeColor = Color.Green;
                lblValidAddUsername.Text = "O";
                addUsernameValidBool = true;
            }
            else
            {
                lblValidAddUsername.ForeColor = Color.Red;
                lblValidAddUsername.Text = "X";
                addUsernameValidBool = false;
            }
        }

        //checks for changes in password and validity
        private void tbxAddPasswordActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePassword(tbxAddPasswordActual.Text))
            {
                lblValidAddPassword.ForeColor = Color.Green;
                lblValidAddPassword.Text = "O";
                addPasswordValidBool = true;
            }
            else
            {
                lblValidAddPassword.ForeColor = Color.Red;
                lblValidAddPassword.Text = "X";
                addPasswordValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for first challenge answer
        private void tbxAddFirstChallengeAnswerActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //only allows for certain keys to be pressed for second challenge answer
        private void tbxAddSecondChallengeAnswerActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //only allows for certain keys to be pressed for third challenge answer
        private void tbxAddThirdChallengeAnswerActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //allows user to add image and checks validity
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;

                if (clsValidation.ValidateImage(fileName))
                {
                    lblValidAddImage.ForeColor = Color.Green;
                    lblValidAddImage.Text = "O";
                    addImageValidBool = true;
                }
                else
                {
                    lblValidAddImage.ForeColor = Color.Red;
                    lblValidAddImage.Text = "X";
                    addImageValidBool = false;
                    fileName = "null";
                }
            }

            lblValidAddImage.Visible = true;
        }

        //clears new account info and hides page
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            tbxAddTitleActual.Clear();
            tbxAddFirstNameActual.Clear();
            tbxAddMiddleNameActual.Clear();
            tbxAddLastNameActual.Clear();
            tbxAddSuffixActual.Clear();
            tbxAddAddressActual.Clear();
            tbxAddCityActual.Clear();
            tbxAddZipcodeActual.Clear();
            tbxAddStateActual.Clear();
            tbxAddEmailActual.Clear();
            tbxAddPhonePrimaryActual.Clear();
            tbxAddPhoneSecondaryActual.Clear();
            tbxAddUsernameActual.Clear();
            tbxAddPasswordActual.Clear();
            cbxAddFirstChallengeQuestionActual.SelectedIndex = -1;
            tbxAddFirstChallengeAnswerActual.Clear();
            cbxAddSecondChallengeQuestionActual.SelectedIndex = -1;
            tbxAddSecondChallengeAnswerActual.Clear();
            cbxAddThirdChallengeQuestionActual.SelectedIndex = -1;
            tbxAddThirdChallengeAnswerActual.Clear();
            fileName = "null";
            displayTimer.Start();
        }

        //checks for validity of new user info and inserts into database
        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            List<string> addresses = new List<string>();
            if (tbxAddAddressActual.Text.Contains("\n"))
            {
                foreach (string address in tbxAddAddressActual.Text.Split('\n'))
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
                addresses.Add(tbxAddAddressActual.Text);
                addresses.Add("null");
                addresses.Add("null");
            }

            if (clsValidation.ValidateQuestions(cbxAddFirstChallengeQuestionActual, cbxAddSecondChallengeQuestionActual, cbxAddThirdChallengeQuestionActual) == false)
            {
                if (cbxAddFirstChallengeQuestionActual.SelectedIndex <= -1)
                {
                    cbxAddFirstChallengeQuestionActual.Focus();
                }
                else if (cbxAddSecondChallengeQuestionActual.SelectedIndex <= -1)
                {
                    cbxAddSecondChallengeQuestionActual.Focus();
                }
                else if (cbxAddThirdChallengeQuestionActual.SelectedIndex <= -1)
                {
                    cbxAddThirdChallengeQuestionActual.Focus();
                }
                addSecurityQuestionValidBool = false;
            }
            else
            {
                addSecurityQuestionValidBool = true;
            }

            if (clsValidation.ValidateAnswers(tbxAddFirstChallengeAnswerActual.Text, tbxAddSecondChallengeAnswerActual.Text, tbxAddThirdChallengeAnswerActual.Text) == false)
            {
                if (string.IsNullOrEmpty(tbxAddFirstChallengeAnswerActual.Text))
                {
                    tbxAddFirstChallengeAnswerActual.Focus();
                }
                else if (string.IsNullOrEmpty(tbxAddSecondChallengeAnswerActual.Text))
                {
                    tbxAddSecondChallengeAnswerActual.Focus();
                }
                else if (string.IsNullOrEmpty(tbxAddThirdChallengeAnswerActual.Text))
                {
                    tbxAddThirdChallengeAnswerActual.Focus();
                }
                addSecurityAnswersValidBool = false;
            }
            else
            {
                addSecurityAnswersValidBool = true;
            }

            if (clsValidation.ValidateName(tbxAddFirstNameActual, tbxAddLastNameActual))
            {
                addFirstNameValidBool = true;
                addLastNameValidBool = true;
            }
            else
            {
                addFirstNameValidBool = false;
                addLastNameValidBool = false;
            }

            if (addFirstNameValidBool && addLastNameValidBool && addAddressValidBool && addCityValidBool && addZipcodeValidBool && addStateValidBool && addEmailValidBool && addPhonePrimaryValidBool && addPhoneSecondaryValidBool && addUsernameValidBool && addPasswordValidBool && addSecurityQuestionValidBool && addSecurityAnswersValidBool)
            {
                pnlAdd.Visible = false;
                clsSQL.CreateAccount(
                    clsValidation.CheckEmpty(tbxAddTitleActual.Text),
                    tbxAddFirstNameActual.Text,
                    clsValidation.CheckEmpty(tbxAddMiddleNameActual.Text),
                    tbxAddLastNameActual.Text,
                    clsValidation.CheckEmpty(tbxAddSuffixActual.Text),
                    addresses[0],
                    addresses[1],
                    addresses[2],
                    tbxAddCityActual.Text,
                    tbxAddZipcodeActual.Text,
                    tbxAddStateActual.Text,
                    clsValidation.CheckEmpty(tbxAddEmailActual.Text),
                    clsValidation.CheckEmpty(tbxAddPhonePrimaryActual.Text),
                    clsValidation.CheckEmpty(tbxAddPhoneSecondaryActual.Text),
                    fileName,
                    1002,
                    tbxAddUsernameActual.Text,
                    tbxAddPasswordActual.Text,
                    cbxAddFirstChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddFirstChallengeAnswerActual.Text,
                    cbxAddSecondChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddSecondChallengeAnswerActual.Text,
                    cbxAddThirdChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddThirdChallengeAnswerActual.Text,
                    "Manager"
                );

                tbxAddTitleActual.Clear();
                tbxAddFirstNameActual.Clear();
                tbxAddMiddleNameActual.Clear();
                tbxAddLastNameActual.Clear();
                tbxAddSuffixActual.Clear();
                tbxAddAddressActual.Clear();
                tbxAddCityActual.Clear();
                tbxAddZipcodeActual.Clear();
                tbxAddStateActual.Clear();
                tbxAddEmailActual.Clear();
                tbxAddPhonePrimaryActual.Clear();
                tbxAddPhoneSecondaryActual.Clear();
                tbxAddUsernameActual.Clear();
                tbxAddPasswordActual.Clear();
                cbxAddFirstChallengeQuestionActual.SelectedIndex = -1;
                tbxAddFirstChallengeAnswerActual.Clear();
                cbxAddSecondChallengeQuestionActual.SelectedIndex = -1;
                tbxAddSecondChallengeAnswerActual.Clear();
                cbxAddThirdChallengeQuestionActual.SelectedIndex = -1;
                tbxAddThirdChallengeAnswerActual.Clear();
                fileName = "null";

                displayTimer.Start();
            }
        }       

        //allows user to modify selected manager
        private void btnModifyManager_Click(object sender, EventArgs e)
        {
            if (chosenRow != null)
            {
                btnPrintManagers.Enabled = false;
                btnMain.Enabled = false;
                pnlModify.Visible = true;
                pnlModify.AutoScroll = false;
                pnlModify.HorizontalScroll.Enabled = false;
                pnlModify.HorizontalScroll.Visible = false;
                pnlModify.HorizontalScroll.Maximum = 0;
                pnlModify.AutoScroll = true;

                tbxEditTitleActual.TextChanged -= tbxEditTitleActual_TextChanged;
                tbxEditFirstNameActual.TextChanged -= tbxEditFirstNameActual_TextChanged;
                tbxEditMiddleNameActual.TextChanged -= tbxEditMiddleNameActual_TextChanged;
                tbxEditLastNameActual.TextChanged -= tbxEditLastNameActual_TextChanged;
                tbxEditSuffixActual.TextChanged -= tbxEditSuffixActual_TextChanged;
                tbxEditAddressActual.TextChanged -= tbxEditAddressActual_TextChanged;
                tbxEditCityActual.TextChanged -= tbxEditCityActual_TextChanged;
                tbxEditZipcodeActual.TextChanged -= tbxEditZipcodeActual_TextChanged;
                tbxEditStateActual.TextChanged -= tbxEditStateActual_TextChanged;
                tbxEditEmailActual.TextChanged -= tbxEditEmailActual_TextChanged;
                tbxEditPhonePrimaryActual.TextChanged -= tbxEditPhonePrimaryActual_TextChanged;
                tbxEditPhoneSecondaryActual.TextChanged -= tbxEditPhoneSecondaryActual_TextChanged;

                lblValidEditAddress.ForeColor = Color.Green;
                lblValidEditAddress.Text = "O";
                lblValidEditCity.ForeColor = Color.Green;
                lblValidEditCity.Text = "O";
                lblValidEditZipcode.ForeColor = Color.Green;
                lblValidEditZipcode.Text = "O";
                lblValidEditState.ForeColor = Color.Green;
                lblValidEditState.Text = "O";
                lblValidEditEmail.ForeColor = Color.Green;
                lblValidEditEmail.Text = "O";
                lblValidEditPhonePrimary.ForeColor = Color.Green;
                lblValidEditPhonePrimary.Text = "O";
                lblValidEditPhoneSecondary.ForeColor = Color.Green;
                lblValidEditPhoneSecondary.Text = "O";
                lblValidEditImage.ForeColor = Color.Green;
                lblValidEditImage.Text = "O";

                tbxEditTitleActual.Text = chosenRow.Field<string>("Title");
                tbxEditFirstNameActual.Text = chosenRow.Field<string>("NameFirst");
                tbxEditMiddleNameActual.Text = chosenRow.Field<string>("NameMiddle");
                tbxEditLastNameActual.Text = chosenRow.Field<string>("NameLast");
                tbxEditSuffixActual.Text = chosenRow.Field<string>("Suffix");
                
                tbxEditAddressActual.Text = chosenRow.Field<string>("Address1");
                if (!string.IsNullOrEmpty(chosenRow.Field<string>("Address2")))
                {
                    tbxEditAddressActual.Text += "\n" + chosenRow.Field<string>("Address2");
                }
                if (!string.IsNullOrEmpty(chosenRow.Field<string>("Address3")))
                {
                    tbxEditAddressActual.Text += "\n" + chosenRow.Field<string>("Address3");
                }                    
                tbxEditCityActual.Text = chosenRow.Field<string>("City");
                tbxEditZipcodeActual.Text = chosenRow.Field<string>("Zipcode");
                tbxEditStateActual.Text = chosenRow.Field<string>("State");
                tbxEditEmailActual.Text = chosenRow.Field<string>("Email");
                tbxEditPhonePrimaryActual.Text = chosenRow.Field<string>("PhonePrimary");
                tbxEditPhoneSecondaryActual.Text = chosenRow.Field<string>("PhoneSecondary");

                tbxEditTitleActual.TextChanged += tbxEditTitleActual_TextChanged;
                tbxEditFirstNameActual.TextChanged += tbxEditFirstNameActual_TextChanged;
                tbxEditMiddleNameActual.TextChanged += tbxEditMiddleNameActual_TextChanged;
                tbxEditLastNameActual.TextChanged += tbxEditLastNameActual_TextChanged;
                tbxEditSuffixActual.TextChanged += tbxEditSuffixActual_TextChanged;
                tbxEditAddressActual.TextChanged += tbxEditAddressActual_TextChanged;
                tbxEditCityActual.TextChanged += tbxEditCityActual_TextChanged;
                tbxEditZipcodeActual.TextChanged += tbxEditZipcodeActual_TextChanged;
                tbxEditStateActual.TextChanged += tbxEditStateActual_TextChanged;
                tbxEditEmailActual.TextChanged += tbxEditEmailActual_TextChanged;
                tbxEditPhonePrimaryActual.TextChanged += tbxEditPhonePrimaryActual_TextChanged;
                tbxEditPhoneSecondaryActual.TextChanged += tbxEditPhoneSecondaryActual_TextChanged;
            }
        }

        private void tbxEditTitleActual_TextChanged(object sender, EventArgs e)
        {
            editTitleChangedBool = true;
        }

        private void tbxEditFirstNameActual_TextChanged(object sender, EventArgs e)
        {
            editFirstNameChangedBool = true;
        }

        private void tbxEditMiddleNameActual_TextChanged(object sender, EventArgs e)
        {
            editMiddleNameChangedBool = true;
        }

        private void tbxEditLastNameActual_TextChanged(object sender, EventArgs e)
        {
            editLastNameChangedBool = true;
        }

        private void tbxEditSuffixActual_TextChanged(object sender, EventArgs e)
        {
            editSuffixChangedBool = true;
        }

        //checks for changes in address and validity
        private void tbxEditAddressActual_TextChanged(object sender, EventArgs e)
        {
            editAddressChangedBool = true;
            if (clsValidation.ValidateAddress(tbxEditAddressActual.Text))
            {
                lblValidEditAddress.ForeColor = Color.Green;
                lblValidEditAddress.Text = "O";
                editAddressValidBool = true;
            }
            else
            {
                lblValidEditAddress.ForeColor = Color.Red;
                lblValidEditAddress.Text = "X";
                editAddressValidBool = false;
            }
        }

        //checks for changes in city and validity
        private void tbxEditCityActual_TextChanged(object sender, EventArgs e)
        {
            editCityChangedBool = true;
            if (clsValidation.ValidateCity(tbxEditCityActual.Text))
            {
                lblValidEditCity.ForeColor = Color.Green;
                lblValidEditCity.Text = "O";
                editCityValidBool = true;
            }
            else
            {
                lblValidEditCity.ForeColor = Color.Red;
                lblValidEditCity.Text = "X";
                editCityValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for zipcode
        private void tbxEditZipcodeActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in zipcode and validity
        private void tbxEditZipcodeActual_TextChanged(object sender, EventArgs e)
        {
            editZipcodeChangedBool = true;
            if (clsValidation.ValidateZip(tbxEditZipcodeActual.Text))
            {
                lblValidEditZipcode.ForeColor = Color.Green;
                lblValidEditZipcode.Text = "O";
                editZipcodeValidBool = true;
            }
            else
            {
                lblValidEditZipcode.ForeColor = Color.Red;
                lblValidEditZipcode.Text = "X";
                editZipcodeValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for state
        private void tbxEditStateActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in state and validity
        private void tbxEditStateActual_TextChanged(object sender, EventArgs e)
        {
            editStateChangedBool = true;
            if (clsValidation.ValidateState(tbxEditStateActual.Text))
            {
                lblValidEditState.ForeColor = Color.Green;
                lblValidEditState.Text = "O";
                editStateValidBool = true;
            }
            else
            {
                lblValidEditState.ForeColor = Color.Red;
                lblValidEditState.Text = "X";
                editStateValidBool = false;
            }
        }

        //checks for changes in email and validity
        private void tbxEditEmailActual_TextChanged(object sender, EventArgs e)
        {
            lblValidEditEmail.Visible = true;
            editEmailChangedBool = true;

            if (clsValidation.ValidateEmail(tbxEditEmailActual.Text))
            {
                lblValidEditEmail.ForeColor = Color.Green;
                lblValidEditEmail.Text = "O";
                editEmailValidBool = true;
            }
            else
            {
                lblValidEditEmail.ForeColor = Color.Red;
                lblValidEditEmail.Text = "X";
                editEmailValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for primary phone number
        private void tbxEditPhonePrimaryActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in primary phone number and validity
        private void tbxEditPhonePrimaryActual_TextChanged(object sender, EventArgs e)
        {
            lblValidEditPhonePrimary.Visible = true;
            editPhonePrimaryChangedBool = true;

            if (clsValidation.ValidatePhone(tbxEditPhonePrimaryActual.Text))
            {
                lblValidEditPhonePrimary.ForeColor = Color.Green;
                lblValidEditPhonePrimary.Text = "O";
                editPhonePrimaryValidBool = true;
            }
            else
            {
                lblValidEditPhonePrimary.ForeColor = Color.Red;
                lblValidEditPhonePrimary.Text = "X";
                editPhonePrimaryValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for secondary phone number
        private void tbxEditPhoneSecondaryActual_KeyPress(object sender, KeyPressEventArgs e)
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

        //checks for changes in secondary phone number and validity
        private void tbxEditPhoneSecondaryActual_TextChanged(object sender, EventArgs e)
        {
            lblValidEditPhoneSecondary.Visible = true;
            editPhoneSecondaryChangedBool = true;

            if (clsValidation.ValidatePhone(tbxEditPhoneSecondaryActual.Text))
            {
                lblValidEditPhoneSecondary.ForeColor = Color.Green;
                lblValidEditPhoneSecondary.Text = "O";
                editPhoneSecondaryValidBool = true;
            }
            else
            {
                lblValidEditPhoneSecondary.ForeColor = Color.Red;
                lblValidEditPhoneSecondary.Text = "X";
                editPhoneSecondaryValidBool = false;
            }
        }

        //allows user to add new image and checks validity of image
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;

                if (clsValidation.ValidateImage(fileName))
                {
                    lblValidEditImage.ForeColor = Color.Green;
                    lblValidEditImage.Text = "O";
                    editImageValidBool = true;
                    editImageChangedBool = true;
                }
                else
                {
                    lblValidEditImage.ForeColor = Color.Red;
                    lblValidEditImage.Text = "X";
                    editImageValidBool = false;
                    fileName = "null";
                }
            }

            lblValidEditImage.Visible = true;
        }

        //clears edited info and hides page
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            pnlModify.Visible = false;
            tbxEditTitleActual.Clear();
            tbxEditFirstNameActual.Clear();
            tbxEditMiddleNameActual.Clear();
            tbxEditLastNameActual.Clear();
            tbxEditSuffixActual.Clear();
            tbxEditAddressActual.Clear();
            tbxEditCityActual.Clear();
            tbxEditZipcodeActual.Clear();
            tbxEditStateActual.Clear();
            tbxEditEmailActual.Clear();
            tbxEditPhonePrimaryActual.Clear();
            tbxEditPhoneSecondaryActual.Clear();
            fileName = "null";
            displayTimer.Start();
        }

        //checks for validity of new info and updates manager in database
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (editFirstNameValidBool && editLastNameValidBool && editAddressValidBool && editCityValidBool && editZipcodeValidBool && editStateValidBool && editEmailValidBool && editPhonePrimaryValidBool && editPhoneSecondaryValidBool && editImageValidBool)
            {
                if (tbxAddAddressActual.Text.Contains("\n"))
                {
                    foreach (string address in tbxAddAddressActual.Text.Split('\n'))
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
                    addresses.Add(tbxAddAddressActual.Text);
                    addresses.Add("null");
                    addresses.Add("null");
                }

                if (editTitleChangedBool || editFirstNameChangedBool || editMiddleNameChangedBool || editLastNameChangedBool || editSuffixChangedBool || editAddressChangedBool || editCityChangedBool || editZipcodeChangedBool || editStateChangedBool || editEmailChangedBool || editPhonePrimaryChangedBool || editPhoneSecondaryChangedBool || editImageChangedBool)
                {
                    pnlModify.Visible = false;
                    clsSQL.ModifyPerson(
                        Convert.ToInt32(chosenRow["PersonID"].ToString()), 
                        editTitleChangedBool, 
                        editFirstNameChangedBool, 
                        editMiddleNameChangedBool, 
                        editLastNameChangedBool, 
                        editSuffixChangedBool, 
                        editAddressChangedBool, 
                        editCityChangedBool, 
                        editZipcodeChangedBool, 
                        editStateChangedBool, 
                        editEmailChangedBool, 
                        editPhonePrimaryChangedBool,
                        editPhoneSecondaryChangedBool, 
                        editImageChangedBool, 
                        tbxEditTitleActual.Text, 
                        tbxEditFirstNameActual.Text, 
                        tbxEditMiddleNameActual.Text, 
                        tbxEditLastNameActual.Text,
                        tbxEditSuffixActual.Text, 
                        addresses[0],
                        addresses[1], 
                        addresses[2],
                        tbxEditCityActual.Text, 
                        tbxEditZipcodeActual.Text, 
                        tbxEditStateActual.Text, 
                        tbxEditEmailActual.Text,
                        tbxEditPhonePrimaryActual.Text, 
                        tbxEditPhoneSecondaryActual.Text, 
                        fileName,
                        1
                    );

                    tbxEditTitleActual.Clear();
                    tbxEditFirstNameActual.Clear();
                    tbxEditMiddleNameActual.Clear();
                    tbxEditLastNameActual.Clear();
                    tbxEditSuffixActual.Clear();
                    tbxEditAddressActual.Clear();
                    tbxEditCityActual.Clear();
                    tbxEditZipcodeActual.Clear();
                    tbxEditStateActual.Clear();
                    tbxEditEmailActual.Clear();
                    tbxEditPhonePrimaryActual.Clear();
                    tbxEditPhoneSecondaryActual.Clear();
                    fileName = "null";

                    editTitleValidBool = true;
                    editTitleChangedBool = false;
                    editFirstNameValidBool = true;
                    editFirstNameChangedBool = false;
                    editMiddleNameValidBool = true;
                    editMiddleNameChangedBool = false;
                    editLastNameValidBool = true;
                    editLastNameChangedBool = false;
                    editSuffixValidBool = true;
                    editSuffixChangedBool = false;
                    editAddressValidBool = true;
                    editAddressChangedBool = false;
                    editCityValidBool = true;
                    editCityChangedBool = false;
                    editZipcodeValidBool = true;
                    editZipcodeChangedBool = false;
                    editStateValidBool = true;
                    editStateChangedBool = false;
                    editEmailValidBool = true;
                    editEmailChangedBool = false;
                    editPhonePrimaryValidBool = true;
                    editPhonePrimaryChangedBool = false;
                    editPhoneSecondaryValidBool = true;
                    editPhoneSecondaryChangedBool = false;
                    editImageValidBool = true;
                    editImageChangedBool = false;

                    displayTimer.Start();
                }
            }
        }

        //allows user to remove selected manager from database
        private void btnRemoveManager_Click(object sender, EventArgs e)
        {
            if (chosenRow != null)
            {
                SetAllFalse();
                clsSQL.RemovePerson(Convert.ToInt32(chosenRow["PersonID"].ToString()), 1);
                displayTimer.Start();
            }
        }

        //prints html report of managers
        private void btnPrintManagers_Click(object sender, EventArgs e)
        {
            clsHTML.PrintManagers(clsHTML.GenerateReceipt(clsHTML.BuildManagerReceipt()));
        }

        //takes user back to manager home form
        private void btnMain_Click(object sender, EventArgs e)
        {
            new frmManagerHome().Show();
            this.Dispose();
        }

        //allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpManagers.HelpNamespace);
        }

        private void frmManagers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
