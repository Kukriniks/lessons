using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class StringKeeper
    {
       private string str1 = String.Empty;
       private string str2 = String.Empty;

        public virtual void PringStrins()
        {
            Console.WriteLine(str1 + " " + str2);
        }

        public StringKeeper(string str1, string str2) 
        {
            this.str1 = str1;
            this.str2 = str2;
        }
    }
}
