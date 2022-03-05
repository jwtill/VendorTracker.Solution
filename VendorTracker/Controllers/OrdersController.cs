using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;


namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, double price)
    {
      Order myOrder = new Order(title, description, price);
      return RedirectToAction("Index");
    }
   
    

  }

}