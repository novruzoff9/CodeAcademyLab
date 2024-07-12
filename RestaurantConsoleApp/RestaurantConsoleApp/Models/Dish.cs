using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.Models;

public class Dish
{
    public Dish(int id, string name, double price)
    {
        this.DishId = id;
        this.Name = name;
        this.Price = price;
    }
    public int DishId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public static List<Dish> AllDishes = new List<Dish>();

    public static List<Dish> GetDishesByCategory(Category category)
    {
        return AllDishes.Where(x => x.Category == category).ToList();
    }
}
