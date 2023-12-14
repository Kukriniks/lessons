using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Library.Transport
{
    public class Engine
    {    
        public Engine(string fuelType, bool isEngineReady)
        {           
            switch (fuelType.ToLower()) 
            {
                case "gas":
                case "diesel":
                case "electricity":
                    engineType = "CarEngine";
                    break;
                case "reactive":
                    engineType = "PlainEngine";
                    break;
                default:
                    engineType = "not implemented";
                    break;
            }
            this.isEngineReady = isEngineReady;
        }
        public void StartEngine() 
        {
            if (isEngineReady)
            {
                Console.WriteLine("start engine");
            }
        }
        public bool isEngineReady { get; set;}
        public string engineType { get; set;}
    }
 
}
