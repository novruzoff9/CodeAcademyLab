using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.Models;

public class Restaurant
{
    public Restaurant(string name)
    {
        this.Name = name;
    }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }

    public static List<Restaurant> AllRestaurants = new List<Restaurant>();
}
