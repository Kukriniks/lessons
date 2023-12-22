using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
     public class Card
    {
        internal virtual decimal Rate { get;  init; }
        private  decimal Money { get; set; }
        internal virtual decimal GetMoney(decimal monye)
        {
            Console.WriteLine(this.GetType().Name);
            if (monye <= Money)
            {
                Money -= monye + (monye / 100) * Rate;
                Console.WriteLine($"Card balance = {Money} You received {monye} bank received {(monye / 100) * Rate}");
                return monye;
            }
            else if (monye > Money && Money != 0)
            {
                Console.WriteLine("You balance 0");
                monye = Money - (Money / 100) * Rate;
                Console.WriteLine($"Card balance = {Money} You received {monye} bank received {(Money / 100) * Rate}");
                Money = 0;
                return monye;
            }
            else
            {
                Console.WriteLine("no money, no honey");
                return 0;
            }
        }

        internal virtual void AddMoney(decimal monye)
        {
            Money += monye;
        }
    }
}
