using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public bool SportCar { get; set; }
        public bool TintedWindows { get; set; }
       public string Logo { get; set; }
        public int TelephoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberofWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AllWheelDrive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberofDoors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasATrunk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
