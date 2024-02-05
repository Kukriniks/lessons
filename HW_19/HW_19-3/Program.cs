namespace HW_19_3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            PizzaShop newPizza = new PizzaShop();
            //Pizza pizaa = newPizza.MakePizza();
            List<Pizza> pzz = new List<Pizza>();
            Semaphore _pool = new Semaphore(2, 3, "Unic");

            _pool.WaitOne();
            await Task.Run(async() => {         
              

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                     pzz.Add(newPizza.MakePizza());                    
                    await Task.Delay(15000);
                    Console.WriteLine("Pizza order done");
                }

                _pool.Release();
            });




        }
    }
}
