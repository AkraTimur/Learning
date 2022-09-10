using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
     class ShortGuy: TallGuy, IClown
    {
       
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
        public string FynnyThingIHave { get { return "small shoes"; } }
        public void Honk()
        {
            Console.WriteLine("Honk honk hoooonk");
        }
    }
}
