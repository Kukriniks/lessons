namespace Animal
{
    internal class Cat : Animal, ICarnivore
    {
        private string sound;
        private string colour;

        string ICarnivore.typeC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICarnivore.foodC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Cat(string Name, int NumOfLegs, string sound, string colour) : base(Name, NumOfLegs)
        {
            this.sound = sound;
            this.colour = colour;
        }

        void ICarnivore.DisplayEatC()
        {
            Console.WriteLine("Cats like rats");
        }
    }
}
