namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person man1 = new Person(23,Gender.Male);
            Person man2 = new Person(22, Gender.Male);
            Person man3 = new Person(22, Gender.Male);

            Person woman1 = new Person(21, Gender.Femail);
            Person woman2 = new Person(22, Gender.Femail);
            Person woman3 = new Person(23, Gender.Femail);

            List<Person> pList = new List<Person>();
            pList.Add(man1);
            pList.Add(man2);
            pList.Add(man3);
            pList.Add(woman1);
            pList.Add(woman2);
            pList.Add(woman3);
            
            Person[] arPerson = new Person[] { man1, man2, man3, woman1, woman2, woman3 };
            Array.Sort(arPerson,new PersonComparer());
            foreach (var p in arPerson)
            {
                Console.WriteLine($" {p.Age}   {p.PersonGender}");
            }
        }
    }
}
