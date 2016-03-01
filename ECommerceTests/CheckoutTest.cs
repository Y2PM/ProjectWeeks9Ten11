using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerce.Project;
using Moq;
using System.Collections.Generic;

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
            
            double price1 = 100;
            List<Item> itemsList = new List<Item>();
            Basket basket1 = new Basket(itemsList);
            Checkout checkout = new Checkout();
            Item item1 = new Item();
            
            
            item1.price = price1;

            basket1.itemsList.Add(item1);
            //Act
            double priceCheck = checkout.calculatedPrice(basket1);

            //Assert
            Assert.AreEqual(price1, priceCheck);

        }
    }
}
