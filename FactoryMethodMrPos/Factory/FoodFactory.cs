using FactoryMethodMrPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Factory;

public abstract class FoodFactory
{
    public abstract IFood CreateFood();

    public void OrderFood()
    {
        IFood food = CreateFood();

        Console.WriteLine(food.GetName());
        food.Preapearing();
    }
}
