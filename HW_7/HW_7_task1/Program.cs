using ClassLibrary;
namespace HW_7_task1
{
   
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] arrInit1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] arrInit2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                ArrayWorker arr1 = new ArrayWorker();

                foreach (var item in arr1.InvertArray(arrInit1))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.WriteLine("next step");
                ArrayWorker arr2 = new ArrayWorker(arrInit2);
                foreach (var item in arr2.Array)
                {
                    Console.Write(item + " ");
                }
            }
        
    }
}
