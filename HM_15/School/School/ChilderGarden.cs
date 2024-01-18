using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class ChilderGarden
    {

        private List<Child> children = new List<Child>();

        public void AddChild(Child child)
        { 
            children.Add(child);
        }
       
        private void RemoveChild(Child child) 
        {
            children.Remove(child);
        }

        public void StartGrowUP(List<Child> children)
        { 
            foreach (Child child in children)
            {
                child.Age++;
            }
        }
        

    }
}
