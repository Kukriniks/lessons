using System.Collections.Concurrent;
using System.Diagnostics;

namespace Parall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            int ItemCount = 100_000_000;

            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Random rnd = new();

            stopwatch.Start();
            Parallel.For(0, ItemCount, i =>
            {
                bag.Add(rnd.Next(2, 100));
            });

            Parallel.ForEach(bag, item =>
            {
                item = (int)Math.Pow(item, 2);

                //Console.WriteLine($" {item} POW^2 {Math.Pow(item, 2)}");
            });
            stopwatch.Stop();

            //решил замерить и так :)
            stopwatch2.Start();
            List<int> list = new List<int>();

            for (int i = 0; i < ItemCount; i++)
            {
                list.Add(rnd.Next(2, 100));
            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (int)Math.Pow(list[i], 2);
                // Console.WriteLine($" {item} POW^2 {Math.Pow(item, 2)}");
            }
            stopwatch2.Stop();

            Console.WriteLine($"Parallel {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine($"general  {stopwatch2.ElapsedMilliseconds}");


        }
    }
}
