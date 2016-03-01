using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerce.Project;
using System.Collections.Generic;

namespace ECommerceTests
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void Test_addItem_AddsAnItem_WhenAnItemIsAdded()
        {
            //Arrange
            string name = "PocketWormHole";
            Basket basket = new Basket();
            Item item1 = new Item();
            item1.itemName = name;
            
            //Act
            Dictionary<int,Item> basket1 = basket.addItem(item1);

            //Assert
            Assert.AreEqual(name, basket1[0].itemName);
        }

        [TestMethod]
        public void Test_removeItem_RemovesAnItem_WhenGivenAnItemToRemove()
        {
            
        }

    }
}
