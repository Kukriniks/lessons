using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class StringKeeperLower : StringKeeper
    {
        string str1 = String.Empty;
        string str2 = String.Empty;
        private string message = "To Lower";

        public override void PringStrins()
        {
            Console.WriteLine(message);
            Console.WriteLine(str1.ToLower() + " " + str2.ToLower());
        }

        public StringKeeperLower(string str1, string str2) : base(str1, str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }
    }
}
