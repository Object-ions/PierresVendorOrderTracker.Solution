using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresVendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}