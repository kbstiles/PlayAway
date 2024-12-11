using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SF_KStilesM2
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal static class Program
    {
        //Variables
        public static ObservableCollection<clsCategory> categoryList = new ObservableCollection<clsCategory>();

        public static ObservableCollection<clsDiscount> discountList = new ObservableCollection<clsDiscount>();

        public static BindingSource _bsItems = new BindingSource(),
            _bsSearchedItems = new BindingSource(),
            _bsManagers = new BindingSource(),
            _bsCustomers = new BindingSource(),
            _bsSearchedCustomers = new BindingSource(),
            _bsSales = new BindingSource();

        public static List<string> loggedInUserInfo = new List<string>();
        public static List<string> loggedInPOSCustomerInfo = new List<string>();

        public static string conPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlayAwayDatabase.db");

        //Runs initial database grab and starts application
        [STAThread]
        static void Main()
        {
            clsSQL.OpenDatabase();
            clsSQL.InventoryData();
            Console.WriteLine("Inventory Data ran");
            clsSQL.CategoryData();
            Console.WriteLine("Category Data ran");
            clsSQL.DiscountData();
            Console.WriteLine("Discount Data ran");
            clsSQL.ManagerData();
            Console.WriteLine("Manager Data ran");
            clsSQL.CustomerData();
            Console.WriteLine("Customer Data ran");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogon());
        }
    }
}
