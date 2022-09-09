using System;

namespace MinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayMin.Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(ArrayMin.Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(ArrayMin.Min(new[] { '4', '2', '7' }));
            Console.ReadKey();
        }
    }
}
