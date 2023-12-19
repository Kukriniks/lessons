namespace Animal
{
    internal class Zoo
    {
        List<Animal> predators = new List<Animal>();
        List<Animal> herbiores = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            if (animal is Herbivore)
            {
                Console.WriteLine($"Welcome {animal.Name} to {nameof(herbiores)} zoo");
                herbiores.Add(animal);
            }
            else if (animal is Predator)
            {
                Console.WriteLine($"Welcome {animal.Name} to {nameof(predators)} zoo");
                predators.Add(animal);
            }
            else
            {
                Console.WriteLine($"go away {animal.Name}, we don't know who are you :)");
            }
        }

    }
}
