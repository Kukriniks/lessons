using BankCard;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankCard.Bank banc = new BankCard.Bank();
            ClassicCard card = new ClassicCard();

            banc.PutMoneyToCard(card, 10500);
            banc.TakeMoneyFromCard(card, 1000);
           

            GoldCard cardGold = new GoldCard();  
            
            banc.PutMoneyToCard(cardGold, 10500);     
            banc.TakeMoneyFromCard(cardGold, 1000);

            PlatinumCard cardPlatinum = new PlatinumCard();
            banc.PutMoneyToCard(cardPlatinum, 10500);
            banc.TakeMoneyFromCard(cardPlatinum, 1000);

        }
    }
}
