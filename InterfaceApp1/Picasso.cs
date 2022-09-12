using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp1
{
    abstract class Picasso : INose 
    {
        private string face;
        public virtual string Face
        {
            get { return face; }
        }
        public abstract int Ear();
        public Picasso (string face) {
            this.face = face;
        }
        
    }
}
