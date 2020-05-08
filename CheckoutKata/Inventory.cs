using System.Collections.Generic;

namespace CheckoutKata
{
    static class Inventory
    {
        private static readonly Dictionary<string, decimal> priceDirectory = new Dictionary<string, decimal>
        {
            {"A99", 0.50m},
            {"B15", 0.30m},
            {"C40", 0.60m}
        };

        internal static decimal PriceLookup(KeyValuePair<string, int> item)
        {
            var (key, value) = item;
            priceDirectory.TryGetValue(key, out var price);
            return price * value;
        }
    }
}