using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
    internal class Child
    {
        public int Age { get; set; }
        public string Name { get; }
        public string SurName { get; }

        public Child(string name, string surName, int age)
        {
            Age = age;
            Name = name;
            SurName = surName;
        }
    }

}
