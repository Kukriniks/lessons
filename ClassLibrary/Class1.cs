namespace ClassLibrary
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
    public class Cone
    {
        public double radius { get; }
        public double hight { get; }


        public Cone(double radius, double hight)
        {
            this.radius = radius;
            this.hight = hight;
        }

        public double getFullArea()
        {
            return getBaseArea() + Math.PI * radius * (Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(hight, 2)));
            //Sп = Sо  + Sб = Π*r2 + П*r*(√(r2+h2))
        }

        public double getBaseArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
