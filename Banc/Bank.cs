using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class Bank 
    {
        public decimal TakeMoneyFromCard(Card card, decimal money)
        {     
            return card.GetMoney(money);
        }
        public void PutMoneyToCard(Card card,decimal money)
        {
            card.AddMoney(money);
        }

    }  
}
