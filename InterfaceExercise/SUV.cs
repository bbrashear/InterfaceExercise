using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int CargoSpaceSize { get; set; }
        public bool HasThirdRow { get; set; }

        public int NumOfWheels { get; set; }
        public string FuelType { get; set; }
        public int NumOfDoors { get; set; }
        public string TransmissionType { get; set; }

        public string Logo { get; set; }
        public string Reputation { get; set; }

        public SUV()
        {

        }

        public SUV(int cargoSpaceSize, bool hasThirdRow, int numOfWheels, string fuelType, int numOfDoors, 
            string transmissionType, string logo, string reputation)
        {
            CargoSpaceSize = cargoSpaceSize;
            HasThirdRow = hasThirdRow;
            NumOfWheels = numOfWheels;
            FuelType = fuelType;
            NumOfDoors = numOfDoors;
            TransmissionType = transmissionType;
            Logo = logo;
            Reputation = reputation;
        }
    }
}
