using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class SandwichFactory
    {
        public static IOrderable MakeSandwiches(string userOrder)
        {
            switch (userOrder.ToLower())
            {
                case "club sandwich":
                case "club":
                    return new ClubSandwich();

                case "grilled cheese":
                case "grilled cheese sandwich":
                    return new GrilledCheeseSandwich();

                default:
                    return new ClubSandwich();
            }
        }
    }
}
