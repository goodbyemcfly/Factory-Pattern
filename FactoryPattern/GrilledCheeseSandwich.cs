using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GrilledCheeseSandwich : IOrderable
    {
        public double Price { get; set; } = 8.99;

        public void Description()
        {
            Console.WriteLine("A three cheese blend pan toasted on sourdough bread.");
        }
    }
}
