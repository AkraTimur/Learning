using System;
using System.Collections.Generic;

namespace CardsComparer
{
    internal class Program
    {
        public static readonly Random random = new Random();
        static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
                
        }
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of cards: ");


           

                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int num))
                {
                    Console.WriteLine();

                    List<Card> cards = new List<Card>();
                    for (int i = 0; i < num; i++)
                    {
                        cards.Add(RandomCard());
                    }
                    PrintCards(cards);
                    Console.WriteLine(@"
... sorting the cards...
");
                cards.Sort(new CardComparerByValue());
                PrintCards(cards);

                Console.ReadKey();
                }
                

            
        }
    }
}
