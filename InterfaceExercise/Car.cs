using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasGreatGasMialage { get; set; }
        public bool LowToTheGround { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasRadio { get ; set ; }
        public bool NeedsGas { get ; set ; }
        public string CompanySlogan { get ; set ; }
        public string CompanyName { get ; set ; }
    }
}
