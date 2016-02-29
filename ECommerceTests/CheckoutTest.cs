using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerce.Project;
using Moq;

namespace ECommerceTests
{
    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void Test_calculatedPrice_ReturnsCalculatedPriceOf0_WhenGivenAnEmptyBasket()
        {
            //Arrange
            Basket basket = new Basket();
            Checkout checkout = new Checkout();

            //Act
            double price = checkout.calculatedPrice();

            //Assert
            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void Test_calculatedPrice_ReturnsPriceOfItem_WhenGivenABasketWithAnItemInIt()
        {
            //Arrange
            //Mock<Basket> basket = new Mock<Basket>();
            //string name1 = "PocketWormHole";
            double price1 = 100;
            Basket basket = new Basket();
            Checkout checkout = new Checkout();
            Item item1 = new Item();
            //item1.itemName = name1;
            item1.price = price1;

            basket.itemsList.Add(item1);
            //Act
            double priceCheck = checkout.calculatedPrice(basket);

            //Assert
            Assert.AreEqual(price1, priceCheck);

        }
    }
}
