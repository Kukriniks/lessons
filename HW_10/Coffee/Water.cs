namespace Coffee
{
    internal class Water
    {
        public int Temperature { get; init; }
        public int Volume { get; init; }
        public double WaterCoefficient { get; init; }

        private const int maxTemperature = 120;
        private const int minTemperature = 80;
        private const int maxValue = 350;
        private const int minValue = 50;

        public static readonly double waterCoefficientMax = maxTemperature / (double)minValue; //strongest coffee
        public static readonly double waterCoefficientMin = minTemperature / (double)maxValue; //lightest coffee

        public Water(int temperature, int volume)
        {
            if (temperature < minTemperature || temperature > maxTemperature)
            {
                throw new ArgumentOutOfRangeException(nameof(temperature));
            }
            else if (volume < minValue || volume > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(volume));
            }
            else
            {
                Temperature = temperature;
                Volume = volume;
                WaterCoefficient = temperature / (double)volume;
            }
        }
        public static Coffee operator +(Water water, CoffeeBeans beans)
        {
            return new Coffee(water, beans);
        }
    }
}
