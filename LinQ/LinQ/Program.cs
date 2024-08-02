using LinQ.Models;
using LinQ.Helpers;
using Microsoft.EntityFrameworkCore;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new();

            var result = db.Products
            .Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
            .Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock,
                x.Category.CategoryName
            })
            .ToList();


            var newresult = db.OrderDetails
                .Select(x => new
                {
                    x.Order.Customer.CompanyName,
                    x.Order.Employee.FirstName,
                    x.Order.Employee.LastName,
                    x.OrderId,
                    x.Order.OrderDate,
                    ShipperName = db.Shippers.FirstOrDefault(z=>z.ShipperId == x.Order.ShipVia).CompanyName
                })
                .ToList();


            var restaurants = db.Customers
                .Where(x => x.CompanyName.Contains("restaurant"))
                .ToList();

            var employyers = db.Employees
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.BirthDate,
                    Age = (int)((DateTime.Now - x.BirthDate).Value.TotalDays / 365),
                }).ToList();



            ListToTabel.Generateatable(employyers);
        }
    }
}
