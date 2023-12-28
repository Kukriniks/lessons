namespace Coffee
{
    internal class CoffeeBeans
    {
        public int Volume { get; init; }
        public CoffeeBeanVariety CoffeeVariety { get; init; }
        public readonly double coffeeStrength;
        private static int maxValue = 10;
        private static int minValue = 2;
        public static readonly double coffeeStrengthMax = Enum.GetValues(typeof(CoffeeBeanVariety)).Cast<int>().Max() * maxValue / 100D;
        public static readonly double coffeeStrengthMin = Enum.GetValues(typeof(CoffeeBeanVariety)).Cast<int>().Min() * minValue / 100D;
        public CoffeeBeans(int volume, CoffeeBeanVariety coffeeVariety)
        {
            if (volume < minValue || volume > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(volume));
            }
            else
            {
                Volume = volume;
                CoffeeVariety = coffeeVariety;
                coffeeStrength = ((int)CoffeeVariety * (double)volume) / 100;
            }
        }
    }
    public enum CoffeeBeanVariety
    {
        Liberica = 10,
        Arabbica = 30,
        Robusta = 50
    }
}
