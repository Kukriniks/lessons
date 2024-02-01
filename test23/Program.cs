namespace test23
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Action<int> action = (it) => { Console.WriteLine(it*30); };
            //action = (i) => { Console.WriteLine(i); };
           Method(action);
            
            //Task.Delay(10000).Wait();
             Task.WaitAll();

        }
        static async Task<Task> Method(Action <int>action)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % 10 == 0)
                    {
                        action(i);
                        Thread.Sleep(1000);
                    }
                }
            });
            
        }
    }
}
