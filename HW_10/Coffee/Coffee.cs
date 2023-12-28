namespace Coffee
{
    internal class Coffee
    {
        public CoffeeStrength Strength { get; init; }
        public int Volume { get; init; }
        public Coffee(Water water, CoffeeBeans beans)
        {
            Volume = water.Volume + (beans.Volume / 100) * 2;
            double stranghtCofficient = water.WaterCoefficient + beans.coffeeStrength;
            double stranghtCofficientMax = Water.waterCoefficientMax + CoffeeBeans.coffeeStrengthMax;
            double stranghtCofficientMin = Water.waterCoefficientMin + CoffeeBeans.coffeeStrengthMin;
            int ratio = Convert.ToInt32((stranghtCofficientMax - stranghtCofficientMin) / Enum.GetNames(typeof(CoffeeStrength)).Length);
            /*
             * представляем диапазон возможной крепости кофе и разбиваем его на кол-во CoffeeStrength
             * определяем в каком из диапазонов оказывается наш кофе и в зависимости от этого 
             * присваеваем значение Strength
             */
            int diapason = 0;
            int range = ratio;
            for (int  i = Convert.ToInt32(stranghtCofficientMin); i < stranghtCofficientMax; i++)
            {
                if (i == ratio)
                {
                    diapason++;
                    ratio += range;
                }
                if (i == Convert.ToInt32(stranghtCofficient))
                {
                    Strength = (CoffeeStrength)diapason;
                    break;
                }
            }            
        }
    }
    public enum CoffeeStrength
    {
        Light,
        Medium,
        Strong,
        Rocket
    }
}
