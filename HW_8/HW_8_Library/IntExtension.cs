namespace HW_8_Library
{
    public static class IntExtension
    {
        public static int intMaxValue(this int[]? array)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
    }
}
