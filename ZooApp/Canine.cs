using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp
{
    abstract class Canine: Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
}
