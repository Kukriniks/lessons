

using System.Collections;

namespace Fitness
{
    internal class Client 
    {
        public Dictionary<int, Dictionary<int, int>> Year { get; set; }
        public int ID { get; init; }

        public Client(int ID)
        {
            Random rnd = new Random();
            Year = new Dictionary<int, Dictionary<int, int>>();
           
            for (int j = 2010; j <= 2022; j++)
            {
                var temp = new Dictionary<int, int>();
                for (int i = 0; i < 12; i++)
                {
                    temp.Add(i + 1, rnd.Next(0, 120)); //fit hours in a each month
                }               
                Year.Add(j, temp);
            }

            this.ID = ID;
        }

    }
}
