using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Panda
{
    internal class Panda
    {
        private int attack;
        readonly string name;
        private int HP { get; set; }
        private int DeFence { get; set; }
        public Color PandaColor { get; init; }
        public Gender PandaGender { get; init; }
       
        public Panda(string name, Color color, Gender gender)
        {
            Random rnd = new Random();
            this.name = name;         
            HP = rnd.Next(10, 20);
            DeFence = rnd.Next(10, 20);
            attack = rnd.Next(20, 30);
            this.PandaGender = gender;
            this.PandaColor = color;
        }

        public static Panda operator + (Panda panda1, Panda panda2)
        {
            if (panda1.PandaGender != panda2.PandaGender && panda1 != null && panda2 != null)
            {
                Console.WriteLine("New panda born");
                Array values = Enum.GetValues(typeof(Gender));
                Random random = new Random();
                Gender randomGender = (Gender)values.GetValue(random.Next(values.Length));
                return new Panda(panda1.name + panda2.name, panda1.PandaColor, randomGender);
            }
            else 
            {
                Console.WriteLine("Same gender or NULL , impossible make new panda");
                return null;
            }
        }
        public static Panda operator - (Panda panda1, Panda panda2)
        {
            if (panda1 != null && panda2 != null)
            {
                panda2.HP = (panda2.DeFence + panda2.HP - panda1.attack > 1) ? (panda2.DeFence + panda2.HP - panda1.attack) : 1;
            }
            else
                Console.WriteLine("Panda can't be NULL");
            return null; //возвращать по сути ничего не надо просто у обьекта панда2 уменьшаем HP
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else if (object.ReferenceEquals(this, obj))
            {
                return true;
            }
            else
            { 
                Panda panda = (Panda)obj;
                return (this.HP == panda.HP) && (this.PandaColor == panda.PandaColor);
            }            
        }
    }

    public enum Color
    { 
        White_Black,
        Black,
        White
    }

    public enum Gender
    {
        Mail,
        Femail
    }
}
