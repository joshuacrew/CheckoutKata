using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class Checkout
    {
        private readonly List<string> basket;
        private static readonly Dictionary<string, decimal> priceDirectory = new Dictionary<string, decimal>
        {
            {"A99", 0.50m},
            {"B15", 0.30m},
            {"C40", 0.60m}
        };

        public Checkout()
        {
            basket = new List<string>();
        }

        public void Scan(Item item)
        {
            basket.Add(item.Sku);
        }

        public decimal GetTotalPrice()
        {
            priceDirectory.TryGetValue(basket.First(), out var price);
            return price;
        }
    }
}