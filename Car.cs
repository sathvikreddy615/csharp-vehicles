using System;
using System.Collections.Generic;

namespace Vehicles 
{
    public class Car : IVehicle, IGround
    {
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public double MaxLandSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The ferrari is zooming");
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}