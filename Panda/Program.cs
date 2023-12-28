namespace Panda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda panda2 = new Panda("Mike", Color.Black, Gender.Mail);
            Panda panda1 = new Panda("Pepsi", Color.Black, Gender.Femail);

            var panda3 = panda1 + panda2;
            _ = panda3 - panda1;

            bool isEqual = panda1.Equals(panda2);
        }
    }
}
