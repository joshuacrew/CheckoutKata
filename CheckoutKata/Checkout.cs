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

        public void Scan(IEnumerable<string> items)
        {
            foreach (var sku in items)
            {
                if (basket.ContainsKey(sku))
                {
                    basket[sku] += 1;
                }
                else
                {
                    basket.Add(sku, 1);
                }
            }
        }

        public decimal GetTotalPrice()
        {
            return Calculator.CalculatePrice(basket);
        }
    }
}