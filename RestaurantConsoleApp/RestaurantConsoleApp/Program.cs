using RestaurantConsoleApp.BusinessLogic;
using RestaurantConsoleApp.Models;

namespace RestaurantConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        LoadData();
        ShowMenu();
        AdminPanel();
    }

    public static void AdminPanel()
    {
        Console.WriteLine("1. Category-ler");
        Console.WriteLine("2. Qidalar");

        Console.WriteLine("Hansı List-e melumat artirmaq istediyinizi seçin");
        Console.WriteLine("3. Menyu Goster");
        int listn = Convert.ToInt32(Console.ReadLine());

        if (listn == 1)
        {
            AddCategory();
        }
        else if (listn == 2)
        {
            AddDish();
        }
        else if (listn == 3)
        {
            ShowMenu();
        }
        AdminPanel();
    }

    public static void ShowMenu()
    {
        Console.WriteLine("Menyu");
        foreach (var category in Category.AllCategories)
        {
            Console.WriteLine($"{category.Name} qidaları:");
            List<Dish> categorydishes = new List<Dish>();
            categorydishes = DishService.GetDishesByCategory(category);
            foreach (var dish in categorydishes)
            {
                Console.WriteLine($"{dish.DishId}. {dish.Name} - {dish.Price}");
            }
            Console.WriteLine();
        }
    }

    public static void LoadData()
    {
        Category Pizzac = new Category(1, "Pizza");
        Category Saladc = new Category(2, "Salad");

        Category.AllCategories.Add(Pizzac);
        Category.AllCategories.Add(Saladc);

        Dish peperonni = new Dish(1, "peperonni", 12.99);
        Dish toyuqlupizza = new Dish(2, "toyuqlu pizza", 8.37);
        Dish mixedpizza = new Dish(3, "Mixed pizza", 15.49);

        peperonni.Category = Pizzac;
        toyuqlupizza.Category = Pizzac;
        mixedpizza.Category = Pizzac;

        Dish.AllDishes.Add(peperonni);
        Dish.AllDishes.Add(toyuqlupizza);
        Dish.AllDishes.Add(mixedpizza);


        Dish sezar = new Dish(1, "Sezar salatı", 8.59);
        Dish cobansalati = new Dish(2, "Çoban salatı", 2.47);

        sezar.Category = Saladc;
        cobansalati.Category = Saladc;

        Dish.AllDishes.Add(sezar);
        Dish.AllDishes.Add(cobansalati);

        List<Dish> randomdata = new List<Dish>();
        randomdata.Add(sezar);
        randomdata.Add(toyuqlupizza);

        //Console.WriteLine(RestaurantMethods.GetSumofPrice(randomdata));
    }

    public static void AddCategory()
    {
        Console.WriteLine("Category adini daxil edin:");
        string categoryname = Console.ReadLine();
        Console.WriteLine("Category üçün Description daxil edin:");
        string categorydesc = Console.ReadLine();

        int newid = Category.AllCategories.Last().CategoryId + 1;

        Category addcategory = new Category(newid, categoryname);
        addcategory.Description = categorydesc;
        Category.AllCategories.Add(addcategory);
        Console.WriteLine("Kateqoriyaniz ugurla artirildi");
    }

    public static void AddDish()
    {
        foreach (var category in Category.AllCategories)
        {
            Console.WriteLine($"{category.CategoryId}. {category.Name}");
        }
        Console.WriteLine("Qidani artirmaq istediyiniz kateqoriya nomresini daxil edin");
        int catid = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qida adini daxil edin:");
        string dishname = Console.ReadLine();
        Console.WriteLine("Qidanin qiymetini daxil edin");
        double dishprice = Convert.ToDouble(Console.ReadLine());


        int newid = Dish.AllDishes.Last().DishId + 1;
        Dish adddish = new Dish(newid, dishname, dishprice);

        adddish.Category = Category.AllCategories.FirstOrDefault(x => x.CategoryId == catid);
        Dish.AllDishes.Add(adddish);

        Dish.AllDishes.Find(x => x.DishId == 7);
    }
}
