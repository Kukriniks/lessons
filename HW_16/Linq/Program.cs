namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int[] ints = { -10, 22, 13, 43, -5, -12, 100 };
            int[] resInt = ints.Where(x => x < 0 && x % 2 == 0).Reverse().ToArray();
            foreach (int x in resInt) { Console.WriteLine(x); }
            #endregion

            #region task2
            string[] str = { "Hello", "here", "we", "are" };
            var resStr = str.Select(s => s[0]).Reverse().ToArray();
            foreach (char x in resStr) { Console.Write(x + " "); }
            #endregion

            #region task3
            //a) Извлечь из нее все положительные числа, сохранив их исходный порядок следования
            int[] ints2 = { 11, -20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20 };
            var positiveInts = ints2.Where(x => x > 0).ToArray();

            //b)Извлечь из нее все нечетные числа, сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.
            var oddsInt = ints2.Where(x => x % 2 != 0).Skip(1).Distinct().ToArray();

            //c)Извлечь из нее все четные отрицательные числа, поменяв порядок извлеченных чисел на обратный.
            var evenInts = ints2.Where(x => x % 2 == 0 && x < 0).Reverse().ToArray(); // -20 only

            //d)Извлечь из нее все положительные двузначные числа, отсортировав их по возрастанию
            var odds = ints2.Where(x => x > 9 && x < 100).Order().ToArray();
            #endregion

            #region task Median
            string[] str1 = { "123", "345" };
            var median = str1.Median();
            #endregion


        }
    }
}
