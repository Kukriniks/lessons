namespace School
{
    internal class Child
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public Child(string name, string surName, int age)
        {
            Age = age;
            Name = name;
            SurName = surName;
        }

        public Child()
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}  SurName: {SurName} Age: {Age}";
        }
    }

}
