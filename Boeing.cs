using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Boeing : IVehicle, IAir
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("The 747 giant is cruising at 40000 feet");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}