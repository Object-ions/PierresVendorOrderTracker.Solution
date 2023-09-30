using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorOrderTracker.Models;
using System;

namespace PierresVendorOrderTracker.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            // Arrange
            Order newOrder = new Order("test");
            // Act

            // Assert
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
        //Arrange
        string description = "Bagette";

        //Act
        Order newOrder = new Order(description);
        string result = newOrder.Description;

        //Assert
        Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
        //Arrange
        string description = "Bagette";
        Order newOrder = new Order(description);

        //Act
        string updatedDescription = "Challa";
        newOrder.Description = updatedDescription;
        string result = newOrder.Description;

        //Assert
        Assert.AreEqual(updatedDescription, result);
        }
    }
}