using System;
using System.Collections.Generic;

namespace Vehicles
{
    internal interface IVehicle
    {
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }
}