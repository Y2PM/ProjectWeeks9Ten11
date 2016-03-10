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

            #region referenceUrl
            //http://stackoverflow.com/questions/9122708/unit-testing-private-methods-in-c-sharp 
            //Class target = new Class();
            //PrivateObject obj = new PrivateObject(target);
            //var retVal = obj.Invoke("PrivateMethod");
            //Assert.AreEqual(retVal);
            #endregion
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
            //Make a mock object

            //Arrange
            string name = "John";
            string price = "20";
            Dump dump = new Dump(new ECommerceProjectSystemEntities());
            item item1 = new item() { item_name = name, item_price = Int32.Parse(price) };

            AddItemToSellPageViewModel addToDB = new AddItemToSellPageViewModel(dump, item1);
            PrivateObject obj = new PrivateObject(addToDB);
            //Act
            obj.Invoke("addToDB(item1)");
            //Assert

        }
        */
    }
}
