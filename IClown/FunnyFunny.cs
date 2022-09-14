using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IClown
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; }  }
        public FunnyFunny(string funnyThingIHav)
        {
            this.funnyThingIHave = funnyThingIHav;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}.");
        }
    }
}
