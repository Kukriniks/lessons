using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAndBuyer
{
    internal class Bueyer
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string? Name { get; set; }

        public Bueyer(int id, int carID, string name)
        {
            ID = id;
            CarID = carID;
            Name = name;            
        }
    }
}
