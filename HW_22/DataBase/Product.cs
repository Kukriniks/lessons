using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataBase
{
    public class Product : IProduct
    {       
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
        {
            return $"Name: {ProductName} Price: {Price} StockQuantity: {StockQuantity} ID: {ProductId}";
        }
    }
}
