using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("vroooom");
        }
    }
}
