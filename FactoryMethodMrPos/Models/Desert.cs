using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Models;

public class Desert : IFood
{
    public Desert(string name, string aroma)
    {
        Name = name;
        Aroma = aroma;
    }

    public string Name { get; set; }
    public string Aroma { get; set; }
    public string GetName() => $"{Name} Desert";

    public void Preapearing()
    {
        Console.WriteLine($"{Aroma} ile dadlandir");
        Console.WriteLine("Servis et");
    }
}
