using System;

namespace Fighter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();
          Fighter AIFighter = new Fighter("AKRA", random.Next(1, 90), random.Next(1, 25));
          Console.WriteLine("Hello Fighters!");
          Console.Write("Enter the name: ");
          string name1 = Console.ReadLine();
          Console.WriteLine($"Your's oponnet is: {AIFighter.Name}");
          Fighter firstFigther = new Fighter(name1, random.Next(1, 90), random.Next(1, 25));
          Kata.Stats(firstFigther);
          string firstAttacker = Kata.FindFerstAttacker(firstFigther.Name, AIFighter.Name);
          string winner = Kata.declareWinner(firstFigther, AIFighter, firstAttacker);
            


            Console.ReadLine();
        }
    }
}
