using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // DONE - Create 2 Interfaces called IVehicle & ICompany

            // DONE - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE - Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE - In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car1 = new Car
            {
                HasATrunk = true,
                NumberofDoors = 4,
                AllWheelDrive = false,
                TintedWindows = true,
                NumberofWheels = 4,
                SportCar = true,  
                Logo = "Go Fast",
                TelephoneNumber = 1234567890,

            };
            Truck truck1 = new Truck
            {
                HasATrunk = false,
                NumberofDoors = 2,
                AllWheelDrive = true,
                TowPackage = true,
                Commerical = true,
                NumberofWheels = 4,
                Logo = "OffRoad Delights",
                TelephoneNumber = 1234567890,

            };
            SUV suv1 = new SUV
            {
                LuggageRack = true,
                ThirdRowSeats = true,
                AllWheelDrive = true,
                HasATrunk = false,
                NumberofDoors = 5,
                NumberofWheels = 4,
                Logo = "Comfort Travels",
                TelephoneNumber = 1234567890,

            };

        }
    }
}
