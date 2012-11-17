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
        

        public static void primeGeneratorWithFuel(SpaceShip playerSpaceShip)
        {
            int fuelRequrement = playerSpaceShip.engineering.powerGenerator.maxFuelLevel - playerSpaceShip.engineering.powerGenerator.fuelLevel;

            if (playerSpaceShip.engineering.fuelStore.fuelLevel > 0)
            {

                if (fuelRequrement < playerSpaceShip.engineering.powerGenerator.fuelLevel)
                {
                    playerSpaceShip.engineering.powerGenerator.fuelLevel = playerSpaceShip.engineering.powerGenerator.maxFuelLevel;
                    playerSpaceShip.engineering.fuelStore.fuelLevel = playerSpaceShip.engineering.fuelStore.fuelLevel - fuelRequrement;

                    Console.WriteLine("Your generator is primed. Ship fuel stores are now: " + playerSpaceShip.engineering.fuelStore.fuelLevel);
                }

                if (fuelRequrement > playerSpaceShip.engineering.fuelStore.fuelLevel)
                {
                    playerSpaceShip.engineering.powerGenerator.fuelLevel = playerSpaceShip.engineering.powerGenerator.fuelLevel + playerSpaceShip.engineering.fuelStore.fuelLevel;
                    playerSpaceShip.engineering.fuelStore.fuelLevel = 0;

                    Console.WriteLine("You have used the last of your fuel priming your generator.");
                }
            }

            if (playerSpaceShip.engineering.fuelStore.fuelLevel == 0)
            {
                Console.WriteLine("You have no fuel.");
            }
        }

        public static void runGenerator(SpaceShip playerSpaceShip)
        {
            int fuelInput = playerSpaceShip.engineering.powerGenerator.fuelLevel;

            if (fuelInput > 0)
            {
                playerSpaceShip.powerPool = fuelInput * playerSpaceShip.engineering.powerGenerator.efficiency;
                playerSpaceShip.powerPool = playerSpaceShip.powerPool + playerSpaceShip.engineering.powerGenerator.currentPowerStored;
            }

            if (fuelInput == 0)
            {
                Console.WriteLine("Not enough fuel to run generator.");
            }
        }

        public static void pickSystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {
            
            if (playerSpaceShip.fighterCockpit != null)
            {
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls.maxPowerStorage, playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored);
                }

                if(playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {

                }
                
                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {

                }

                playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption;
                playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
            }

            if (playerSpaceShip.bridge != null)
            {
                playerSpaceShip.bridge.pilotControls.operationalPowerConsumption;
                playerSpaceShip.bridge.aI.operationalPowerConsumption;

            }

            if (playerSpaceShip.engineering != null)
            {
                playerSpaceShip.engineering.shields.operationalPowerConsumption
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
        }

        public static void dishOutHierarchyPowerpacket(SpaceShip playerSpaceShip, int systemMaxPowerStored, int systemCurrentPowerStored)
        {
            int powerStorageSpace = systemMaxPowerStored - systemCurrentPowerStored;

            if (playerSpaceShip.powerPool < 0)
            {
                if (powerStorageSpace < playerSpaceShip.powerPool)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - powerStorageSpace;
                    systemCurrentPowerStored = systemMaxPowerStored;
                }

                if (playerSpaceShip.powerPool < powerStorageSpace)
                {
                    systemCurrentPowerStored = systemCurrentPowerStored + playerSpaceShip.powerPool;
                    playerSpaceShip.powerPool = 0;
                }
            }
        }

        
        public static void distributePowerPool(SpaceShip playerSpaceShip) // unfinished
        {
            if (playerSpaceShip.powerPool >= playerSpaceShip.spaceShipPowerOverhead)
            {
                if (playerSpaceShip.fighterCockpit != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
                }

                if (playerSpaceShip.bridge != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.bridge.pilotControls.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.bridge.aI.operationalPowerConsumption;

                }

                if (playerSpaceShip.engineering != null)
                {
                    
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.shields.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.engines.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption; 
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.fabricator.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption; 
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.fuelStore.operationalPowerConsumption;

                }

                if (playerSpaceShip.lifeSupport != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption;

                }

                if (playerSpaceShip.comms != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.transmitter.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.receiver.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.cryptography.operationalPowerConsumption;

                }

                if (playerSpaceShip.fireControl != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption;

                }

                if (playerSpaceShip.fireControl2 != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption;
                }

                if (playerSpaceShip.fireControl3 != null)
                {
                    
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption;

                }

                if (playerSpaceShip.fireControl4 != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption;
                }

                if (playerSpaceShip.medibay != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption;
                }

                if (playerSpaceShip.cargoHold != null)
                {

                }

                if (playerSpaceShip.shuttleBay != null)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption;
                }

                if (playerSpaceShip.powerPool > 0)
                {

                }
            }
        } // unfinished

        }
                //playerSpaceShip.engineering.pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.shields = new ShipSystem("Shields", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.aI = new ShipSystem("A.I.", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.engines = new ShipSystem("Engines", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.fabricator = new ShipSystem("Fabricator", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.wasteDisposal = new ShipSystem("Waste Disposal", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.airScrubber = new ShipSystem ("Air Scrubber", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.gravityGenerator = new ShipSystem ("Gravity Generator", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.temperatureControl = new ShipSystem ("Temperature Control", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.transmitter = new ShipSystem ("Transmitter", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.receiver = new ShipSystem ("Receiver", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.cryptography = new ShipSystem ("Cryptography", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.weaponsTargeting = new ShipSystem ("Weapons Targeting", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.weaponsFiring = new ShipSystem ("Weapons Firing", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.surgeryTable = new ShipSystem ("Surgery Table", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.hangar = new ShipSystem ("Hangar", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.engineering.repairBay = new ShipSystem ("Repair Bay", playerSpaceShip.bridge.roomType);


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
