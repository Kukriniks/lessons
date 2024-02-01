namespace test232323
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Action<int> action = (i) => { Console.WriteLine(i); };

            var tt = await Method(action);
        }

        static async Task<Task> Method(Action<int> action)
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