using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class Program
    {



        static void Main(string[] args)
        {
            SpaceShip playerSpaceShip = null;

                playerSpaceShip = ShipConstructionMethods.initialShipCreation();
                Console.WriteLine(playerSpaceShip.shipName);
                ShipConstructionMethods.chooseShipClass(playerSpaceShip);
                ShipConstructionMethods.setShipRooms(playerSpaceShip);
                ShipConstructionMethods.setShipSystems(playerSpaceShip);
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Bridge"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Engineering"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Life Support"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Comms"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Fire Control"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Fire Control 2"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Fire Control 3"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Fire Control 4"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Medibay"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Cargo Hold"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Fighter Cockpit"));
                ReportingMethods.roomReport(playerSpaceShip.getSpecificRoom("Shuttle Bay"));
                ReportingMethods.shipStatusReport(playerSpaceShip);

                testingMethods.testPowerSystem(playerSpaceShip);

                Console.ReadLine();   
            
              
        }
    }
}