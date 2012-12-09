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
                ReportingMethods.roomReport(playerSpaceShip.bridge);
                ReportingMethods.roomReport(playerSpaceShip.engineering);
                ReportingMethods.roomReport(playerSpaceShip.lifeSupport);
                ReportingMethods.roomReport(playerSpaceShip.comms);
                ReportingMethods.roomReport(playerSpaceShip.fireControl);
                ReportingMethods.roomReport(playerSpaceShip.fireControl2);
                ReportingMethods.roomReport(playerSpaceShip.fireControl3);
                ReportingMethods.roomReport(playerSpaceShip.fireControl4);
                ReportingMethods.roomReport(playerSpaceShip.medibay);
                ReportingMethods.roomReport(playerSpaceShip.cargoHold);
                ReportingMethods.roomReport(playerSpaceShip.fighterCockpit);
                ReportingMethods.roomReport(playerSpaceShip.shuttleBay);
                ReportingMethods.shipStatusReport(playerSpaceShip);

                testingMethods.testPowerSystem(playerSpaceShip);

                Console.ReadLine();                             
        }
    }
}