namespace HW_7_task1
{
    public class ArrayWorker
    {
        private int[]? array;
        public int[] Array
        {
            get
            {
                return array = array ?? System.Array.Empty<int>(); //avoid null reference exception                
            }
            set { array = value; }
        }

        public ArrayWorker(int[] array)
        {
            Console.WriteLine("Constructor with params");
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                int tepmp = array[i];
                array[i] = array[j];
                array[j] = tepmp;
            }
            this.array = array;
        }

        public ArrayWorker()
        { Console.WriteLine("Constructor withOut params"); }

        public int[] InvertArray(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                int tepmp = array[i];
                array[i] = array[j];
                array[j] = tepmp;
            }
            return array;
        }
    }
}
