using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp1
{
    internal class Acts: Picasso
    {
        public Acts() : base("Acts") { }
        public override int Ear()
        {
            return 5;
        }
    }
}
