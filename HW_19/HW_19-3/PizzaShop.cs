using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19_3
{
    internal class PizzaShop
    {
        public Pizza MakePizza()
        {
            Pizza pizza = new Pizza();
            
            Console.WriteLine("adding sausage");
            Task.Delay(1000).Wait();

            pizza.Sausage = 1;

            Console.WriteLine("adding Tomato");
            Task.Delay(1000).Wait();
            pizza.Tomato = 1;
 
            Console.WriteLine("adding Cheees");
            Task.Delay(1000).Wait();
            pizza.Cheees = 1;

            Console.WriteLine($"Sausage:{pizza.Sausage} Tomato:{pizza.Tomato} Cheees:{pizza.Cheees}");
            Console.WriteLine("Take pizza in oven");
            Task.Delay(10000).Wait();
            Console.WriteLine("Pizza done");
            return pizza;
        }

        private void AddIngredients()
        { 

        }
        private void PutInOven()
        { 

        }
    }
}
