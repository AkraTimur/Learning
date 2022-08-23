using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter
{
    internal class Kata
    {
        static Random randomKata = new Random();
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            string theWinnerIs = "";
            if (firstAttacker == fighter1.Name)
            {
                while (true)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}; {fighter2.Name} now has {fighter2.Health} and is dead.{fighter1.Name} wins ");
                        theWinnerIs = fighter1.Name;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}; {fighter2.Name} now has {fighter2.Health}.");
                    }

                    fighter1.Health -= fighter2.DamagePerAttack;

                    if (fighter1.Health <= 0)
                    {
                        Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}; {fighter1.Name} now has {fighter1.Health} and is dead.{fighter2.Name} wins ");
                        theWinnerIs = fighter2.Name;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}; {fighter1.Name} now has {fighter1.Health}.");
                    }

                }

            }
            else
            {
                while (true)
                {
                    fighter1.Health -= fighter2.DamagePerAttack;

                    if (fighter1.Health <= 0)
                    {
                        Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}; {fighter1.Name} now has {fighter1.Health} and is dead.{fighter2.Name} wins ");
                        theWinnerIs = fighter2.Name;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}; {fighter1.Name} now has {fighter1.Health}.");
                    }

                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}; {fighter2.Name} now has {fighter2.Health} and is dead.{fighter1.Name} wins ");
                        theWinnerIs = fighter1.Name;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}; {fighter2.Name} now has {fighter2.Health}.");
                    }

                }
            }

            
            return theWinnerIs;
        }
        public static void Stats (Fighter fighter1)
        {
            Console.WriteLine($"Your's stats: HEALTH: {fighter1.Health}, DAMAGE: {fighter1.DamagePerAttack}");
            Console.WriteLine("Now let's test your luck");
            Console.WriteLine("Ready!!! Fight!!!");
        }
        public static string FindFerstAttacker(string one, string two)
        {
            int move = Kata.randomKata.Next(1,3);
            if (move == 1) return one;
            else return two;
        }
    }
}
