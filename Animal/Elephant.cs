namespace Animal
{
    internal class Elephant : Animal, IHerbivore, IEquatable<Elephant>
    {
        private string sound;
        private string colour;
        private uint size;

        public Elephant(string Name, int NumOfLegs, string sound, string color, uint size) : base(Name, NumOfLegs)
        {
            this.sound = sound;
            this.colour = color;
            this.size = size;
        }

        string IHerbivore.typeH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IHerbivore.foodH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayAnimal()
        {
            Console.WriteLine("Look at me, I'm big Elephant :)");
        }

        void IHerbivore.DisplayEatH()
        {
            Console.WriteLine("Elephant is eating");
        }

        public bool Equals(Elephant? other)
        {
            if (object.ReferenceEquals(other, null))
                return false;

            return size == other.size;
        }

        public static bool Equals(Elephant? el1, Elephant? el2)
        {
            if (object.ReferenceEquals(el1, el2))
            {
                return true;
            }
            if (el1 == null || el2 == null)
            {
                return false;
            }
            return el1.Equals(el2);
        }
        public override int GetHashCode()
        {
            return (base.Name.GetHashCode() << 2) ^ 2;
        }


    }
}
