using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ClubSandwich : IOrderable
    {
        public double Price { get; set; } = 7.99;

        public void Description()
        {
            Console.WriteLine("A sandwich with turkey, ham, and bacon on rye bread."); ;
        }
    }
}
