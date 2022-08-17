using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrich
{
     class Ostrich: Bird
    {
        public override Egg[] LayEggs(int numberOffEggs)
        {
            Egg[] eggs = new Egg[numberOffEggs];
            for (int i = 0; i < numberOffEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
