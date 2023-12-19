namespace Animal
{
    internal class Herbivore : Animal
    {
        private bool _isHungry;
        readonly int mealValue = 2;
        public int stomachFull;
        public override int HungryLevel { get; set; }

        public override void Live()
        {
            if (HungryLevel < stomachFull)
            {
                _isHungry = true;
                Console.WriteLine("need to go to eat grass :)");
                HungryLevel = Eat(HungryLevel, mealValue, stomachFull);
            }
        }
        public override int Eat(int HungryLevel, int mealValue, int stomachFull)
        {
            Console.WriteLine("mmm... my lovely grass");
            return base.Eat(HungryLevel, mealValue, stomachFull);
        }

        public Herbivore(string Name) : base(Name)
        {
            HungryLevel = 0;
            stomachFull = 10;
        }
    }
}
