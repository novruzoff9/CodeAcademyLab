using RestaurantConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.BusinessLogic;

public class DishService
{
    public static List<Dish> GetDishesByCategory(Category category)
    {
        return Dish.AllDishes.Where(x => x.Category == category).ToList();
    }
}
