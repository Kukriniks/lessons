namespace CarAndBuyer
{
    internal class Buyer
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string? Name { get; set; }

        public Buyer(int id, int carID, string name)
        {
            ID = id;
            CarID = carID;
            Name = name;
        }
    }
}
