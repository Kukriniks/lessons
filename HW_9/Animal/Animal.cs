namespace Animal
{
    internal class Animal
    {
        private bool _isHungry;
        public virtual string Name { get; set; }
        public virtual int HungryLevel { get; set; }
        private int mealValue;
        private int stomachFull;

        public Animal(string Name)
        { this.Name = Name; }

        public virtual void Live() //each species has own Live style )
        {
            // не придумал что сюда можно впихнуть по умолчанию, оставил просто пустой метод
        }

        public virtual int Eat(int HungryLevel, int mealValue, int stomachFull)
        {
            HungryLevel += mealValue;
            if (HungryLevel < stomachFull)
            {
                _isHungry = true;
            }
            else
            {
                Console.WriteLine("I'm not hungry , better go  sleep :)");
                _isHungry = false;
            }
            return HungryLevel;
        }
    }
}
