using Microsoft.VisualBasic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();

            for (int i = 0; i < 120; i++)
            {
                clients.Add(new Client(i));
            }

            var test = (from p in clients
                        from y in p.Year
                        from m in y.Value
                        group m by y.Key into years  //группируем по годам  //select years;
                        from m2 in years
                        group m2.Value by years.Key into years2 //группируем месяцы // select years2;
                        select new { Year = years2.Key, Month = years2.Aggregate((x, y) => x + y) }) //in value Month sum of fitness hours
                       .OrderByDescending(x => x.Month).FirstOrDefault();
            //так тут и не придумал , как получить несколько значений, если сумма часов в месяце вдруг окажется одинаковая ничегоне выходит (
            Console.WriteLine($"In {test.Year} was {test.Month} total fitness hours");          
        }
    }
}

