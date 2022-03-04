using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Orders = new List<Order> {};
    }
     public static void ClearAll()
  {
    _instances.Clear();
  }


  }
}