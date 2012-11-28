using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class PowerHierarchy
    {
        List<KeyValuePair <string, int>> hierarchy = null;
        int numberOfShipSystems;

        public void createHierarchyList(SpaceShip playerSpaceShip)
        {
            
            hierarchy = new List<KeyValuePair<string, int>>();

            if (playerSpaceShip.fighterCockpit != null)
            {


                if (playerSpaceShip.fighterCockpit.pilotControls != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fighterCockpit.pilotControls.systemName, playerSpaceShip.fighterCockpit.pilotControls.powerSupplyHierarchyPosition));
                }
                

                if (playerSpaceShip.fighterCockpit.temperatureControl != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fighterCockpit.temperatureControl.systemName, playerSpaceShip.fighterCockpit.temperatureControl.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.fighterCockpit.airScrubber != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fighterCockpit.airScrubber.systemName, playerSpaceShip.fighterCockpit.airScrubber.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.fighterCockpit.heatExchanger != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fighterCockpit.heatExchanger.systemName, playerSpaceShip.fighterCockpit.heatExchanger.powerSupplyHierarchyPosition));
                }

               

                if (playerSpaceShip.fighterCockpit.shields != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fighterCockpit.shields.systemName, playerSpaceShip.fighterCockpit.shields.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.bridge != null)
            {
                

                if (playerSpaceShip.bridge.pilotControls != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.bridge.pilotControls.systemName, playerSpaceShip.bridge.pilotControls.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.bridge.aI != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.bridge.aI.systemName, playerSpaceShip.bridge.aI.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.engineering != null)
            {
                

                if (playerSpaceShip.engineering.powerDistributor != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.powerDistributor.systemName, playerSpaceShip.engineering.powerDistributor.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.engineering.engines != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.engines.systemName, playerSpaceShip.engineering.engines.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.engineering.powerGenerator != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.powerGenerator.systemName, playerSpaceShip.engineering.powerGenerator.powerSupplyHierarchyPosition));
                }

                if (playerSpaceShip.engineering.fabricator != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.fabricator.systemName, playerSpaceShip.engineering.fabricator.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.engineering.wasteDisposal != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.wasteDisposal.systemName, playerSpaceShip.engineering.wasteDisposal.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.engineering.fuelStore != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.engineering.fuelStore.systemName, playerSpaceShip.engineering.fuelStore.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.lifeSupport != null)
            {
                

                if (playerSpaceShip.lifeSupport.airScrubber != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.lifeSupport.airScrubber.systemName, playerSpaceShip.lifeSupport.airScrubber.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.lifeSupport.gravityGenerator != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.lifeSupport.gravityGenerator.systemName, playerSpaceShip.lifeSupport.gravityGenerator.powerSupplyHierarchyPosition));
                }

               

                if (playerSpaceShip.lifeSupport.temperatureControl != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.lifeSupport.temperatureControl.systemName, playerSpaceShip.lifeSupport.temperatureControl.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.comms != null)
            {
                

                if (playerSpaceShip.comms.transmitter != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.comms.transmitter.systemName, playerSpaceShip.comms.transmitter.powerSupplyHierarchyPosition));
                }

               

                if (playerSpaceShip.comms.receiver != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.comms.receiver.systemName, playerSpaceShip.comms.receiver.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.comms.cryptography != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.comms.cryptography.systemName, playerSpaceShip.comms.cryptography.powerSupplyHierarchyPosition));
                }
            }

            if (playerSpaceShip.fireControl != null)
            {

                

                if (playerSpaceShip.fireControl.weaponsTargeting != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl.weaponsTargeting.systemName, playerSpaceShip.fireControl.weaponsTargeting.powerSupplyHierarchyPosition));
                }

               

                if (playerSpaceShip.fireControl.weaponsFiring != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl.weaponsFiring.systemName, playerSpaceShip.fireControl.weaponsFiring.powerSupplyHierarchyPosition));
                }


            }

            if (playerSpaceShip.fireControl2 != null)
            {

                

                if (playerSpaceShip.fireControl2.weaponsTargeting != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl2.weaponsTargeting.systemName, playerSpaceShip.fireControl2.weaponsTargeting.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.fireControl2.weaponsFiring != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl2.weaponsFiring.systemName, playerSpaceShip.fireControl2.weaponsFiring.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.fireControl3 != null)
            {
                

                if (playerSpaceShip.fireControl3.weaponsTargeting != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl3.weaponsTargeting.systemName, playerSpaceShip.fireControl3.weaponsTargeting.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.fireControl3.weaponsFiring != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl3.weaponsFiring.systemName, playerSpaceShip.fireControl3.weaponsFiring.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.fireControl4 != null)
            {

               

                if (playerSpaceShip.fireControl4.weaponsTargeting != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl4.weaponsTargeting.systemName, playerSpaceShip.fireControl4.weaponsTargeting.powerSupplyHierarchyPosition));
                }

                

                if (playerSpaceShip.fireControl4.weaponsFiring != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.fireControl4.weaponsFiring.systemName, playerSpaceShip.fireControl4.weaponsFiring.powerSupplyHierarchyPosition));
                }

            }

            if (playerSpaceShip.medibay != null)
            {
                

                if (playerSpaceShip.medibay.surgeryTable != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.medibay.surgeryTable.systemName, playerSpaceShip.medibay.surgeryTable.powerSupplyHierarchyPosition));
                }
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {

                

                if (playerSpaceShip.shuttleBay.hangar != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.shuttleBay.hangar.systemName, playerSpaceShip.shuttleBay.hangar.powerSupplyHierarchyPosition));
                }

                if (playerSpaceShip.shuttleBay.repairBay != null)
                {
                    hierarchy.Add(new KeyValuePair<string, int>(playerSpaceShip.shuttleBay.repairBay.systemName, playerSpaceShip.shuttleBay.repairBay.powerSupplyHierarchyPosition));
                }
            }

        }


        public void checkForDuplicateValues(SpaceShip playerSpaceShip)
        {
            
        }

        public void checkForGaps()
        {

        }

        public void correctHierarchErrors()
        {

        }

        public void applyHierarchy()
        {

        }

    }
}
