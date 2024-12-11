namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to hold calculations used during checkout.
    /// </summary>
    public class clsCalculations
    {
        //Variables
        decimal Subtotal,
            taxAmount,
            totalDue,
            discountAmount,
            discountSubtotal;

        decimal? discountPercentage,
            discountDollarAmount;

        public clsCalculations(decimal subTotal, decimal taxAmount, decimal totalDue)
        {
            SetSubtotal(subTotal);
            SetTaxAmount(taxAmount);
            SetTotalDue(totalDue);
        }

        public decimal GetSubtotal()
        {
            return Subtotal;
        }

        public void SetSubtotal(decimal subTotal)
        {
            this.Subtotal = subTotal;
        }

        public decimal GetTaxAmount()
        {
            return taxAmount;
        }

        public void SetTaxAmount(decimal taxAmount)
        {
            this.taxAmount = taxAmount;
        }

        public decimal GetTotalDue()
        {
            return totalDue;
        }

        public void SetTotalDue(decimal totalDue)
        {
            this.totalDue = totalDue;
        }

        public decimal? GetDiscountDollarAmount()
        {
            return discountDollarAmount;
        }

        public void SetDiscountDollarAmount(decimal? discountDollarAmount)
        {
            this.discountDollarAmount = discountDollarAmount;
        }

        public decimal? GetDiscountPercentage()
        {
            return discountPercentage;
        }

        public void SetDiscountPercentage(decimal? discountPercentage)
        {
            this.discountPercentage = discountPercentage;
        }

        public decimal GetDiscountAmount()
        {
            return discountAmount;
        }

        public void SetDiscountAmount(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal GetDiscountSubtotal()
        {
            return discountSubtotal;
        }

        public void SetDiscountSubtotal(decimal discountSubtotal)
        {
            this.discountSubtotal = discountSubtotal;
        }
    }
}
