using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Library.Transport
{
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Try to move");
            if (engine.isEngineReady && engine.engineType == "CarEngine")
            {
                Console.WriteLine("All right, let's go");
            }
            else
            {
                Console.WriteLine("Something's wrong");
            }         
        }

        private Engine engine;
        public override Engine Engine
        {
            get
            {
               Engine = engine;
               return engine;
            }
            set { engine = value; }
        }
    }
}
