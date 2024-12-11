using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used to select customer to be user for POS.
    /// </summary>
    public partial class frmPOS : Form
    {
        //Variable
        public System.Windows.Forms.Timer posCustomersTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public Thread customerDataThread;

        public DataRow row = null,
            chosenCustomer = null;

        private bool searchBool = false;

        public string managerName = "";

        public object dataSource;

        public frmPOS()
        {
            InitializeComponent();
            dataSource = Program._bsCustomers;
        }

        //if form is visible starts timer
        private void frmPOS_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                dgvCustomers.ClearSelection();

                btnChooseCustomer.Enabled = false;

                posCustomersTimer.Interval = 2000;
                posCustomersTimer.Tick += new EventHandler(posCustomersTimer_Tick);

                displayTimer.Interval = 500;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                SetAllFalse();
                displayTimer.Start();
            }
        }

        public void posCustomersTimer_Tick(object sender, EventArgs e)
        {
            SetAllTrue();
            posCustomersTimer.Stop();
            posCustomersTimer.Dispose();
        }

        public void displayTimer_Tick(object sender, EventArgs e)
        {
            CustomerRefresh();
            displayTimer.Stop();
            displayTimer.Dispose();
        }

        /// <summary>
        /// Used to refresh data grid view.
        /// </summary>
        private void CustomerRefresh()
        {

            this.BeginInvoke((MethodInvoker)delegate
            {
                customerDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeCustomerDgvSetup();
                }));

                posCustomersTimer.Stop();
                customerDataThread.Start();
                posCustomersTimer.Start();
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
                CustomersDgvSetup(dataSource);
            }
        }

        /// <summary>
        /// Used to setup and link the data grid view with customer info.
        /// </summary>
        private void CustomersDgvSetup(object dataSource)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = dataSource;

            dgvCustomers.Columns["PersonID"].DataPropertyName = "PersonID";
            dgvCustomers.Columns["Title"].DataPropertyName = "Title";
            dgvCustomers.Columns["NameFirst"].DataPropertyName = "NameFirst";
            dgvCustomers.Columns["NameMiddle"].DataPropertyName = "NameMiddle";
            dgvCustomers.Columns["NameLast"].DataPropertyName = "NameLast";
            dgvCustomers.Columns["Suffix"].DataPropertyName = "Suffix";
            dgvCustomers.Columns["Address1"].DataPropertyName = "Address1";
            dgvCustomers.Columns["Address2"].DataPropertyName = "Address2";
            dgvCustomers.Columns["Address3"].DataPropertyName = "Address3";
            dgvCustomers.Columns["City"].DataPropertyName = "City";
            dgvCustomers.Columns["Zipcode"].DataPropertyName = "Zipcode";
            dgvCustomers.Columns["State"].DataPropertyName = "State";
            dgvCustomers.Columns["Email"].DataPropertyName = "Email";
            dgvCustomers.Columns["PhonePrimary"].DataPropertyName = "PhonePrimary";
            dgvCustomers.Columns["PhoneSecondary"].DataPropertyName = "PhoneSecondary";
            dgvCustomers.Columns["PersonDeleted"].DataPropertyName = "PersonDeleted";

            dgvCustomers.AutoResizeColumns();
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnSearch.Enabled = false;
            btnClear.Enabled = false;
            dgvCustomers.Enabled = false;
            btnMain.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnSearch.Enabled = true;
            btnClear.Enabled = true;
            dgvCustomers.Enabled = true;
            btnMain.Enabled = true;
        }

        //checks if customer was selected and allows for user to move to shop
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < clsSQL.DTCustomersTable.Rows.Count; i++)
                {
                    row = clsSQL.DTCustomersTable.Rows[i];
                    if (Convert.ToInt32(dgvCustomers[0, e.RowIndex].Value) == row.Field<Int64>("PersonID"))
                    {
                        btnChooseCustomer.Enabled = true;

                        chosenCustomer = row;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Selection");
            }
        }

        //used to search for customer based on parameters
        private void btnSearch_Click(object sender, EventArgs e)
        {            
            FillBy(searchBool, tbxSearch.Text);
        }

        //clears and resets search parameters
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            searchBool = false;
            FillBy(searchBool, tbxSearch.Text);
        }

        //takes user to POS shop form
        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            clsSQL.UserInfo(Convert.ToInt32(chosenCustomer.Field<Int64>("PersonID")), Program.loggedInPOSCustomerInfo);
            new frmShopPOS().Show();
            this.Dispose();
        }

        //takes user to manager home form
        private void btnMain_Click(object sender, EventArgs e)
        {
            new frmManagerHome().Show();
            this.Dispose();
        }

        //allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPOS.HelpNamespace);
        }

        /// <summary>
        /// Fills data grid view with customers based on search parameters.
        /// </summary>
        /// <param name="searchBool">Determines if search was used</param>
        /// <param name="searchText">Holds search info</param>
        /// <example>
        /// <code>
        /// FillBy(searchBool, tbxSearch.Text);
        /// </code>
        /// </example>
        private void FillBy(bool searchBool, string searchText)
        {
            SetAllFalse();

            //makes sure search is not null or empty
            if (!string.IsNullOrEmpty(searchText))
            {
                searchBool = true;
            }
            else
            {
                searchBool = false;
            }

            //if search is used, update data grid view based on search parameters, else show all customer data
            if (searchBool)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    clsSQL.SearchCustomerData(tbxSearch.Text);
                    dataSource = Program._bsSearchedCustomers;

                    displayTimer.Stop();
                    displayTimer.Start();
                });
            }
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    dataSource = Program._bsCustomers;

                    displayTimer.Stop();
                    displayTimer.Start();
                });
            }
        }
    }
}
