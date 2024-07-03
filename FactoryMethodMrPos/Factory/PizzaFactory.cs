using FactoryMethodMrPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Factory;

public class PizzaFactory : FoodFactory
{
    public int BakeTime { get; set; }
    public string Name { get; set; }

    public PizzaFactory(string name, int baketime) 
    { 
        this.Name = name;
        this.BakeTime = baketime;
    }

    public override IFood CreateFood()
    {
        return new Pizza(Name, BakeTime);
    }
}