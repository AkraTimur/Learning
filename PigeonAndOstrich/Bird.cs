using System;
using System.Collections.Generic;
using System.Text;

namespace PigeonAndOstrich
{
    class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOffEggs)
        {
            Console.Error.WriteLine("Bird.LeyEggs should never get called");
            return new Egg[0];
        }
    }
}
