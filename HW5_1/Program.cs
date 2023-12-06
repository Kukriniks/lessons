namespace HW5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            int multiplicand;
            Console.WriteLine("input value");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("wrong value");
            }
            Console.WriteLine("input multiplicand");

            while (!int.TryParse(Console.ReadLine(), out multiplicand))
            {
                Console.WriteLine("wrong value");
            }

            for (int i = 1; i <= multiplicand; i++)
            {
                Console.WriteLine($"{value} x {i} = {value * i}");
            }
            Console.ReadLine();
        }
    }
}
