namespace Animal
{
    internal class Predator : Animal
    {
        private bool _isHungry;
        readonly int mealValue = 5;
        private int stomachFull;
        public override int HungryLevel { get; set; }

        public override void Live()
        {
            if (HungryLevel < stomachFull)
            {
                _isHungry = true;
                Console.WriteLine("Oh!!! I'm so hungry, I try to catch something yummy :)");
            }

            Random rng = new Random();
            if (_isHungry)
            {
                bool randomBool = rng.Next(0, 2) > 0;
                if (randomBool)
                {
                    Console.WriteLine("Ye!!!, i catch it");
                    HungryLevel = Eat(HungryLevel, mealValue, stomachFull);
                }
                else
                {
                    Console.WriteLine("Uuuuu.. fail hunting try to catch later ");
                }
            }
        }

        public override int Eat(int HungryLevel, int mealValue, int stomachFull)
        {
            Console.WriteLine("I've got a meat !!!");
            return base.Eat(HungryLevel, mealValue, stomachFull);
        }

        public Predator(string Name) : base(Name)
        {
            HungryLevel = 0;
            stomachFull = 20;
        }
    }
}
