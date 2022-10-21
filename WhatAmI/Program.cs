namespace WhatAmI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var whatAmI = new {Color = "Blue", Flavor = "Tasty", Height = 37 }; // анонимный тип
            Console.WriteLine(whatAmI);
        }
    }
}