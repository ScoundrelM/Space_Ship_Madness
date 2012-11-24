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
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);

                if (playerSpaceShip.fighterCockpit.pilotControls.isOperational == true)
                {
                powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.temperatureControl);

                if (playerSpaceShip.fighterCockpit.temperatureControl.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption;
                    
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.airScrubber);

                if (playerSpaceShip.fighterCockpit.airScrubber.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.heatExchanger);

                if (playerSpaceShip.fighterCockpit.heatExchanger.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.shields);

                if(playerSpaceShip.fighterCockpit.shields.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.bridge.pilotControls);

                if (playerSpaceShip.bridge.pilotControls.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.bridge.pilotControls.operationalPowerConsumption;
                }
                
                checkSystemOperational(playerSpaceShip.bridge.aI);

                if (playerSpaceShip.bridge.aI.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.bridge.aI.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.powerDistributor.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.powerDistributor.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.engines);

                if (playerSpaceShip.engineering.engines.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.engines.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.powerGenerator);

                if (playerSpaceShip.engineering.powerGenerator.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.fabricator);

                if (playerSpaceShip.engineering.fabricator.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.fabricator.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.fabricator);

                if (playerSpaceShip.engineering.fabricator.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.fabricator.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);

                if (playerSpaceShip.engineering.wasteDisposal.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.engineering.fuelStore);

                if (playerSpaceShip.engineering.fuelStore.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.engineering.fuelStore.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);

                if (playerSpaceShip.lifeSupport.airScrubber.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);

                if (playerSpaceShip.lifeSupport.gravityGenerator.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);

                if (playerSpaceShip.lifeSupport.temperatureControl.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption;
                } 

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.comms.transmitter);

                if (playerSpaceShip.comms.transmitter.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.comms.transmitter.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.comms.receiver);

                if (playerSpaceShip.comms.receiver.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.comms.receiver.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.comms.cryptography);

                if (playerSpaceShip.comms.cryptography.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.comms.cryptography.operationalPowerConsumption;
                }                 
            }

            if (playerSpaceShip.fireControl != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);

                if (playerSpaceShip.fireControl.weaponsTargeting.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);

                if (playerSpaceShip.fireControl.weaponsFiring.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption;
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);

                if (playerSpaceShip.fireControl2.weaponsTargeting.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);

                if (playerSpaceShip.fireControl2.weaponsFiring.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);

                if (playerSpaceShip.fireControl3.weaponsTargeting.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);

                if (playerSpaceShip.fireControl3.weaponsFiring.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);

                if (playerSpaceShip.fireControl4.weaponsTargeting.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption;
                }

                checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);

                if (playerSpaceShip.fireControl4.weaponsFiring.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption;
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.medibay.surgeryTable);

                if (playerSpaceShip.medibay.surgeryTable.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption;
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {
  
            }

            if (playerSpaceShip.shuttleBay != null)
            {

                checkSystemOperational(playerSpaceShip.shuttleBay.hangar);

                if (playerSpaceShip.shuttleBay.hangar.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption;
                }

                if (playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                {
                    powerRequirementRunningTotal = powerRequirementRunningTotal + playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption;
                }
            }

            playerSpaceShip.spaceShipPowerOverhead = powerRequirementRunningTotal;

            Console.WriteLine("Power Overhead this tick: " + powerRequirementRunningTotal);
        }

        public static void primeGeneratorWithFuel(SpaceShip playerSpaceShip)
        {
            int fuelRequrement = playerSpaceShip.engineering.powerGenerator.maxFuelLevel - playerSpaceShip.engineering.powerGenerator.fuelLevel;

            if (playerSpaceShip.engineering.fuelStore.fuelLevel == 0)
            {
                Console.WriteLine("You have no fuel.");
            }

            if (playerSpaceShip.engineering.fuelStore.fuelLevel > 0)
            {

                if (fuelRequrement <= playerSpaceShip.engineering.fuelStore.fuelLevel)
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


        }

        public static void checkSystemOperational(ShipSystem shipSystem)
        {
            if (shipSystem.isSwitchedOn == false || shipSystem.isBroken == true || shipSystem.isDestroyed == true)
            {
                shipSystem.isOperational = false;
            }

            if (shipSystem.isSwitchedOn == true && shipSystem.isBroken == false && shipSystem.isDestroyed == false)
            {
                shipSystem.isOperational = true;
            }

        }

        public static void runGenerator(SpaceShip playerSpaceShip)
        {
            int fuelInput = playerSpaceShip.engineering.powerGenerator.fuelLevel;

            if(playerSpaceShip.engineering.powerGenerator.isOperational == true)
            {
                if (fuelInput <= 0)
                {
                    Console.WriteLine("Not enough fuel to run generator.");
                }
            

                if (fuelInput > 0)
                {
                    playerSpaceShip.powerPool = fuelInput * playerSpaceShip.engineering.powerGenerator.efficiency;
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool + playerSpaceShip.engineering.powerGenerator.currentPowerStored;
                    playerSpaceShip.engineering.powerGenerator.fuelLevel = 0;
                }
            }

            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
        }

        public static void abundantSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {

            if (playerSpaceShip.fighterCockpit != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.pilotControls.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls.maxPowerStorage, playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.temperatureControl.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.temperatureControl.maxPowerStorage, playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.airScrubber.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber.maxPowerStorage, playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.heatExchanger.isOperational)
                {
                 checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);   dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger.maxPowerStorage, playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.shields.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields.maxPowerStorage, playerSpaceShip.fighterCockpit.shields.currentPowerStored);
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.pilotControls.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls.maxPowerStorage, playerSpaceShip.bridge.pilotControls.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.aI.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI.maxPowerStorage, playerSpaceShip.bridge.aI.currentPowerStored);
                }
            }

            if (playerSpaceShip.engineering != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.shields.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields.maxPowerStorage, playerSpaceShip.engineering.shields.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.engines.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines.maxPowerStorage, playerSpaceShip.engineering.engines.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerDistributor.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerDistributor.maxPowerStorage, playerSpaceShip.engineering.powerDistributor.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerGenerator.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator.maxPowerStorage, playerSpaceShip.engineering.powerGenerator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.fabricator.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator.maxPowerStorage, playerSpaceShip.engineering.fabricator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.wasteDisposal.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal.maxPowerStorage, playerSpaceShip.engineering.wasteDisposal.currentPowerStored);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.airScrubber.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber.maxPowerStorage, playerSpaceShip.lifeSupport.airScrubber.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.gravityGenerator.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator.maxPowerStorage, playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.temperatureControl.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl.maxPowerStorage, playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored);
                }

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.transmitter.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter.maxPowerStorage, playerSpaceShip.comms.transmitter.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.receiver.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver.maxPowerStorage, playerSpaceShip.comms.receiver.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.cryptography.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography.maxPowerStorage, playerSpaceShip.comms.cryptography.currentPowerStored);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsFiring.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsFiring.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsFiring.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsFiring.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.medibay.surgeryTable.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable.maxPowerStorage, playerSpaceShip.medibay.surgeryTable.currentPowerStored);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.hangar.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar.maxPowerStorage, playerSpaceShip.shuttleBay.hangar.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.repairBay.isOperational)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay.maxPowerStorage, playerSpaceShip.shuttleBay.repairBay.currentPowerStored);
                }
            }
        }

        public static void limitedSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {

            if (playerSpaceShip.fighterCockpit != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.pilotControls.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption ,playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.airScrubber);
                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.airScrubber.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption, playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.heatExchanger);
                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.heatExchanger.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption, playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.shields);
                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.shields.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption, playerSpaceShip.fighterCockpit.shields.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.powerDistributor);
                if (playerSpaceShip.fighterCockpit.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.powerDistributor.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.powerDistributor.operationalPowerConsumption, playerSpaceShip.fighterCockpit.powerDistributor.currentPowerStored);
                }


            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.bridge.pilotControls);
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.pilotControls.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls.operationalPowerConsumption, playerSpaceShip.bridge.pilotControls.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.bridge.aI);
                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.aI.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI.operationalPowerConsumption, playerSpaceShip.bridge.aI.currentPowerStored);
                }
            }

            if (playerSpaceShip.engineering != null)
            {
                checkSystemOperational(playerSpaceShip.engineering.shields);
                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.shields.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields.operationalPowerConsumption, playerSpaceShip.engineering.shields.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerDistributor);
                if (playerSpaceShip.engineering.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerDistributor.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerDistributor.operationalPowerConsumption, playerSpaceShip.engineering.powerDistributor.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.engineering.engines);
                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.engines.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines.operationalPowerConsumption, playerSpaceShip.engineering.engines.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerGenerator);
                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerGenerator.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption, playerSpaceShip.engineering.powerGenerator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.engineering.fabricator);
                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.fabricator.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator.operationalPowerConsumption, playerSpaceShip.engineering.fabricator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);
                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.wasteDisposal.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption, playerSpaceShip.engineering.wasteDisposal.currentPowerStored);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);
                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.airScrubber.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption, playerSpaceShip.lifeSupport.airScrubber.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);
                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.gravityGenerator.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption, playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);
                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.temperatureControl.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption, playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored);
                }

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.comms.transmitter);
                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.transmitter.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter.operationalPowerConsumption, playerSpaceShip.comms.transmitter.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.comms.receiver);
                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.receiver.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver.operationalPowerConsumption, playerSpaceShip.comms.receiver.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.comms.cryptography);
                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.cryptography.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography.operationalPowerConsumption, playerSpaceShip.comms.cryptography.currentPowerStored);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);
                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);
                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsFiring.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);
                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);
                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsFiring.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);
                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsFiring.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);
                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsTargeting.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);
                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsFiring.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.medibay.surgeryTable);
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.medibay.surgeryTable.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption, playerSpaceShip.medibay.surgeryTable.currentPowerStored);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                checkSystemOperational(playerSpaceShip.shuttleBay.hangar);
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.hangar.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption, playerSpaceShip.shuttleBay.hangar.currentPowerStored);
                }
                checkSystemOperational(playerSpaceShip.shuttleBay.repairBay);
                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.repairBay.isOperational)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption, playerSpaceShip.shuttleBay.repairBay.currentPowerStored);
                }
            }
        }

        public static void dishOutHierarchyOverflowPowerpacket(SpaceShip playerSpaceShip, int systemMaxPowerStored, int systemCurrentPowerStored)
        {
            int powerStorageSpace = systemMaxPowerStored - systemCurrentPowerStored;
            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
            if (playerSpaceShip.powerPool > 0)
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

            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
        }

        public static void dishOutHierarchyBasePowerpacket(SpaceShip playerSpaceShip, int systemPowerOverhead, int systemCurrentPowerStored)
        {

            if (playerSpaceShip.powerPool > 0)
            {
                Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
                if (playerSpaceShip.powerPool > systemPowerOverhead)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - systemPowerOverhead;
                }

                if (playerSpaceShip.powerPool < systemPowerOverhead)
                {
                    if (playerSpaceShip.powerPool + systemCurrentPowerStored > systemPowerOverhead)
                    {
                        systemCurrentPowerStored = systemCurrentPowerStored - (systemPowerOverhead - playerSpaceShip.powerPool);
                    }

                    if (playerSpaceShip.powerPool + systemCurrentPowerStored < systemPowerOverhead)
                    {
                        systemCurrentPowerStored = 0;
                        playerSpaceShip.powerPool = 0;

                    }
                }

                Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
            }

            if (playerSpaceShip.powerPool <= 0)
            {
                playerSpaceShip.powerPool = 0;

                if (systemPowerOverhead < systemCurrentPowerStored)
                {
                    systemCurrentPowerStored = systemCurrentPowerStored - systemPowerOverhead;
                }

                if (systemPowerOverhead > systemCurrentPowerStored)
                {
                    systemCurrentPowerStored = 0;
                }
            }
        }

        public static int countShipSystems(SpaceShip playerSpaceShip) // needs developing further
        {
            int systemCount = 0;
            if (playerSpaceShip.fighterCockpit != null)
            {
                //playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption;
                //playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption;
                //playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption;
                //playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption;
                //playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
                systemCount = systemCount + 5;
            }

            if (playerSpaceShip.bridge != null)
            {
                //playerSpaceShip.bridge.pilotControls.operationalPowerConsumption;
                //playerSpaceShip.bridge.aI.operationalPowerConsumption;
                systemCount = systemCount + 2;

            }

            if (playerSpaceShip.engineering != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.engineering.shields.operationalPowerConsumption +
                //playerSpaceShip.engineering.engines.operationalPowerConsumption +
                //playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption + 
                //playerSpaceShip.engineering.fabricator.operationalPowerConsumption + 
                //playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption + 
                //playerSpaceShip.engineering.fuelStore.operationalPowerConsumption;

                systemCount = systemCount + 6;

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption +
                //playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption +
                //playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption;

                systemCount = systemCount + 3;

            }

            if (playerSpaceShip.comms != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.comms.transmitter.operationalPowerConsumption +
                //playerSpaceShip.comms.receiver.operationalPowerConsumption +
                //playerSpaceShip.comms.cryptography.operationalPowerConsumption;

                systemCount = systemCount + 3;

            }

            if (playerSpaceShip.fireControl != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption +
                //playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption;

                systemCount = systemCount + 2;

            }

            if (playerSpaceShip.fireControl2 != null)
            {

                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption +
                //playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption;

                systemCount = systemCount + 2;

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption +
                //playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption;

                systemCount = systemCount + 2;



            }

            if (playerSpaceShip.fireControl4 != null)
            {

                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption + 
                //playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption;

                systemCount = systemCount + 2;

            }

            if (playerSpaceShip.medibay != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption;

                systemCount = systemCount + 1;
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                //powerRequirementRunningTotal = powerRequirementRunningTotal +
                //playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption +
                //playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption;

                systemCount = systemCount + 2;
            }

            return systemCount;
        }
 
        public static void distributePowerPool(SpaceShip playerSpaceShip) // unfinished
        {
            if (playerSpaceShip.powerPool >= playerSpaceShip.spaceShipPowerOverhead)
            {
                if (playerSpaceShip.fighterCockpit != null)
                {
                    checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                    if (playerSpaceShip.fighterCockpit.pilotControls.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fighterCockpit.temperatureControl);
                    if (playerSpaceShip.fighterCockpit.temperatureControl.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fighterCockpit.airScrubber);
                    if (playerSpaceShip.fighterCockpit.airScrubber.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fighterCockpit.heatExchanger);
                    if (playerSpaceShip.fighterCockpit.heatExchanger.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fighterCockpit.shields);
                    if (playerSpaceShip.fighterCockpit.shields.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.bridge != null)
                {

                    checkSystemOperational(playerSpaceShip.bridge.pilotControls);
                    if (playerSpaceShip.bridge.pilotControls.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.bridge.pilotControls.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.bridge.aI);
                    if (playerSpaceShip.bridge.aI.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.bridge.aI.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.engineering != null)
                {

                    checkSystemOperational(playerSpaceShip.engineering.shields);
                    if (playerSpaceShip.engineering.shields.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.shields.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.engineering.engines);
                    if (playerSpaceShip.engineering.engines.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.engines.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.engineering.powerGenerator);
                    if (playerSpaceShip.engineering.powerGenerator.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.engineering.fabricator);
                    if (playerSpaceShip.engineering.fabricator.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.fabricator.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);
                    if (playerSpaceShip.engineering.wasteDisposal.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.engineering.fuelStore);
                    if (playerSpaceShip.engineering.fuelStore.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.fuelStore.operationalPowerConsumption;
                    }
                    
                    checkSystemOperational(playerSpaceShip.engineering.powerDistributor);
                    if (playerSpaceShip.engineering.powerDistributor.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.engineering.powerDistributor.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.lifeSupport != null)
                {


                    checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);
                    if (playerSpaceShip.lifeSupport.airScrubber.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption;
                    }


                    checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);
                    if (playerSpaceShip.lifeSupport.gravityGenerator.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption;
                    }


                    checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);
                    if (playerSpaceShip.lifeSupport.temperatureControl.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.comms != null)
                {


                    checkSystemOperational(playerSpaceShip.comms.transmitter);
                    if (playerSpaceShip.comms.transmitter.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.transmitter.operationalPowerConsumption;
                    }


                    checkSystemOperational(playerSpaceShip.comms.receiver);
                    if (playerSpaceShip.comms.receiver.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.receiver.operationalPowerConsumption;
                    }


                    checkSystemOperational(playerSpaceShip.comms.cryptography);
                    if (playerSpaceShip.comms.cryptography.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.comms.cryptography.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.fireControl != null)
                {
                    checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);
                    if (playerSpaceShip.fireControl.weaponsTargeting.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);
                    if (playerSpaceShip.fireControl.weaponsFiring.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption;
                    }




                }

                if (playerSpaceShip.fireControl2 != null)
                {
                    checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);
                    if (playerSpaceShip.fireControl2.weaponsTargeting.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);
                    if (playerSpaceShip.fireControl2.weaponsFiring.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.fireControl3 != null)
                {

                    checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);
                    if (playerSpaceShip.fireControl3.weaponsTargeting.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);
                    if (playerSpaceShip.fireControl3.weaponsFiring.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption;
                    }

                }

                if (playerSpaceShip.fireControl4 != null)
                {
                    checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);
                    if (playerSpaceShip.fireControl4.weaponsTargeting.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);
                    if (playerSpaceShip.fireControl4.weaponsFiring.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption;
                    }
                }

                if (playerSpaceShip.medibay != null)
                {


                    checkSystemOperational(playerSpaceShip.medibay.surgeryTable);
                    if (playerSpaceShip.medibay.surgeryTable.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.fireControl4.surgeryTable.operationalPowerConsumption;
                    }

                }

                if (playerSpaceShip.cargoHold != null)
                {

                }

                if (playerSpaceShip.shuttleBay != null)
                {

                    checkSystemOperational(playerSpaceShip.shuttleBay.hangar);
                    if (playerSpaceShip.shuttleBay.hangar.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption;
                    }

                    checkSystemOperational(playerSpaceShip.shuttleBay.repairBay);
                    if (playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                    {
                        playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption;
                    }

                }

                if (playerSpaceShip.powerPool > 0)
                {
                    int positionCurrentlyChecking = countShipSystems(playerSpaceShip);
                    int highestPosition = positionCurrentlyChecking;
                    bool keepGoing = true;
                    positionCurrentlyChecking = 1;

                    while (keepGoing == true)
                    {
                        abundantSupplySystemPowerHierarchy(playerSpaceShip, positionCurrentlyChecking);
                        positionCurrentlyChecking++;
                        
                        if (positionCurrentlyChecking < (highestPosition + 1))
                        {
                            keepGoing = false;
                        }
                    }

                }
            }

            if (playerSpaceShip.powerPool < playerSpaceShip.spaceShipPowerOverhead)
            {
                int positionCurrentlyChecking = countShipSystems(playerSpaceShip);
                int highestPosition = positionCurrentlyChecking;
                bool keepGoing = true;
                positionCurrentlyChecking = 1;

                while (keepGoing == true)
                {
                    limitedSupplySystemPowerHierarchy(playerSpaceShip, positionCurrentlyChecking);
                    positionCurrentlyChecking++;

                    if (positionCurrentlyChecking < (highestPosition + 1))
                    {
                        keepGoing = false;
                    }
                }

            }
        }

        public static void powerBleed(SpaceShip playerSpaceShip)
        {
            if (playerSpaceShip.fighterCockpit != null)
            {
                if (playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored --;
                }



                if (playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored--;

                }



                if (playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored--;
                }



                if (playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored--;
                }


                if (playerSpaceShip.fighterCockpit.shields.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.shields.currentPowerStored--;
                }

            }

            if (playerSpaceShip.bridge != null)
            {


                if (playerSpaceShip.bridge.pilotControls.currentPowerStored > 0)
                {
                    playerSpaceShip.bridge.pilotControls.currentPowerStored--;
                }



                if (playerSpaceShip.bridge.aI.currentPowerStored > 0)
                {
                    playerSpaceShip.bridge.aI.currentPowerStored--;
                }

            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.powerDistributor.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.powerDistributor.currentPowerStored--;
                }



                if (playerSpaceShip.engineering.engines.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.engines.currentPowerStored--;
                }



                if (playerSpaceShip.engineering.powerGenerator.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.powerGenerator.currentPowerStored--;
                }



                if (playerSpaceShip.engineering.fabricator.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.fabricator.currentPowerStored--;
                }

                if (playerSpaceShip.engineering.wasteDisposal.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.wasteDisposal.currentPowerStored--;
                }



                if (playerSpaceShip.engineering.fuelStore.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.fuelStore.currentPowerStored--;
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {


                if (playerSpaceShip.lifeSupport.airScrubber.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.airScrubber.currentPowerStored--;
                }



                if (playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored--;
                }



                if (playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored--;
                }

            }

            if (playerSpaceShip.comms != null)
            {


                if (playerSpaceShip.comms.transmitter.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.transmitter.currentPowerStored--;
                }



                if (playerSpaceShip.comms.receiver.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.receiver.currentPowerStored--;
                }



                if (playerSpaceShip.comms.cryptography.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.cryptography.currentPowerStored--;
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                if (playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored--;
                }



                if (playerSpaceShip.fireControl.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl.weaponsFiring.currentPowerStored--;
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {



                if (playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored--;
                }



                if (playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored--;
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {


                if (playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored--;
                }



                if (playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored--;
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {



                if (playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored--;
                }



                if (playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored--;
                }

            }

            if (playerSpaceShip.medibay != null)
            {


                if (playerSpaceShip.medibay.surgeryTable.currentPowerStored > 0)
                {
                    playerSpaceShip.medibay.surgeryTable.currentPowerStored--;
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {



                if (playerSpaceShip.shuttleBay.hangar.currentPowerStored > 0)
                {
                    playerSpaceShip.shuttleBay.hangar.currentPowerStored--;
                }

                if (playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                {
                    playerSpaceShip.shuttleBay.repairBay.currentPowerStored--;
                }
            }
        }

    }
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
        
    

