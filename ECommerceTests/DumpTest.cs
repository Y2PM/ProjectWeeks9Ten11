using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseLibrary;
using System.Collections.Generic;
using Moq;
using System.Data.Entity;
using System.Linq;


namespace ECommerceTests
{
    [TestClass]
    public class DumpTest
    {
        [TestMethod]
        public void Test_GetItemsFromDB_GetsDatabaseItems_WhenCalled()
        {
            //Note: I need to be able to test this without actually using the database.

            //Arrange

            Mock<ECommerceProjectSystemEntities> MockECommerceProjectSystemEntities
                = new Mock<ECommerceProjectSystemEntities>();//*********mocked context*********

            var mockSet = new Mock<DbSet<item>>();

            //Pretend Data:
            var data = new List<item>
            {
                new item { item_name = "PocketWormHole", item_price = 50 },
                new item { item_name = "NuclearWinterGenerator", item_price = 2000 },
            }.AsQueryable();
            //

            //Making a Mockset:
            mockSet.As<IQueryable<item>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<item>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<item>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<item>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            //--Stub:
            MockECommerceProjectSystemEntities.Setup(c => c.items).Returns(mockSet.Object);
            Dump dump = new Dump(MockECommerceProjectSystemEntities.Object);

            //Act
            List<item> itemList = dump.GetItemsFromDB();

            //Assert
            CollectionAssert.AreEqual(data.ToList(), itemList);
        }

        /*
        [TestMethod]
        public void Test_addItemtoDB_AddsAnItemToTheDataBase_WhenGivenAnItemToAdd()
        {
            //Arrange

            //*********mocked context*********:
            Mock<ECommerceProjectSystemEntities> MockECommerceProjectSystemEntities = new Mock<ECommerceProjectSystemEntities>();
            Dump dump = new Dump(MockECommerceProjectSystemEntities.Object);
            item item1 = new item() { item_name = "Money", item_price = 68 };

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

            MockECommerceProjectSystemEntities.Setup(c => c.items).Returns(mockSet.Object);

            //Act
            dump.addItemtoDB(item1);

            //Assert
            CollectionAssert.AreEqual(data.ToList().Count+1, dump.ToList().Count);

        }
        */
    }
}
