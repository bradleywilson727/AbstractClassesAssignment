using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

            this.Year = "1956";
            this.Make = "Triumph";
            this.Model = "Bonneville";

        }

        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"My motorcycle is a {Year} {Make} {Model}.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I really do be ZOOMING.");
        }
    }
}
