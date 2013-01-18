using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class testingMethods
    {
        public static void testPowerSystem(SpaceShip playerSpaceShip)
        {
            Console.WriteLine("How Much fuel for this test?");

            string fuelInput = Console.ReadLine();
            int testLevel = Int32.Parse(fuelInput);
            bool keepGoing = true;

            if (playerSpaceShip.shipType == "Fighter")
            {
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").fuelStore.fuelLevel = testLevel;
                //playerSpaceShip.fighterCockpit.fuelStore.fuelLevel = testLevel;
            }

            if (playerSpaceShip.shipType != "Fighter")
            {
                playerSpaceShip.getSpecificRoom("Engineering").fuelStore.fuelLevel = testLevel;
                //playerSpaceShip.getSpecificRoom("Engineering").fuelStore.fuelLevel = testLevel;
            }

            while (keepGoing == true)
            {
                TimeManagementMethods.executePowerTick(playerSpaceShip);
                //Console.ReadLine();

                //ReportingMethods.shipSystemReport(playerSpaceShip.fighterCockpit.aI);
                //ReportingMethods.shipSystemReport(playerSpaceShip.engineering.shields);
                //ReportingMethods.shipSystemReport(playerSpaceShip.bridge.aI);
                

                if (playerSpaceShip.shipType == "Fighter")
                {
                    int storedSystemPower = playerSpaceShip.shipStoredPower();
                    if (playerSpaceShip.getSpecificRoom("Fighter Cockpit").fuelStore.fuelLevel <= 0 && playerSpaceShip.getSpecificShipSystem("Capacitor").currentPowerStored <= 0 && storedSystemPower <= 0) 
                    {
                        keepGoing = false;
                    }
                }

                if (playerSpaceShip.shipType != "Fighter")
                {
                    int storedSystemPower = playerSpaceShip.shipStoredPower();
                    if (playerSpaceShip.getSpecificRoom("Engineering").fuelStore.fuelLevel <= 0 && playerSpaceShip.getSpecificShipSystem("Capacitor").currentPowerStored <= 0 && storedSystemPower <= 0)
                    {
                        keepGoing = false;
                    }
                }
            }
        }
        
    
    
    
    }
}

