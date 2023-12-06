namespace matrix
{
    internal class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows count");

            int rows;
            int.TryParse(Console.ReadLine(), out rows);

            Console.WriteLine("Enter columns count");
            int colums;
            int.TryParse(Console.ReadLine(), out colums);

            int[,] arr1 = new int[rows, colums];
            int[,] arr2 = new int[rows, colums];

            arr1 = initArry(arr1);
            arr2 = initArry(arr2);

            Console.WriteLine("Array 1");
            printArray(arr1);
            Console.WriteLine();
            Console.WriteLine("Array 2");
            printArray(arr2);
            Console.WriteLine();
            Console.WriteLine("\tResultArray");
            printArray(MatarixSum(arr1, arr2));
        }

        static int[,] initArry(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = rnd.Next(0, 10);

                }
            }
            return arr;
        }
        static int[,] MatarixSum(int[,] arr1, int[,] arr2)
        {
            int[,] sumArr = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    sumArr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return sumArr;
        }

        static void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
