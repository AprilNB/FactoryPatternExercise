using System;
namespace FactoryPatternExercise
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialogue();
            Console.WriteLine("Let's get going!");
        }
    }
}
