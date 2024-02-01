namespace synchronization
{
    internal class Program
    {
        internal static void Incriment(ref int i, object lockObject)
        {

            for (int j = 0; j < 1000; j++)
            {
                lock (lockObject)
                {
                    Console.WriteLine($"Current Thread = {Thread.CurrentThread.Name}");
                    i++;
                }
            }
        }

        static void Main(string[] args)
        {
            object lockObject = new object();

            int count = 0;

            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => Incriment(ref count, lockObject));
                threads[i].Name = i.ToString();
                threads[i].Start();
            }

            while (!threads.All(x => x.IsAlive != true))
            {
                for (int i = 0; i < threads.Length; i++)
                {
                    Console.Write($"{threads[i].Name}-{threads[i].IsAlive} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(count);
        }

    }
}
