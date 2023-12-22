using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class GoldCard : Card
    {
        private decimal Money { get; set; }
        internal override decimal Rate { get; init; } = 0.5M;
        internal override decimal GetMoney(decimal monye)
        {            
            return base.GetMoney(monye); 
        }
        internal override void AddMoney(decimal monye)
        {
            base.AddMoney(monye);
        }
    }
}
