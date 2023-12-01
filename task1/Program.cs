namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 200;
            while (count < 500)
            {
                count++; //200 not in range
                if (count % 17 == 0)
                {
                    Console.Write($"{count},");
                }
            }
            Console.Write("\b \b"); //delete last ","
            //make some changes
            Console.ReadKey();
        }
    }
}
