using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialogue();
            Console.WriteLine("The Car is driving! Wooo!");
        }
    }
}
