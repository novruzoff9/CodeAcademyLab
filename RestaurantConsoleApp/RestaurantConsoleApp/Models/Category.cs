using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.Models;

public class Category
{
    public Category(int id, string name)
    {
        this.CategoryId = id;
        this.Name = name;
    }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish> Dishes { get; set; }

    public static List<Category> AllCategories = new List<Category>();
}
