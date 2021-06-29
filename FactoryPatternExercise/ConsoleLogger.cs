using System;
using System.Threading;

namespace FactoryPatternExercise
{
    public class ConsoleLogger
    {
        public static void VehicleStartupDialogue()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key!");
            Thread.Sleep(1000);
        }
    }
}
