using System;
using System.Collections.Generic;
using System.Text;

namespace IClown
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;
        
        public ScaryScary(string funnyThingIHave, int scaryThingCount) : base(funnyThingIHave)
        {
            this.scaryThingCount = scaryThingCount;

        }

        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders."; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
        }
    }
}

