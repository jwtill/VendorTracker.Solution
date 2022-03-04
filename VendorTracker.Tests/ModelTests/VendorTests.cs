using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Marcus", "Amazing Larry's Foods");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Dan";
      Vendor newVendor = new Vendor(name, "Big Foods");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
     [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "A smelly place";
      Vendor newVendor = new Vendor("Amazing Larry", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
  }
}