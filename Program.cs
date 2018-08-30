
using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

        // Build a collection of all vehicles that fly


        List<IAir> AirVehicleList = new List<IAir>();

        Cessna Cessna172 = new Cessna() {
            Wheels = 3,
            Doors = 3,
            PassengerCapacity = 5,
            Winged = true,
            TransmissionType = "None",
            EngineVolume = 31.1,
            MaxAirSpeed = 309.0
        };

        Boeing Boeing747 = new Boeing() {
            Wheels = 12,
            Doors = 8,
            PassengerCapacity = 420,
            Winged = true,
            TransmissionType = "None",
            EngineVolume = 102.3,
            MaxAirSpeed = 575.0
        };

        AirVehicleList.Add(Cessna172);
        AirVehicleList.Add(Boeing747);

        // With a single `foreach`, have each vehicle Fly()\
        
        foreach (var plane in AirVehicleList)
        {
            plane.Fly();
        }

        // Build a collection of all vehicles that operate on roads

        Car FerrariSpider = new Car()
        {
            PassengerCapacity = 3,
            Winged = false,
            TransmissionType = "Manual",
            EngineVolume = 1.6,
            Wheels = 4,
            Doors = 2,
            MaxLandSpeed = 210
        };

        Motorcycle Ducati916 = new Motorcycle()
        {
            PassengerCapacity = 2,
            Winged = false,
            TransmissionType = "Manual",
            EngineVolume = 1.3,
            Wheels = 2,
            Doors = 0,
            MaxLandSpeed = 160.4
        };

        List<IGround> GroundVehicleList = new List<IGround>();

        GroundVehicleList.Add(FerrariSpider);
        GroundVehicleList.Add(Ducati916);

        foreach (var vehicle in GroundVehicleList)
        {
            vehicle.Drive();
        }

    

    // With a single `foreach`, have each road vehicle Drive()

    // Build a collection of all vehicles that operate on water

    List<IAir> WaterVehicleList = new List<IAir>();

        // With a single `foreach`, have each water vehicle Drive()
    }
}
}
