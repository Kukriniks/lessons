namespace Animal
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {
        private string sound;
        private string colour;

        public Bear(string Name, int NumOfLegs, string sound, string color) : base(Name, NumOfLegs)
        {
            this.sound = sound;
            this.colour = color;
        }
        public string typeC { get; set; }
        public string foodC { get; set; }
        public string typeH { get; set; }
        public string foodH { get; set; }

        void ICarnivore.DisplayEatC()
        {
            Console.WriteLine("Bear eat meat");
        }

        void IHerbivore.DisplayEatH()
        {
            Console.WriteLine("Bears likes berries");
        }
    }
}
