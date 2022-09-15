using System;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card aceOfSpacades = new Card("Ace", "Spades");
            Console.WriteLine(aceOfSpacades.Name);



            Console.ReadKey();
            
        }
    }
}
