using System;
using System.Collections.Generic;
using System.Text;

namespace IClown
{
    internal interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
