using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp1
{
    internal class Clowns:Picasso
    {
        public Clowns() : base("Clowns") { }
        public override int Ear()
        {
            return 7;
        }

    }

   
}
