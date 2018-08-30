using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Cessna : IVehicle, IAir
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
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