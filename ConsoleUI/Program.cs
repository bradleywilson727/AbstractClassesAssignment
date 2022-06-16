using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicles = new List<Vehicle>();

            var myCar = new Car();

            myCar.HasTrunk = true;

            vehicles.Add(myCar);
            
            var myMotorcycle = new Motorcycle();

            myMotorcycle.HasSideCar = true;

            vehicles.Add(myMotorcycle);

            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE
             * The vehicle class shall have three string properties Year, Make, and Model DONE
             * Set the defaults to something generic in the Vehicle class DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods DONE
             * Only in the Motorcycle class will you override the virtual drive method DONE
            */

            // Create a list of Vehicle called vehicles DONE


            Vehicle truck = new Car() { Year = "1948", Make = "Ford", Model = "Maisto" };

            vehicles.Add(truck);
           
            Vehicle suv = new Car() { Year = "2022", Make = "Ford", Model = "Bronco" };

            vehicles.Add(suv);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"This vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}." );
            }
            

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes DONE
             * - new it up as one of each derived class DONE?
             * Set the properties with object initializer syntax DONE
             */

            /*
             * Add the 4 vehicles to the list DONE
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle DONE

            myCar.DriveAbstract();
            myCar.DriveVirtual();

            myMotorcycle.DriveAbstract();
            myMotorcycle.DriveVirtual();



            #endregion
            Console.ReadLine();
        }
    }
}
