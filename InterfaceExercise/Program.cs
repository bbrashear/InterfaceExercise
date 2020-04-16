using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            Car myCar = new Car()
            {
                TrunkSize = 15,
                HasHatchback = false,
                NumOfWheels = 4,
                FuelType = "gas",
                NumOfDoors = 4,
                TransmissionType = "manual",
                Logo = "Toyota",
                Reputation = "reliability"
            };

            Truck myTruck = new Truck()
            {
                BedSize = 93,
                HasCrewCab = false,
                NumOfWheels = 4,
                FuelType = "diesel",
                NumOfDoors = 2,
                TransmissionType = "automatic",
                Logo = "Ford",
                Reputation = "unreliable"
            };

            SUV mySUV = new SUV()
            {
                CargoSpaceSize = 30,
                HasThirdRow = true,
                NumOfWheels = 4,
                FuelType = "gas",
                NumOfDoors = 4,
                TransmissionType = "automatic",
                Logo = "Subaru",
                Reputation = "green"
            };

            //Creatively display and organize their values

            DisplayCar(myCar);
            PauseConsole();
            DisplayTruck(myTruck);
            PauseConsole();
            DisplaySUV(mySUV);
            PauseConsole();
            Console.WriteLine("See ya later!");
           
        }

        public static void DisplayCar(Car car)
        {
            Console.WriteLine($"{car.TrunkSize}, {car.HasHatchback}, {car.NumOfWheels}, {car.FuelType}, {car.NumOfDoors}," +
                $" {car.TransmissionType}, {car.Logo}, {car.Reputation}");
        }

        public static void DisplayTruck(Truck truck)
        {
            Console.WriteLine($"{truck.BedSize}, {truck.HasCrewCab}, {truck.NumOfWheels}, {truck.FuelType}, {truck.NumOfDoors}," +
                $" {truck.TransmissionType}, {truck.Logo}, {truck.Reputation}");
        }

        public static void DisplaySUV(SUV suv)
        {
            Console.WriteLine($"{suv.CargoSpaceSize}, {suv.HasThirdRow}, {suv.NumOfWheels}, {suv.FuelType}, {suv.NumOfDoors}," +
                $" {suv.TransmissionType}, {suv.Logo}, {suv.Reputation}");
        }

        public static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
