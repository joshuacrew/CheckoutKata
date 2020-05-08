using System.Collections.Generic;

namespace CheckoutKata
{
    internal static class DiscountStore
    {
        public static List<Discount> GetDiscountCriteria()
        {
            return new List<Discount>
            {
                new Discount("A99", 3, -0.20m),
                new Discount("B15", 2, -0.15m)
                
            };
        }
    }
}