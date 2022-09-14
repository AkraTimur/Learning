using System;
using System.Collections.Generic;
using System.Text;

namespace ApplianceApp
{
    internal class CofeeMaker:Appliance
    {
        string name = "CoffeMaker";
        public float CofeeLeft = 2.25f;
        public void FillWithWater()
        {
            Console.WriteLine("CofeeMaker Fill with water.");
        }
        public void StartBrewing()
        {
            Console.WriteLine("CofeeMaker Start brewing");
        }
    }
}
