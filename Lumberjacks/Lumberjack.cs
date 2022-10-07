using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjacks
{
    internal class Lumberjack
    {
        public string Name { get; set; }
        public Lumberjack(string name)
        {
            Name = name;
        }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count>0)
            Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
        }

    }
}
