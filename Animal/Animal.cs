

namespace Animal
{
    internal abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numOfgLegs;
        public int NumOfLegs
        {
            get { return numOfgLegs; }
            set { numOfgLegs = value; }
        }

        public void DisplayAnimal() { }

        public Animal(string Name, int NumOfLegs)
        {
            this.Name = Name;
            this.NumOfLegs = NumOfLegs;
        }
    }
}
