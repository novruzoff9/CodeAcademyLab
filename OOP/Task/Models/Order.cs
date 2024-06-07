using Polymorphism_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models;

public class Order
{
    public static List<Order> Orders = new List<Order>();

    public int Id { get; set; }
    public List<Book> Books { get; set; }
    public double TotalPrice { get; set; }
    public readonly DateTime OrderDateTime = DateTime.Now;

    public override string ToString()
    {
        return $"{this.Id} nomreli sifaris:\nSifaris olunan kitablar:\n{Library.ReadBooks(this.Books)}\n" +
            $"Umumi mebleg: {this.TotalPrice}\nSifaris vaxti {this.OrderDateTime}";
    }

    /// <summary>
    /// Sifarisin umumi Meblegi
    /// </summary>
    /// <param name="books">Sifarisde movcud olan kitablar</param>
    /// <returns>Umumi mebleg</returns>
    public static double OrderAmount(List<Book> books)
    {
        double total = 0;
        foreach (var book in books)
        {
            total += book.Price;
        }
        return total;
    }

    /// <summary>
    /// Sifarisi tamamlama
    /// </summary>
    /// <param name="books">Sifarisde movcud olan kitablar</param>
    public static void CompleteOrder(List<Book> books)
    {
        Order order = new Order();

        order.Id = Orders.Count + 1;
        order.Books = books;
        order.TotalPrice = OrderAmount(books);
        Orders.Add(order);
    }

    /// <summary>
    /// Butun sifarisleri goster
    /// </summary>
    public static void ShowOrders()
    {
        Console.WriteLine("Verilmis butun sifarisler:\n");
        foreach (Order order in Orders)
        {
            Console.WriteLine(order);
        }
    }
}
