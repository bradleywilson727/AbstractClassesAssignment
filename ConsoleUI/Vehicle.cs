using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
            
        }

        public string Year { get; set; } = "Year";
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm virtually driving");
        }
    }
}
