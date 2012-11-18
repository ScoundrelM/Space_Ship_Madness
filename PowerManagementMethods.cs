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

        public static void abundantSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {

            if (playerSpaceShip.fighterCockpit != null)
            {
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls.maxPowerStorage, playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.temperatureControl.maxPowerStorage, playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber.maxPowerStorage, playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger.maxPowerStorage, playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields.maxPowerStorage, playerSpaceShip.fighterCockpit.shields.currentPowerStored);
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls.maxPowerStorage, playerSpaceShip.bridge.pilotControls.currentPowerStored);
                }

                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI.maxPowerStorage, playerSpaceShip.bridge.aI.currentPowerStored);
                }
            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields.maxPowerStorage, playerSpaceShip.engineering.shields.currentPowerStored);
                }

                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines.maxPowerStorage, playerSpaceShip.engineering.engines.currentPowerStored);
                }

                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator.maxPowerStorage, playerSpaceShip.engineering.powerGenerator.currentPowerStored);
                }

                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator.maxPowerStorage, playerSpaceShip.engineering.fabricator.currentPowerStored);
                }

                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal.maxPowerStorage, playerSpaceShip.engineering.wasteDisposal.currentPowerStored);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {

                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber.maxPowerStorage, playerSpaceShip.lifeSupport.airScrubber.currentPowerStored);
                }

                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator.maxPowerStorage, playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored);
                }

                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl.maxPowerStorage, playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored);
                }

            }

            if (playerSpaceShip.comms != null)
            {

                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter.maxPowerStorage, playerSpaceShip.comms.transmitter.currentPowerStored);
                }

                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver.maxPowerStorage, playerSpaceShip.comms.receiver.currentPowerStored);
                }

                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography.maxPowerStorage, playerSpaceShip.comms.cryptography.currentPowerStored);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {

                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {

                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting.maxPowerStorage, playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring.maxPowerStorage, playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable.maxPowerStorage, playerSpaceShip.medibay.surgeryTable.currentPowerStored);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar.maxPowerStorage, playerSpaceShip.shuttleBay.hangar.currentPowerStored);
                }

                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyOverflowPowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay.maxPowerStorage, playerSpaceShip.shuttleBay.repairBay.currentPowerStored);
                }
            }
        }

        public static void limitedSupplySystemPowerHierarchy(SpaceShip playerSpaceShip, int powerHierarchyPosition)
        {

            if (playerSpaceShip.fighterCockpit != null)
            {
                if (playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.pilotControls.operationalPowerConsumption ,playerSpaceShip.fighterCockpit.pilotControls.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.temperatureControl.operationalPowerConsumption, playerSpaceShip.fighterCockpit.temperatureControl.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.airScrubber.operationalPowerConsumption, playerSpaceShip.fighterCockpit.airScrubber.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.heatExchanger.operationalPowerConsumption, playerSpaceShip.fighterCockpit.heatExchanger.currentPowerStored);
                }

                if (playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fighterCockpit.shields.operationalPowerConsumption, playerSpaceShip.fighterCockpit.shields.currentPowerStored);
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                if (playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.pilotControls.operationalPowerConsumption, playerSpaceShip.bridge.pilotControls.currentPowerStored);
                }

                if (playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.bridge.aI.operationalPowerConsumption, playerSpaceShip.bridge.aI.currentPowerStored);
                }
            }

            if (playerSpaceShip.engineering != null)
            {

                if (playerSpaceShip.engineering.shields.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.shields.operationalPowerConsumption, playerSpaceShip.engineering.shields.currentPowerStored);
                }

                if (playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.engines.operationalPowerConsumption, playerSpaceShip.engineering.engines.currentPowerStored);
                }

                if (playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.powerGenerator.operationalPowerConsumption, playerSpaceShip.engineering.powerGenerator.currentPowerStored);
                }

                if (playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.fabricator.operationalPowerConsumption, playerSpaceShip.engineering.fabricator.currentPowerStored);
                }

                if (playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.engineering.wasteDisposal.operationalPowerConsumption, playerSpaceShip.engineering.wasteDisposal.currentPowerStored);
                }
            }

            if (playerSpaceShip.lifeSupport != null)
            {

                if (playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.airScrubber.operationalPowerConsumption, playerSpaceShip.lifeSupport.airScrubber.currentPowerStored);
                }

                if (playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.gravityGenerator.operationalPowerConsumption, playerSpaceShip.lifeSupport.gravityGenerator.currentPowerStored);
                }

                if (playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.lifeSupport.temperatureControl.operationalPowerConsumption, playerSpaceShip.lifeSupport.temperatureControl.currentPowerStored);
                }

            }

            if (playerSpaceShip.comms != null)
            {

                if (playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.transmitter.operationalPowerConsumption, playerSpaceShip.comms.transmitter.currentPowerStored);
                }

                if (playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.receiver.operationalPowerConsumption, playerSpaceShip.comms.receiver.currentPowerStored);
                }

                if (playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.comms.cryptography.operationalPowerConsumption, playerSpaceShip.comms.cryptography.currentPowerStored);
                }
            }

            if (playerSpaceShip.fireControl != null)
            {

                if (playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl2 != null)
            {

                if (playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl2.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl2.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl2.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                if (playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl3.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl3.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl3.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                if (playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsTargeting.operationalPowerConsumption, playerSpaceShip.fireControl4.weaponsTargeting.currentPowerStored);
                }

                if (playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.fireControl4.weaponsFiring.operationalPowerConsumption, playerSpaceShip.fireControl4.weaponsFiring.currentPowerStored);
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                if (playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.medibay.surgeryTable.operationalPowerConsumption, playerSpaceShip.medibay.surgeryTable.currentPowerStored);
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                if (playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.hangar.operationalPowerConsumption, playerSpaceShip.shuttleBay.hangar.currentPowerStored);
                }

                if (playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition == powerHierarchyPosition)
                {
                    dishOutHierarchyBasePowerpacket(playerSpaceShip, playerSpaceShip.shuttleBay.repairBay.operationalPowerConsumption, playerSpaceShip.shuttleBay.repairBay.currentPowerStored);
                }
            }
        }



        public static void dishOutHierarchyOverflowPowerpacket(SpaceShip playerSpaceShip, int systemMaxPowerStored, int systemCurrentPowerStored)
        {
            int powerStorageSpace = systemMaxPowerStored - systemCurrentPowerStored;

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
        }

        public static void dishOutHierarchyBasePowerpacket(SpaceShip playerSpaceShip, int systemPowerOverhead, int systemCurrentPowerStored)
        {

            if (playerSpaceShip.powerPool > 0)
            {
                if (playerSpaceShip.powerPool > systemPowerOverhead)
                {
                    playerSpaceShip.powerPool = playerSpaceShip.powerPool - systemPowerOverhead;
                }

                if (playerSpaceShip.powerPool < systemPowerOverhead)
                {
                    if ((playerSpaceShip.powerPool + systemCurrentPowerStored) > systemPowerOverhead)
                    {
                        systemCurrentPowerStored = systemCurrentPowerStored - (systemPowerOverhead - playerSpaceShip.powerPool);
                    }

                    if ((playerSpaceShip.powerPool + systemCurrentPowerStored) < systemPowerOverhead)
                    {
                        systemCurrentPowerStored = 0;
                    }
                }
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
        
    

