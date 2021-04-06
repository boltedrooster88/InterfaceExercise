using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        public bool Commerical { get; set; }
        public bool TowPackage { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TelephoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberofWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AllWheelDrive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberofDoors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasATrunk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
