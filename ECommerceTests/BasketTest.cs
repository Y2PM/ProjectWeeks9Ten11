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
            //Arrange
            string name1 = "PocketWormHole";
            string name2 = "NuclearWinterGenerator";

            List<Item> itemsList1 = new List<Item>();
            Basket basket = new Basket(itemsList1);
            Item item1 = new Item();
            Item item2 = new Item();


            item1.itemName = name1;
            item2.itemName = name2;

            basket.itemsList.Add(item1);
            basket.itemsList.Add(item2);

            //Act
            basket.removeItem(item1, basket.itemsList);
            //Assert
            Assert.AreEqual(1, basket.itemsList.Count);
        }


       
    }
}
