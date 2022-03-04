using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Monday Delivery", "A bunch of bread", 17.21);
      return View(starterOrder);
    }

    [Route("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return View("Index", myItem);
    }



  }
}