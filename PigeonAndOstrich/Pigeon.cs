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
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}
