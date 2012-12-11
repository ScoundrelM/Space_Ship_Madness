using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class TimeManagementMethods
    {
        public static void executeMainTick(SpaceShip playerSpaceShip)
        {
            executePowerTick(playerSpaceShip);
            playerInteractionTime();
        }
        public static void executePowerTick(SpaceShip playerSpaceShip)
        {
            playerSpaceShip.primeGeneratorWithFuel();
            playerSpaceShip.runGenerator();
            playerSpaceShip.enforceValidityOnHierarchy();
            playerSpaceShip.distributePower();
            playerSpaceShip.checkForOverheating();
            playerSpaceShip.powerBleed();
            playerSpaceShip.checkAirForLeaks();
        }

        static void playerInteractionTime()
        {

        }
    }
}