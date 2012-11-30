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
            PowerManagementMethods.primeGeneratorWithFuel(playerSpaceShip);
            PowerManagementMethods.runGenerator(playerSpaceShip);
           // playerSpaceShip.checkPowerHierarchyIntegrity();
            playerSpaceShip.distributePower();
            PowerManagementMethods.powerBleed(playerSpaceShip);
        }

        static void executeSystemTick()
        {

        }
    }
}