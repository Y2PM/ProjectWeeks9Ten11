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
            basket.addItem(item1, itemsList1);

            //Assert
            Assert.AreEqual(1, itemsList1.Count);
        }

        [TestMethod]
        public void Test_removeItem_RemovesAnItem_WhenGivenAnItemToRemove()
        {
            //Arrange

            #region CoolNames
            //string name1 = "PocketWormHole";
            //string name2 = "NuclearWinterGenerator"; 
            #endregion

            List<Item> itemsList1 = new List<Item>();
            Basket basket = new Basket(itemsList1);
            Item item1 = new Item();
            Item item2 = new Item();

            basket.addItem(item1, itemsList1);
            basket.addItem(item2, itemsList1);

            //Act
            basket.removeItem(item1, basket.itemsList);
            //Assert
            Assert.AreEqual(1, basket.itemsList.Count);
        }


       
    }
}
