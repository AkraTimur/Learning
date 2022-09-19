using System;

namespace arrayContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myList = new string[2];
            string a = "Yay!";
            string b = "Bummer";
            myList[0] = a;
            myList[1] = b;
            Console.WriteLine(myList.Length);
            Console.WriteLine(Finder.FindContains(myList, b));
            Console.ReadKey();
        }
    }
}
