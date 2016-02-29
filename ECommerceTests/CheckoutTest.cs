using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerce.Project;

namespace ECommerceTests
{
    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void Test_Checkout_ReturnsCalculatedPriceOf0_WhenGivenAnEmptyBasket()
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
        public void Test_Checkout_ReturnsPriceOfItem_WhenGivenABasketWithAnItemInIt()
        {
            
        }
    }
}
