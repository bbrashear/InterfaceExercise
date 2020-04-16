using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public bool HasCrewCab { get; set; }

        public int NumOfWheels { get; set; }
        public string FuelType { get; set; }
        public int NumOfDoors { get; set; }
        public string TransmissionType { get; set; }

        public string Logo { get; set; }
        public string Reputation { get; set; }

        public Truck()
        {

        }

        public Truck(int bedSize, bool hasCrewCab, int numOfWheels, string fuelType, int numOfDoors,
    string transmissionType, string logo, string reputation)
        {
            BedSize = bedSize;
            HasCrewCab = hasCrewCab;
            NumOfWheels = numOfWheels;
            FuelType = fuelType;
            NumOfDoors = numOfDoors;
            TransmissionType = transmissionType;
            Logo = logo;
            Reputation = reputation;
        }
    }
}
