using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberofWheels { get; set; }
        public bool AllWheelDrive { get; set; }
        public int NumberofDoors { get; set; }
        public bool HasATrunk { get; set; }

    }
}
