using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public int TrunkSize { get; set; }
        public bool HasHatchback { get; set; }

        public int NumOfWheels { get; set; }
        public string FuelType { get; set; }
        public int NumOfDoors { get; set; }
        public string TransmissionType { get; set; }

        public string Logo { get; set; }
        public string Reputation { get; set; }

        public Car()
        {

        }

        public Car(int trunkSize, bool hasHatchback, int numOfWheels, string fuelType, int numOfDoors,
    string transmissionType, string logo, string reputation)
        {
            TrunkSize = trunkSize;
            HasHatchback = hasHatchback;
            NumOfWheels = numOfWheels;
            FuelType = fuelType;
            NumOfDoors = numOfDoors;
            TransmissionType = transmissionType;
            Logo = logo;
            Reputation = reputation;
        }
    }
}
