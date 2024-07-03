using FactoryMethodMrPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Factory;

public class PastaFactory : FoodFactory
{
    public int BoilTime { get; set; }
    public string Name { get; set; }

    public PastaFactory(string name, int boil)
    {
        this.BoilTime = boil;
        this.Name = name;
    }

    public override IFood CreateFood()
    {
        return new Pasta(Name, BoilTime);
    }
}
