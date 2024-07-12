using RestaurantConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.BusinessLogic;

public class OrderService
{
    public static void AddOrder(List<Dish> dishes)
    {
        int newid = Order.AllOrders.Last().OrderId;
        Order neworder = new Order(newid);
        neworder.Dishes = dishes;
        neworder.TotalAmount = RestaurantMethods.GetSumofPrice(dishes);

        Order.AllOrders.Add(neworder);
    }
}
