using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {
        [TestCase("A99", 0.50)]
        [TestCase("B15", 0.30)]
        [TestCase("C40", 0.60)]
        public void ShouldReturnCorrectPriceForIndividualItem(string sku, double expectedPrice)
        {
            var checkout = new Checkout();

            checkout.Scan(new []{sku});

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(expectedPrice, totalPrice);
        }

        [TestCase(new [] {"A99", "A99"}, 1)]
        [TestCase(new[] { "B15", "B15" }, 0.60)]
        [TestCase(new[] { "C40", "C40" }, 1.20)]
        [TestCase(new[] { "A99", "C40" }, 1.10)]
        public void ShouldReturnCorrectPriceForMultipleItems(string[] items, double expectedPrice)
        {
            var checkout = new Checkout();
            
            checkout.Scan(items);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(expectedPrice, totalPrice);
        }
    }
}