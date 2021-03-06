﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
        public void SelectPizzaType()
        {
            int selection = 1;
            Console.WriteLine("-----Select type of pizza------");
            Console.WriteLine("1.Veg");
            Console.WriteLine("2.Non Veg");
            selection = Convert.ToInt32(Console.ReadLine());
            if(selection==1)
            {
                var vegPizza = new VegPizza();
                vegPizza.Veg();
            }
            else
            {
                var nonVegPizza = new NonVegPizza();
                nonVegPizza.NonVeg();
            }
        }
    }
    public class VegPizza : Pizza
    {
        public void Veg()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza() { Id=1,Name = "cheese pizza", Price = 150 });
            pizzaList.Add(new Pizza() { Id=2,Name = "veg Sausage", Price = 160 });
            pizzaList.Add(new Pizza() { Id=3,Name = "veg supreme", Price = 170 });
            Console.WriteLine("--------Select a pizza--------");
            int choosedPizza;
            foreach(var item in pizzaList)
            {
                Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
            }
            choosedPizza = Convert.ToInt32(Console.ReadLine());
            foreach (var item in pizzaList)
            {
                if(item.Id==choosedPizza)
                {
                    Order.Cart.Add(new Pizza() { Id = item.Id, Name = item.Name, Price = item.Price });
                   // Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
                }
            }
        }
    }
    public class NonVegPizza : Pizza
    {
        public void NonVeg()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza() { Id = 1, Name = "cheese pizza", Price = 150 });
            pizzaList.Add(new Pizza() { Id = 2, Name = "Non veg Sausage", Price = 160 });
            pizzaList.Add(new Pizza() { Id = 3, Name = "Non veg supreme", Price = 170 });
            Console.WriteLine("--------Select a pizza--------");
            foreach (var item in pizzaList)
            {
             Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
            }
            int choosenPizza;
            choosenPizza = Convert.ToInt32(Console.ReadLine());
            foreach (var item in pizzaList)
            {
                if (item.Id == choosenPizza)
                {
                    Order.Cart.Add(new Pizza() { Id = item.Id, Name = item.Name, Price = item.Price });
                   // Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
                }
            }

        }
    }
}
