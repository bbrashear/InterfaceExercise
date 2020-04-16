using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public string FuelType { get; set; }
        public int NumOfDoors { get; set; }
        public string TransmissionType { get; set; }
    }
}
