using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private readonly Dictionary<string, int> basket;

        public Checkout()
        {
            basket = new Dictionary<string, int>();
        }

        public void Scan(Item item)
        {
            basket.Add(item.Sku, 1);
        }

        public decimal GetTotalPrice()
        {
            return 0.50m;
        }
    }
}