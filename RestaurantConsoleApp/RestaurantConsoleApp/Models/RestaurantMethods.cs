using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.Models;

public static class RestaurantMethods
{
    public static double GetSumofPrice(this List<Dish> dishes)
    {
        double sumofPrice = 0;
        foreach (Dish dish in dishes)
        {
            sumofPrice += dish.Price;
        }
        return sumofPrice;
    }
}
