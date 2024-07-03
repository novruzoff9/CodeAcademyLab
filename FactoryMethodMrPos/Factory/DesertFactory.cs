using FactoryMethodMrPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Factory;

public class DesertFactory : FoodFactory
{
    public string Name { get; set; }
    public string Aroma { get; set; }
    public DesertFactory(string name, string aroma)
    {
        this.Name = name;
        this.Aroma = aroma;
    }
    public override IFood CreateFood()
    {
        return new Desert(Name, Aroma);
    }
}
