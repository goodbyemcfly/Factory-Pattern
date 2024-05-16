using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IOrderable
    {
        public double Price { get; set; }
        public void Description();
    }
}
