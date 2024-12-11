using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form that is used to display and print sales data.
    /// </summary>
    public partial class frmSalesReports : Form
    {
        //Variables
        public System.Windows.Forms.Timer customersTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public Thread customerDataThread;

        public object customerDataSource,
            salesDataSource;

        private bool searchBool = false,
            allOrders = false;

        public DataRow row;

        public int customer = 0;

        public frmSalesReports()
        {
            InitializeComponent();
        }

        //if form is visible fill sales datatable and start timer
        private void frmSalesReports_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                customerDataSource = Program._bsCustomers;

                dgvCustomers.ClearSelection();

                tbxSearch.Text = "";

                cbxTimeFrameActual.SelectedIndex = 0;

                dtpStartDateActual.Value = DateTime.Today;
                dtpEndDateActual.Value = DateTime.Today;

                clsSQL.SalesData(dtpStartDateActual.Value.ToShortDateString(), dtpEndDateActual.Value.ToShortDateString(), customer, allOrders);
                SafeSalesDgvSetup();

                customersTimer.Interval = 2000;
                customersTimer.Tick += new EventHandler(customersTimer_Tick);

                displayTimer.Interval = 500;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                SetAllFalse();
                displayTimer.Start();
            }
            
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
                customerDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeCustomerDgvSetup();
                }));

                customersTimer.Stop();
                customerDataThread.Start();
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
                CustomersDgvSetup(customerDataSource);
            }
        }

        /// <summary>
        /// Used to setup and link the data grid view with customer info.
        /// </summary>
        /// <example>
        /// <code>
        /// CustomersDgvSetup(customerDataSource);
        /// </code>
        /// </example>
        private void CustomersDgvSetup(object dataSource)
        {
            dgvCustomers.AutoGenerateColumns = false;
            if (dgvCustomers.DataSource == null)
            {
                dgvCustomers.DataSource = dataSource;
            }
        }

        /// <summary>
        /// Checks if invoking is needed to keep thread safe.
        /// </summary>
        public void SafeSalesDgvSetup()
        {
            if (this.dgvSales.InvokeRequired)
            {
                Action safeWrite = delegate { SafeSalesDgvSetup(); };
                this.dgvSales.Invoke(safeWrite);
            }
            else
            {
                SalesDgvSetup();
            }
        }

        /// <summary>
        /// Used to setup and link the data grid view with sales info.
        /// </summary>
        private void SalesDgvSetup()
        {
            dgvSales.AutoGenerateColumns = false;
            dgvSales.DataSource = null;
            dgvSales.DataSource = Program._bsSales;
            
            dgvSales.Columns["OrderID"].DataPropertyName = "OrderID";
            dgvSales.Columns["SalePersonID"].DataPropertyName = "PersonID";
            dgvSales.Columns["PersonName"].DataPropertyName = "PersonName";
            dgvSales.Columns["OrderDate"].DataPropertyName = "OrderDate";
            dgvSales.Columns["CC_Number"].DataPropertyName = "CC_Number";
            dgvSales.Columns["InventoryID"].DataPropertyName = "InventoryID";
            dgvSales.Columns["ItemName"].DataPropertyName = "ItemName";
            dgvSales.Columns["Quantity"].DataPropertyName = "Quantity";
            dgvSales.Columns["RowTotal"].DataPropertyName = "RowTotal";

            dgvSales.AutoResizeColumns();
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnSearch.Enabled = false;
            btnReset.Enabled = false;
            cbxTimeFrameActual.Enabled = false;
            btnPrintSales.Enabled = false;
            btnMain.Enabled = false;
            dgvCustomers.Enabled = false;
            dtpStartDateActual.Enabled = false;            
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
            cbxTimeFrameActual.Enabled = true;
            btnPrintSales.Enabled = true;
            btnMain.Enabled = true;
            dgvCustomers.Enabled = true;
            dtpStartDateActual.Enabled = true;            
        }        

        //allows user to search customers by parameters
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillCustomersBy(searchBool, tbxSearch.Text);
        }

        //resets search parameters
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();
            customer = 0;
            tbxSearch.Clear();
            searchBool = false;
            FillCustomersBy(searchBool, tbxSearch.Text);
            clsSQL.SalesData(dtpStartDateActual.Value.ToShortDateString(), dtpEndDateActual.Value.ToShortDateString(), customer, allOrders);
        }

        //checks if time frame was changed and updates sales data based on new time frame
        private void cbxTimeFrameActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimeFrameActual.SelectedIndex == 0)
            {
                dtpStartDateActual.Visible = false;
                dtpEndDateActual.Visible = false;
                allOrders = true;
            }
            else if (cbxTimeFrameActual.SelectedIndex == 1)
            {
                dtpStartDateActual.Visible = true;
                dtpEndDateActual.Visible = true;
                allOrders = false;
                dtpEndDateActual.Value = dtpStartDateActual.Value;
            }
            else if (cbxTimeFrameActual.SelectedIndex == 2)
            {
                dtpStartDateActual.Visible = true;
                dtpEndDateActual.Visible = true;
                allOrders = false;
                dtpEndDateActual.Value = dtpStartDateActual.Value.AddDays(7);
            }
            else if (cbxTimeFrameActual.SelectedIndex == 3)
            {
                dtpStartDateActual.Visible = true;
                dtpEndDateActual.Visible = true;
                allOrders = false;
                dtpEndDateActual.Value = dtpStartDateActual.Value.AddMonths(1);
            }
            else if (cbxTimeFrameActual.SelectedIndex == 4)
            {
                dtpStartDateActual.Visible = true;
                dtpEndDateActual.Visible = true;
                allOrders = false;
                dtpEndDateActual.Value = dtpStartDateActual.Value.AddYears(1);
            }

            clsSQL.SalesData(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), customer, allOrders);
        }

        //prints report of sales data
        private void btnPrintSales_Click(object sender, EventArgs e)
        {
            clsHTML.PrintSalesReports(clsHTML.GenerateReceipt(clsHTML.BuildSalesReceipt(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), allOrders)));
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
            Help.ShowHelp(this, hlpSalesReports.HelpNamespace);
        }

        //allows user to view only selected customers orders
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < clsSQL.DTCustomersTable.Rows.Count; i++)
                {
                    row = clsSQL.DTCustomersTable.Rows[i];
                    if (Convert.ToInt32(dgvCustomers[0, e.RowIndex].Value) == row.Field<Int64>("PersonID"))
                    {
                        customer = Convert.ToInt32(row.Field<Int64>("PersonID"));

                        clsSQL.SalesData(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), customer, allOrders);
                        SafeSalesDgvSetup();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Selection");
            }
        }

        //checks for changes in start date and updates sales data accordingly
        private void dtpStartDateActual_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTimeFrameActual.SelectedIndex == 1)
                {
                    dtpEndDateActual.Value = dtpStartDateActual.Value;
                }
                else if (cbxTimeFrameActual.SelectedIndex == 2)
                {
                    dtpEndDateActual.Value = dtpStartDateActual.Value.AddDays(7);
                }
                else if (cbxTimeFrameActual.SelectedIndex == 3)
                {
                    dtpEndDateActual.Value = dtpStartDateActual.Value.AddMonths(1);
                }
                else if (cbxTimeFrameActual.SelectedIndex == 4)
                {
                    dtpEndDateActual.Value = dtpStartDateActual.Value.AddYears(1);
                }

                clsSQL.SalesData(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), customer, allOrders);
                SafeSalesDgvSetup();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Start Date");
            }
        }

        /// <summary>
        /// Used to update customer data grid view based on search parameters
        /// </summary>
        /// <param name="searchBool">Determines if search was used</param>
        /// <param name="searchText">Holds search parameter</param>
        /// <example>
        /// <code>
        /// FillCustomersBy(searchBool, tbxSearch.Text);
        /// </code>
        /// </example>
        private void FillCustomersBy(bool searchBool, string searchText)
        {
            SetAllFalse();

            //checks if search has actual text
            if (!string.IsNullOrEmpty(searchText))
            {
                searchBool = true;
            }
            else
            {
                searchBool = false;
            }

            //Refills data grid view based on users given parameters
            if (searchBool)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    clsSQL.SearchCustomerData(tbxSearch.Text);
                    customerDataSource = Program._bsSearchedCustomers;

                    displayTimer.Stop();
                    displayTimer.Start();
                });
            }
            //else refills data grid view based on no parameters
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    customerDataSource = Program._bsCustomers;

                    displayTimer.Stop();
                    displayTimer.Start();
                });
            }
        }

        private void frmSalesReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
