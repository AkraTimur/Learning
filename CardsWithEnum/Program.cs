using System;

namespace CardsWithEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card(Values.Ace, Suits.Spades);
            Console.WriteLine(myCard.Name);

            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 4);
            int anyRandomInteger = random.Next();

            Card card = new Card((Values)numberBetween1and13, (Suits)numberBetween0and3);
            Console.WriteLine(card.Name);
            Console.ReadKey();
        }
    }
}
