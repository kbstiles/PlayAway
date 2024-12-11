using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form that is used as the cart for POS.
    /// </summary>
    public partial class frmCartPOS : Form
    {
        //Variables
        public Thread shopThread;

        decimal subTotal,
            taxAmount,
            tax,
            totalDue,
            discountAmount,
            discountSubtotal;

        decimal? discountPercentage,
            discountDollarAmount;

        public static clsCalculations cal;

        public static clsOrders order;

        public int cartIndex,
            inventoryIndex;

        public static clsDiscount usedDiscount;

        public string CCNum;

        public static bool discountAdded = false;

        //fills cart
        public frmCartPOS()
        {
            clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), frmShopPOS.orderDetailsList);
            InitializeComponent();            
        }

        //populates and calculates cart and receipt data and fills ComboBox with valid discount code
        private void frmCartPOS_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string expDate;

            lbxCart.Items.Clear();
            
            PopulateData();
            cbxDiscountCodesActual.Items.Add("None");
            foreach (clsDiscount discount in Program.discountList)
            {
                expDate = discount.expirationDate;
                if (String.Compare(expDate, today.ToString("yyyy-MM-dd")) == 1 && discount.Disabled != true)
                {
                    cbxDiscountCodesActual.Items.Add(discount.discountCode);
                }
            }
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        private void SetAllFalse()
        {
            lbxCart.Enabled = false;
            btnContinueShopping.Enabled = false;
            btnCheckout.Enabled = false;
            btnRemoveItem.Enabled = false;
            btnClearCart.Enabled = false;
            btnModifyQuantity.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        private void SetAllTrue()
        {
            lbxCart.Enabled = true;
            btnContinueShopping.Enabled = true;
            btnCheckout.Enabled = true;
            btnRemoveItem.Enabled = true;
            btnClearCart.Enabled = true;
            btnModifyQuantity.Enabled = true;
        }

        //Sets ListBox parameters
        private void lbxCart_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(lbxCart.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y);
            e.DrawFocusRectangle();
        }

        //sets ListBox parameters
        private void lbxCart_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 120;
        }

        //takes user back to POS shop form
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {            
            new frmShopPOS().Show();
            this.Dispose();
        }

        //Validates if all user info is correct, finalizes order and prints receipt
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Variables
            int? discountID = null;

            //checks for discount
            if (cbxDiscountCodesActual.SelectedIndex != -1)
            {
                foreach (clsDiscount discount in Program.discountList)
                {
                    if ((discount.discountCode).Equals(cbxDiscountCodesActual.Text))
                    {
                        discountID = discount.discountID;
                        break;
                    }
                }
            }

            //Checks for valid credit card number, CCV and expiration date
            if (clsValidation.ValidateCCNum(tbxCCNum.Text) && clsValidation.ValidateCCV(tbxCCV.Text) && clsValidation.ValidateExpDate(tbxExpiration.Text) && lbxCart.Items.Count != 0)
            {
                CCNum = tbxCCNum.Text;
                CCNum = CCNum.Insert(4, "-");
                CCNum = CCNum.Insert(9, "-");
                CCNum = CCNum.Insert(14, "-");

                int orderID = 0;

                //inserts order details and orders into database
                foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                {
                    orderID = orderDetail.GetOrderID();
                    clsSQL.FinalizeOrderDetailsInfo(orderDetail.GetInventoryID(), orderDetail.GetQuantity());
                }

                //inserts order into database
                clsSQL.FinalizeOrderInfo(orderID, CCNum, tbxCCV.Text, tbxExpiration.Text);

                //prints out receipt
                clsHTML.PrintPOSReceipt(clsHTML.GenerateReceipt(clsHTML.BuildShopPOSReceipt()));

                frmShopPOS.orderDetailsList.Clear();

                //updates database inventory
                clsSQL.InventoryData();

                new frmShopPOS().Show();
                this.Dispose();
            }
        }    

        //checks for changes in credit card number and validity
        private void tbxCCNum_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCCNum(tbxCCNum.Text))
            {
                lblValidCCNum.ForeColor = Color.Green;
                lblValidCCNum.Text = "O";
            }
            else
            {
                lblValidCCNum.ForeColor = Color.Red;
                lblValidCCNum.Text = "X";
            }
        }

        //checks for changes in CCV and validity
        private void tbxCCV_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCCV(tbxCCV.Text))
            {
                lblValidCCV.ForeColor = Color.Green;
                lblValidCCV.Text = "O";
            }
            else
            {
                lblValidCCV.ForeColor = Color.Red;
                lblValidCCV.Text = "X";
            }
        }

        //checks for changes in expiration date and validity
        private void tbxExpiration_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateExpDate(tbxExpiration.Text))
            {
                lblValidExpDate.ForeColor = Color.Green;
                lblValidExpDate.Text = "O";
            }
            else
            {
                lblValidExpDate.ForeColor = Color.Red;
                lblValidExpDate.Text = "X";
            }
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartIndex = lbxCart.SelectedIndex;
            btnRemoveItem.Enabled = true;
            btnModifyQuantity.Enabled = true;
        }

        //checks for changes in discoutn code and repopulates data based on new discount choice
        private void cbxDiscountCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAllFalse();
            PopulateData();
            SetAllTrue();
        }

        //allows user to remove selected item from cart
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            clsSQL.RemoveCartItem(frmShopPOS.orderDetailsList[cartIndex].GetOrderID(), frmShopPOS.orderDetailsList[cartIndex].GetInventoryID(), frmShopPOS.orderDetailsList.Count);
            lbxCart.Items.Clear();
            clsSQL.AddEmployeeID(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(Program.loggedInUserInfo[0]));
            clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), frmShopPOS.orderDetailsList);
            PopulateData();
        }

        //allows user to clear cart
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            clsSQL.ClearCart(frmShopPOS.orderDetailsList[0].GetOrderID());
            lbxCart.Items.Clear();
            clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), frmShopPOS.orderDetailsList);
            lblSubtotalActual.Text = "";
            lblDiscountSubtotalActual.Text = "";
            lblTaxActual.Text = "";
            lblTotalActual.Text = "";
            cbxDiscountCodesActual.SelectedIndex = -1;
            lblDiscountTypeActual.Text = "";
            lblDiscountAmountActual.Text = "";
            tbxCCNum.Text = "";
            tbxCCV.Text = "";
            tbxExpiration.Text = "";
            btnCheckout.Enabled = false;
        }

        //allows user to modify quantity of selected item
        private void btnModifyQuantity_Click(object sender, EventArgs e)
        {
            lbxCart.Enabled = false;
            lbxCart.Visible = false;
            btnContinueShopping.Enabled = false;
            btnCheckout.Enabled = false;
            btnRemoveItem.Enabled = false;
            btnClearCart.Enabled = false;
            btnModifyQuantity.Enabled = false;
            cbxDiscountCodesActual.Enabled = false;
            tbxCCNum.Enabled = false;
            tbxCCV.Enabled = false;
            tbxExpiration.Enabled = false;
            lblProductNameLabel.Visible = true;
            lblProductNameActual.Visible = true;
            lblProductNameActual.Text = frmShopPOS.orderDetailsList[cartIndex].GetItemName();
            lblProductPriceLabel.Visible = true;
            lblProductPriceActual.Visible = true;
            lblProductPriceActual.Text = frmShopPOS.orderDetailsList[cartIndex].GetOriginalPrice().ToString("C", CultureInfo.CurrentCulture);
            lblCurrentQuantityLabel.Visible = true;
            lblCurrentQuantityActual.Visible = true;
            lblCurrentQuantityActual.Text = frmShopPOS.orderDetailsList[cartIndex].GetQuantity().ToString();
            lblNewQuantity.Visible = true;
            cbxQuantity.Items.Clear();
            cbxQuantity.Visible = true;
            cbxQuantity.Enabled = true;
            btnSave.Visible = true;
            btnSave.Enabled = true;

            for (int i = 0; i < Program._bsItems.Count; i++)
            {
                if (clsSQL.DTInventoryTable.Rows[i].Field<Int64>("InventoryID") == frmShopPOS.orderDetailsList[cartIndex].GetInventoryID())
                {
                    inventoryIndex = i;
                    break;
                }
            }

            for (int i = 1; i < clsSQL.DTInventoryTable.Rows[inventoryIndex].Field<Int64>("Quantity") + 1; i++)
            {
                cbxQuantity.Items.Add(i);
            }
        }

        //allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpCartPOS.HelpNamespace);
        }

        //Saves users new item quantity
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidNewQuantity(cbxQuantity.Text))
            {
                clsSQL.UpdateCartItemQuantity(frmShopPOS.orderDetailsList[cartIndex].GetOrderID(), frmShopPOS.orderDetailsList[cartIndex].GetInventoryID(), Convert.ToInt32(cbxQuantity.Text));
                lbxCart.Items.Clear();
                clsSQL.AddEmployeeID(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(Program.loggedInUserInfo[0]));
                clsSQL.FillCart(Convert.ToInt32(Program.loggedInPOSCustomerInfo[0]), frmShopPOS.orderDetailsList);
                lblProductNameLabel.Visible = false;
                lblProductNameActual.Visible = false;
                lblProductPriceLabel.Visible = false;
                lblProductPriceActual.Visible = false;
                lblCurrentQuantityLabel.Visible = false;
                lblCurrentQuantityActual.Visible = false;
                lblNewQuantity.Visible = false;
                cbxQuantity.Visible = false;
                cbxQuantity.Enabled = false;
                btnSave.Visible = false;
                btnSave.Enabled = false;
                btnModifyQuantity.Enabled = false;
                lbxCart.Enabled = true;
                lbxCart.Visible = true;
                btnContinueShopping.Enabled = true;
                btnCheckout.Enabled = true;
                btnRemoveItem.Enabled = true;
                btnClearCart.Enabled = true;
                cbxDiscountCodesActual.Enabled = true;
                tbxCCNum.Enabled = true;
                tbxCCV.Enabled = true;
                tbxExpiration.Enabled = true;
                PopulateData();
            }
        }

        /// <summary>
        /// Populates the cart ListBox and handles recalculations.
        /// </summary>
        public void PopulateData()
        {
            //Variables
            subTotal = 0;
            taxAmount = 0;
            tax = .0825M;
            totalDue = 0;

            lbxCart.Items.Clear();

            if (frmShopPOS.orderDetailsList.Count != 0)
            {
                //Variables
                string biggestItemName = frmShopPOS.orderDetailsList[0].GetItemName();

                int biggestLength = frmShopPOS.orderDetailsList[0].GetItemName().Length;

                //set ListBox parameters
                foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                {
                    if (orderDetail.GetItemName().Length > biggestLength)
                    {
                        biggestLength = orderDetail.GetItemName().Length;
                        biggestItemName = orderDetail.GetItemName();
                    }
                }

                Graphics g = lbxCart.CreateGraphics();

                int hzSize = (int)g.MeasureString("Product Name: " + biggestItemName, lbxCart.Font).Width;

                lbxCart.HorizontalExtent = hzSize;

                string itemBuffer = new string('-', Convert.ToInt32(Math.Round(("Product Name: " + biggestItemName).Length * 1.25)));

                //fills ListBox
                foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                {
                    string productName = orderDetail.GetItemName();
                    int quantity = orderDetail.GetQuantity();
                    decimal unitPrice = orderDetail.GetOriginalPrice(),
                        totalPrice = unitPrice * quantity;

                    lbxCart.Items.Add(
                        "Product Name: " + productName +
                        "\nPrice Per Unit: " + unitPrice.ToString("C", CultureInfo.CurrentCulture) +
                        "\nQuantity: " + quantity.ToString() +
                        "\nTotal Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture) +
                        "\n" + itemBuffer
                    );

                    orderDetail.SetTotalPerLine(totalPrice);

                    subTotal += totalPrice;
                }

                lbxCart.DrawMode = DrawMode.OwnerDrawVariable;
                lbxCart.MeasureItem += lbxCart_MeasureItem;
                lbxCart.DrawItem += lbxCart_DrawItem;


                //calculates and displays new subtotal, tax amounts, totals and discounts
                lblSubtotalActual.Text = subTotal.ToString("C", CultureInfo.CurrentCulture);

                taxAmount = subTotal * tax;

                totalDue = subTotal + taxAmount;

                cal = new clsCalculations(subTotal, taxAmount, totalDue);
                if (cbxDiscountCodesActual.SelectedIndex >= 1)
                {
                    clsOrderDetails usedOrderDetail = null;

                    for (int i = 0; i < Program.discountList.Count; i++)
                    {
                        if (cbxDiscountCodesActual.Text.Equals(Program.discountList[i].discountCode))
                        {
                            usedDiscount = Program.discountList[i];
                            clsSQL.AddDiscountID(frmShopPOS.orderDetailsList[0].GetOrderID(), usedDiscount.discountID);
                            break;
                        }
                    }

                    //checks if discount has cart based or item based
                    if (usedDiscount.discountLevel == 0)
                    {
                        //checks if discount type is percentage or dollar amount
                        if (usedDiscount.discountType == 0)
                        {
                            cal.SetDiscountPercentage(usedDiscount.discountPercentage);
                            discountPercentage = cal.GetDiscountPercentage();
                            discountSubtotal = subTotal - (subTotal * (decimal)discountPercentage);
                            lblDiscountTypeActual.Text = Convert.ToDecimal(discountPercentage).ToString("P", CultureInfo.InvariantCulture);
                        }
                        else if (usedDiscount.discountType == 1)
                        {
                            cal.SetDiscountDollarAmount(usedDiscount.discountDollarAmount);
                            discountDollarAmount = cal.GetDiscountDollarAmount();
                            discountSubtotal = subTotal - (decimal)discountDollarAmount;
                            lblDiscountTypeActual.Text = Convert.ToDecimal(discountDollarAmount).ToString("C", CultureInfo.CurrentCulture);
                        }

                        lblDiscountLevelActual.Text = "Cart";
                        lblDiscountLevelLabel.Visible = true;
                        lblDiscountLevelActual.Visible = true;
                        lblDiscountTypeLabel.Visible = true;
                        lblDiscountTypeActual.Visible = true;

                        cal.SetDiscountSubtotal(discountSubtotal);

                        discountAmount = subTotal - discountSubtotal;
                        cal.SetDiscountAmount(discountAmount);
                        lblDiscountAmountActual.Text = discountAmount.ToString("C", CultureInfo.CurrentCulture);
                        lblDiscountAmountLabel.Visible = true;
                        lblDiscountAmountActual.Visible = true;
                        lblDiscountSubtotalActual.Text = discountSubtotal.ToString("C", CultureInfo.CurrentCulture);
                        lblDiscountSubtotalLabel.Visible = true;
                        lblDiscountSubtotalActual.Visible = true;
                        taxAmount = discountSubtotal * tax;
                        cal.SetTaxAmount(taxAmount);
                        totalDue = discountSubtotal + taxAmount;
                        cal.SetTotalDue(totalDue);
                        discountAdded = true;
                    }
                    else if (usedDiscount.discountLevel == 1)
                    {
                        bool hasItem = false;
                        if (usedDiscount.inventoryID != null)
                        {
                            foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                            {
                                if (orderDetail.GetInventoryID() == usedDiscount.inventoryID)
                                {
                                    usedOrderDetail = orderDetail;
                                    hasItem = true;
                                    break;
                                }
                            }

                            if (hasItem)
                            {
                                //checks if discount type is percentage or dollar amount
                                if (usedDiscount.discountType == 0)
                                {
                                    foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                                    {
                                        if (Convert.ToInt32(usedDiscount.inventoryID) == orderDetail.GetInventoryID())
                                        {
                                            cal.SetDiscountPercentage(usedDiscount.discountPercentage);
                                            discountPercentage = cal.GetDiscountPercentage();
                                            orderDetail.SetUpdatedPrice(orderDetail.GetOriginalPrice() * (decimal)discountPercentage);
                                            discountSubtotal = subTotal - orderDetail.GetUpdatedPrice();
                                        }
                                    }
                                    lblDiscountTypeActual.Text = Convert.ToDecimal(discountPercentage).ToString("P", CultureInfo.InvariantCulture);
                                }
                                else if (usedDiscount.discountType == 1)
                                {
                                    foreach (clsOrderDetails orderDetail in frmShopPOS.orderDetailsList)
                                    {
                                        if (Convert.ToInt32(usedDiscount.inventoryID) == orderDetail.GetInventoryID())
                                        {
                                            cal.SetDiscountDollarAmount(usedDiscount.discountDollarAmount);
                                            discountDollarAmount = cal.GetDiscountDollarAmount();                                            
                                            orderDetail.SetUpdatedPrice(orderDetail.GetOriginalPrice() - Convert.ToDecimal(usedDiscount.discountDollarAmount));
                                            discountSubtotal = subTotal - (decimal) discountDollarAmount;
                                        }
                                    }
                                    lblDiscountTypeActual.Text = Convert.ToDecimal(discountDollarAmount).ToString("C", CultureInfo.CurrentCulture);
                                }

                                usedOrderDetail.SetDiscountID(usedDiscount.discountID);
                                if (usedOrderDetail.GetUpdatedPrice() < 0)
                                {
                                    usedOrderDetail.SetUpdatedPrice(0);
                                }

                                lblDiscountLevelActual.Text = "Item";
                                lblDiscountLevelLabel.Visible = true;
                                lblDiscountLevelActual.Visible = true;
                                lblDiscountTypeLabel.Visible = true;
                                lblDiscountTypeActual.Visible = true;

                                cal.SetDiscountSubtotal(discountSubtotal);

                                if (usedDiscount.discountType == 0)
                                {
                                    discountAmount = subTotal - discountSubtotal;
                                }
                                else if (usedDiscount.discountType == 1)
                                {
                                    discountAmount = (decimal)discountDollarAmount;
                                }
                                    
                                cal.SetDiscountAmount(discountAmount);
                                lblDiscountAmountActual.Text = discountAmount.ToString("C", CultureInfo.CurrentCulture);
                                lblDiscountAmountLabel.Visible = true;
                                lblDiscountAmountActual.Visible = true;
                                lblDiscountSubtotalActual.Text = discountSubtotal.ToString("C", CultureInfo.CurrentCulture);
                                lblDiscountSubtotalLabel.Visible = true;
                                lblDiscountSubtotalActual.Visible = true;
                                taxAmount = discountSubtotal * tax;
                                cal.SetTaxAmount(taxAmount);
                                totalDue = discountSubtotal + taxAmount;
                                cal.SetTotalDue(totalDue);
                                discountAdded = true;
                            }
                            else
                            {
                                MessageBox.Show("No Items in cart that can use discount code '" + cbxDiscountCodesActual.SelectedItem.ToString() + "'");
                                cbxDiscountCodesActual.SelectedIndex = 0;
                                discountAdded = false;
                            }
                        }
                    }                    
                }
                else
                {
                    clsSQL.AddDiscountID(frmShopPOS.orderDetailsList[0].GetOrderID(), null);
                    taxAmount = subTotal * tax;
                    cal.SetTaxAmount(taxAmount);

                    totalDue = subTotal + taxAmount;
                    cal.SetTotalDue(totalDue);

                    lblDiscountLevelActual.Text = "";
                    lblDiscountLevelLabel.Visible = false;
                    lblDiscountLevelActual.Visible = false;
                    lblDiscountSubtotalLabel.Visible = false;
                    lblDiscountSubtotalActual.Visible = false;
                    lblDiscountTypeLabel.Visible = false;
                    lblDiscountTypeActual.Visible = false;
                    lblDiscountAmountLabel.Visible = false;
                    lblDiscountAmountActual.Visible = false;
                    discountAdded = false;
                }

                btnCheckout.Enabled = true;
                lblTaxActual.Text = taxAmount.ToString("C", CultureInfo.CurrentCulture);

                lblTotalActual.Text = totalDue.ToString("C", CultureInfo.CurrentCulture);
            }
        }        

        private void frmCartPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
