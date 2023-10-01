using System.Collections.Generic;
using System;

namespace PierresVendorOrderTracker.Models
{
  public class Order
  {
    public int Number { get; set; }
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(int number, string title, string description, decimal price)
    {
      Number = number;
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Now;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}