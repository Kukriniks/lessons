using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is Person && p2 is Person)
            {
                if ((p1.Age == p2.Age && p1.PersonGender == Gender.Femail && p2.PersonGender == Gender.Male) || p1.Age > p2.Age)
                    return -1;
                if (p1.Age < p2.Age)
                    return 1;
                else return 0;
            }
            else
                throw new ArgumentException();
        }
    }
}
