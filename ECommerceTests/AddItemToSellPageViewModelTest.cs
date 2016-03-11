using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfECommerceProject.ViewModels;
using DatabaseLibrary;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

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


        [TestMethod]
        public void Test_addToDB_AddsItemToDataBase_WhenCalled()
        {
            //Arrange

            Mock<ECommerceProjectSystemEntities> MockECommerceProjectSystemEntities = new Mock<ECommerceProjectSystemEntities>();
            Mock<Dump> dump = new Mock<Dump>(MockECommerceProjectSystemEntities.Object);
            Mock<item> item1 = new Mock<item>();

            var mockSet = new Mock<DbSet<item>>();

            //Initial Pretend Data:
            var data = new List<item>
            {
                new item { item_name = "PocketWormHole", item_price = 50 },
                new item { item_name = "NuclearWinterGenerator", item_price = 2000 },
            }.AsQueryable();

            //Making a Mockset:
            mockSet.As<IQueryable<item>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<item>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<item>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<item>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            MockECommerceProjectSystemEntities.Setup(c => c.items).Returns(mockSet.Object);//Stub

            AddItemToSellPageViewModel addToDBClass = new AddItemToSellPageViewModel(dump.Object, item1.Object);
            //Act
            addToDBClass.addToDB();
            //Assert
            dump.Verify(x => x.addItemtoDB(It.IsAny<item>()));
        }
    }
}
