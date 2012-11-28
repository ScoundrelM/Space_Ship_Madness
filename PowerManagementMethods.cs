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

                if (playerSpaceShip.fighterCockpit.shields.isOperational == true)
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
                checkSystemOperational(playerSpaceShip.engineering.powerDistributor);

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

            if (playerSpaceShip.engineering.powerGenerator.isOperational == true)
            {
                if (fuelInput <= 0)
                {
                    Console.WriteLine("Not enough fuel to run generator.");
                }


                if (fuelInput > 0)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool + (fuelInput * playerSpaceShip.engineering.powerGenerator.efficiency);
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool + playerSpaceShip.engineering.powerGenerator.currentPowerStored;
                    playerSpaceShip.engineering.powerGenerator.fuelLevel = 0;
                }
            }

            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
        }

        public static void abundantSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {
            //checkPowerSystemHierarchy(playerSpaceShip);

            if (playerSpaceShip.fighterCockpit != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.pilotControls.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.temperatureControl.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.temperatureControl);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.airScrubber.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.heatExchanger.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.shields.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields);
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.bridge.pilotControls);
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.pilotControls.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls);
                }
                checkSystemOperational(playerSpaceShip.bridge.aI);
                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.aI.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI);
                }
            }

            if (playerSpaceShip.engineering != null)
            {
                checkSystemOperational(playerSpaceShip.engineering.shields);
                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.shields.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields);
                }
                checkSystemOperational(playerSpaceShip.engineering.engines);
                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.engines.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerDistributor);
                if (playerSpaceShip.engineering.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerDistributor.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerDistributor);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerGenerator);
                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerGenerator.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator);
                }
                checkSystemOperational(playerSpaceShip.engineering.fabricator);
                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.fabricator.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator);
                }
                checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);
                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.wasteDisposal.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);
                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.airScrubber.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);
                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.gravityGenerator.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);
                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.temperatureControl.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl);
                }

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.comms.transmitter);
                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.transmitter.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter);
                }
                checkSystemOperational(playerSpaceShip.comms.receiver);
                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.receiver.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver);
                }
                checkSystemOperational(playerSpaceShip.comms.cryptography);
                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.cryptography.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);
                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);
                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);
                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);
                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);
                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);
                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);
                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.medibay.surgeryTable);
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.medibay.surgeryTable.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                checkSystemOperational(playerSpaceShip.shuttleBay.hangar);
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.hangar.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar);
                }
                checkSystemOperational(playerSpaceShip.shuttleBay.repairBay);
                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay);
                }
            }
        }

        public static void limitedSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {
            //checkPowerSystemHierarchy(playerSpaceShip);

            if (playerSpaceShip.fighterCockpit != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.pilotControls.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.airScrubber);
                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.airScrubber.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.heatExchanger);
                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.heatExchanger.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.shields);
                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.shields.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields);
                }
                checkSystemOperational(playerSpaceShip.fighterCockpit.powerDistributor);
                if (playerSpaceShip.fighterCockpit.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fighterCockpit.powerDistributor.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.powerDistributor);
                }


            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.bridge.pilotControls);
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.pilotControls.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls);
                }
                checkSystemOperational(playerSpaceShip.bridge.aI);
                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.bridge.aI.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI);
                }
            }

            if (playerSpaceShip.engineering != null)
            {
                checkSystemOperational(playerSpaceShip.engineering.shields);
                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.shields.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerDistributor);
                if (playerSpaceShip.engineering.powerDistributor.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerDistributor.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerDistributor);
                }
                checkSystemOperational(playerSpaceShip.engineering.engines);
                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.engines.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines);
                }
                checkSystemOperational(playerSpaceShip.engineering.powerGenerator);
                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.powerGenerator.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator);
                }
                checkSystemOperational(playerSpaceShip.engineering.fabricator);
                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.fabricator.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator);
                }
                checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);
                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.engineering.wasteDisposal.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);
                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.airScrubber.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);
                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.gravityGenerator.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator);
                }
                checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);
                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.lifeSupport.temperatureControl.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl);
                }

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.comms.transmitter);
                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.transmitter.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter);
                }
                checkSystemOperational(playerSpaceShip.comms.receiver);
                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.receiver.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver);
                }
                checkSystemOperational(playerSpaceShip.comms.cryptography);
                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.comms.cryptography.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);
                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);
                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);
                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);
                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl2.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);
                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl3.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);
                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsTargeting.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting);
                }
                checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);
                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.fireControl4.weaponsFiring.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.medibay.surgeryTable);
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.medibay.surgeryTable.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                checkSystemOperational(playerSpaceShip.shuttleBay.hangar);
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.hangar.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar);
                }
                checkSystemOperational(playerSpaceShip.shuttleBay.repairBay);
                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition && playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay);
                }
            }
        }

        public static void dishOutHierarchyOverflowPowerpacket(SpaceShip playerSpaceShip, ShipSystem shipSystem)
        {
            int powerStorageSpace = shipSystem.maxPowerStorage - shipSystem.currentPowerStored;
            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
            if (playerSpaceShip.powerPool > 0)
            {
                if (powerStorageSpace <= playerSpaceShip.powerPool)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - powerStorageSpace;
                    shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
                    Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
                }

                if (playerSpaceShip.powerPool < powerStorageSpace)
                {
                    shipSystem.currentPowerStored = shipSystem.currentPowerStored + playerSpaceShip.powerPool;
                    playerSpaceShip.powerPool = 0;
                    Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
                }
            }
            Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
            Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
        }

        public static void dishOutHierarchyBasePowerpacket(SpaceShip playerSpaceShip, ShipSystem shipSystem)
        {
            int systemPowerRequirement = shipSystem.operationalPowerConsumption;

            if (playerSpaceShip.powerPool <= 0)
            {
                playerSpaceShip.powerPool = 0;

                if (systemPowerRequirement <= shipSystem.currentPowerStored)
                {
                    shipSystem.currentPowerStored = shipSystem.currentPowerStored - systemPowerRequirement;
                }

                if (systemPowerRequirement > shipSystem.currentPowerStored)
                {
                    shipSystem.currentPowerStored = 0;
                }

                Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
            }

            if (playerSpaceShip.powerPool > 0)
            {
                Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);



                if (playerSpaceShip.powerPool > systemPowerRequirement)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - systemPowerRequirement;
                }

                if (playerSpaceShip.powerPool < systemPowerRequirement)
                {
                    if (playerSpaceShip.powerPool + shipSystem.currentPowerStored > systemPowerRequirement)
                    {
                        shipSystem.currentPowerStored = shipSystem.currentPowerStored - (systemPowerRequirement - playerSpaceShip.powerPool);
                        playerSpaceShip.powerPool = 0;
                        Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
                    }

                    if (playerSpaceShip.powerPool + shipSystem.currentPowerStored < systemPowerRequirement)
                    {
                        shipSystem.currentPowerStored = 0;
                        playerSpaceShip.powerPool = 0;
                        Console.WriteLine(shipSystem.systemName + " has " + shipSystem.currentPowerStored + " power points stored.");
                        //turn system off
                        shipSystem.isSwitchedOn = false;
                    }
                }

                Console.WriteLine("Current Power Pool: " + playerSpaceShip.powerPool);
            }
        }

        public static int countShipSystems(SpaceShip playerSpaceShip) // needs developing further
        {
            int systemCount = 0;
            if (playerSpaceShip.fighterCockpit != null)
            {
                if (playerSpaceShip.fighterCockpit.pilotControls != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fighterCockpit.temperatureControl != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fighterCockpit.airScrubber != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fighterCockpit.heatExchanger != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fighterCockpit.shields != null)
                {
                    systemCount = systemCount + 1;
                }
            }

            if (playerSpaceShip.bridge != null)
            {
                if (playerSpaceShip.bridge.pilotControls != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.bridge.aI != null)
                {
                    systemCount = systemCount + 1;
                }


            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.shields != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.engineering.engines != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.engineering.powerGenerator != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.engineering.fabricator != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.engineering.wasteDisposal != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.engineering.fuelStore != null)
                {
                    systemCount = systemCount + 1;
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                if (playerSpaceShip.lifeSupport.airScrubber != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.lifeSupport.gravityGenerator != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.lifeSupport.temperatureControl != null)
                {
                    systemCount = systemCount + 1;
                }
            }

            if (playerSpaceShip.comms != null)
            {

                if (playerSpaceShip.comms.transmitter != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.comms.receiver != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.comms.cryptography != null)
                {
                    systemCount = systemCount + 1;
                }

            }

            if (playerSpaceShip.fireControl != null)
            {

                if (playerSpaceShip.fireControl.weaponsTargeting != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fireControl.weaponsFiring != null)
                {
                    systemCount = systemCount + 1;
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {

                if (playerSpaceShip.fireControl2.weaponsTargeting != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fireControl2.weaponsFiring != null)
                {
                    systemCount = systemCount + 1;
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                if (playerSpaceShip.fireControl3.weaponsTargeting != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fireControl3.weaponsFiring != null)
                {
                    systemCount = systemCount + 1;
                }



            }

            if (playerSpaceShip.fireControl4 != null)
            {

                if (playerSpaceShip.fireControl4.weaponsTargeting != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.fireControl4.weaponsFiring != null)
                {
                    systemCount = systemCount + 1;
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                if (playerSpaceShip.medibay.surgeryTable != null)
                {
                    systemCount = systemCount + 1;
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {

                if (playerSpaceShip.shuttleBay.hangar != null)
                {
                    systemCount = systemCount + 1;
                }

                if (playerSpaceShip.shuttleBay.repairBay != null)
                {
                    systemCount = systemCount + 1;
                }
            }

            return systemCount;
        }

        public static void distributePowerPool(SpaceShip playerSpaceShip) // unfinished
        {
            if (playerSpaceShip.powerPool >= playerSpaceShip.spaceShipPowerOverhead)
            {
                playerSpaceShip.powerPool = playerSpaceShip.powerPool - playerSpaceShip.spaceShipPowerOverhead;




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

                        if (positionCurrentlyChecking >= (highestPosition))
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

                    if (positionCurrentlyChecking >= (highestPosition + 1))
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
                    playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored = playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored - 1;
                }



                if (playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored--;

                }



                if (playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored = playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored - 1;
                }



                if (playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored = playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored - 1;
                }


                if (playerSpaceShip.fighterCockpit.shields.currentPowerStored > 0)
                {
                    playerSpaceShip.fighterCockpit.shields.currentPowerStored = playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.bridge != null)
            {


                if (playerSpaceShip.bridge.pilotControls.currentPowerStored > 0)
                {
                    playerSpaceShip.bridge.pilotControls.currentPowerStored = playerSpaceShip.bridge.pilotControls.currentPowerStored - 1;
                }



                if (playerSpaceShip.bridge.aI.currentPowerStored > 0)
                {
                    playerSpaceShip.bridge.aI.currentPowerStored = playerSpaceShip.bridge.aI.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.powerDistributor.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.powerDistributor.currentPowerStored = playerSpaceShip.engineering.powerDistributor.currentPowerStored - 1;
                }



                if (playerSpaceShip.engineering.engines.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.engines.currentPowerStored = playerSpaceShip.engineering.engines.currentPowerStored - 1;
                }



                if (playerSpaceShip.engineering.powerGenerator.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.powerGenerator.currentPowerStored = playerSpaceShip.engineering.powerGenerator.currentPowerStored - 1;
                }



                if (playerSpaceShip.engineering.fabricator.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.fabricator.currentPowerStored = playerSpaceShip.engineering.fabricator.currentPowerStored - 1;
                }

                if (playerSpaceShip.engineering.wasteDisposal.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.wasteDisposal.currentPowerStored = playerSpaceShip.engineering.wasteDisposal.currentPowerStored - 1;
                }



                if (playerSpaceShip.engineering.fuelStore.currentPowerStored > 0)
                {
                    playerSpaceShip.engineering.fuelStore.currentPowerStored = playerSpaceShip.engineering.fuelStore.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {


                if (playerSpaceShip.lifeSupport.airScrubber.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.airScrubber.currentPowerStored = playerSpaceShip.lifeSupport.airScrubber.currentPowerStored - 1;
                }



                if (playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored = playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored - 1;
                }



                if (playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored > 0)
                {
                    playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored = playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.comms != null)
            {


                if (playerSpaceShip.comms.transmitter.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.transmitter.currentPowerStored = playerSpaceShip.comms.transmitter.currentPowerStored - 1;
                }



                if (playerSpaceShip.comms.receiver.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.receiver.currentPowerStored = playerSpaceShip.comms.receiver.currentPowerStored - 1;
                }



                if (playerSpaceShip.comms.cryptography.currentPowerStored > 0)
                {
                    playerSpaceShip.comms.cryptography.currentPowerStored = playerSpaceShip.comms.cryptography.currentPowerStored - 1;
                }
            }

            if (playerSpaceShip.fireControl != null)
            {
                if (playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored = playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored - 1;
                }



                if (playerSpaceShip.fireControl.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl.weaponsFiring.currentPowerStored = playerSpaceShip.fireControl.weaponsFiring.currentPowerStored - 1;
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {



                if (playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored = playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored - 1;
                }



                if (playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored = playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {


                if (playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored = playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored - 1;
                }



                if (playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored = playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {



                if (playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored = playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored - 1;
                }



                if (playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored > 0)
                {
                    playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored = playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored - 1;
                }

            }

            if (playerSpaceShip.medibay != null)
            {


                if (playerSpaceShip.medibay.surgeryTable.currentPowerStored > 0)
                {
                    playerSpaceShip.medibay.surgeryTable.currentPowerStored = playerSpaceShip.medibay.surgeryTable.currentPowerStored - 1;
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                if (playerSpaceShip.shuttleBay.hangar.currentPowerStored > 0)
                {
                    playerSpaceShip.shuttleBay.hangar.currentPowerStored = playerSpaceShip.shuttleBay.hangar.currentPowerStored - 1;
                }

                if (playerSpaceShip.shuttleBay.repairBay.isOperational == true)
                {
                    playerSpaceShip.shuttleBay.repairBay.currentPowerStored = playerSpaceShip.shuttleBay.repairBay.currentPowerStored - 1;
                }
            }
        }

        public static int calculateStoredSystemPower(SpaceShip playerSpaceShip)
        {
            int storedSystemPower = 0;

            // Find system level power consumption.

            if (playerSpaceShip.fighterCockpit != null)
            {
                checkSystemOperational(playerSpaceShip.fighterCockpit.pilotControls);

                if (playerSpaceShip.fighterCockpit.pilotControls != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.temperatureControl);

                if (playerSpaceShip.fighterCockpit.temperatureControl != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored;

                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.airScrubber);

                if (playerSpaceShip.fighterCockpit.airScrubber != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.heatExchanger);

                if (playerSpaceShip.fighterCockpit.heatExchanger != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fighterCockpit.shields);

                if (playerSpaceShip.fighterCockpit.shields != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fighterCockpit.shields.currentPowerStored;
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                checkSystemOperational(playerSpaceShip.bridge.pilotControls);

                if (playerSpaceShip.bridge.pilotControls != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.bridge.pilotControls.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.bridge.aI);

                if (playerSpaceShip.bridge.aI != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.bridge.aI.currentPowerStored;
                }

            }

            if (playerSpaceShip.engineering != null)
            {
                checkSystemOperational(playerSpaceShip.engineering.powerDistributor);

                if (playerSpaceShip.engineering.powerDistributor != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.powerDistributor.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.engineering.engines);

                if (playerSpaceShip.engineering.engines != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.engines.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.engineering.powerGenerator);

                if (playerSpaceShip.engineering.powerGenerator != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.powerGenerator.currentPowerStored;
                }


                checkSystemOperational(playerSpaceShip.engineering.fabricator);

                if (playerSpaceShip.engineering.fabricator != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.fabricator.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.engineering.wasteDisposal);

                if (playerSpaceShip.engineering.wasteDisposal != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.wasteDisposal.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.engineering.fuelStore);

                if (playerSpaceShip.engineering.fuelStore != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.engineering.fuelStore.currentPowerStored;
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                checkSystemOperational(playerSpaceShip.lifeSupport.airScrubber);

                if (playerSpaceShip.lifeSupport.airScrubber != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.lifeSupport.airScrubber.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.lifeSupport.gravityGenerator);

                if (playerSpaceShip.lifeSupport.gravityGenerator != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.lifeSupport.temperatureControl);

                if (playerSpaceShip.lifeSupport.temperatureControl != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored;
                }

            }

            if (playerSpaceShip.comms != null)
            {
                checkSystemOperational(playerSpaceShip.comms.transmitter);

                if (playerSpaceShip.comms.transmitter != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.comms.transmitter.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.comms.receiver);

                if (playerSpaceShip.comms.receiver != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.comms.receiver.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.comms.cryptography);

                if (playerSpaceShip.comms.cryptography != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.comms.cryptography.currentPowerStored;
                }
            }

            if (playerSpaceShip.fireControl != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl.weaponsTargeting);

                if (playerSpaceShip.fireControl.weaponsTargeting != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fireControl.weaponsFiring);

                if (playerSpaceShip.fireControl.weaponsFiring != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl.weaponsFiring.currentPowerStored;
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl2.weaponsTargeting);

                if (playerSpaceShip.fireControl2.weaponsTargeting != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fireControl2.weaponsFiring);

                if (playerSpaceShip.fireControl2.weaponsFiring != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored;
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                checkSystemOperational(playerSpaceShip.fireControl3.weaponsTargeting);

                if (playerSpaceShip.fireControl3.weaponsTargeting != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fireControl3.weaponsFiring);

                if (playerSpaceShip.fireControl3.weaponsFiring != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored;
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                checkSystemOperational(playerSpaceShip.fireControl4.weaponsTargeting);

                if (playerSpaceShip.fireControl4.weaponsTargeting != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored;
                }

                checkSystemOperational(playerSpaceShip.fireControl4.weaponsFiring);

                if (playerSpaceShip.fireControl4.weaponsFiring != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored;
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                checkSystemOperational(playerSpaceShip.medibay.surgeryTable);

                if (playerSpaceShip.medibay.surgeryTable != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.medibay.surgeryTable.currentPowerStored;
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {

                checkSystemOperational(playerSpaceShip.shuttleBay.hangar);

                if (playerSpaceShip.shuttleBay.hangar != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.shuttleBay.hangar.currentPowerStored;
                }

                if (playerSpaceShip.shuttleBay.repairBay != null)
                {
                    storedSystemPower = storedSystemPower + playerSpaceShip.shuttleBay.repairBay.currentPowerStored;
                }
            }

            return storedSystemPower;

        }
    }
}
//        public static void checkPowerSystemHierarchy(SpaceShip playerSpaceShip)//totally fucked
//        {
//            // make sure power systems have continuous hierarchy numbers

//            int numberOfSystems = countShipSystems(playerSpaceShip);
//            int nextHierarchyPosition = 1;
//            int positionsToCorrect = 0;

//            if (playerSpaceShip.fighterCockpit != null)
//                {
//                    if (playerSpaceShip.fighterCockpit.pilotControls != null)
//                    {
//                        if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fighterCockpit.temperatureControl != null)
//                    {
//                        if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fighterCockpit.airScrubber != null)
//                    {
//                        if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.fighterCockpit.heatExchanger != null)
//                    {
//                        if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.fighterCockpit.shields != null)
//                    {
//                        if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }
//                }

//                if (playerSpaceShip.bridge != null)
//                {
//                    if (playerSpaceShip.bridge.pilotControls != null)
//                    {
//                        if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.bridge.aI != null)
//                    {
//                        if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }


//                }

//                if (playerSpaceShip.engineering != null)
//                {

//                    if (playerSpaceShip.engineering.shields != null)
//                    {
//                        if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.engineering.engines != null)
//                    {
//                        if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.engineering.powerGenerator != null)
//                    {
//                        if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.engineering.fabricator != null)
//                    {
//                        if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                    if (playerSpaceShip.engineering.wasteDisposal != null)
//                    {
//                        if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.engineering.fuelStore != null)
//                    {
//                        if (playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }

//                }

//                if (playerSpaceShip.lifeSupport != null)
//                {
//                    if (playerSpaceShip.lifeSupport.airScrubber != null)
//                    {
//                        if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.lifeSupport.gravityGenerator != null)
//                    {
//                        if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.lifeSupport.temperatureControl != null)
//                    {
//                        if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }
//                }

//                if (playerSpaceShip.comms != null)
//                {

//                    if (playerSpaceShip.comms.transmitter != null)
//                    {
//                        if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.comms.receiver != null)
//                    {
//                        if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.comms.cryptography != null)
//                    {
//                        if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                }

//                if (playerSpaceShip.fireControl != null)
//                {

//                    if (playerSpaceShip.fireControl.weaponsTargeting != null)
//                    {
//                        if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.fireControl.weaponsFiring != null)
//                    {
//                        if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }


//                }

//                if (playerSpaceShip.fireControl2 != null)
//                {

//                    if (playerSpaceShip.fireControl2.weaponsTargeting != null)
//                    {
//                        if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                     }

//                    if (playerSpaceShip.fireControl2.weaponsFiring != null)
//                    {
//                        if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                }

//                if (playerSpaceShip.fireControl3 != null)
//                {
//                    if (playerSpaceShip.fireControl3.weaponsTargeting != null)
//                    {
//                        if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                        if (playerSpaceShip.fireControl3.weaponsFiring != null)
//                        {
//                            if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//                            {
//                                playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                                positionsToCorrect = positionsToCorrect + 1;
//                            }

//                        }
//                    }
//                }

//                if (playerSpaceShip.fireControl4 != null)
//                {
//                    if (playerSpaceShip.fireControl4.weaponsTargeting != null)
//                    {
//                        if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.fireControl4.weaponsFiring != null)
//                    {
//                        if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                }

//                if (playerSpaceShip.medibay != null)
//                {
//                    if (playerSpaceShip.medibay.surgeryTable != null)
//                    {
//                        if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }
//                }

//                if (playerSpaceShip.cargoHold != null)
//                {

//                }

//                if (playerSpaceShip.shuttleBay != null)
//                {

//                    if (playerSpaceShip.shuttleBay.hangar != null)
//                    {
//                        if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }

//                    }

//                    if (playerSpaceShip.shuttleBay.repairBay != null)
//                    {
//                        if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition > numberOfSystems)
//                        {
//                            playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition = numberOfSystems + 1;
//                            positionsToCorrect = positionsToCorrect + 1;
//                        }


//                    }
//                }
            
//            while (positionsToCorrect + nextHierarchyPosition < numberOfSystems +1)
//            {
//                if (playerSpaceShip.fighterCockpit != null)
//                {
//                    if (playerSpaceShip.fighterCockpit.pilotControls != null)
//                    {

//                        if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }

//                    }

//                    if (playerSpaceShip.fighterCockpit.temperatureControl != null)
//                    {

//                        if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fighterCockpit.airScrubber != null)
//                    {

//                        if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fighterCockpit.heatExchanger != null)
//                    {

//                        if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fighterCockpit.shields != null)
//                    {

//                        if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }
//                }

//                if (playerSpaceShip.bridge != null)
//                {
//                    if (playerSpaceShip.bridge.pilotControls != null)
//                    {

//                        if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.bridge.aI != null)
//                    {

//                        if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }


//                }

//                if (playerSpaceShip.engineering != null)
//                {

//                    if (playerSpaceShip.engineering.shields != null)
//                    {

//                        if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.engineering.engines != null)
//                    {

//                        if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.engineering.powerGenerator != null)
//                    {


//                        if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.engineering.fabricator != null)
//                    {

//                        if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.engineering.wasteDisposal != null)
//                    {

//                        if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.engineering.fuelStore != null)
//                    {

//                        if (playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                }

//                if (playerSpaceShip.lifeSupport != null)
//                {
//                    if (playerSpaceShip.lifeSupport.airScrubber != null)
//                    {

//                        if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.lifeSupport.gravityGenerator != null)
//                    {

//                        if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.lifeSupport.temperatureControl != null)
//                    {

//                        if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }
//                }

//                if (playerSpaceShip.comms != null)
//                {

//                    if (playerSpaceShip.comms.transmitter != null)
//                    {

//                        if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.comms.receiver != null)
//                    {

//                        if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.comms.cryptography != null)
//                    {

//                        if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                }

//                if (playerSpaceShip.fireControl != null)
//                {

//                    if (playerSpaceShip.fireControl.weaponsTargeting != null)
//                    {

//                        if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fireControl.weaponsFiring != null)
//                    {

//                        if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }


//                }

//                if (playerSpaceShip.fireControl2 != null)
//                {

//                    if (playerSpaceShip.fireControl2.weaponsTargeting != null)
//                    {

//                        if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fireControl2.weaponsFiring != null)
//                    {
                       
//                        if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                }

//                if (playerSpaceShip.fireControl3 != null)
//                {
//                    if (playerSpaceShip.fireControl3.weaponsTargeting != null)
//                    {


//                        if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fireControl3.weaponsFiring != null)
//                    {


//                        if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }
//                }

//                if (playerSpaceShip.fireControl4 != null)
//                {

//                    if (playerSpaceShip.fireControl4.weaponsTargeting != null)
//                    {


//                        if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.fireControl4.weaponsFiring != null)
//                    {


//                        if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                }

//                if (playerSpaceShip.medibay != null)
//                {
//                    if (playerSpaceShip.medibay.surgeryTable != null)
//                    {


//                        if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }
//                }

//                if (playerSpaceShip.cargoHold != null)
//                {

//                }

//                if (playerSpaceShip.shuttleBay != null)
//                {

//                    if (playerSpaceShip.shuttleBay.hangar != null)
//                    {

//                        if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }

//                    if (playerSpaceShip.shuttleBay.repairBay != null)
//                    {
//                        if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == nextHierarchyPosition)
//                        {
//                            nextHierarchyPosition = nextHierarchyPosition + 1;
//                        }
//                    }
//                }
//            }
//            //if (playerSpaceShip.fighterCockpit != null)
//            //{
//            //    if (playerSpaceShip.fighterCockpit.pilotControls != null)
//            //    {
//            //        if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.shuttleBay.pilotControls.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }

//            //    }

//            //    if (playerSpaceShip.fighterCockpit.temperatureControl != null)
//            //    {
//            //        if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.shuttleBay.temperatureControl.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fighterCockpit.airScrubber != null)
//            //    {
//            //        if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.shuttleBay.airScrubber.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fighterCockpit.heatExchanger != null)
//            //    {
//            //        if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.shuttleBay.heatExchanger.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fighterCockpit.shields != null)
//            //    {
//            //        if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.shuttleBay.shields.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }
//            //}

//            //if (playerSpaceShip.bridge != null)
//            //{
//            //    if (playerSpaceShip.bridge.pilotControls != null)
//            //    {
//            //        if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.bridge.aI != null)
//            //    {
//            //        if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }


//            //}

//            //if (playerSpaceShip.engineering != null)
//            //{

//            //    if (playerSpaceShip.engineering.shields != null)
//            //    {
//            //        if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.engineering.engines != null)
//            //    {
//            //        if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.engineering.powerGenerator != null)
//            //    {
//            //        if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.engineering.fabricator != null)
//            //    {
//            //        if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.engineering.wasteDisposal != null)
//            //    {
//            //        if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.engineering.fuelStore != null)
//            //    {
//            //        if (playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //}

//            //if (playerSpaceShip.lifeSupport != null)
//            //{
//            //    if (playerSpaceShip.lifeSupport.airScrubber != null)
//            //    {
//            //        if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.lifeSupport.gravityGenerator != null)
//            //    {
//            //        if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.lifeSupport.temperatureControl != null)
//            //    {
//            //        if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }
//            //}

//            //if (playerSpaceShip.comms != null)
//            //{

//            //    if (playerSpaceShip.comms.transmitter != null)
//            //    {
//            //        if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.comms.receiver != null)
//            //    {
//            //        if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.comms.cryptography != null)
//            //    {
//            //        if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //}

//            //if (playerSpaceShip.fireControl != null)
//            //{

//            //    if (playerSpaceShip.fireControl.weaponsTargeting != null)
//            //    {
//            //        if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fireControl.weaponsFiring != null)
//            //    {

//            //        if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.fireControl.repairBay.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }


//            //}

//            //if (playerSpaceShip.fireControl2 != null)
//            //{

//            //    if (playerSpaceShip.fireControl2.weaponsTargeting != null)
//            //    {
//            //        if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.fireControl2.repairBay.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fireControl2.weaponsFiring != null)
//            //    {
//            //        if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //            playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //        }
//            //    }

//            //}

//            //if (playerSpaceShip.fireControl3 != null)
//            //{
//            //    if (playerSpaceShip.fireControl3.weaponsTargeting != null)
//            //    {
//            //        if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fireControl3.weaponsFiring != null)
//            //    {
//            //        if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }
//            //}

//            //if (playerSpaceShip.fireControl4 != null)
//            //{

//            //    if (playerSpaceShip.fireControl4.weaponsTargeting != null)
//            //    {
//            //        if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.shuttleBay.weaponsTargeting.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }

//            //    if (playerSpaceShip.fireControl4.weaponsFiring != null)
//            //    {
//            //        if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }

//            //}

//            //if (playerSpaceShip.medibay != null)
//            //{
//            //    if (playerSpaceShip.medibay.surgeryTable != null)
//            //    {
//            //        if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }


//            //        if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }
//            //}

//            //if (playerSpaceShip.cargoHold != null)
//            //{

//            //}

//            //if (playerSpaceShip.shuttleBay != null)
//            //{

//            //    if (playerSpaceShip.shuttleBay.hangar != null)
//            //    {
//            //        if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }

//            //    if (playerSpaceShip.shuttleBay.repairBay != null)
//            //    {
//            //        if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition < nextHierarchyPosition)
//            //        {
//            //            playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition = numberOfSystems + 1;
//            //        }

//            //        if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition > numberOfSystems)
//            //        {
//            //            playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition = nextHierarchyPosition;
//            //            nextHierarchyPosition = nextHierarchyPosition + 1;
//            //        }
//            //    }
//            //}
//        }
//    }
//}
            
            
            
            

            

//                //playerSpaceShip.engineering.pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.shields = new ShipSystem("Shields", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.aI = new ShipSystem("A.I.", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.engines = new ShipSystem("Engines", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.fabricator = new ShipSystem("Fabricator", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.wasteDisposal = new ShipSystem("Waste Disposal", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.engineering.roomType);
//                //playerSpaceShip.engineering.airScrubber = new ShipSystem ("Air Scrubber", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.gravityGenerator = new ShipSystem ("Gravity Generator", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.temperatureControl = new ShipSystem ("Temperature Control", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.transmitter = new ShipSystem ("Transmitter", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.receiver = new ShipSystem ("Receiver", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.cryptography = new ShipSystem ("Cryptography", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.weaponsTargeting = new ShipSystem ("Weapons Targeting", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.weaponsFiring = new ShipSystem ("Weapons Firing", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.surgeryTable = new ShipSystem ("Surgery Table", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.hangar = new ShipSystem ("Hangar", playerSpaceShip.bridge.roomType);
//                //playerSpaceShip.engineering.repairBay = new ShipSystem ("Repair Bay", playerSpaceShip.bridge.roomType);


//            //    int fuelDifference = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).maxFuelLevel - ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel;

//            //    if (ShipSystemMethods.findSystemFuelStore(playerSpaceShip).fuelLevel == 0)
//            //    {
//            //        Console.WriteLine("Your fuel reserves have run dry");
//            //    }
//            //    else if ((ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel < ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).maxFuelLevel) && (fuelDifference < ShipSystemMethods.findSystemFuelStore(playerSpaceShip).fuelLevel))
//            //    {
//            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel - fuelDifference;
//            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel + fuelDifference;
//            //        Console.WriteLine("Generators primed.");
//            //    }
//            //    else if (fuelDifference >= ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel)
//            //    {
//            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel + ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel;
//            //        ShipSystemMethods.findSystemPowerGenerator(playerSpaceShip).fuelLevel = 0;
//            //        Console.WriteLine("You have just used the last of your fuel reserves priming your generators.");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Something Weird is happening in the fuel system.");
//            //    }

//            //}

//            //    return powerGeneratedThisTurn;
//            //}
//            //public static int powerHierarchyCycleThrough(SpaceShip playerSpaceShip, int hierarchyPosition, int currentPowerPool)
//            //{
//            //    while (currentPowerPool > 0)
//            //    {
//            //        foreach (Room room in playerSpaceShip.rooms)
//            //        {
//            //            foreach (ShipSystem shipSystem in room.shipSystems)
//            //            {
//            //                if (shipSystem.powerSupplyHierarchyPosition == hierarchyPosition)
//            //                {
//            //                    int powerDifference = shipSystem.maxPowerStorage - shipSystem.currentPowerStored;
//            //                    if (powerDifference < currentPowerPool)
//            //                    {
//            //                        shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
//            //                        currentPowerPool = currentPowerPool - powerDifference;
//            //                        return currentPowerPool;
//            //                    }
//            //                    else if (powerDifference >= currentPowerPool)
//            //                    {
//            //                        shipSystem.currentPowerStored = shipSystem.currentPowerStored + currentPowerPool;
//            //                        currentPowerPool = 0;
//            //                        return currentPowerPool;
//            //                    }
//            //                }
//            //            }
//            //        }
//            //    }
//            //    return currentPowerPool;
//            //}
//            //public static void distributePowerToSystems(SpaceShip playerSpaceShip, int currentPowerPool, int currentPowerRequirement)
//            //{
//            //    int numberOfSystems = 0;
//            //    if (currentPowerPool == currentPowerRequirement)
//            //    {
//            //        foreach (Room room in playerSpaceShip.rooms)
//            //        {
//            //            foreach (ShipSystem shipSystem in room.shipSystems)
//            //            {
//            //                shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
//            //            }
//            //        }
//            //        currentPowerPool = 0;
//            //    }
//            //    else if (currentPowerRequirement < currentPowerPool)
//            //    {
//            //        int leftoverPowerThisTick = currentPowerPool - currentPowerRequirement;
//            //        foreach (Room room in playerSpaceShip.rooms)
//            //        {
//            //            foreach (ShipSystem shipSystem in room.shipSystems)
//            //            {
//            //                numberOfSystems++;
//            //                shipSystem.currentPowerStored = shipSystem.maxPowerStorage;
//            //            }
//            //            int powerSystemOverload = leftoverPowerThisTick / numberOfSystems;
//            //            foreach (ShipSystem shipSystem in room.shipSystems)
//            //            {
//            //                shipSystem.currentTemperature = shipSystem.currentTemperature + powerSystemOverload;
//            //            }
//            //        }
//            //        currentPowerPool = 0;
//            //    }
//            //    else if (currentPowerRequirement > currentPowerPool)
//            //    {
//            //        foreach (Room room in playerSpaceShip.rooms)
//            //        {
//            //            foreach (ShipSystem shipSystem in room.shipSystems)
//            //            {
//            //                numberOfSystems++;
//            //            }
//            //        }
//            //        int hierarchyPosition = 1;
//            //        while (numberOfSystems >= hierarchyPosition)
//            //        {
//            //            currentPowerPool = PowerManagementMethods.powerHierarchyCycleThrough(playerSpaceShip, hierarchyPosition, currentPowerPool);
//            //            hierarchyPosition++;
//            //        }

//            //    }
//            //}
        
    

