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
        string IHerbivore.typeH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IHerbivore.foodH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICarnivore.typeC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICarnivore.foodC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
