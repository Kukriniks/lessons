namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Herbivore rabbit1 = new Herbivore("rabbit1");

            while (rabbit1.HungryLevel < rabbit1.stomachFull)
            {
                rabbit1.Live();
                Console.WriteLine("hungreLevel = " + rabbit1.HungryLevel);
            }

            Predator woolf = new Predator("woolf1");
            while (woolf.HungryLevel < 20)
            {
                woolf.Live();
                Console.WriteLine("hungreLevel = " + woolf.HungryLevel);
            }

            Zoo zoo = new Zoo();
            zoo.AddAnimal(rabbit1);
            Animal ant = new Animal("ant");
            zoo.AddAnimal(ant);

        }
    }
}
