using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfECommerceProject.ViewModels;
using DatabaseLibrary;

namespace ECommerceTests
{
    [TestClass]
    public class AddItemToSellPageViewModelTest
    {
        [TestMethod]
        public void Test_canAddToDB_ReturnsTrue_WhenCalled()
        {
            //Arrange
            AddItemToSellPageViewModel addbool = new AddItemToSellPageViewModel();
            PrivateObject obj = new PrivateObject(addbool);
            //Act
            Boolean addbool2 = (Boolean)obj.Invoke("canAddToDB");
            //Assert
            Assert.AreEqual(true, addbool2);
        }

        /*
        [TestMethod]
        public void Test_addToDB_AddsItemToDataBase_WhenCalled()
        {
            //Arrange
            string name = "John";
            string price = "20";
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            item item1 = new item() { item_name = name, item_price = Int32.Parse(price) };
            //Act

            //Assert

        }
        */
    }
}
