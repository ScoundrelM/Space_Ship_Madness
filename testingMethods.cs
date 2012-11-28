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
                playerSpaceShip.fighterCockpit.fuelStore.fuelLevel = testLevel;
            }

            if (playerSpaceShip.shipType != "Fighter")
            {
                playerSpaceShip.engineering.fuelStore.fuelLevel = testLevel;
            }

            while (keepGoing == true)
            {
                TimeManagementMethods.executePowerTick(playerSpaceShip);

                //ReportingMethods.shipSystemReport(playerSpaceShip.fighterCockpit.aI);
                //ReportingMethods.shipSystemReport(playerSpaceShip.engineering.shields);
                //ReportingMethods.shipSystemReport(playerSpaceShip.bridge.aI);
                

                if (playerSpaceShip.shipType == "Fighter")
                {
                    int storedSystemPower = PowerManagementMethods.calculateStoredSystemPower(playerSpaceShip);
                    if (playerSpaceShip.fighterCockpit.fuelStore.fuelLevel <= 0 && playerSpaceShip.powerPool <= 0 &&  storedSystemPower <= 0) 
                    {
                        keepGoing = false;
                    }
                }

                if (playerSpaceShip.shipType != "Fighter")
                {
                    int storedSystemPower = PowerManagementMethods.calculateStoredSystemPower(playerSpaceShip);
                    if (playerSpaceShip.engineering.fuelStore.fuelLevel <= 0 && playerSpaceShip.powerPool <= 0 && storedSystemPower <= 0)
                    {
                        keepGoing = false;
                    }
                }
            }
        }
        
    
    
    
    }
}

