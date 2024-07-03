using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Models;

public class Pizza : IFood
{
    public Pizza(string name, int bakeTime)
    {
        Name = name;
        BakeTime = bakeTime;
    }

    public string Name { get; set; }
    public int BakeTime { get; set; }
    public string GetName() => $"{this.Name} Pizza";

    public void Preapearing()
    {
        Console.WriteLine("Inqrediyentler artirilir");
        Console.WriteLine($"{this.BakeTime} deqiqe sobada bisirilir");
    }
}
