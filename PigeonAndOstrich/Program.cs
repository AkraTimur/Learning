using System;

namespace PigeonAndOstrich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\nPress P for pigeon, O for ostrich: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'O') bird = new Ostrich();
                else if (key == 'P') bird = new Pigeon();
                else return;
                Console.Write("\nHow many eggs should it lay? ");
                if (!int.TryParse(Console.ReadLine(), out int numberOffEggs)) return;
                Egg[] eggs = bird.LayEggs(numberOffEggs);
                foreach (Egg egg in eggs)
                {
                    Console.WriteLine(egg.Description);
                }
            }

        }
    }
}
