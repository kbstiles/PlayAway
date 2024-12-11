namespace SF_KStilesM2
{
    /// <summary>
    /// Class that handles creation of order details to be used throughout the program.
    /// </summary>
    public class clsOrderDetails
    {
        //Variables
        string itemName;

        decimal originalPrice,
            updatedPrice,
            totalPerLine;

        int quantity,
            inventoryID,
            orderID;

        int? discountID;

        public int GetInventoryID()
        {
            return inventoryID;
        }

        public void SetInventoryID(int inventoryID)
        {
            this.inventoryID = inventoryID;
        }

        public string GetItemName()
        {
            return itemName;
        }

        public void SetItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public decimal GetOriginalPrice()
        {
            return originalPrice;
        }

        public void SetOriginalPrice(decimal originalPrice)
        {
            this.originalPrice = originalPrice;
        }

        public decimal GetUpdatedPrice()
        {
            return updatedPrice;
        }

        public void SetUpdatedPrice(decimal updatedPrice)
        {
            this.updatedPrice = updatedPrice;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public decimal GetTotalPerLine()
        {
            return totalPerLine;
        }

        public void SetTotalPerLine(decimal totalPerLine)
        {
            this.totalPerLine = totalPerLine;
        }

        public int GetOrderID()
        {
            return orderID;
        }

        public void SetOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public void SetDiscountID(int? discountID)
        {
            this.discountID = discountID;
        }

        public clsOrderDetails(int orderID, int inventoryID, string itemName, decimal unitPrice, int orderQuantity)
        {
            SetOrderID(orderID);
            SetInventoryID(inventoryID);
            SetItemName(itemName);
            SetOriginalPrice(unitPrice);
            SetQuantity(orderQuantity);

        }
    }
}
