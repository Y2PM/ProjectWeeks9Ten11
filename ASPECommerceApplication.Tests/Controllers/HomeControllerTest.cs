using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPECommerceApplication;
using ASPECommerceApplication.Controllers;
using Moq;
using System.Web;
using System.Web.Routing;
using DatabaseLibrary;

namespace ASPECommerceApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_Index_ReturnsAViewResult_WhenCalled()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_About_ReturnsAboutString_WhenCalled()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Test_Contact_ReturnsAViewResult_WhenCalled()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        //[TestMethod]
        //public void Test_IndexMethodInGetPriceController_ReturnsAViewResult_WhenCalled()
        //{
        //    // Arrange
        //    var mockRequest = new Mock<HttpRequestBase>();
        //    mockRequest.SetupGet(x => x.Headers).Returns(new System.Net.WebHeaderCollection { { "X-Requested-With", "XMLHttpRequest" } });//Not Ajax soon.
        //    //mockRequest.SetupGet(x => x.Headers).Returns(new System.Net.WebHeaderCollection { { "X-Requested-With", "XMLHttpRequest" } });//Ajax.
        //    //Set whether the request is ajax or not

        //    var context = new Mock<HttpContextBase>();
        //    context.SetupGet(x => x.Request).Returns(mockRequest.Object);

        //    //Use Dependency Injection to mock the database
        //    Mock<ECommerceProjectSystemEntities> MockECommerceProjectSystemEntities = new Mock<ECommerceProjectSystemEntities>();

        //    GetPriceController controller = new GetPriceController(MockECommerceProjectSystemEntities.Object);
        //    controller.ControllerContext = new ControllerContext(context.Object, new RouteData(), controller);

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

    }
}
