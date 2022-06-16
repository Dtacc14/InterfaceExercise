using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool GoodStorageSpace { get; set; }
        public bool HighOffGround { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasRadio { get ; set ; }
        public bool NeedsGas { get ; set ; }
        public string CompanySlogan { get ; set ; }
        public string CompanyName { get ; set ; }
    }
}
