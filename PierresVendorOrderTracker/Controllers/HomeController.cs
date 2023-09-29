using Microsoft.AspNetCore.Mvc;
using PierresVendorOrderTracker.Models;

namespace PierresVendorOrderTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Add first order to To Do List");
      return View(starterOrder);
    }

  }
}
