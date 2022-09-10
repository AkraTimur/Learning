using System;

namespace InterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            ShortGuy shortGuy = new ShortGuy() { Height = 56, Name = "Mike" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FynnyThingIHave}");
            tallGuy.Honk();
            shortGuy.TalkAboutYourself();
            Console.WriteLine($"The short guy has {shortGuy.FynnyThingIHave}");
            shortGuy.Honk();
            
            Console.ReadLine();
        }
    }
}
