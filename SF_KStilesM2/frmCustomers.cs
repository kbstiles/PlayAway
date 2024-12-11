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
    /// Form that is used to view, add, edit and remove customers.
    /// </summary>
    public partial class frmCustomers : Form
    {
        //Variables
        public System.Windows.Forms.Timer customersTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public Thread customersDataThread;

        DataRow row = null;

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

        //if form visible start timer
        private void frmCustomers_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                dgvCustomers.ClearSelection();

                customersTimer.Interval = 2000;
                customersTimer.Tick += new EventHandler(customersTimer_Tick);

                displayTimer.Interval = 500;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                displayTimer.Start();
            }
        }       

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            clsSQL.PopulateAllQuestions(cbxAddFirstChallengeQuestionActual, cbxAddSecondChallengeQuestionActual, cbxAddThirdChallengeQuestionActual);

        }

        public void customersTimer_Tick(object sender, EventArgs e)
        {
            customersTimer.Stop();
            SetAllTrue();            
            customersTimer.Dispose();
        }

        public void displayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();
            SetAllFalse();
            CustomerRefresh();            
            displayTimer.Dispose();
        }

        /// <summary>
        /// Used to refresh data grid view.
        /// </summary>
        private void CustomerRefresh()
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                customersDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeCustomerDgvSetup();
                }));

                customersTimer.Stop();
                customersDataThread.Start();
                customersTimer.Start();
            });
        }

        /// <summary>
        /// Checks if invoking is needed to keep thread safe.
        /// </summary>
        public void SafeCustomerDgvSetup()
        {
            if (this.dgvCustomers.InvokeRequired)
            {
                Action safeWrite = delegate { SafeCustomerDgvSetup(); };
                this.dgvCustomers.Invoke(safeWrite);
            }
            else
            {
                CustomersDgvSetup();
            }
        }

        /// <summary>
        /// Used to setup and link the data grid view with customer info.
        /// </summary>
        private void CustomersDgvSetup()
        {
            dgvCustomers.AutoGenerateColumns = false;

            if (dgvCustomers.DataSource == null)
            {
                dgvCustomers.DataSource = Program._bsCustomers;
            }

            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[0].Selected = true;
            byte[] bytes = null;
            row = clsSQL.DTCustomersTable.Rows[0];

            pbxCustomerImage.Width = pnlImage.Width;
            pbxCustomerImage.Height = pnlImage.Height;

            if (row["Image"] != DBNull.Value)
            {
                bytes = (byte[])row["Image"];

                if (pbxCustomerImage.Image != null)
                {
                    pbxCustomerImage.Image.Dispose();
                }

                pbxCustomerImage.Image = clsImage.ByteArrayToImage(bytes);
            }
            else
            {
                pbxCustomerImage.Image = null;
            }
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnAddCustomer.Enabled = false;
            btnModifyCustomer.Enabled = false;
            btnRemoveCustomer.Enabled = false;
            btnPrintCustomers.Enabled = false;
            btnMain.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnAddCustomer.Enabled = true;
            btnPrintCustomers.Enabled = true;
            btnMain.Enabled = true;
        }

        //checks if customer was clicked and updates image
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] bytes = null;
            try
            {
                for (int i = 0; i < clsSQL.DTCustomersTable.Rows.Count; i++)
                {
                    row = clsSQL.DTCustomersTable.Rows[i];
                    if (Convert.ToInt32(dgvCustomers[0, e.RowIndex].Value) == Convert.ToInt32(row.Field<Int64>("PersonID").ToString()))
                    {
                        btnModifyCustomer.Enabled = true;
                        btnRemoveCustomer.Enabled = true;

                        pbxCustomerImage.Width = pnlImage.Width;
                        pbxCustomerImage.Height = pnlImage.Height;

                        if (row["Image"] != DBNull.Value)
                        {
                            bytes = (byte[])row["Image"];

                            pbxCustomerImage.Image = clsImage.ByteArrayToImage(bytes);
                        }
                        else
                        {
                            pbxCustomerImage.Image = null;
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
            if ((pbxCustomerImage.Width < (MINMAX * pnlImage.Width)) && (pbxCustomerImage.Height < (MINMAX * pnlImage.Height)))
            {
                pbxCustomerImage.Width = Convert.ToInt32(pbxCustomerImage.Width * ZOOMFACTOR);
                pbxCustomerImage.Height = Convert.ToInt32(pbxCustomerImage.Height * ZOOMFACTOR);

                pbxCustomerImage.Location = new Point(-Convert.ToInt32(shiftedX), -Convert.ToInt32(shiftedY));
            }
        }

        /// <summary>
        /// Used to zoom out of an image.
        /// </summary>
        private void ZoomOut()
        {
            if ((pbxCustomerImage.Width > (pnlImage.Width / MINMAX)) && (pbxCustomerImage.Height > (pnlImage.Height / MINMAX)))
            {
                pbxCustomerImage.Width = Convert.ToInt32(pbxCustomerImage.Width / ZOOMFACTOR);
                pbxCustomerImage.Height = Convert.ToInt32(pbxCustomerImage.Height / ZOOMFACTOR);

                pbxCustomerImage.Location = new Point(0, 0);
            }
        }

        //checks if mouse button is pressed and zooms in on image
        private void pbxCustomerImage_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
            ZoomIn();
        }

        //checks for mouse movement and moves image accordingly
        private void pbxCustomerImage_MouseMove(object sender, MouseEventArgs e)
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
                    pbxCustomerImage.Location = new Point(usedX, usedY);
                }
            }
        }

        //checks if mouse button is released and zooms out of image
        private void pbxCustomerImage_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            ZoomOut();
        }

        //allows user to add a new account
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();
            pbxCustomerImage.Image = null;
            btnPrintCustomers.Enabled = false;
            btnMain.Enabled = false;
            pnlAdd.Visible = true;
            pnlAdd.AutoScroll = false;
            pnlAdd.HorizontalScroll.Enabled = false;
            pnlAdd.HorizontalScroll.Visible = false;
            pnlAdd.HorizontalScroll.Maximum = 0;
            pnlAdd.AutoScroll = true;
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

        //only allows for certain keys to be pressed for zipcode
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

        //only allows for certain keys to be pressed for state
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

        //only allows for certain keys to be pressed for primary phone number
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

        //only allows for certain keys to be pressed for secondary phone number
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

        //checks user info for validity and inserts into database
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
                    1001,
                    tbxAddUsernameActual.Text,
                    tbxAddPasswordActual.Text,
                    cbxAddFirstChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddFirstChallengeAnswerActual.Text,
                    cbxAddSecondChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddSecondChallengeAnswerActual.Text,
                    cbxAddThirdChallengeQuestionActual.SelectedIndex + 100,
                    tbxAddThirdChallengeAnswerActual.Text,
                    "Customer"
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
        
        //allows user to modify selected customer
        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                pnlModify.Visible = true;
                btnPrintCustomers.Enabled = false;
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

                tbxEditTitleActual.Text = row.Field<string>("Title");
                tbxEditFirstNameActual.Text = row.Field<string>("NameFirst");
                tbxEditMiddleNameActual.Text = row.Field<string>("NameMiddle");
                tbxEditLastNameActual.Text = row.Field<string>("NameLast");
                tbxEditSuffixActual.Text = row.Field<string>("Suffix");

                tbxEditAddressActual.Text = row.Field<string>("Address1");
                if (!string.IsNullOrEmpty(row.Field<string>("Address2")))
                {
                    tbxEditAddressActual.Text += "\n" + row.Field<string>("Address2");
                }
                if (!string.IsNullOrEmpty(row.Field<string>("Address3")))
                {
                    tbxEditAddressActual.Text += "\n" + row.Field<string>("Address3");
                }
                tbxEditCityActual.Text = row.Field<string>("City");
                tbxEditZipcodeActual.Text = row.Field<string>("Zipcode");
                tbxEditStateActual.Text = row.Field<string>("State");
                tbxEditEmailActual.Text = row.Field<string>("Email");
                tbxEditPhonePrimaryActual.Text = row.Field<string>("PhonePrimary");
                tbxEditPhoneSecondaryActual.Text = row.Field<string>("PhoneSecondary");

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

        //allows user to add an image and checks for validity
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

            lblValidAddImage.Visible = true;
        }

        //clears new info and hides page
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

        //checks for validity of changes and updates selected customer
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
                        Convert.ToInt32(row["PersonID"].ToString()),
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
                        0
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

                    displayTimer.Start();
                }
            }
        }

        //allows user to remove customer
        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                SetAllFalse();
                clsSQL.RemovePerson(Convert.ToInt32(row["PersonID"].ToString()), 0);
                displayTimer.Start();
            }
        }

        //prints html report of customers
        private void btnPrintCustomers_Click(object sender, EventArgs e)
        {
            clsHTML.PrintCustomers(clsHTML.GenerateReceipt(clsHTML.BuildCustomerReceipt()));
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
            Help.ShowHelp(this, hlpCustomers.HelpNamespace);
        }

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
