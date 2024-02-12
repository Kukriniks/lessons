using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal interface IProduct
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public int ProductId { get; set; }
    }
}
