using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to handle receipt and log printing.
    /// </summary>
    internal class clsHTML
    {
        //Variables
        private static StringBuilder css = new StringBuilder();
        private static StringBuilder baseHTML = new StringBuilder();
        private static StringBuilder receiptHTML = new StringBuilder();
        private static StringBuilder inventoryHTML = new StringBuilder();
        private static StringBuilder managersHTML = new StringBuilder();
        private static StringBuilder customersHTML = new StringBuilder();
        private static StringBuilder receiptPOSHTML = new StringBuilder();
        private static StringBuilder discountsHTML = new StringBuilder();
        private static StringBuilder salesHTML = new StringBuilder();

        public static DataRow row = null;

        public static clsDiscount discount = null;

        /// <summary>
        /// Used to create the base of receipts and logs.
        /// </summary>
        /// <param name="ReceiptBuilderType">Holds the type of receipt or log to be built</param>
        /// <returns>The build of the html receipt/log</returns>
        /// <example>
        /// <code>
        /// clsHTML.GenerateReceipt(clsHTML.BuildShopReceipt())
        /// </code>
        /// </example>
        public static StringBuilder GenerateReceipt(StringBuilder ReceiptBuilderType)
        {
            //sets the base of the html to be used
            css.Clear();
            baseHTML.Clear();
            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; border: 1px solid black; text-align:center;}");
            css.AppendLine(".header {font-weight: bold;}");
            css.AppendLine("p {text-align:left;}");
            css.AppendLine("div {border: 5px solid black; text-align: center; display: inline-block}");
            css.AppendLine("table {border-collapse: collapse;}");
            css.AppendLine("</style>");

            baseHTML.AppendLine("<html>");
            baseHTML.AppendLine($"<head>{css}</head>");
            baseHTML.AppendLine("<body>");

            //grabs the specific receipt or log type to be made
            baseHTML.Append(ReceiptBuilderType);

            baseHTML.AppendLine("</body></html>");

            return baseHTML;
        }

        /// <summary>
        /// Builds receipts after a customer checks out.
        /// </summary>
        /// <returns>Returns the html build of the receipt</returns>
        public static StringBuilder BuildShopReceipt()
        {
            receiptHTML.Clear();
            //builds the table to hodl the cart data
            receiptHTML.AppendLine("<div>");
            receiptHTML.AppendLine("<table>");
            receiptHTML.AppendLine("<caption><h2>Play Away Receipt</h2></caption>");
            receiptHTML.AppendLine($"<caption><p>Name: {Program.loggedInUserInfo[1]}</p></caption>");
            receiptHTML.AppendLine($"<caption><p>Sales Receipt #{frmShop.orderDetailsList[0].GetOrderID()}</p></caption>");
            receiptHTML.AppendLine("<tr><td class=\"header\">Item</td><td class=\"header\">Item Price</td><td class=\"header\">Quantity</td><td class=\"header\">Total Price</td></tr>");
            
            //fills the table with the cart items info
            for (int i = 0; i < frmShop.orderDetailsList.Count; i++)
            {
                receiptHTML.Append("<tr>");
                receiptHTML.AppendLine($"<td>{frmShop.orderDetailsList[i].GetItemName()}</td>");
                receiptHTML.AppendLine($"<td>{frmShop.orderDetailsList[i].GetOriginalPrice().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptHTML.AppendLine($"<td>{frmShop.orderDetailsList[i].GetQuantity()}</td>");
                receiptHTML.AppendLine($"<td>{frmShop.orderDetailsList[i].GetTotalPerLine().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptHTML.Append("</tr>");
                
            }

            //calculates and displays subtotals, discounts and totals
            receiptHTML.AppendLine("<tr><td colspan=4><hr/></td></tr>");
            receiptHTML.Append("<tr>");
            receiptHTML.AppendLine("<td>Subtotal: </td>");
            receiptHTML.AppendLine($"<td>{frmCart.cal.GetSubtotal().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.Append("</tr>");
            if (frmCart.discountAdded)
            {
                receiptHTML.Append("<tr>");
                receiptHTML.AppendLine("<td>Discount: </td>");
                receiptHTML.AppendLine("<td></td>");
                if (frmCart.cal.GetDiscountPercentage() != null)
                {
                    receiptHTML.AppendLine($"<td>{Convert.ToDecimal(frmCart.cal.GetDiscountPercentage()).ToString("P", CultureInfo.InvariantCulture)}</td>");
                }else if (frmCart.cal.GetDiscountDollarAmount() != null)
                {
                    receiptHTML.AppendLine($"<td>{Convert.ToDecimal(frmCart.cal.GetDiscountDollarAmount()).ToString("C", CultureInfo.CurrentCulture)}</td>");
                }

                receiptHTML.AppendLine($"<td>-({frmCart.cal.GetDiscountAmount().ToString("C", CultureInfo.CurrentCulture)})</td>");
                receiptHTML.Append("</tr>");
                receiptHTML.Append("<tr>");
                receiptHTML.AppendLine("<td>Discounted Subtotal: </td>");
                receiptHTML.AppendLine($"<td>{frmCart.cal.GetDiscountSubtotal().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptHTML.AppendLine("<td></td>");
                receiptHTML.AppendLine("<td></td>");
                receiptHTML.Append("</tr>");
            }
            receiptHTML.Append("<tr>");
            receiptHTML.AppendLine("<td>Tax (8.25%): </td>");
            receiptHTML.AppendLine($"<td>{frmCart.cal.GetTaxAmount().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.Append("</tr>");
            receiptHTML.Append("<tr>");
            receiptHTML.AppendLine("<td>Total: </td>");
            receiptHTML.AppendLine($"<td>{frmCart.cal.GetTotalDue().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.AppendLine("<td></td>");
            receiptHTML.Append("</tr>");
            receiptHTML.AppendLine("</table>");
            receiptHTML.AppendLine("</div>");

            return receiptHTML;
        }

        /// <summary>
        /// Builds html log of database inventory.
        /// </summary>
        /// <returns>Returns the html build of the inventory</returns>
        public static StringBuilder BuildInventoryReceipt()
        {
            inventoryHTML.Clear();

            //sets up the available inventory table
            inventoryHTML.AppendLine("<div>");
            inventoryHTML.AppendLine("<table>");
            inventoryHTML.AppendLine("<caption><h2>Available Items Report</h2></caption>");
            inventoryHTML.AppendLine("<tr><td class=\"header\">Inventory ID</td><td class=\"header\">Item Name</td><td class=\"header\">Item Cost</td><td class=\"header\">Item Price</td><td class=\"header\">Qantity On Hand</td><td class=\"header\">Restock Threshold</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
            {
                row = clsSQL.DTInventoryTable.Rows[i];
                if (row.Field<Int64?>("Discontinued") == 1 || row.Field<Int64?>("Discontinued") == null)
                {
                    inventoryHTML.Append("<tr>");
                    inventoryHTML.AppendLine($"<td>{row["InventoryID"]}</td>");
                    inventoryHTML.AppendLine($"<td>{row["ItemName"]}</td>");
                    inventoryHTML.AppendLine($"<td>{((decimal)row["Cost"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                    inventoryHTML.AppendLine($"<td>{((decimal)row["RetailPrice"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                    inventoryHTML.AppendLine($"<td>{row["Quantity"]}</td>");
                    inventoryHTML.AppendLine($"<td>{row["RestockThreshold"]}</td>");
                    inventoryHTML.Append("</tr>");
                }

            }

            inventoryHTML.AppendLine("</table>");
            inventoryHTML.AppendLine("</div>");

            //sets up the inventory needing to be restocked table
            inventoryHTML.AppendLine("<div>");
            inventoryHTML.AppendLine("<table>");
            inventoryHTML.AppendLine("<caption><h2>Restock Report</h2></caption>");
            inventoryHTML.AppendLine("<tr><td class=\"header\">Inventory ID</td><td class=\"header\">Item Name</td><td class=\"header\">Item Cost</td><td class=\"header\">Item Price</td><td class=\"header\">Qantity On Hand</td><td class=\"header\">Restock Threshold</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
            {
                row = clsSQL.DTInventoryTable.Rows[i];
                if (row.Field<Int64>("Quantity") < row.Field<Int64>("RestockThreshold") && (row.Field<Int64?>("Discontinued") == 1 || row.Field<Int64?>("Discontinued") == null))
                {
                    inventoryHTML.Append("<tr>");
                    inventoryHTML.AppendLine($"<td>{row["InventoryID"]}</td>");
                    inventoryHTML.AppendLine($"<td>{row["ItemName"]}</td>");
                    inventoryHTML.AppendLine($"<td>{((decimal)row["Cost"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                    inventoryHTML.AppendLine($"<td>{((decimal)row["RetailPrice"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                    inventoryHTML.AppendLine($"<td>{row["Quantity"]}</td>");
                    inventoryHTML.AppendLine($"<td>{row["RestockThreshold"]}</td>");
                    inventoryHTML.Append("</tr>");
                }

            }

            inventoryHTML.AppendLine("</table>");
            inventoryHTML.AppendLine("</div>");

            //sets up the total inventory table
            inventoryHTML.AppendLine("<div>");
            inventoryHTML.AppendLine("<table>");
            inventoryHTML.AppendLine("<caption><h2>All Items Report</h2></caption>");
            inventoryHTML.AppendLine("<tr><td class=\"header\">Inventory ID</td><td class=\"header\">Item Name</td><td class=\"header\">Item Cost</td><td class=\"header\">Item Price</td><td class=\"header\">Qantity On Hand</td><td class=\"header\">Restock Threshold</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
            {
                row = clsSQL.DTInventoryTable.Rows[i];
                inventoryHTML.Append("<tr>");
                inventoryHTML.AppendLine($"<td>{row["InventoryID"]}</td>");
                inventoryHTML.AppendLine($"<td>{row["ItemName"]}</td>");
                inventoryHTML.AppendLine($"<td>{((decimal)row["Cost"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                inventoryHTML.AppendLine($"<td>{((decimal)row["RetailPrice"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                inventoryHTML.AppendLine($"<td>{row["Quantity"]}</td>");
                inventoryHTML.AppendLine($"<td>{row["RestockThreshold"]}</td>");
                inventoryHTML.Append("</tr>");
            }

            inventoryHTML.AppendLine("</table>");
            inventoryHTML.AppendLine("</div>");

            return inventoryHTML;
        }

        /// <summary>
        /// Builds the html log of the manager accounts.
        /// </summary>
        /// <returns>Returns the html build of manager accounts</returns>
        public static StringBuilder BuildManagerReceipt()
        {
            managersHTML.Clear();
            
            //sets up table
            managersHTML.AppendLine("<div>");
            managersHTML.AppendLine("<table>");
            managersHTML.AppendLine("<caption><h2>Manager Report</h2></caption>");
            managersHTML.AppendLine("<tr><td class=\"header\">Person ID</td><td class=\"header\">Title</td><td class=\"header\">First Name</td><td class=\"header\">Middle Name</td><td class=\"header\">Last Name</td><td class=\"header\">Suffix</td><td class=\"header\">Address 1</td><td class=\"header\">Address 2</td><td class=\"header\">Address 3</td><td class=\"header\">City</td><td class=\"header\">Zipcode</td><td class=\"header\">State</td><td class=\"header\">Email</td><td class=\"header\">Phone Primary</td><td class=\"header\">Phone Secondary</td><td class=\"header\">Person Deleted</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTManagersTable.Rows.Count; i++)
            {
                row = clsSQL.DTManagersTable.Rows[i];

                managersHTML.Append("<tr>");
                managersHTML.AppendLine($"<td>{row["PersonID"]}</td>");
                managersHTML.AppendLine($"<td>{row["Title"]}</td>");
                managersHTML.AppendLine($"<td>{row["NameFirst"]}</td>");
                managersHTML.AppendLine($"<td>{row["NameMiddle"]}</td>");
                managersHTML.AppendLine($"<td>{row["NameLast"]}</td>");
                managersHTML.AppendLine($"<td>{row["Suffix"]}</td>");
                managersHTML.AppendLine($"<td>{row["Address1"]}</td>");
                managersHTML.AppendLine($"<td>{row["Address2"]}</td>");
                managersHTML.AppendLine($"<td>{row["Address3"]}</td>");
                managersHTML.AppendLine($"<td>{row["City"]}</td>");
                managersHTML.AppendLine($"<td>{row["Zipcode"]}</td>");
                managersHTML.AppendLine($"<td>{row["State"]}</td>");
                managersHTML.AppendLine($"<td>{row["Email"]}</td>");
                managersHTML.AppendLine($"<td>{row["PhonePrimary"]}</td>");
                managersHTML.AppendLine($"<td>{row["PhoneSecondary"]}</td>");
                managersHTML.AppendLine($"<td>{row["PersonDeleted"]}</td>");
                managersHTML.Append("</tr>");

            }

            managersHTML.AppendLine("</table>");
            managersHTML.AppendLine("</div>");

            return managersHTML;
        }

        /// <summary>
        /// Builds html log of customers.
        /// </summary>
        /// <returns>Returns the html build of customers</returns>
        public static StringBuilder BuildCustomerReceipt()
        {
            customersHTML.Clear();

            //sets up table
            customersHTML.AppendLine("<div>");
            customersHTML.AppendLine("<table>");
            customersHTML.AppendLine("<caption><h2>Customer Report</h2></caption>");
            customersHTML.AppendLine("<tr><td class=\"header\">Person ID</td><td class=\"header\">Title</td><td class=\"header\">First Name</td><td class=\"header\">Middle Name</td><td class=\"header\">Last Name</td><td class=\"header\">Suffix</td><td class=\"header\">Address 1</td><td class=\"header\">Address 2</td><td class=\"header\">Address 3</td><td class=\"header\">City</td><td class=\"header\">Zipcode</td><td class=\"header\">State</td><td class=\"header\">Email</td><td class=\"header\">Phone Primary</td><td class=\"header\">Phone Secondary</td><td class=\"header\">Person Deleted</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTCustomersTable.Rows.Count; i++)
            {
                row = clsSQL.DTCustomersTable.Rows[i];

                customersHTML.Append("<tr>");
                customersHTML.AppendLine($"<td>{row["PersonID"]}</td>");
                customersHTML.AppendLine($"<td>{row["Title"]}</td>");
                customersHTML.AppendLine($"<td>{row["NameFirst"]}</td>");
                customersHTML.AppendLine($"<td>{row["NameMiddle"]}</td>");
                customersHTML.AppendLine($"<td>{row["NameLast"]}</td>");
                customersHTML.AppendLine($"<td>{row["Suffix"]}</td>");
                customersHTML.AppendLine($"<td>{row["Address1"]}</td>");
                customersHTML.AppendLine($"<td>{row["Address2"]}</td>");
                customersHTML.AppendLine($"<td>{row["Address3"]}</td>");
                customersHTML.AppendLine($"<td>{row["City"]}</td>");
                customersHTML.AppendLine($"<td>{row["Zipcode"]}</td>");
                customersHTML.AppendLine($"<td>{row["State"]}</td>");
                customersHTML.AppendLine($"<td>{row["Email"]}</td>");
                customersHTML.AppendLine($"<td>{row["PhonePrimary"]}</td>");
                customersHTML.AppendLine($"<td>{row["PhoneSecondary"]}</td>");
                customersHTML.AppendLine($"<td>{row["PersonDeleted"]}</td>");
                customersHTML.Append("</tr>");

            }

            customersHTML.AppendLine("</table>");
            customersHTML.AppendLine("</div>");

            return customersHTML;
        }

        /// <summary>
        /// Builds html receipt of employee POS checkout.
        /// </summary>
        /// <returns>Returns the html build of the POS checkout receipt</returns>
        public static StringBuilder BuildShopPOSReceipt()
        {
            receiptPOSHTML.Clear();

            //sets up table
            receiptPOSHTML.AppendLine("<div>");
            receiptPOSHTML.AppendLine("<table>");
            receiptPOSHTML.AppendLine("<caption><h2>Play Away Receipt</h2></caption>");
            receiptPOSHTML.AppendLine($"<caption><p>Customer Name: {Program.loggedInPOSCustomerInfo[1]}</p></caption>");
            receiptPOSHTML.AppendLine($"<caption><p>Employee Name: {Program.loggedInUserInfo[1]}</p></caption>");
            receiptPOSHTML.AppendLine($"<caption><p>Sales Receipt #{frmShopPOS.orderDetailsList[0].GetOrderID()}</p></caption>");
            receiptPOSHTML.AppendLine("<tr><td class=\"header\">Item</td><td class=\"header\">Item Price</td><td class=\"header\">Quantity</td><td class=\"header\">Total Price</td></tr>");

            //fills table with data
            for (int i = 0; i < frmShopPOS.orderDetailsList.Count; i++)
            {
                receiptPOSHTML.Append("<tr>");
                receiptPOSHTML.AppendLine($"<td>{frmShopPOS.orderDetailsList[i].GetItemName()}</td>");
                receiptPOSHTML.AppendLine($"<td>{frmShopPOS.orderDetailsList[i].GetOriginalPrice().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptPOSHTML.AppendLine($"<td>{frmShopPOS.orderDetailsList[i].GetQuantity()}</td>");
                receiptPOSHTML.AppendLine($"<td>{frmShopPOS.orderDetailsList[i].GetTotalPerLine().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptPOSHTML.Append("</tr>");

            }
            receiptPOSHTML.AppendLine("<tr><td colspan=4><hr/></td></tr>");
            receiptPOSHTML.Append("<tr>");
            receiptPOSHTML.AppendLine("<td>Subtotal: </td>");
            receiptPOSHTML.AppendLine($"<td>{frmCartPOS.cal.GetSubtotal().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.Append("</tr>");
            if (frmCartPOS.discountAdded)
            {
                receiptPOSHTML.Append("<tr>");
                receiptPOSHTML.AppendLine("<td>Discount: </td>");
                receiptPOSHTML.AppendLine("<td></td>");
                if (frmCartPOS.cal.GetDiscountPercentage() != null)
                {
                    receiptPOSHTML.AppendLine($"<td>{Convert.ToDecimal(frmCartPOS.cal.GetDiscountPercentage()).ToString("P", CultureInfo.InvariantCulture)}</td>");
                }
                else if (frmCartPOS.cal.GetDiscountDollarAmount() != null)
                {
                    receiptPOSHTML.AppendLine($"<td>{Convert.ToDecimal(frmCartPOS.cal.GetDiscountDollarAmount()).ToString("C", CultureInfo.CurrentCulture)}</td>");
                }

                receiptPOSHTML.AppendLine($"<td>-({frmCartPOS.cal.GetDiscountAmount().ToString("C", CultureInfo.CurrentCulture)})</td>");
                receiptPOSHTML.Append("</tr>");
                receiptPOSHTML.Append("<tr>");
                receiptPOSHTML.AppendLine("<td>Discounted Subtotal: </td>");
                receiptPOSHTML.AppendLine($"<td>{frmCartPOS.cal.GetDiscountSubtotal().ToString("C", CultureInfo.CurrentCulture)}</td>");
                receiptPOSHTML.AppendLine("<td></td>");
                receiptPOSHTML.AppendLine("<td></td>");
                receiptPOSHTML.Append("</tr>");
            }
            receiptPOSHTML.Append("<tr>");
            receiptPOSHTML.AppendLine("<td>Tax (8.25%): </td>");
            receiptPOSHTML.AppendLine($"<td>{frmCartPOS.cal.GetTaxAmount().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.Append("</tr>");
            receiptPOSHTML.Append("<tr>");
            receiptPOSHTML.AppendLine("<td>Total: </td>");
            receiptPOSHTML.AppendLine($"<td>{frmCartPOS.cal.GetTotalDue().ToString("C", CultureInfo.CurrentCulture)}</td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.AppendLine("<td></td>");
            receiptPOSHTML.Append("</tr>");
            receiptPOSHTML.AppendLine("</table>");
            receiptPOSHTML.AppendLine("</div>");

            return receiptPOSHTML;
        }

        /// <summary>
        /// Builds the html log of all discounts.
        /// </summary>
        /// <returns>Returns the html build of discounts</returns>
        public static StringBuilder BuildDiscountReceipt()
        {
            discountsHTML.Clear();

            //sets up table
            discountsHTML.AppendLine("<div>");
            discountsHTML.AppendLine("<table>");
            discountsHTML.AppendLine("<caption><h2>Discount Code Report</h2></caption>");
            discountsHTML.AppendLine("<tr><td class=\"header\">Discount ID</td><td class=\"header\">Discount Code</td><td class=\"header\">Description</td><td class=\"header\">Discount Level</td><td class=\"header\">Inventory ID</td><td class=\"header\">Discount Type</td><td class=\"header\">Discount Percentage</td><td class=\"header\">Discount Dollar Amount</td><td class=\"header\">Start Date</td><td class=\"header\">Expiration Date</td><td class=\"header\">Disabled</td></tr>");

            //fills table with data
            for (int i = 0; i < Program.discountList.Count; i++)
            {
                discount = Program.discountList[i];

                discountsHTML.Append("<tr>");
                discountsHTML.AppendLine($"<td>{discount.discountID}</td>");
                discountsHTML.AppendLine($"<td>{discount.discountCode}</td>");
                discountsHTML.AppendLine($"<td>{discount.Description}</td>");
                discountsHTML.AppendLine($"<td>{discount.discountLevel}</td>");
                discountsHTML.AppendLine($"<td>{discount.inventoryID}</td>");
                discountsHTML.AppendLine($"<td>{discount.discountType}</td>");

                if (discount.discountPercentage != null)
                {
                    discountsHTML.AppendLine($"<td>{discount.discountPercentage.Value.ToString("P", CultureInfo.CurrentCulture)}</td>");
                }
                else
                {
                    discountsHTML.AppendLine($"<td>{discount.discountPercentage}</td>");
                }

                if (discount.discountDollarAmount != null)
                {

                    discountsHTML.AppendLine($"<td>{discount.discountDollarAmount.Value.ToString("C", CultureInfo.CurrentCulture)}</td>");
                }
                else
                {
                    discountsHTML.AppendLine($"<td>{discount.discountDollarAmount}</td>");
                }
                
                if (discount.startDate != null)
                {
                    discountsHTML.AppendLine($"<td>{discount.startDate}</td>");
                }
                else
                {
                    discountsHTML.AppendLine($"<td>{discount.startDate}</td>");
                }
                discountsHTML.AppendLine($"<td>{discount.expirationDate}</td>");
                discountsHTML.AppendLine($"<td>{discount.Disabled}</td>");
                discountsHTML.Append("</tr>");

            }

            discountsHTML.AppendLine("</table>");
            discountsHTML.AppendLine("</div>");

            return discountsHTML;
        }

        /// <summary>
        /// Builds html log of sales based on parameters.
        /// </summary>
        /// <param name="startDate">Holds user inputted start date of sales</param>
        /// <param name="endDate">Holds user inputted end date of sales</param>
        /// <param name="allOrders">Determines if sales are time specific</param>
        /// <returns>Returns the html build of sales</returns>
        /// <example>
        /// <code>
        /// clsHTML.BuildSalesReceipt(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), allOrders)
        /// </code>
        /// </example>
        public static StringBuilder BuildSalesReceipt(string startDate, string endDate, bool allOrders)
        {
            double totalSales = 0;

            salesHTML.Clear();

            //sets up table
            salesHTML.AppendLine("<div>");
            salesHTML.AppendLine("<table>");
            salesHTML.AppendLine("<caption><h2>Sales Report</h2></caption>");
            if (allOrders)
            {
                salesHTML.AppendLine($"<caption><h2>All Orders</h2></caption>");
            }
            else
            {
                salesHTML.AppendLine($"<caption><h2>Start Date: {startDate}</h2></caption>");
                salesHTML.AppendLine($"<caption><h2>End Date: {endDate}</h2></caption>");
            }            
            salesHTML.AppendLine("<tr><td class=\"header\">Order ID</td><td class=\"header\">Person ID</td><td class=\"header\">Person Name</td><td class=\"header\">Order Date</td><td class=\"header\">CC Number</td><td class=\"header\">Inventory ID</td><td class=\"header\">Item Name</td><td class=\"header\">Quantity</td><td class=\"header\">Row Total</td></tr>");

            //fills table with data
            for (int i = 0; i < clsSQL.DTSalesTable.Rows.Count; i++)
            {                
                row = clsSQL.DTSalesTable.Rows[i];

                salesHTML.Append("<tr>");
                salesHTML.AppendLine($"<td>{row["OrderID"]}</td>");
                salesHTML.AppendLine($"<td>{row["PersonID"]}</td>");
                salesHTML.AppendLine($"<td>{row["PersonName"]}</td>");
                salesHTML.AppendLine($"<td>{row["OrderDate"]}</td>");
                salesHTML.AppendLine($"<td>{row["CC_Number"]}</td>");
                salesHTML.AppendLine($"<td>{row["InventoryID"]}</td>");
                salesHTML.AppendLine($"<td>{row["ItemName"]}</td>");
                salesHTML.AppendLine($"<td>{row["Quantity"]}</td>");
                salesHTML.AppendLine($"<td>{((double)row["RowTotal"]).ToString("C", CultureInfo.CurrentCulture)}</td>");
                salesHTML.Append("</tr>");

                totalSales += (double)row["RowTotal"];
            }

            salesHTML.AppendLine("<tr><td colspan=9><hr/></td></tr>");
            salesHTML.Append("<tr>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td></td>");
            salesHTML.AppendLine("<td>Sales Total: </td>");
            salesHTML.AppendLine($"<td>{totalSales.ToString("C", CultureInfo.CurrentCulture)}</td>");            
            salesHTML.Append("</tr>");

            salesHTML.AppendLine("</table>");
            salesHTML.AppendLine("</div>");

            return salesHTML;
        }

        /// <summary>
        /// Sets destination path of customer receipt and opens in browser.
        /// </summary>
        /// <param name="html">Holds the receipt to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintReceipt(clsHTML.GenerateReceipt(clsHTML.BuildShopReceipt()));
        /// </code>
        /// </example>
        public static void PrintReceipt(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShop.orderDetailsList[0].GetOrderID()}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShop.orderDetailsList[0].GetOrderID()}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShop.orderDetailsList[0].GetOrderID()}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets destination path of inventory log and opens in browser.
        /// </summary>
        /// <param name="html">Holds the log to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintInventory(clsHTML.GenerateReceipt(clsHTML.BuildInventoryReceipt()));
        /// </code>
        /// </example>
        public static void PrintInventory(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\InventoryLogs\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\InventoryLogs\\{today.ToString("yyyy-MM-dd")}\\InventoryLog{today.ToString("HH-mm-ss-fff")}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\InventoryLogs\\{today.ToString("yyyy-MM-dd")}\\InventoryLog{today.ToString("HH-mm-ss-fff")}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\InventoryLogs\\{today.ToString("yyyy-MM-dd")}\\InventoryLog{today.ToString("HH-mm-ss-fff")}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the destination path of the managers log and opens in browser.
        /// </summary>
        /// <param name="html">Holds the log to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintManagers(clsHTML.GenerateReceipt(clsHTML.BuildManagerReceipt()));
        /// </code>
        /// </example>
        public static void PrintManagers(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\ManagerLogs\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\ManagerLogs\\{today.ToString("yyyy-MM-dd")}\\ManagerLog{today.ToString("HH-mm-ss-fff")}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\ManagerLogs\\{today.ToString("yyyy-MM-dd")}\\ManagerLog{today.ToString("HH-mm-ss-fff")}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\ManagerLogs\\{today.ToString("yyyy-MM-dd")}\\ManagerLog{today.ToString("HH-mm-ss-fff")}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the destination path of the customer log and opens in browser.
        /// </summary>
        /// <param name="html">Holds the log to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintCustomers(clsHTML.GenerateReceipt(clsHTML.BuildCustomerReceipt()));
        /// </code>
        /// </example>
        public static void PrintCustomers(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\CustomerLogs\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\CustomerLogs\\{today.ToString("yyyy-MM-dd")}\\CustomerLog{today.ToString("HH-mm-ss-fff")}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\CustomerLogs\\{today.ToString("yyyy-MM-dd")}\\CustomerLog{today.ToString("HH-mm-ss-fff")}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\CustomerLogs\\{today.ToString("yyyy-MM-dd")}\\CustomerLog{today.ToString("HH-mm-ss-fff")}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the destination path of the POS receipt and opens in browser.
        /// </summary>
        /// <param name="html">Holds the receipt to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintPOSReceipt(clsHTML.GenerateReceipt(clsHTML.BuildShopPOSReceipt()));
        /// </code>
        /// </example>
        public static void PrintPOSReceipt(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShopPOS.orderDetailsList[0].GetOrderID()}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShopPOS.orderDetailsList[0].GetOrderID()}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Receipts\\{today.ToString("yyyy-MM-dd")}\\ReceiptNum{frmShopPOS.orderDetailsList[0].GetOrderID()}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the destination path of the discounts log and opens in browser.
        /// </summary>
        /// <param name="html">Holds the log to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintDiscounts(clsHTML.GenerateReceipt(clsHTML.BuildDiscountReceipt()));
        /// </code>
        /// </example>
        public static void PrintDiscounts(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Discounts\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Discounts\\{today.ToString("yyyy-MM-dd")}\\DiscountReport{today.ToString("HH-mm-ss-fff")}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Discounts\\{today.ToString("yyyy-MM-dd")}\\DiscountReport{today.ToString("HH-mm-ss-fff")}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Discounts\\{today.ToString("yyyy-MM-dd")}\\DiscountReport{today.ToString("HH-mm-ss-fff")}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets the destination path of the sales log and opens in browser.
        /// </summary>
        /// <param name="html">Holds the log to be used</param>
        /// <example>
        /// <code>
        /// clsHTML.PrintSalesReports(clsHTML.GenerateReceipt(clsHTML.BuildSalesReceipt(dtpStartDateActual.Value.ToString("yyyy-MM-dd"), dtpEndDateActual.Value.ToString("yyyy-MM-dd"), allOrders)));
        /// </code>
        /// </example>
        public static void PrintSalesReports(StringBuilder html)
        {
            try
            {
                DateTime today = DateTime.Now;

                // Creates the directory if it doesn't exist.
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Sales\\{today.ToString("yyyy-MM-dd")}");

                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Sales\\{today.ToString("yyyy-MM-dd")}\\SalesReport{today.ToString("HH-mm-ss-fff")}.html");
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Sales\\{today.ToString("yyyy-MM-dd")}\\SalesReport{today.ToString("HH-mm-ss-fff")}.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\PlayAway\\Sales\\{today.ToString("yyyy-MM-dd")}\\SalesReport{today.ToString("HH-mm-ss-fff")}.html");

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.", "Error with System Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
