using System;
using System.Collections.Generic;
using System.Text;

namespace ApplianceApp
{
    internal class Appliance
    {
        string name = "Appliance";
        public void ConsumePower()
        {
            Console.WriteLine($"{name} Consume Power");
        }
    }
}
