using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class ReportingMethods
    {
        public static void shipStatusReport(SpaceShip playerSpaceShip)
        {
            Console.WriteLine("Ship Status Report");
            Console.WriteLine("Current Shipwide Total Hit Points " + playerSpaceShip.currentTotalHitPoints);
            int powerRequirement = playerSpaceShip.shipOperationalPowerConsumption();
            Console.WriteLine("Current Power Requirement " + powerRequirement);
            Console.WriteLine("Total Ship Mass: " + playerSpaceShip.totalMass);
        }

        public static void roomReport(Room roomName)
        {
            if (roomName != null)
            {
                Console.WriteLine(roomName.roomType + " Oxygen Level: " + roomName.oxygenLevel + "% of ideal level.");
                Console.WriteLine(roomName.roomType + " Has Heat Exchanger: " + roomName.heatExchangerInterface);
                Console.WriteLine(roomName.roomType + " Has Air Scrubber: " + roomName.airScrubber);
                Console.WriteLine(roomName.roomType + " Air Pressure: " + roomName.airPressure + "kPa");
                Console.WriteLine(roomName.roomType + " Air: Temperature " + roomName.airTemperature + " Degrees C");
                Console.WriteLine(roomName.roomType + " Has Compromised Bulkhead: " + roomName.bulkheadCompromised);
                Console.WriteLine(roomName.roomType + " Bulkhead Current Hit Points: " + roomName.currentBulkheadHitPoints);
                Console.WriteLine(roomName.roomType + " Bulkhead Structural Integrity Threshold: " + roomName.bulkheadHitPointsStructuralIntegrityThreshold);
                Console.WriteLine(roomName.roomType + " Bulkhead Mass: " + roomName.bulkheadMass);
                Console.ReadLine();
            }
        }

        public static void shipSystemReport(ShipSystem shipSystem)
        {
            if (shipSystem != null)
            {
                Console.WriteLine(shipSystem.systemName);
                Console.WriteLine(shipSystem.systemName + " in " + shipSystem.systemRoomName + " has a mass of " + shipSystem.mass);
                Console.WriteLine(shipSystem.currentPowerStored + " power points are stored in this system.");
            }
        }

    }
}

