using System;
using System.Collections.Generic;
using System.Text;

namespace ApplianceApp
{
    internal class Oven:Appliance,ICoocksFood
    {
        string name = "Oven";
        public float Capacity = 5f;
        public void Preheat()
        {
            Console.WriteLine("Oven preheat");
        }
        public void CookFood()
        {
            Console.WriteLine("Oven coock food");
        }
    }
}
