using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool IsLifted { get; set; }
        public bool NotAnnoyinglyLoud { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasRadio { get ; set ; }
        public bool NeedsGas { get ; set ; }
        public string CompanySlogan { get ; set ; }
        public string CompanyName { get ; set ; }
    }
}
