using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

            this.Year = "2012";
            this.Make = "Nissan";
            this.Model = "Rogue";

        }

        

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"My car is a {Year} {Make} {Model}.");
        }
    }
}
