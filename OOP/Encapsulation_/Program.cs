using OOP.Encapsulation;
using OOP.Encapsulation.Models;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Salam";
            customer.Lastname = "Siyad";
            customer.Address = "Adres";
            Console.WriteLine();
        }
    }
}
