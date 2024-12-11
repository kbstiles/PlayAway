using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used to view, add, edit and remove discount codes.
    /// </summary>
    public partial class frmCodes : Form
    {
        //Variables
        public System.Windows.Forms.Timer codesTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public Thread codesDataThread;

        public clsDiscount code,
            chosenCode = null;

        public bool editDiscountCodeChangedBool = false,
            editDiscountCodeValidBool = true,
            editDescriptionChangedBool = false,
            editDescriptionValidBool = true,
            editDiscountLevelChangedBool = false,
            editDiscountLevelValidBool = true,
            editInventoryIDChangedBool = false,
            editInventoryIDValidBool = true,
            editDiscountTypeChangedBool = false,
            editDiscountTypeValidBool = true,
            editDiscountPercentageChangedBool = false,
            editDiscountPercentageValidBool = true,
            editDiscountDollarAmountChangedBool = false,
            editDiscountDollarAmountValidBool = true,
            editStartDateChangedBool = false,
            editStartDateValidBool = true,
            editStartDateNulled = false,
            editExpirationDateChangedBool = false,
            editExpirationDateValidBool = true,
            editDisabledChangedBool = false,
            editDisabledValidBool = true,
            addDiscountCodeValidBool = false,
            addDescriptionValidBool = false,
            addDiscountLevelValidBool = false,
            addInventoryIDValidBool = true,
            addDiscountTypeValidBool = false,
            addDiscountPercentageValidBool = false,
            addDiscountDollarAmountValidBool = false,
            addStartDateValidBool = true,
            addExpirationDateValidBool = false,
            addDisabledValidBool = true;


        private void frmCodes_Load(object sender, EventArgs e)
        {
            tbxAddDiscountPercentageActual.TextChanged -= tbxAddDiscountPercentageActual_TextChanged;
            tbxAddDiscountDollarAmountActual.TextChanged -= tbxAddDiscountDollarAmountActual_TextChanged;
        }

        public frmCodes()
        {
            InitializeComponent();
        }

        //if form visible starts timer
        private void frmCodes_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                dgvCodes.ClearSelection();

                codesTimer.Interval = 2000;
                codesTimer.Tick += new EventHandler(codesTimer_Tick);

                displayTimer.Interval = 500;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                SetAllFalse();
                displayTimer.Start();
            }
        }

        public void codesTimer_Tick(object sender, EventArgs e)
        {
            SetAllTrue();
            codesTimer.Stop();
            codesTimer.Dispose();
        }

        public void displayTimer_Tick(object sender, EventArgs e)
        {
            SetAllFalse();
            CodeRefresh();
            displayTimer.Stop();
            displayTimer.Dispose();
        }

        /// <summary>
        /// Used to refresh data grid view
        /// </summary>
        private void CodeRefresh()
        {

            this.BeginInvoke((MethodInvoker)delegate
            {
                codesDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeCodeDgvSetup();
                }));

                codesTimer.Stop();
                codesDataThread.Start();
                codesTimer.Start();
            });
        }

        /// <summary>
        /// Checks if invoking is need to keep threading safe.
        /// </summary>
        public void SafeCodeDgvSetup()
        {
            if (this.dgvCodes.InvokeRequired)
            {
                Action safeWrite = delegate { SafeCodeDgvSetup(); };
                this.dgvCodes.Invoke(safeWrite);
            }
            else
            {
                CodesDgvSetup();
            }
        }

        /// <summary>
        /// Used to setup and link data grid view with discount code data.
        /// </summary>
        private void CodesDgvSetup()
        {
            dgvCodes.AutoGenerateColumns = false;
            if (dgvCodes.DataSource == null)
            {
                dgvCodes.DataSource = Program.discountList;
            }

            dgvCodes.Columns["DiscountPercentage"].DefaultCellStyle.Format = "P";
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnAddCode.Enabled = false;
            btnModifyCode.Enabled = false;
            btnRemoveCode.Enabled = false;
            dgvCodes.Enabled = false;
            btnPrintCodes.Enabled = false;
            btnMain.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnAddCode.Enabled = true;
            dgvCodes.Enabled = true;
            btnPrintCodes.Enabled = true;
            btnMain.Enabled = true;
        }

        //checks if new discount code has been selected
        private void dgvCodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < Program.discountList.Count; i++)
                {
                    code = Program.discountList[i];
                    if ((dgvCodes[1, e.RowIndex].Value).Equals(code.discountCode))
                    {
                        chosenCode = Program.discountList[i];

                        btnModifyCode.Enabled = true;
                        btnRemoveCode.Enabled = true;

                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Selection");
            }
        }

        //allows user to add new discount code
        private void btnAddCode_Click(object sender, EventArgs e)
        {
            btnAddCode.Enabled = false;
            btnModifyCode.Enabled = false;
            btnRemoveCode.Enabled = false;
            btnPrintCodes.Enabled = false;
            btnMain.Enabled = false;
            pnlAdd.Visible = true;
            pnlAdd.AutoScroll = false;
            pnlAdd.HorizontalScroll.Enabled = false;
            pnlAdd.HorizontalScroll.Visible = false;
            pnlAdd.HorizontalScroll.Maximum = 0;
            pnlAdd.AutoScroll = true;
            dtpAddStartDateActual.Value = DateTime.Today;
            dtpAddExpirationDateActual.Value = DateTime.Today;
        }

        //checks for changes in discount code and validity
        private void tbxAddDiscountCodeActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesDiscountCode(tbxAddDiscountCodeActual.Text))
            {
                addDiscountCodeValidBool = true;
            }
            else
            {
                addDiscountCodeValidBool = false;
            }
        }

        //checks for changes in discoutn code description and validity
        private void tbxAddDescriptionActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesDescription(tbxAddDescriptionActual.Text))
            {
                addDescriptionValidBool = true;
            }
            else
            {
                addDescriptionValidBool = false;
            }
        }

        //checks for changes in discount level and shows appropriate options
        private void cbxAddDiscountLevelActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAddDiscountLevelActual.SelectedIndex == 0)
            {
                tbxAddInventoryIDActual.TextChanged -= tbxAddInventoryIDActual_TextChanged;
                tbxAddInventoryIDActual.Clear();
                lblAddInventoryIDLabel.Enabled = false;
                lblAddInventoryIDLabel.Visible = false;
                tbxAddInventoryIDActual.Enabled = false;
                tbxAddInventoryIDActual.Visible = false;
                lblRequired4.Enabled = false;
                lblRequired4.Visible = false;                
                addDiscountLevelValidBool = true;
                lblValidAddInventoryID.Visible = false;
            }
            else if (cbxAddDiscountLevelActual.SelectedIndex == 1)
            {
                tbxAddInventoryIDActual.TextChanged += tbxAddInventoryIDActual_TextChanged;
                tbxAddInventoryIDActual.Clear();
                lblAddInventoryIDLabel.Enabled = true;
                lblAddInventoryIDLabel.Visible = true;
                tbxAddInventoryIDActual.Enabled = true;
                tbxAddInventoryIDActual.Visible = true;
                lblRequired4.Enabled = true;
                lblRequired4.Visible = true;
                addDiscountLevelValidBool = true;
                lblValidAddInventoryID.Visible = true;
            }
            else
            {
                addDiscountLevelValidBool = false;
            }
        }

        //checks for changes in discount code inventory ID and validity
        private void tbxAddInventoryIDActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesInventoryID(tbxAddInventoryIDActual.Text))
            {
                lblValidAddInventoryID.ForeColor = Color.Green;
                lblValidAddInventoryID.Text = "O";
                addInventoryIDValidBool = true;
            }
            else
            {
                lblValidAddInventoryID.ForeColor = Color.Red;
                lblValidAddInventoryID.Text = "X";
                addInventoryIDValidBool = false;
            }
        }

        //checks for changes in discount type and shows appropriate options
        private void cbxAddDiscountTypeActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxAddDiscountPercentageActual.Clear();
            tbxAddDiscountDollarAmountActual.Clear();
            if (cbxAddDiscountTypeActual.SelectedIndex == 0)
            {
                tbxAddDiscountPercentageActual.TextChanged += tbxAddDiscountPercentageActual_TextChanged;
                tbxAddDiscountDollarAmountActual.TextChanged -= tbxAddDiscountDollarAmountActual_TextChanged;
                lblAddDiscountPercentageLabel.Enabled = true;
                lblAddDiscountPercentageLabel.Visible = true;
                tbxAddDiscountPercentageActual.Enabled = true;
                tbxAddDiscountPercentageActual.Visible = true;
                lblValidAddDiscountPercentage.Visible = true;
                lblRequired6.Visible = true;
                lblAddDiscountDollarAmountLabel.Enabled = false;
                lblAddDiscountDollarAmountLabel.Visible = false;
                tbxAddDiscountDollarAmountActual.Enabled = false;
                tbxAddDiscountDollarAmountActual.Visible = false;
                lblValidAddDiscountDollarAmount.Visible = false;
                lblRequired7.Visible = false;
                addDiscountTypeValidBool = true;
                addDiscountDollarAmountValidBool = true;
            }
            else if(cbxAddDiscountTypeActual.SelectedIndex == 1)
            {
                tbxAddDiscountPercentageActual.TextChanged -= tbxAddDiscountPercentageActual_TextChanged;
                tbxAddDiscountDollarAmountActual.TextChanged += tbxAddDiscountDollarAmountActual_TextChanged;
                lblAddDiscountPercentageLabel.Enabled = false;
                lblAddDiscountPercentageLabel.Visible = false;
                tbxAddDiscountPercentageActual.Enabled = false;
                tbxAddDiscountPercentageActual.Visible = false;
                lblValidAddDiscountPercentage.Visible = false;
                lblRequired6.Visible = false;
                lblAddDiscountDollarAmountLabel.Enabled = true;
                lblAddDiscountDollarAmountLabel.Visible = true;
                tbxAddDiscountDollarAmountActual.Enabled = true;
                tbxAddDiscountDollarAmountActual.Visible = true;
                lblValidAddDiscountDollarAmount.Visible = true;
                lblRequired7.Visible = true;
                addDiscountTypeValidBool = true;
                addDiscountPercentageValidBool = true;
            }
            else
            {
                tbxAddDiscountPercentageActual.TextChanged -= tbxAddDiscountPercentageActual_TextChanged;
                tbxAddDiscountDollarAmountActual.TextChanged -= tbxAddDiscountDollarAmountActual_TextChanged;
                lblAddDiscountPercentageLabel.Enabled = false;
                lblAddDiscountPercentageLabel.Visible = false;
                tbxAddDiscountPercentageActual.Enabled = false;
                tbxAddDiscountPercentageActual.Visible = false;
                lblValidAddDiscountPercentage.Visible = false;
                lblRequired6.Visible = false;
                lblAddDiscountDollarAmountLabel.Enabled = false;
                lblAddDiscountDollarAmountLabel.Visible = false;
                tbxAddDiscountDollarAmountActual.Enabled = false;
                tbxAddDiscountDollarAmountActual.Visible = false;
                lblValidAddDiscountDollarAmount.Visible = false;
                lblRequired7.Visible = false;
                addDiscountTypeValidBool = false;
            }
            
        }

        //checks for changes in discount code percentage and validity
        private void tbxAddDiscountPercentageActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesDiscountPercentage(tbxAddDiscountPercentageActual.Text) && tbxAddDiscountPercentageActual.Visible)
            {
                lblValidAddDiscountPercentage.ForeColor = Color.Green;
                lblValidAddDiscountPercentage.Text = "O";
                addDiscountPercentageValidBool = true;
            }
            else
            {
                lblValidAddDiscountPercentage.ForeColor = Color.Red;
                lblValidAddDiscountPercentage.Text = "X";
                addDiscountPercentageValidBool = false;
            }
        }

        //checks for changes in discount code dollar amount and validity
        private void tbxAddDiscountDollarAmountActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesDiscountDollarAmount(tbxAddDiscountDollarAmountActual.Text) && tbxAddDiscountDollarAmountActual.Visible)
            {
                lblValidAddDiscountDollarAmount.ForeColor = Color.Green;
                lblValidAddDiscountDollarAmount.Text = "O";
                addDiscountDollarAmountValidBool = true;
            }
            else
            {
                lblValidAddDiscountDollarAmount.ForeColor = Color.Red;
                lblValidAddDiscountDollarAmount.Text = "X";
                addDiscountDollarAmountValidBool = false;
            }
        }

        //checks for changes in discount code expiration date and validity
        private void dtpAddExpirationDateActual_ValueChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCodesExpirationDate(dtpAddStartDateActual.Value.ToShortDateString(), dtpAddExpirationDateActual.Value.ToShortDateString()))
            {
                lblValidAddExpirationDate.ForeColor = Color.Green;
                lblValidAddExpirationDate.Text = "O";
                addExpirationDateValidBool = true;
            }
            else
            {
                lblValidAddExpirationDate.ForeColor = Color.Red;
                lblValidAddExpirationDate.Text = "X";
                addExpirationDateValidBool = false;
            }
        }

        //clears code info and hides page
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            tbxAddDiscountCodeActual.Clear();
            tbxAddDescriptionActual.Clear();
            cbxAddDiscountLevelActual.SelectedIndex = -1;
            tbxAddInventoryIDActual.Clear();
            cbxAddDiscountTypeActual.SelectedIndex = -1;            
            tbxAddDiscountPercentageActual.Clear();
            tbxAddDiscountDollarAmountActual.Clear();
            dtpAddStartDateActual.Value = DateTime.Today;
            dtpAddExpirationDateActual.Value = DateTime.Today;
            chbxAddDisabledActual.Checked = false;

            displayTimer.Start();
        }

        //checks for validity of discount code info and inserts into database
        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            if (addDiscountCodeValidBool && addDescriptionValidBool && addDiscountLevelValidBool && addInventoryIDValidBool && addDiscountTypeValidBool && addDiscountPercentageValidBool && addDiscountDollarAmountValidBool && addExpirationDateValidBool)
            {
                pnlAdd.Visible = false;
                clsSQL.AddCode(
                    tbxAddDiscountCodeActual.Text, 
                    tbxAddDescriptionActual.Text, 
                    cbxAddDiscountLevelActual.SelectedIndex, 
                    tbxAddInventoryIDActual.Text, 
                    cbxAddDiscountTypeActual.SelectedIndex,
                    tbxAddDiscountPercentageActual.Text, 
                    tbxAddDiscountDollarAmountActual.Text, 
                    dtpAddStartDateActual.Value.ToString("yyyy-MM-dd"), 
                    dtpAddExpirationDateActual.Value.ToString("yyyy-MM-dd"), 
                    chbxAddDisabledActual.Checked
                );

                tbxAddDiscountCodeActual.Clear();
                tbxAddDescriptionActual.Clear();
                cbxAddDiscountLevelActual.SelectedIndex = -1;
                tbxAddInventoryIDActual.Clear();
                cbxAddDiscountTypeActual.SelectedIndex = -1;
                tbxAddDiscountPercentageActual.Clear();
                tbxAddDiscountDollarAmountActual.Clear();
                dtpAddStartDateActual.Value = DateTime.Today;
                dtpAddExpirationDateActual.Value = DateTime.Today;
                chbxAddDisabledActual.Checked = false;
                Console.WriteLine("Code Added");

                displayTimer.Start();
            }
        }

        //allows user to modify selected discount code
        private void btnModifyCode_Click(object sender, EventArgs e)
        {
            if (chosenCode != null)
            {
                pnlModify.Visible = true;
                btnAddCode.Enabled = false;
                btnModifyCode.Enabled = false;
                btnRemoveCode.Enabled = false;
                btnPrintCodes.Enabled = false;
                btnMain.Enabled = false;

                tbxEditDiscountCodeActual.TextChanged -= tbxEditDiscountCodeActual_TextChanged;
                tbxEditDescriptionActual.TextChanged -= tbxEditDescriptionActual_TextChanged;
                cbxEditDiscountLevelActual.TextChanged -= cbxEditDiscountLevelActual_SelectedIndexChanged;
                tbxEditInventoryIDActual.TextChanged -= tbxEditInventoryIDActual_TextChanged;
                cbxEditDiscountTypeActual.TextChanged -= cbxEditDiscountTypeActual_SelectedIndexChanged;
                tbxEditDiscountPercentageActual.TextChanged -= tbxEditDiscountPercentageActual_TextChanged;
                tbxEditDiscountDollarAmountActual.TextChanged -= tbxEditDiscountDollarAmountActual_TextChanged;
                chbxEditStartDateNull.CheckedChanged -= chbxEditStartDateNull_CheckedChanged;
                chbxEditDisabledActual.CheckedChanged -= chbxEditDisabledActual_CheckedChanged;

                lblValidEditInventoryID.ForeColor = Color.Green;
                lblValidEditInventoryID.Text = "O";
                lblValidEditDiscountPercentage.ForeColor = Color.Green;
                lblValidEditDiscountPercentage.Text = "O";
                lblValidEditDiscountDollarAmount.ForeColor = Color.Green;
                lblValidEditDiscountDollarAmount.Text = "O";
                lblValidEditExpirationDate.ForeColor = Color.Green;
                lblValidEditExpirationDate.Text = "O";

                tbxEditDiscountCodeActual.Text = chosenCode.discountCode;
                tbxEditDescriptionActual.Text = chosenCode.Description;
                cbxEditDiscountLevelActual.SelectedIndex = chosenCode.discountLevel;

                if (chosenCode.discountLevel == 0)
                {
                    lblEditInventoryIDLabel.Visible = false;
                    lblEditInventoryIDLabel.Enabled = false;
                    tbxEditInventoryIDActual.Visible = false;
                    tbxEditInventoryIDActual.Enabled = false;                    
                    lblValidEditInventoryID.Visible = false;
                    lblRequired12.Visible = false;
                }
                else 
                {
                    lblEditInventoryIDLabel.Visible = true;
                    lblEditInventoryIDLabel.Enabled = true;
                    tbxEditInventoryIDActual.Visible = true;
                    tbxEditInventoryIDActual.Enabled = true;                    
                    lblValidEditInventoryID.Visible = true;
                    lblRequired12.Visible = true;
                }

                tbxEditInventoryIDActual.Text = (chosenCode.inventoryID).ToString();
                cbxEditDiscountTypeActual.SelectedIndex = chosenCode.discountType;

                if (chosenCode.discountType == 0)
                {
                    lblEditDiscountPercentageLabel.Visible = true;
                    lblEditDiscountPercentageLabel.Enabled = true;
                    tbxEditDiscountPercentageActual.Visible = true;
                    tbxEditDiscountPercentageActual.Enabled = true;
                    lblValidEditDiscountPercentage.Visible = true;
                    lblRequired14.Visible = true;

                    lblEditDiscountDollarAmountLabel.Visible = false;
                    lblEditDiscountDollarAmountLabel.Enabled = false;
                    tbxEditDiscountDollarAmountActual.Visible = false;
                    tbxEditDiscountDollarAmountActual.Enabled = false;
                    lblValidEditDiscountDollarAmount.Visible = false;
                    lblRequired15.Visible = false;
                }
                else
                {
                    lblEditDiscountPercentageLabel.Visible = false;
                    lblEditDiscountPercentageLabel.Enabled = false;
                    tbxEditDiscountPercentageActual.Visible = false;
                    tbxEditDiscountPercentageActual.Enabled = false;
                    lblValidEditDiscountPercentage.Visible = false;
                    lblRequired14.Visible = false;

                    lblEditDiscountDollarAmountLabel.Visible = true;
                    lblEditDiscountDollarAmountLabel.Enabled = true;
                    tbxEditDiscountDollarAmountActual.Visible = true;
                    tbxEditDiscountDollarAmountActual.Enabled = true;
                    lblValidEditDiscountDollarAmount.Visible = true;
                    lblRequired15.Visible = true;
                }

                if (chosenCode.discountPercentage != null)
                {
                    tbxEditDiscountPercentageActual.Text = (Convert.ToInt32(chosenCode.discountPercentage * 100)).ToString();
                }
                else
                {
                    tbxEditDiscountPercentageActual.Text = (chosenCode.discountPercentage).ToString();
                }
                
                tbxEditDiscountDollarAmountActual.Text = (chosenCode.discountDollarAmount).ToString();

                if (chosenCode.startDate != null)
                {
                    chbxEditStartDateNull.Checked = true;
                }
                else
                {
                    chbxEditStartDateNull.Checked = false;
                }

                if (chbxEditStartDateNull.Checked)
                {
                    editStartDateNulled = false;
                    dtpEditStartDateActual.Visible = true;
                    if (chosenCode.startDate != null)
                    {
                        dtpEditStartDateActual.Value = DateTime.ParseExact(chosenCode.startDate, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        dtpEditStartDateActual.Value = DateTime.Today;
                    }
                        
                }
                else
                {
                    editStartDateNulled = true;
                    dtpEditStartDateActual.Visible = false;
                    dtpEditStartDateActual.Value = DateTime.Today;
                }

                dtpEditExpirationDateActual.Value = DateTime.ParseExact(chosenCode.expirationDate, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);

                if (chosenCode.Disabled == true)
                {
                    chbxEditDisabledActual.Checked = true;
                }
                else
                {
                    chbxEditDisabledActual.Checked = false;
                }

                tbxEditDiscountCodeActual.TextChanged += tbxEditDiscountCodeActual_TextChanged;
                tbxEditDescriptionActual.TextChanged += tbxEditDescriptionActual_TextChanged;
                cbxEditDiscountLevelActual.TextChanged += cbxEditDiscountLevelActual_SelectedIndexChanged;
                tbxEditInventoryIDActual.TextChanged += tbxEditInventoryIDActual_TextChanged;
                cbxEditDiscountTypeActual.TextChanged += cbxEditDiscountTypeActual_SelectedIndexChanged;
                tbxEditDiscountPercentageActual.TextChanged += tbxEditDiscountPercentageActual_TextChanged;
                tbxEditDiscountDollarAmountActual.TextChanged += tbxEditDiscountDollarAmountActual_TextChanged;
                chbxEditStartDateNull.CheckedChanged += chbxEditStartDateNull_CheckedChanged;
                chbxEditDisabledActual.CheckedChanged += chbxEditDisabledActual_CheckedChanged;
            }
        }

        //checks for changes in discount code and validity
        private void tbxEditDiscountCodeActual_TextChanged(object sender, EventArgs e)
        {
            editDiscountCodeChangedBool = true;

            if (clsValidation.ValidateCodesDiscountCode(tbxEditDiscountCodeActual.Text))
            {
                editDiscountCodeValidBool = true;
            }
            else
            {
                editDiscountCodeValidBool = false;
            }
        }

        //checks for changes in discount code description and validity
        private void tbxEditDescriptionActual_TextChanged(object sender, EventArgs e)
        {
            editDescriptionChangedBool = true;

            if (clsValidation.ValidateCodesDescription(tbxEditDescriptionActual.Text))
            {
                editDescriptionValidBool = true;
            }
            else
            {
                editDescriptionValidBool = false;
            }
        }

        //checks for changes in discount level and shows appropriate options
        private void cbxEditDiscountLevelActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDiscountLevelChangedBool = true;
            editInventoryIDChangedBool = true;
            

            if (cbxEditDiscountLevelActual.SelectedIndex == 0)
            {                
                tbxEditInventoryIDActual.TextChanged -= tbxEditInventoryIDActual_TextChanged;
                lblEditInventoryIDLabel.Enabled = false;
                lblEditInventoryIDLabel.Visible = false;
                tbxEditInventoryIDActual.Enabled = false;
                tbxEditInventoryIDActual.Visible = false;
                lblValidEditInventoryID.Enabled = false;
                lblValidEditInventoryID.Visible = false;
                lblRequired12.Enabled = false;
                lblRequired12.Visible = false;
                editDiscountLevelValidBool = true;
            }
            else if (cbxEditDiscountLevelActual.SelectedIndex == 1)
            {
                tbxEditInventoryIDActual.Text = (chosenCode.inventoryID).ToString();
                if (string.IsNullOrEmpty(tbxEditInventoryIDActual.Text))
                {
                    lblValidEditInventoryID.ForeColor = Color.Red;
                    lblValidEditInventoryID.Text = "X";
                }
                tbxEditInventoryIDActual.TextChanged += tbxEditInventoryIDActual_TextChanged;
                lblEditInventoryIDLabel.Enabled = true;
                lblEditInventoryIDLabel.Visible = true;
                tbxEditInventoryIDActual.Enabled = true;
                tbxEditInventoryIDActual.Visible = true;
                lblValidEditInventoryID.Enabled = true;
                lblValidEditInventoryID.Visible = true;
                lblRequired12.Enabled = true;
                lblRequired12.Visible = true;
                editDiscountLevelValidBool = true;
            }
            else
            {
                editDiscountLevelValidBool = false;
            }
        }

        //checks for changes in discount code inventory ID and validity
        private void tbxEditInventoryIDActual_TextChanged(object sender, EventArgs e)
        {
            editInventoryIDChangedBool = true;

            if (clsValidation.ValidateCodesInventoryID(tbxEditInventoryIDActual.Text))
            {
                lblValidEditInventoryID.ForeColor = Color.Green;
                lblValidEditInventoryID.Text = "O";
                editInventoryIDValidBool = true;

            }
            else
            {
                lblValidEditInventoryID.ForeColor = Color.Red;
                lblValidEditInventoryID.Text = "X";
                editInventoryIDValidBool = false;
            }
        }

        //checks for changes in discount type and shows appropriate options
        private void cbxEditDiscountTypeActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            editDiscountTypeChangedBool = true;
            editDiscountPercentageChangedBool = true;
            editDiscountDollarAmountChangedBool = true;

            if (cbxEditDiscountTypeActual.SelectedIndex == 0)
            {
                tbxEditDiscountPercentageActual.TextChanged += tbxEditDiscountPercentageActual_TextChanged;
                tbxEditDiscountDollarAmountActual.TextChanged -= tbxEditDiscountDollarAmountActual_TextChanged;
                lblEditDiscountPercentageLabel.Enabled = true;
                lblEditDiscountPercentageLabel.Visible = true;
                tbxEditDiscountPercentageActual.Enabled = true;
                tbxEditDiscountPercentageActual.Visible = true;
                lblValidEditDiscountPercentage.Visible = true;
                if (string.IsNullOrEmpty(tbxEditDiscountPercentageActual.Text))
                {
                    lblValidEditDiscountPercentage.ForeColor = Color.Red;
                    lblValidEditDiscountPercentage.Text = "X";
                }                    
                lblRequired14.Visible = true;
                lblEditDiscountDollarAmountLabel.Enabled = false;
                lblEditDiscountDollarAmountLabel.Visible = false;
                tbxEditDiscountDollarAmountActual.Enabled = false;
                tbxEditDiscountDollarAmountActual.Visible = false;
                lblValidEditDiscountDollarAmount.Visible = false;
                lblRequired15.Visible = false;
                editDiscountTypeValidBool = true;
            }
            else if (cbxEditDiscountTypeActual.SelectedIndex == 1)
            {
                tbxEditDiscountPercentageActual.TextChanged -= tbxEditDiscountPercentageActual_TextChanged;
                tbxEditDiscountDollarAmountActual.TextChanged += tbxEditDiscountDollarAmountActual_TextChanged;
                lblEditDiscountPercentageLabel.Enabled = false;
                lblEditDiscountPercentageLabel.Visible = false;
                tbxEditDiscountPercentageActual.Enabled = false;
                tbxEditDiscountPercentageActual.Visible = false;
                lblValidEditDiscountPercentage.Visible = false;
                lblRequired14.Visible = false;
                lblEditDiscountDollarAmountLabel.Enabled = true;
                lblEditDiscountDollarAmountLabel.Visible = true;
                tbxEditDiscountDollarAmountActual.Enabled = true;
                tbxEditDiscountDollarAmountActual.Visible = true;
                lblValidEditDiscountDollarAmount.Visible = true;
                if (string.IsNullOrEmpty(tbxEditDiscountDollarAmountActual.Text))
                {
                    lblValidEditDiscountDollarAmount.ForeColor = Color.Red;
                    lblValidEditDiscountDollarAmount.Text = "X";
                }
                lblRequired15.Visible = true;
                editDiscountTypeValidBool = true;
            }
        }

        //checks for changes in discount percentage and validity
        private void tbxEditDiscountPercentageActual_TextChanged(object sender, EventArgs e)
        {
            editDiscountPercentageChangedBool = true;

            if (clsValidation.ValidateCodesDiscountPercentage(tbxEditDiscountPercentageActual.Text) && tbxEditDiscountPercentageActual.Visible)
            {
                lblValidEditDiscountPercentage.ForeColor = Color.Green;
                lblValidEditDiscountPercentage.Text = "O";
                editDiscountPercentageValidBool = true;
            }
            else
            {
                lblValidEditDiscountPercentage.ForeColor = Color.Red;
                lblValidEditDiscountPercentage.Text = "X";
                editDiscountPercentageValidBool = false;
            }
        }

        //checks for changes in discount dollar amount and validity
        private void tbxEditDiscountDollarAmountActual_TextChanged(object sender, EventArgs e)
        {
            editDiscountDollarAmountChangedBool = true;

            if (clsValidation.ValidateCodesDiscountDollarAmount(tbxEditDiscountDollarAmountActual.Text) && tbxEditDiscountDollarAmountActual.Visible)
            {
                lblValidEditDiscountDollarAmount.ForeColor = Color.Green;
                lblValidEditDiscountDollarAmount.Text = "O";
                editDiscountDollarAmountValidBool = true;
            }
            else
            {
                lblValidEditDiscountDollarAmount.ForeColor = Color.Red;
                lblValidEditDiscountDollarAmount.Text = "X";
                editDiscountDollarAmountValidBool = false;
            }
        }

        private void dtpEditStartDateActual_ValueChanged(object sender, EventArgs e)
        {
            editStartDateChangedBool = true;
        }

        //checks if start date null value is changed
        private void chbxEditStartDateNull_CheckedChanged(object sender, EventArgs e)
        {
            editStartDateChangedBool = true;

            if (chbxEditStartDateNull.Checked)
            {
                editStartDateNulled = false;
                dtpEditStartDateActual.Enabled = true;
                dtpEditStartDateActual.Visible = true;
            }
            else
            {
                editStartDateNulled = true;
                dtpEditStartDateActual.Enabled = false;
                dtpEditStartDateActual.Visible = false;
            }
        }

        //checks for changes in discount code expiration date and validity
        private void dtpEditExpirationDateActual_ValueChanged(object sender, EventArgs e)
        {
            editExpirationDateChangedBool = true;

            if (clsValidation.ValidateCodesExpirationDate(dtpEditStartDateActual.Value.ToShortDateString(), dtpEditExpirationDateActual.Value.ToShortDateString()))
            {
                lblValidEditExpirationDate.ForeColor = Color.Green;
                lblValidEditExpirationDate.Text = "O";
                editExpirationDateValidBool = true;
            }
            else
            {
                lblValidEditExpirationDate.ForeColor = Color.Green;
                lblValidEditExpirationDate.Text = "O";
                editExpirationDateValidBool = true;
            }
        }

        //checks for changes in discount code disabled
        private void chbxEditDisabledActual_CheckedChanged(object sender, EventArgs e)
        {
            editDisabledChangedBool = true;

            if (chbxEditDisabledActual.Checked)
            {
                editDisabledValidBool = true;
            }
            else
            {
                editDisabledValidBool = false;
            }
        }

        //clears new code info and hides page
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            pnlModify.Visible = false;
            tbxEditDiscountCodeActual.Clear();
            tbxEditDescriptionActual.Clear();
            cbxEditDiscountLevelActual.SelectedIndex = -1;
            tbxEditInventoryIDActual.Clear();
            tbxEditInventoryIDActual.Visible = false;
            cbxEditDiscountTypeActual.SelectedIndex = -1;
            tbxEditDiscountPercentageActual.Clear();
            tbxEditDiscountPercentageActual.Visible = false;
            tbxEditDiscountDollarAmountActual.Clear();
            tbxEditDiscountDollarAmountActual.Visible = false;
            dtpEditStartDateActual.Value = DateTime.Today;
            dtpEditExpirationDateActual.Value = DateTime.Today;
            chbxEditDisabledActual.Checked = false;

            displayTimer.Start();
        }

        //checks for validity of new discount code info and updates selected discount code
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (((cbxEditDiscountLevelActual.SelectedIndex == 0) || (cbxEditDiscountLevelActual.SelectedIndex == 1 && editInventoryIDValidBool)) && ((cbxEditDiscountTypeActual.SelectedIndex == 0 && editDiscountPercentageValidBool) || (cbxEditDiscountTypeActual.SelectedIndex == 1 && editDiscountDollarAmountValidBool)) && editExpirationDateValidBool)
            {
                pnlModify.Visible = false;
                clsSQL.ModifyCode(
                    chosenCode.discountID,
                    tbxEditDiscountCodeActual.Text,
                    editDiscountCodeChangedBool,
                    tbxEditDescriptionActual.Text,
                    editDescriptionChangedBool,
                    cbxEditDiscountLevelActual.SelectedIndex,
                    editDiscountLevelChangedBool,
                    tbxEditInventoryIDActual.Text,
                    editInventoryIDChangedBool,
                    cbxEditDiscountTypeActual.SelectedIndex,
                    editDiscountTypeChangedBool,
                    tbxEditDiscountPercentageActual.Text,
                    editDiscountPercentageChangedBool,
                    tbxEditDiscountDollarAmountActual.Text,
                    editDiscountDollarAmountChangedBool,
                    dtpEditStartDateActual.Value.ToShortDateString(),
                    editStartDateChangedBool,
                    editStartDateNulled,
                    dtpEditExpirationDateActual.Value.ToShortDateString(),
                    editExpirationDateChangedBool,
                    chbxEditDisabledActual.Checked,
                    editDisabledChangedBool
                );

                tbxEditDiscountCodeActual.Clear();
                tbxEditDescriptionActual.Clear();
                cbxEditDiscountLevelActual.SelectedIndex = -1;
                tbxEditInventoryIDActual.Clear();
                tbxEditInventoryIDActual.Visible = false;
                cbxEditDiscountTypeActual.SelectedIndex = -1;
                tbxEditDiscountPercentageActual.Clear();
                tbxEditDiscountPercentageActual.Visible = false;
                tbxEditDiscountDollarAmountActual.Clear();
                tbxEditDiscountDollarAmountActual.Visible = false;
                chbxEditDisabledActual.Checked = false;
                Console.WriteLine("Code Modified");

                displayTimer.Start();
            }
        }

        //allows user to remove selected discount code from database
        private void btnRemoveCode_Click(object sender, EventArgs e)
        {
            if (chosenCode != null)
            {
                SetAllFalse();
                clsSQL.RemoveCode(chosenCode.discountID);
                displayTimer.Start();
            }
        }       

        //prints report of discount codes
        private void btnPrintCodes_Click(object sender, EventArgs e)
        {
            clsHTML.PrintDiscounts(clsHTML.GenerateReceipt(clsHTML.BuildDiscountReceipt()));
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
            Help.ShowHelp(this, hlpCodes.HelpNamespace);
        }

        private void frmCodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
