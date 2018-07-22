using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Model
{
    public class Bill
    {     
        public int cost=0;

        public void Payment(Pizza pizza)
        {
            foreach (var item in Order.Cart)
            {
                cost = cost + item.Price;
            }
            Console.WriteLine("Your bill is"+ cost);
        }
    }
}
