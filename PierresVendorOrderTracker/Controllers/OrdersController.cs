using Microsoft.AspNetCore.Mvc;
using PierresVendorOrderTracker.Models;
using System.Collections.Generic; 

namespace PierresVendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Order myOrder = new Order(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}