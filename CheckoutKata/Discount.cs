namespace CheckoutKata
{
    internal class Discount
    {
        public string Sku { get; }
        public int AmountRequired { get; }
        public decimal DiscountedAmount { get; }

        public Discount(string sku, int amountRequired, decimal discountedAmount)
        {
            Sku = sku;
            AmountRequired = amountRequired;
            DiscountedAmount = discountedAmount;
        }
    }
}