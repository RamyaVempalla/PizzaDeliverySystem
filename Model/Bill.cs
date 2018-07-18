using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
        
        public int total=0;

        public void payment(Pizza pizza)
        {
            foreach (var item in Order.cart)
            {
                total = total + item.Price;
            }
            Console.WriteLine("Your bill is"+total);
        }
    }
}
