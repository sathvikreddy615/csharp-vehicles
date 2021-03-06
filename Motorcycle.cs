using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Motorcycle : IVehicle, IGround
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
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