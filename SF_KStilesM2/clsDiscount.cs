using System;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to hold discount data
    /// </summary>
    public class clsDiscount
    {
        //Variables
        public string discountCode { get; }
        public string Description { get; }

        public int discountID { get; }
        public int discountLevel { get; }
        public int? inventoryID { get; }
        public int discountType { get; }

        public decimal? discountPercentage { get; }
        public decimal? discountDollarAmount { get; }

        public string expirationDate { get; }

        public string startDate { get; }

        public bool? Disabled { get; }

        public clsDiscount(
            int discountID,
            string discountCode,
            string Description,
            int discountLevel,
            int? inventoryID,
            int discountType,
            decimal? discountPercentage,
            decimal? discountDollarAmount,
            string startDate,
            string expirationDate,
            bool? Disabled
            )
        {
            this.discountID = discountID;
            this.discountCode = discountCode;
            this.Description = Description;
            this.discountLevel = discountLevel;
            this.inventoryID = inventoryID;
            this.discountType = discountType;
            this.discountPercentage = discountPercentage;
            this.discountDollarAmount = discountDollarAmount;
            this.startDate = startDate;
            this.expirationDate = expirationDate;
            this.Disabled = Disabled;
        }
    }
}
