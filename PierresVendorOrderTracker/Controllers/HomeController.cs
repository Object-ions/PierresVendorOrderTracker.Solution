using Microsoft.AspNetCore.Mvc;
using PierresVendorOrderTracker.Models;

namespace PierresVendorOrderTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Add first order to the list");
      return View(starterOrder);
    }

    [Route("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [Route("/orders")]
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return View("Index", myOrder);
    }
  }
}
