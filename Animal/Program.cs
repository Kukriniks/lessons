namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant el = new Elephant("Elif", 4, "uuuu", "grey", 20);
            Elephant el2 = new Elephant("Elif", 4, "uuuu", "grey", 20);
            Elephant el3 = new Elephant("Elif", 4, "uuuu", "grey", 30);
            Cat cat = new Cat("Miu", 4, "miu", "stripes");
            Bear bear = new Bear("Baloo", 4, "rrrUUU", "black");
            

            Object obj = new();
            Zoo zoo = new Zoo();
            zoo.AddAnimal(cat);
            zoo.AddAnimal(el);
            zoo.AddAnimal(bear);
            zoo.AddAnimal(obj);

            zoo.ShowCarnivoresAnimals();
            zoo.ShowHerbivoreAnimals();

            Console.WriteLine(el.Equals(cat));
            Console.WriteLine(Elephant.Equals(el, el2));
        }
    }
}
