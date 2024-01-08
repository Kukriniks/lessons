namespace Animal
{
    internal class Cat : Animal, ICarnivore
    {
        private string sound;
        private string colour;

        public string typeC { get; set; }
        public string foodC { get; set; }

        void ICarnivore.DisplayEatC()
        {
            Console.WriteLine("Cats like rats");
        }

        public Cat(string Name, int NumOfLegs, string sound, string colour) : base(Name, NumOfLegs)
        {
            this.sound = sound;
            this.colour = colour;
        }
    }
}
