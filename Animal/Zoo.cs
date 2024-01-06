
namespace Animal
{
    internal class Zoo
    {
        List<IHerbivore> herbivores = new List<IHerbivore>();
        List<ICarnivore> carnivores = new List<ICarnivore>();

        public void AddAnimal<T>(T animal)
        {
            if (animal is IHerbivore)
            {
                herbivores.Add((IHerbivore)animal);
            }
            else if (animal is ICarnivore)
            {
                carnivores.Add((ICarnivore)animal);
            }
            else
            {
                Console.WriteLine("Cant identify animal");
            }
        }
        public void ShowHerbivoreAnimals()
        {
            foreach (var animal in herbivores)
            {
                Console.WriteLine(animal);
            }
        }
        public void ShowCarnivoresAnimals()
        {
            foreach (var animal in carnivores)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
