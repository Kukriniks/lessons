using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cone
    {
        private double radius { get; }
        private double hight { get; }

        public Cone(double radius, double hight)
        {
            this.radius = radius;
            this.hight = hight;
        }

        public double getFullArea()
        {
            return getBaseArea() + Math.PI * radius * (Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(hight, 2)));
            //Sп = Sо  + Sб = Π*r2 + П*r*(√(r2+h2))
        }

        public double getBaseArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
