using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;


namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, double price)
    {
      Order myOrder = new Order(title, description, price);
      return RedirectToAction("Index");
    }
    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    

  }

}