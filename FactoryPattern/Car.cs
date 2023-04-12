using System;
namespace FactoryPatternVehicles
{
    public class Car : Ivehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving at a safe pace. oh boy!");
        }
    }
}