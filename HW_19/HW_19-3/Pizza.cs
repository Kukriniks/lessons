using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19_3
{
    internal class Pizza
    {
		private int chees;
		private int tomato;
		private int sausage;


		public int Sausage
        {
			get {
 
				 return sausage; 
			}
			set { sausage = rnd.Next(10,20); }
		}


		public int Tomato
		{
			get { 

				return tomato; 
			}
			set { tomato = rnd.Next(10, 30); }
		}


		public int Cheees
		{
			get { 

				return chees; 
			}
			set { chees = rnd.Next(20, 50); }
		}

		private Random rnd = new Random();




	}
}
