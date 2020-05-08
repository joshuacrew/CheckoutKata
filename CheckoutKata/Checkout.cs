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

        public void Scan(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                basket.Add(item);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in basket)
            {
                priceDirectory.TryGetValue(item, out var price);
                totalPrice += price;
            }
            return totalPrice;
        }
    }
}