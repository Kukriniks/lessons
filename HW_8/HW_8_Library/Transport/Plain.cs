using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Library.Transport
{
    public class Plain : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Try to fly");
            if (engine.isEngineReady && isGoodWeather)
            {
                Console.WriteLine("All right, let's fly away");
            }
            else
            {
                Console.WriteLine("Something's wrong");
            }
        }
        public bool isGoodWeather { get; set; }

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
