using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class PowerManagementMethods
    {
        public static void calculatePowerRequirementForTick(SpaceShip playerSpaceShip)
        {
            int powerRequirementRunningTotal = 0;

            // Find system level power consumption.

            if (playerSpaceShip.fighterCockpit != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption + playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption + playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption + playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption + playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
            }

            if (playerSpaceShip.bridge != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.bridge.pilotControls.operationalPowerConsumption + playerSpaceShip.bridge.aI.operationalPowerConsumption;

            }

            if (playerSpaceShip.engineering != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.engineering.shields.operationalPowerConsumption +
                playerSpaceShip.engineering.engines.operationalPowerConsumption +
                playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption + 
                playerSpaceShip.engineering.fabricator.operationalPowerConsumption + 
                playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption + 
                playerSpaceShip.engineering.fuelStore.operationalPowerConsumption;

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption +
                playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption +
                playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption;

            }

            if (playerSpaceShip.comms != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.comms.transmitter.operationalPowerConsumption +
                playerSpaceShip.comms.receiver.operationalPowerConsumption +
                playerSpaceShip.comms.cryptography.operationalPowerConsumption;

            }

            if (playerSpaceShip.fireControl != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption +
                playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption;

            }

            if (playerSpaceShip.fireControl2 != null)
            {

                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption +
                playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption;

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption +
                playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption;

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption + 
                playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption;

            }

            if (playerSpaceShip.medibay != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption;
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                powerRequirementRunningTotal = powerRequirementRunningTotal +
                playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption +
                playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption;
            }

            playerSpaceShip.spaceShipPowerOverhead = powerRequirementRunningTotal;
        }
        
        //public static int calculateOverallPowerRequirementForTick(SpaceShip playerSpaceShip)
        //{
        //    int overallPowerRequirement = 0;
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            overallPowerRequirement = shipSystem.operationalPowerConsumption + overallPowerRequirement;
        //        }
        //    }
        //    overallPowerRequirement = playerSpaceShip.spaceShipPowerOverhead + overallPowerRequirement;
        //    return overallPowerRequirement;
        //}
        public static void calculateFuelLevels(SpaceShip playerSpaceShip)
        {
            //    int fuelDifference = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).maxFuelLevel - ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel;

            //    if (ShipSystemMethods.findSystemFuelStore(playerSpaceShip).fuelLevel == 0)
            //    {
            //        Console.WriteLine("Your fuel reserves have run dry");
            //    }
            //    else if ((ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel < ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).maxFuelLevel) && (fuelDifference < ShipSystemMethods.findSystemFuelStore(playerSpaceShip).fuelLevel))
            //    {
            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel - fuelDifference;
            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel + fuelDifference;
            //        Console.WriteLine("Generators primed.");
            //    }
            //    else if (fuelDifference >= ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel)
            //    {
            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel + ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel;
            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = 0;
            //        Console.WriteLine("You have just used the last of your fuel reserves priming your generators.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Something Weird is happening in the fuel system.");
            //    }

            //}
            //public static int calculatePowerGenerated(SpaceShip playerSpaceShip)
            //{
            //    int powerGeneratedThisTurn = 0;
            //    foreach (Room room in playerSpaceShip.rooms)
            //    {
            //        foreach (ShipSystem shipSystem in room.shipSystems)
            //        {
            //            switch (shipSystem.name)
            //            {
            //                case "Power Generator":
            //                    if ((shipSystem.isOperational == true) && (shipSystem.fuelLevel > shipSystem.efficiency))
            //                    {
            //                        int possibleGenerationFromFuel = (shipSystem.fuelLevel / shipSystem.efficiency);
            //                        if (possibleGenerationFromFuel >= shipSystem.powerGeneration)
            //                        {
            //                            powerGeneratedThisTurn = shipSystem.powerGeneration;
            //                        }
            //                        else
            //                        {
            //                            powerGeneratedThisTurn = shipSystem.fuelLevel / shipSystem.efficiency;
            //                        }
            //                    }
            //                    else if (shipSystem.fuelLevel < shipSystem.efficiency)
            //                    {
            //                        Console.WriteLine("The Generator is not primed with enough fuel to create power.");
            //                    }
            //                    else if (shipSystem.isOperational == false)
            //                    {
            //                        Console.WriteLine("The Power Generator is not operational");
            //                    }
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //    }
            //    return powerGeneratedThisTurn;
            //}
            //public static int powerHierarchyCycleThrough(SpaceShip playerSpaceShip, int hierarchyPosition, int currentPowerPool)
            //{
            //    while (currentPowerPool > 0)
            //    {
            //        foreach (Room room in playerSpaceShip.rooms)
            //        {
            //            foreach (ShipSystem shipSystem in room.shipSystems)
            //            {
            //                if (shipSystem.powerSupplyHierarchyPosition == hierarchyPosition)
            //                {
            //                    int powerDifference = shipSystem.maxPowerStorage - shipSystem.currentPowerStored;
            //                    if (powerDifference < currentPowerPool)
            //                    {
            //                        shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
            //                        currentPowerPool = currentPowerPool - powerDifference;
            //                        return currentPowerPool;
            //                    }
            //                    else if (powerDifference >= currentPowerPool)
            //                    {
            //                        shipSystem.currentPowerStored = shipSystem.currentPowerStored + currentPowerPool;
            //                        currentPowerPool = 0;
            //                        return currentPowerPool;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    return currentPowerPool;
            //}
            //public static void distributePowerToSystems(SpaceShip playerSpaceShip, int currentPowerPool, int currentPowerRequirement)
            //{
            //    int numberOfSystems = 0;
            //    if (currentPowerPool == currentPowerRequirement)
            //    {
            //        foreach (Room room in playerSpaceShip.rooms)
            //        {
            //            foreach (ShipSystem shipSystem in room.shipSystems)
            //            {
            //                shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
            //            }
            //        }
            //        currentPowerPool = 0;
            //    }
            //    else if (currentPowerRequirement < currentPowerPool)
            //    {
            //        int leftoverPowerThisTick = currentPowerPool - currentPowerRequirement;
            //        foreach (Room room in playerSpaceShip.rooms)
            //        {
            //            foreach (ShipSystem shipSystem in room.shipSystems)
            //            {
            //                numberOfSystems++;
            //                shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
            //            }
            //            int powerSystemOverload = leftoverPowerThisTick / numberOfSystems;
            //            foreach (ShipSystem shipSystem in room.shipSystems)
            //            {
            //                shipSystem.currentTemperature = shipSystem.currentTemperature + powerSystemOverload;
            //            }
            //        }
            //        currentPowerPool = 0;
            //    }
            //    else if (currentPowerRequirement > currentPowerPool)
            //    {
            //        foreach (Room room in playerSpaceShip.rooms)
            //        {
            //            foreach (ShipSystem shipSystem in room.shipSystems)
            //            {
            //                numberOfSystems++;
            //            }
            //        }
            //        int hierarchyPosition = 1;
            //        while (numberOfSystems >= hierarchyPosition)
            //        {
            //            currentPowerPool = PowerManagementMethods.powerHierarchyCycleThrough(playerSpaceShip, hierarchyPosition, currentPowerPool);
            //            hierarchyPosition++;
            //        }

            //    }
            //}
        }
    }
}
