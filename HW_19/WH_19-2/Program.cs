using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;
using System.Timers;

namespace WH_19_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 10_000;//ms
            PrintString(time);
            Console.ReadLine();
        }
        static async Task PrintString(int time)
        {
            //Timer
            Task Ttimer = Task.Run(() => { StartTimer(time); }); //так красивее но не правильно 

            //Можно так 
            await Task.Delay(time).ContinueWith(_ => { Console.WriteLine("Hello from callback"); });

            //GetAwaiter();
            Task awaiter = Task.Delay(time);
            var aAwaiter = awaiter.GetAwaiter();
            aAwaiter.OnCompleted(() => { Console.WriteLine("Hello from callback"); });
        }

        public static void StartTimer(int time)
        {
            int timerEventsCount = 0;
            System.Timers.Timer timer;
            timer = new System.Timers.Timer(time);
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
            {
                timerEventsCount++;
                Console.WriteLine($"count down {time / 1000 - timerEventsCount + 1}");
                if (timerEventsCount > time/1000)
                {
                    Console.WriteLine("Hello from callback");
                    timer.Enabled = false;
                }
            }            
        }
    }
}
