using System;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used as main hub for manager operations.
    /// </summary>
    public partial class frmManagerHome : Form
    {
        public frmManagerHome()
        {
            InitializeComponent();
        }

        //Takes user to inventory form
        private void btnInventory_Click(object sender, EventArgs e)
        {
            new frmInventory().Show();
            this.Hide();
        }

        //Takes user to managers form
        private void btnManagers_Click(object sender, EventArgs e)
        {
            new frmManagers().Show();
            this.Hide();
        }

        //takes user to customers form
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new frmCustomers().Show();
            this.Hide();
        }

        //takes user to POS form
        private void btnPOS_Click(object sender, EventArgs e)
        {
            new frmPOS().Show();
            this.Hide();
        }

        //takes user to discount codes form
        private void btnCodes_Click(object sender, EventArgs e)
        {
            new frmCodes().Show();
            this.Hide();
        }

        //takes user to sales report form
        private void btnReports_Click(object sender, EventArgs e)
        {
            new frmSalesReports().Show();        
            this.Hide();
        }

        //Allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpManagerHome.HelpNamespace);
        }

        //takes user back to login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.loggedInUserInfo.Clear();
            Program.loggedInPOSCustomerInfo.Clear();
            new frmLogon().Show();
            this.Dispose();
        }
    }
}
