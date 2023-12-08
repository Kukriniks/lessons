
using ClassLibrary;    

    internal class Program
    {
        static void Main(string[] args)
        {
            Cone cone = new Cone(5, 10);
            Console.WriteLine("Full area of your cone = " + Math.Round(cone.getFullArea(),2));
            Console.WriteLine("Base area of your cone = " + Math.Round(cone.getBaseArea(),2));
        }
    }

