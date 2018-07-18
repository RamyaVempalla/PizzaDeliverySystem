using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------WELCOME---------");
            Pizza pizza = new Pizza();
            Beverages beverages = new Beverages();
            Bill bill = new Bill();
            int choice=1;
            do
            {
             int option;
                Console.WriteLine("1.Pizza");
                Console.WriteLine("2.Beverages");
                Console.WriteLine("3.Bill");
                Console.WriteLine("4.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        pizza.selectPizzaType();
                        break;
                    case 2:
                        beverages.selectBeverage();
                        break;
                    case 3:
                        bill.payment(pizza);
                        break;
                    case 4:Console.WriteLine("Exit");
                        break;
                    default:Console.WriteLine("Enter the correct number");
                        break;
                }
                choice = option;
            } while (choice!=4);
        }
    }
}
