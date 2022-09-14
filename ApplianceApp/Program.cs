using System;
using System.Text.Encodings.Web;

namespace ApplianceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofeeMaker misterCofee = new CofeeMaker();
            Oven oldToasty = new Oven();

            Appliance[] kitchenWare = new Appliance[2];
            kitchenWare[0] = misterCofee;
            kitchenWare[1] = oldToasty;

            Appliance powerConsumer = new CofeeMaker();
            powerConsumer.ConsumePower();
            
            if (powerConsumer is CofeeMaker joeJav)
            {
                joeJav.StartBrewing();
            }


            Console.ReadKey();
        }
    }
}
