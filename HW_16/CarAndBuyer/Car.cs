

namespace CarAndBuyer
{
    internal class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Car(int id, int age, string carName)
        {
            ID = id;
            Name = carName;
            Age = age;
        }
    }
}
