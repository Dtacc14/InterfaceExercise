using System;
using System.Collections.Generic;
using System.Text;

 namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool HasSteeringWheel { get; set; }
        public bool HasRadio { get; set; }
        public bool NeedsGas { get; set; }

    }
}
