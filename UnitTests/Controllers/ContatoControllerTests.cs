using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ExamplesDotnetFramework.Controllers;
using ExamplesDotnetFramework.Models;
using System.Collections.Generic;
using System.Collections;

namespace UnitTests.Controllers
{
    [TestClass]
    public class ContatoControllerTests
    {
        [TestMethod]
        public void Create()
        {
            // Arrange
            var IsTrue = true;

            // Assert
            Assert.IsTrue(IsTrue);
        }

        [TestMethod]
        public void List()
        {
            // Arrange
            var controller = new ContatoController();

            // Act
            var result = controller.List() as ViewResult;
            var contatos = (IList)result.ViewData.Model;

            // Assert            
            Assert.AreEqual(3, contatos.Count);
        }
    }
}
