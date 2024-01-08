

namespace Person
{
    internal class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public Gender PersonGender { get; set; }

        public int CompareTo(Person person)
        {
                if ((Age == person.Age && PersonGender == Gender.Femail && person.PersonGender==Gender.Male) || Age > person.Age)
                    return -1;
                if (Age < person.Age)
                    return 1;
                else return 0;
        }
        public Person(int Age, Gender gender)
        {
            this.Age = Age;
            this.PersonGender = gender;
        }
    }
    public enum Gender
    { 
        Male,
        Femail
    }
}
