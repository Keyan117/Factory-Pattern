using System;
namespace FactoryPatternVehicles
{
    public class ThreeWheeler : Ivehicle
    {
        public ThreeWheeler()
        {

        }

        public void Drive()
        {
             ConsoleLogger.VehicleStartUpDialogue();
             Console.WriteLine("Let's get going!");
        }
    }
}