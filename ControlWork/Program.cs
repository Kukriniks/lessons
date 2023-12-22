namespace ControlWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringKeeper stringKeeper = new StringKeeper("hELlo", "wOrLd!");
            StringKeeperLower stringKeeperLower = new StringKeeperLower("hELlo", "wOrLd!");
            StringKeeperUpper stringKeeperUpper = new StringKeeperUpper("hELlo", "wOrLd!");
            stringKeeper.PringStrins();
            stringKeeperUpper.PringStrins();
            stringKeeperLower.PringStrins();
        }
    }
}
