using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Models;

public class Pasta : IFood
{
    public Pasta(string name, int boilTime)
    {
        Name = name;
        BoilTime = boilTime;
    }
    
    public string Name { get; set; }
    public int BoilTime { get; set; }
    public string GetName() => $"{this.Name} Pasta";

    public void Preapearing()
    {
        Console.WriteLine("Inqrediyentler artirilir");
        Console.WriteLine($"{this.BoilTime} deqiqe qazanda qaynadilir");
    }
}