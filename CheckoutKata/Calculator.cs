using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public static class Calculator
    {
        private static decimal _totalPrice;

        public static decimal CalculatePrice(Dictionary<string, int> basket)
        {
            _totalPrice = 0;

            _totalPrice += basket.Select(Inventory.PriceLookup).Sum();

            ApplySpecialOffers(basket);

            return _totalPrice;
        }

        private static void ApplySpecialOffers(Dictionary<string, int> basket)
        {
            var discounts = DiscountStore.GetDiscountCriteria();

            foreach (var item in basket)
            {
                var discount =
                    discounts.FirstOrDefault(d => d.Sku == item.Key && d.AmountRequired <= item.Value);

                if (discount != null)
                {
                    var numberOfDiscountsToApply = item.Value / discount.AmountRequired;

                    _totalPrice += discount.DiscountedAmount * numberOfDiscountsToApply;
                }
            }
        }
    }
}