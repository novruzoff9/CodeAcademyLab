﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.Models;

public class Order
{
    public Order(int id)
    {
        this.OrderId = id;
    }
    public int OrderId { get; set; }
    public List<Dish> Dishes { get; set; }
    public double TotalAmount { get; set; }

    public static List<Order> AllOrders = new List<Order>();

    public static void AddOrder(List<Dish> dishes)
    {
        int newid = AllOrders.Last().OrderId;
        Order neworder = new Order(newid);
        neworder.Dishes = dishes;
        neworder.TotalAmount = RestaurantMethods.GetSumofPrice(dishes);

        AllOrders.Add(neworder);
    }

}
