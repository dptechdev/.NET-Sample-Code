//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using SportStore.Domain.Abstract;
//using SportStore.Domain.Entities;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using SportStore.WebUI.Controllers;

//namespace SportStore.UnitTests
//{
//    [TestClass]
//    public class AdminTests
//    {
//       [TestMethod]
//        public void Can_Edit_Product()
//        {
//           //Arrange - creat the mock repository
//            Mock<IProductRepository> mock = new Mock<IProductRepository>();
//            mock.Setup(m => m.Products).Returns(new Product[] {
//               new Product {ProductID = 1, Name = "P1"},
//               new Product {ProductID = 2, Name = "P2"},
//               new Product {ProductID = 3, Name = "P3"},
//           });

//           //Arrange - create the controller
//            AdminController target = new AdminController(mock.Object);

//           //Act 
//            Product p1 = target.Edit(1).ViewData.Model as Product;
//            Product p2 = target.Edit(2).ViewData.Model as Product;
//            Product p3 = target.Edit(3).ViewData.Model as Product;

//           //Assert
//            Assert.AreEqual(1, p1.ProductID);
//            Assert.AreEqual(2, p2.ProductID);
//            Assert.AreEqual(3, p3.ProductID);

//        }

      

//    }
//}
