namespace fact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num = Fact(10);
            Console.WriteLine(num);
            Console.ReadLine();

            uint Fact(uint n)
            {
                if (n == 0)
                    return 1;
                else
                    Console.WriteLine(n);
                return n * Fact(n - 1);
            }
        }
    }
}
