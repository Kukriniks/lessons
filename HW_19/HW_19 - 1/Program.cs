namespace HW_19_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            //Task for test
            var testTask = Task.Run(() =>
               {
                   for (global::System.Int32 i = 0; i < 10; i++)
                   {
                       Console.WriteLine("Task-Test");
                       Thread.Sleep(1000);
                   }
               });

            //Token cancel delegat
            token.Register(() => { Console.WriteLine("Task Canceled"); });

            Action action = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("=====Cancel+++++");
                        break;
                    }

                    Console.WriteLine($"do something in thread {Thread.CurrentThread.ManagedThreadId}"); ;
                    Task.Delay(1000).Wait();
                }
            };

            //Run method wit my task
            Task test = RunActionAsync(action, token);
            Thread.Sleep(1000);

            cts.Cancel(); //cancel Task

            for (int i = 0; i < 10; i++) // просто посмотреть как будет выполняться 
            {
                Console.WriteLine($"From Main in in thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }

            await Console.Out.WriteLineAsync("end of Main");
            Console.ReadLine();
        }

        static async Task RunActionAsync(Action action, CancellationToken token)
        {
            await Task.Run(action, token);
            Console.WriteLine("end of Method RunAction");


        }
    }
}
