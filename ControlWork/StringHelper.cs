using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class StringHelper
    {
        string str;
        public string StrRevers()
        { 
            string tempStr = String.Empty;
            for (int i = str.Length - 1; i > 0; i--)
            { tempStr += str[i]; }
            return tempStr;
        }
        public StringHelper(string str)
        {
            this.str = str;
        }
    }
}
