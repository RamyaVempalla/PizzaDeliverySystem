using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Beverages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public void selectBeverage()
        {
            List<Beverages> beverageList = new List<Beverages>();
            beverageList.Add(new Beverages() { Id = 1, Name = "Aam panna", Price = 150 });
            beverageList.Add(new Beverages() { Id = 2, Name = "Kesar kasturi", Price = 160 });
            beverageList.Add(new Beverages() { Id = 3, Name = "Liyo", Price = 170 });
            Console.WriteLine("--------Select a beverage--------");
            int choosedPizza;
            foreach (var item in beverageList)
            {
                Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
            }
            choosedPizza = Convert.ToInt32(Console.ReadLine());
            foreach (var item in beverageList)
            {
                if (item.Id == choosedPizza)
                {
                    Order.cart.Add(new Pizza() { Id = item.Id, Name = item.Name, Price = item.Price });
                    // Console.WriteLine(item.Id + "." + item.Name + " " + item.Price);
                }
            }
        }
    }
}
