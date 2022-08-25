using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrich
{
     class Pigeon: Bird
    {
        public override Egg[] LayEggs(int numberOffEggs)
        {
           Egg[] eggs = new Egg[numberOffEggs];
            for(int i = 0; i < numberOffEggs;i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    eggs[i] = new BrokenEgg( "white");
                }
                else
                {
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
                }
                
            }
            return eggs;
        }
    }
}
