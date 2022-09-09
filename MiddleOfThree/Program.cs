using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MOT.MiddleOfThree(2, 5, 4));
            Console.WriteLine(MOT.MiddleOfThree(3, 1, 2));
            Console.WriteLine(MOT.MiddleOfThree(3, 5, 9));
            Console.WriteLine(MOT.MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MOT.MiddleOfThree(3.45, 2.67, 3.12));
            Console.ReadKey();
        }
    }
}
