using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {
        [Test]
        public void ShouldReturnCorrectPriceForIndividualItem()
        {
            var checkout = new Checkout();
            var item = new Item("A99");

            checkout.Scan(item);

            var totalPrice = checkout.GetTotalPrice();

            Assert.AreEqual(0.50, totalPrice);
        }
    }
}