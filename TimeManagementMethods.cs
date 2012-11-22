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
            PowerManagementMethods.calculatePowerRequirementForTick(playerSpaceShip);
            PowerManagementMethods.primeGeneratorWithFuel(playerSpaceShip);
            PowerManagementMethods.runGenerator(playerSpaceShip);
            PowerManagementMethods.distributePowerPool(playerSpaceShip);
        }

        static void executeSystemTick()
        {

        }
    }
}