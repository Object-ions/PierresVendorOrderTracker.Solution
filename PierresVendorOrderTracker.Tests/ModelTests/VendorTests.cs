using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresVendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Suzi Cafe";
      string name02 = "Susu 'n' Sons";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Suzi Cafe";
      string name02 = "Susu 'n' Sons";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string orderNumber = "123ABC";
      string orderTitle = "Test Title";
      string orderDescription = "Bagette";
      decimal orderPrice = 10.99m;
      Order newOrder = new Order(orderNumber, orderTitle, orderDescription, orderPrice);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzi Cafe";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}