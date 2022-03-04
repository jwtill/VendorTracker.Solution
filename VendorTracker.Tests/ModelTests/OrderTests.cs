using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

   

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "Some Things", 3.99);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Blue Monday Order"; 
      string description = "Some Things";
      double price = 3.99;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Blue Monday Order"; 
      string description = "Some Things";
      double price = 3.99;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Price()
    {
      string title = "Blue Monday Order"; 
      string description = "Some Things";
      double price = 3.99;
      Order newOrder = new Order(title, description, price);
      double result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Blue Monday Order"; 
      string description = "Some Things";
      double price = 3.99;
      Order newOrder = new Order(title, description, price);
      string updatedTitle = "Happy Mondays";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "Blue Monday Order"; 
      string description = "Some Things";
      double price = 3.99;
      Order newOrder = new Order(title, description, price);
      string updatedDescription = "Some Other Things";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
  }
}