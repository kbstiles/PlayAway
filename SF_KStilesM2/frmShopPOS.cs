using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System;
using System.Globalization;
using System.Collections.ObjectModel;
using System.Drawing;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form that is used as the shop for POS.
    /// </summary>
    public partial class frmShopPOS : Form
    {
        //Variables
        public static clsOrderDetails orderDetails;

        public static ObservableCollection<clsOrderDetails> orderDetailsList = new ObservableCollection<clsOrderDetails>();

        public System.Windows.Forms.Timer dataTimer = new System.Windows.Forms.Timer();

        public bool searchBool,
            categoryBool,
            priceBool,
            clearBool = false;

        public decimal lowerPrice = 0,
            upperPrice = 0;

        public string search = "",
            category = "";

        public static int categoryID,
            cartCount;

        public bool itemAdded = false,
            categoryAdded = false;

        public Thread shopDataThread;

        public DataRow row = null;

        public static clsOrders order;

        private double ZOOMFACTOR = 1.75;

        private int MINMAX = 2;

        bool mousePressed = false;

        float shiftedX,
            shiftedY;

        int usedX,
            usedY;

        //fills up cart based on selected customer
        public frmShopPOS()
        {
            InitializeComponent();
            clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), orderDetailsList);
            cartCount = 0;
            foreach (clsOrderDetails orderDetail in orderDetailsList)
            {
                cartCount += orderDetail.GetQuantity();
            }
            lblCartCount.Text = cartCount.ToString();
        }

        //starts ListBox and ComboBox setup
        private void frmShopPOS_Load(object sender, System.EventArgs e)
        {
            orderDetailsList.CollectionChanged += orderDetailsList_CollectionChanged;
            lbxItems.SelectedIndexChanged -= lbxItems_SelectedIndexChanged;
            dataTimer.Interval = 2000;
            dataTimer.Tick += new EventHandler(dataTimer_Tick);

            SetAllFalse();

            LbxSetup(Program._bsItems);
            CbxSetup();
        }

        //checks for changes in cart and updates
        private void orderDetailsList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            cartCount = 0;
            foreach (clsOrderDetails orderDetail in orderDetailsList)
            {
                cartCount += orderDetail.GetQuantity();
            }
            lblCartCount.Text = cartCount.ToString();
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            tbxSearch.Enabled = false;
            btnSearch.Enabled = false;
            cbxCategories.Enabled = false;
            cbxPrice.Enabled = false;
            btnClear.Enabled = false;
            lbxItems.Enabled = false;
            cbxQuantity.Enabled = false;
            btnAddToCart.Enabled = false;
            btnCart.Enabled = false;
            btnMain.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            tbxSearch.Enabled = true;
            btnSearch.Enabled = true;
            cbxCategories.Enabled = true;
            cbxPrice.Enabled = true;
            btnClear.Enabled = true;
            lbxItems.Enabled = true;

            if (Program.loggedInUserInfo.Count != 0)
            {
                cbxQuantity.Enabled = true;
                btnAddToCart.Enabled = true;
                btnCart.Enabled = true;
            }

            btnMain.Enabled = true;
        }        

        public void dataTimer_Tick(object sender, EventArgs e)
        {
            SetAllTrue();
            lbxItems.SelectedIndexChanged += lbxItems_SelectedIndexChanged;
            if (clearBool)
            {
                cbxCategories.SelectedIndexChanged += cbxCategories_SelectedIndexChanged;
                cbxPrice.SelectedIndexChanged += cbxPrice_SelectedIndexChanged;
            }
            clearBool = false;
            dataTimer.Stop();
            dataTimer.Dispose();
        }

        //allows uesr to filter items by search parameters
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxItems.SelectedIndexChanged -= lbxItems_SelectedIndexChanged;
            search = tbxSearch.Text;
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                searchBool = false;
            }
            else
            {
                searchBool = true;
            }
            FillBy(searchBool, categoryBool, priceBool, search, category, lowerPrice, upperPrice);
        }

        //allows user to filter items by category
        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxItems.SelectedIndexChanged -= lbxItems_SelectedIndexChanged;
            if (cbxCategories.SelectedIndex == -1 || cbxCategories.SelectedIndex == 0)
            {
                categoryBool = false;
            }
            else
            {
                categoryBool = true;
                category = cbxCategories.SelectedItem.ToString();
            }
            FillBy(searchBool, categoryBool, priceBool, search, category, lowerPrice, upperPrice);
        }

        //allows user to filter items by price range
        private void cbxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxItems.SelectedIndexChanged -= lbxItems_SelectedIndexChanged;
            if (cbxPrice.SelectedIndex == -1 || cbxPrice.SelectedIndex == 0)
            {
                priceBool = false;
            }
            else
            {
                priceBool = true;
                switch (cbxPrice.SelectedIndex)
                {
                    case 1:
                        lowerPrice = 0.00M;
                        upperPrice = 9.99M;
                        break;
                    case 2:
                        lowerPrice = 10.00M;
                        upperPrice = 19.99M;
                        break;
                    case 3:
                        lowerPrice = 20.00M;
                        upperPrice = 29.99M;
                        break;
                    case 4:
                        lowerPrice = 30.00M;
                        upperPrice = 39.99M;
                        break;
                    case 5:
                        lowerPrice = 40.00M;
                        upperPrice = 49.99M;
                        break;
                    case 6:
                        lowerPrice = 50.00M;
                        upperPrice = 9999999.99M;
                        break;
                }
            }
            FillBy(searchBool, categoryBool, priceBool, search, category, lowerPrice, upperPrice);
        }

        //clears filter and search parameters
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBool = true;
            lbxItems.SelectedIndexChanged -= lbxItems_SelectedIndexChanged;
            cbxCategories.SelectedIndexChanged -= cbxCategories_SelectedIndexChanged;
            cbxPrice.SelectedIndexChanged -= cbxPrice_SelectedIndexChanged;
            tbxSearch.Clear();
            cbxCategories.SelectedIndex = 0;
            cbxCategories.Text = "Categories";
            cbxPrice.SelectedIndex = 0;
            cbxPrice.Text = "Price Filter";
            searchBool = false;
            categoryBool = false;
            priceBool = false;
            FillBy(searchBool, categoryBool, priceBool, search, category, lowerPrice, upperPrice);
        }

        /// <summary>
        /// Used to setup and link ListBox with inventory data.
        /// </summary>
        /// <param name="ds">Holds binding source to be used as link</param>
        /// <example>
        /// <code>
        /// LbxSetup(Program._bsItems);
        /// </code>
        /// </example>
        public void LbxSetup(BindingSource ds)
        {
            if (this.lbxItems.InvokeRequired)
            {
                Action safeWrite = delegate { LbxSetup(ds); };
                this.lbxItems.Invoke(safeWrite);
            }
            else
            {
                //initial link and filter
                ds.Filter = "(Discontinued IS NULL OR Discontinued = 0) AND Quantity > 0";
                this.lbxItems.DataSource = ds;
                this.lbxItems.DisplayMember = "itemName";
                this.lbxItems.Refresh();

                byte[] bytes = null;
                cbxQuantity.Items.Clear();

                //selects first item and display its info and image
                for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
                {
                    row = clsSQL.DTInventoryTable.Rows[i];

                    if (row.Field<Int64>("InventoryID") == Convert.ToInt32((((DataRowView)lbxItems.SelectedItem)["InventoryID"])))
                    {
                        if (this.lbxItems.Items.Count != 0)
                        {
                            this.lbxItems.SelectedIndex = 0;

                            tbxDescriptionActual.Text = row.Field<string>("ItemDescription");

                            foreach (clsCategory category in Program.categoryList)
                            {
                                if (category.categoryID == row.Field<Int64>("CategoryID"))
                                {
                                    lblCategoryActual.Text = category.categoryName;
                                    break;
                                }
                            }

                            pbxItemImage.Width = pnlImage.Width;
                            pbxItemImage.Height = pnlImage.Height;

                            if (row["ItemImage"] != DBNull.Value)
                            {
                                bytes = (byte[])row["ItemImage"];

                                if (pbxItemImage.Image != null)
                                {
                                    pbxItemImage.Image.Dispose();
                                }

                                pbxItemImage.Image = clsImage.ByteArrayToImage(bytes);
                            }
                            else
                            {
                                pbxItemImage.Image = null;
                            }

                            lblQuantityActual.Text = row.Field<Int64>("Quantity").ToString();

                            lblPriceActual.Text = row.Field<decimal>("RetailPrice").ToString("C", CultureInfo.CurrentCulture);

                            for (int j = 1; j < row.Field<Int64>("Quantity") + 1; j++)
                            {
                                cbxQuantity.Items.Add(j);
                            }
                            cbxQuantity.SelectedItem = 1;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Used to fill ComboBox with categories.
        /// </summary>
        public void CbxSetup()
        {
            cbxCategories.Items.Add("None");
            foreach (clsCategory category in Program.categoryList)
            {
                cbxCategories.Items.Add(category.categoryName);
            }
            cbxCategories.Refresh();
        }

        /// <summary>
        /// Used to zoom in on an image.
        /// </summary>
        private void ZoomIn()
        {
            if ((pbxItemImage.Width < (MINMAX * pnlImage.Width)) && (pbxItemImage.Height < (MINMAX * pnlImage.Height)))
            {
                pbxItemImage.Width = Convert.ToInt32(pbxItemImage.Width * ZOOMFACTOR);
                pbxItemImage.Height = Convert.ToInt32(pbxItemImage.Height * ZOOMFACTOR);

                pbxItemImage.Location = new Point(-Convert.ToInt32(shiftedX), -Convert.ToInt32(shiftedY));
            }
        }

        /// <summary>
        /// Used to zoom out of an image.
        /// </summary>
        private void ZoomOut()
        {
            if ((pbxItemImage.Width > (pnlImage.Width / MINMAX)) && (pbxItemImage.Height > (pnlImage.Height / MINMAX)))
            {
                pbxItemImage.Width = Convert.ToInt32(pbxItemImage.Width / ZOOMFACTOR);
                pbxItemImage.Height = Convert.ToInt32(pbxItemImage.Height / ZOOMFACTOR);

                pbxItemImage.Location = new Point(0, 0);
            }
        }

        //checks if mouse button is pressed and zooms in on image
        private void pbxItemImage_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
            ZoomIn();
        }

        //checks for mouse movement and moves image accordingly
        private void pbxItemImage_MouseMove(object sender, MouseEventArgs e)
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
                    pbxItemImage.Location = new Point(usedX, usedY);
                }
            }
        }

        //checks if mouse button is released and zooms out of image
        private void pbxItemImage_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            ZoomOut();
        }

        //checks if a new item has been selected and changes page info accordingly
        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] bytes = null;
            cbxQuantity.Items.Clear();

            for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
            {
                row = clsSQL.DTInventoryTable.Rows[i];

                if (row.Field<Int64>("InventoryID") == Convert.ToInt32((((DataRowView)lbxItems.SelectedItem)["InventoryID"])))
                {
                    tbxDescriptionActual.Text = row.Field<string>("ItemDescription");

                    foreach (clsCategory category in Program.categoryList)
                    {
                        if (category.categoryID == row.Field<Int64>("CategoryID"))
                        {
                            lblCategoryActual.Text = category.categoryName;
                            break;
                        }
                    }

                    pbxItemImage.Width = pnlImage.Width;
                    pbxItemImage.Height = pnlImage.Height;

                    if (row["ItemImage"] != DBNull.Value)
                    {
                        bytes = (byte[])row["ItemImage"];

                        pbxItemImage.Image.Dispose();

                        pbxItemImage.Image = clsImage.ByteArrayToImage(bytes);
                    }
                    else
                    {
                        pbxItemImage.Image = null;
                    }

                    lblQuantityActual.Text = row.Field<Int64>("Quantity").ToString();

                    lblPriceActual.Text = row.Field<decimal>("RetailPrice").ToString("C", CultureInfo.CurrentCulture);

                    for (int j = 1; j < row.Field<Int64>("Quantity") + 1; j++)
                    {
                        cbxQuantity.Items.Add(j);
                    }

                    cbxQuantity.SelectedItem = 1;
                }
            }
        }

        //allows user to add item to cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //Variables
            bool existingOrderDetail = false;

            int itemQuantity = Convert.ToInt32(cbxQuantity.SelectedItem);

            //Checks to make sure an item is selected
            if (lbxItems.SelectedIndex == -1)
            {
                tbxSearch.Text = "Select a product.";
            }
            else
            {
                //Gets selected items row in database
                for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
                {
                    row = clsSQL.DTInventoryTable.Rows[i];

                    if (row.Field<Int64>("InventoryID") == Convert.ToInt32((((DataRowView)lbxItems.SelectedItem)["InventoryID"])))
                    {                        
                        break;
                    }
                }

                //Checks to make sure user selected valid amount
                if (clsValidation.ValidQuantity(itemQuantity, Convert.ToInt32(row.Field<Int64>("Quantity"))))
                {
                    foreach(clsOrderDetails orderDetail in orderDetailsList)
                    {
                        //Checks if current item already exists in cart, if so then adds to item quantity
                        if (orderDetail.GetInventoryID() == row.Field<Int64>("InventoryID"))
                        {
                            existingOrderDetail = true;
                            if (clsValidation.ValidQuantity(itemQuantity + orderDetail.GetQuantity(), Convert.ToInt32(row.Field<Int64>("Quantity"))))
                            {
                                clsSQL.AddEmployeeID(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(Program.loggedInUserInfo[0]));
                                clsSQL.AddToCartItemQuantity(clsSQL.GetID(false, "OrderDetailsID", "OrderDetails", true, orderDetail.GetOrderID(), orderDetail.GetInventoryID()), itemQuantity);

                                break;
                            }
                        }
                    }

                    //If user doesn't have item already in cart
                    if (existingOrderDetail == false)
                    {
                        order = new clsOrders(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), Convert.ToInt32(Program.loggedInUserInfo[0]), "", "", "");

                        //if OTHER items are in cart
                        if (orderDetailsList.Count != 0)
                        {
                            clsSQL.AddEmployeeID(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(Program.loggedInUserInfo[0]));
                            order.SetOrderID(clsSQL.GetID(true, "OrderID", "Orders", false, null));
                        }
                        //else if cart is empty
                        else
                        {
                            clsSQL.CreateOrder(order);
                        }

                        clsSQL.CreateOrderDetails(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(row.Field<Int64>("InventoryID")), Convert.ToInt32(cbxQuantity.SelectedItem));
                    }

                    clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), orderDetailsList);
                }
            }
        }

        //takes user to cart form
        private void btnCart_Click(object sender, EventArgs e)
        {
            if (orderDetailsList.Count != 0)
            {
                this.Hide();
                new frmCartPOS().Show();
            }
        }

        //takes user back to manager home form
        private void btnMain_Click(object sender, EventArgs e)
        {
            Program.loggedInPOSCustomerInfo.Clear();
            new frmPOS().Show();
            this.Dispose();
        }

        //allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpShopPOS.HelpNamespace);
        }

        private void frmShopPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbxItems.Dispose();
            cbxCategories.Items.Clear();
            cbxCategories.Dispose();
        }

        /// <summary>
        /// Used to fill ListBox based on search filter and parameters.
        /// </summary>
        /// <param name="searchBool">Determines if search was used</param>
        /// <param name="categoryBool">Determines if category filter was used</param>
        /// <param name="priceBool">Determines if price filter was used</param>
        /// <param name="search">Holds user inputted search parameter</param>
        /// <param name="category">Holds selected category</param>
        /// <param name="lowerPrice">Holds selected lower price range</param>
        /// <param name="upperPrice">Holds selected upper price range</param>
        /// <example>
        /// <code>
        /// FillBy(searchBool, categoryBool, priceBool, search, category, lowerPrice, upperPrice);
        /// </code>
        /// </example>
        public void FillBy(bool searchBool, bool categoryBool, bool priceBool, string search, string category, decimal lowerPrice, decimal upperPrice)
        {
            //clears up page
            SetAllFalse();
            lbxItems.ClearSelected();
            lbxItems.DataSource = null;
            tbxDescriptionActual.Text = "";
            lblCategoryActual.Text = "";
            lblQuantityActual.Text = "";
            lblPriceActual.Text = "";
            pbxItemImage.Image = null;
            cbxQuantity.SelectedIndex = -1;
            cbxQuantity.Items.Clear();

            //checks if search has actual text
            if (string.IsNullOrEmpty(search))
            {
                searchBool = false;
            }

            //grabs selected category from database
            if (categoryBool)
            {
                foreach (clsCategory cat in Program.categoryList)
                {
                    if (category.Equals(cat.categoryName))
                    {
                        categoryID = cat.categoryID;
                    }
                }
            }

            //Refills ListBox based on users given parameters
            if (searchBool || categoryBool || priceBool)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    shopDataThread = new Thread(new ThreadStart(delegate
                    {
                        clsSQL.SearchInventoryData(searchBool, categoryBool, priceBool, tbxSearch.Text, categoryID, lowerPrice, upperPrice);
                        LbxSetup(Program._bsSearchedItems);
                    }));

                    dataTimer.Stop();
                    shopDataThread.Start();
                    dataTimer.Start();
                });
            }
            //else refills ListBox based on no parameters
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    shopDataThread = new Thread(new ThreadStart(delegate
                    {
                        LbxSetup(Program._bsItems);
                    }));

                    dataTimer.Stop();
                    shopDataThread.Start();
                    dataTimer.Start();
                });
            }

        }
    }
}
