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
            executeSystemTick();
        }
        public static void executePowerTick(SpaceShip playerSpaceShip)
        {
            playerSpaceShip.primeGeneratorWithFuel();
            playerSpaceShip.runGenerator();
            playerSpaceShip.enforceValidityOnHierarchy();
            playerSpaceShip.distributePower();
            playerSpaceShip.powerBleed();
        }

        static void executeSystemTick()
        {

        }
    }
}