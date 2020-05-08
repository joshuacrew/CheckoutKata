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
            var item = new Item(sku);

            checkout.Scan(item);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(expectedPrice, totalPrice);
        }
    }
}