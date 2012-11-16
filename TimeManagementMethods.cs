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
            //int currentPowerRequirement = PowerManagementMethods.calculateOverallPowerRequirementForTick(playerSpaceShip);
            //PowerManagementMethods.calculateFuelLevels(playerSpaceShip);
            //int currentPowerPool = PowerManagementMethods.calculatePowerGenerated(playerSpaceShip);
            //PowerManagementMethods.distributePowerToSystems(playerSpaceShip, currentPowerPool, currentPowerRequirement);
        }
        static void executeSystemTick()
        {

        }
    }
}