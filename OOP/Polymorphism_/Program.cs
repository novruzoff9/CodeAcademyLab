using Polymorphism_.Models;

namespace Polymorphism_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MobilePhone ph = new();
            ph.OS = "Android";
            ph.Brand = "Samsung";

            Console.WriteLine(ph.GetHashCode());
        }
    }
}
