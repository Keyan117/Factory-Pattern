using System;
namespace FactoryPatternVehicles
{
    public class Motorcycle : Ivehicle
    {
        public Motorcycle()
        {
            
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("vrooooooooooom");
        }
    }
}