using Microsoft.AspNetCore.Mvc;

namespace PierresVendorOrderTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}