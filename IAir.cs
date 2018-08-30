using System;
using System.Collections.Generic;

namespace Vehicles
{
    internal interface IAir
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
    }
}