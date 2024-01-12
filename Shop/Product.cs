using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Product : ISalable
    {
        public int Price { get ; set ; }
        public string Name { get ; set; }

        Product(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
