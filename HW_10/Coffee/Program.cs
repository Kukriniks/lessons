namespace Coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Water water = new(120, 200);
            CoffeeBeans beans = new(10, CoffeeBeanVariety.Liberica);
            var coffee = water + beans;
            Console.WriteLine(coffee.Strength);
        }
    }
}
