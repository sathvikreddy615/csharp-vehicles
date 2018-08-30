using System;
using System.Collections.Generic;

namespace Vehicles
{
    internal interface IGround
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        double MaxLandSpeed { get; set; }
        void Drive();
    }
}