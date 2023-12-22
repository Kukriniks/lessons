using System;


namespace BankCard
{
    internal class ClassicCard : Card
    {
        internal override decimal Rate { get; init; } = 1M;
        private decimal Money { get; set; }

        internal override decimal GetMoney(decimal money)
		{
            return base.GetMoney(money);
        }
		internal override void AddMoney(decimal monye)
		{ 
			base.AddMoney(monye);
		}
    }
}
