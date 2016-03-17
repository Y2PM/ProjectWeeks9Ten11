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
            List<Item> itemsList1 = new List<Item>();
            Basket basket = new Basket(itemsList1);
            Item item1 = new Item();
            item1.itemName = name;
            
            //Act
            basket.addItem(item1);

            //Assert
            Assert.AreEqual(1, itemsList1.Count);
        }

        [TestMethod]
        public void Test_removeItem_RemovesAnItem_WhenGivenAnItemToRemove()
        {
            //Arrange
            List<Item> itemsList1 = new List<Item>();
            Basket basket = new Basket(itemsList1);
            Item item1 = new Item();
            Item item2 = new Item();

            basket.addItem(item1);
            basket.addItem(item2);

            //Act
            basket.removeItem(item1);

            //Assert
            Assert.AreEqual(1, basket.itemsList.Count);
        }
    }
}
