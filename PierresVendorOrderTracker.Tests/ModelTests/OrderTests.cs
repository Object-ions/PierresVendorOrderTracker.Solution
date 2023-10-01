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
            Order newOrder = new Order("123ABC", "test", "test", 10.99m);

            // Assert
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            // Arrange
            string description = "Test Description";
            Order newOrder = new Order("123ABC", "test", description, 10.99m);

            // Act
            string result = newOrder.Description;

            // Assert
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            // Arrange
            string description = "Bagette";
            Order newOrder = new Order("123ABC", "test", description, 10.99m);

            // Act
            string updatedDescription = "Challah";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            // Assert
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
        public void GetAll_ReturnsOrdersList_OrderList()
        {
            // Arrange
            Order newOrder1 = new Order("123ABC", "Title A", "Description A", 10.99m);
            Order newOrder2 = new Order("456DEF", "Title B", "Description B", 12.99m);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            // Act
            List<Order> result = Order.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
        {
            // Arrange
            Order newOrder = new Order("123ABC", "test", "test", 10.99m);

            // Act
            int result = newOrder.Id;

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrderItem_OrderItem()
        {
            // Arrange
            Order newOrder1 = new Order("123ABC", "test", "Description A", 10.99m);
            Order newOrder2 = new Order("456DEF", "test", "Description B", 12.99m);

            // Act
            Order result = Order.Find(2);

            // Assert
            Assert.AreEqual(newOrder2, result);
        }
    }
}