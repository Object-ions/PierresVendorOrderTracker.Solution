using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorOrderTracker.Models;
using System;

namespace PierresVendorOrderTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

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
            string updatedDescription = "Challah";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            // Arrange
            List<Order> newList = new List<Order> { };

            // Act
            List<Order> result = Order.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_returnsOrdersList_OrderList()
        {
            //Arrange
            string descriptionA = "Bagette";
            string descriptionB = "Challah";
            Order newOrderA = new Order(descriptionA);
            Order newOrderB = new Order(descriptionB);
            List<Order> newList = new List<Order> { newOrderA, newOrderB };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}