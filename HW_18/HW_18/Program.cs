namespace HW_18
{
    internal class Program
    {
        static void PrintInt(object obj)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"PrintInt {i}");
                // Thread.Sleep(500);
            }
        }

        static void PrintCahr(object obj)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"Print char {(char)i}");
                // Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Thread printChar = new Thread(PrintCahr)
            { Name = "Thread_Char" };

            Thread printInt = new Thread(PrintInt)
            { Name = "Tread_INT" };

            Console.WriteLine("Tread_Start");
            printChar.Start();
            printInt.Start();

            ThreadPool.QueueUserWorkItem(PrintInt);
            ThreadPool.QueueUserWorkItem(PrintCahr);
            Console.WriteLine("Pool_Start");

            Task task1 = new Task(() => { PrintCahr("="); });
            Task task2 = new Task(() => { PrintCahr("="); });

            task1.Start();
            task2.Start();
            Console.WriteLine("Task Start");
            Console.ReadLine();

        }

    }
}
