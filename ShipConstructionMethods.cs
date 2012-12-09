using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class ShipConstructionMethods
    {
        public static SpaceShip initialShipCreation()
        {
            Console.WriteLine("Please name your vessel");
            string shipName = Console.ReadLine();
            SpaceShip playerSpaceShip = new SpaceShip(shipName);
            playerSpaceShip.shipName = shipName;
            return playerSpaceShip;
            
        }

        public static void chooseShipClass(SpaceShip playerSpaceShip)
        {              
            Console.WriteLine("What class of vessel do you want?");
            Console.WriteLine("");
            Console.WriteLine("A: Fighter");
            Console.WriteLine("B: Shuttle");
            Console.WriteLine("C: Frigate");
            Console.WriteLine("D: Cruiser");
            Console.WriteLine("E: Capital");
            Console.WriteLine("");
            
            bool isInputValid = false;
            string shipClassInput = Console.ReadLine();
            while (isInputValid == false)
            {
                switch (shipClassInput)
                {
                    case "A":

                        playerSpaceShip.shipType = "Fighter";
                        playerSpaceShip.maxStructureHitPoints = 1000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;

                        //playerSpaceShip.spaceShipPowerOverhead = 0;
                        playerSpaceShip.structureMass = 1000;
                        

                        //playerSpaceShip.requiredRooms = new string[1] { "Fighter Cockpit" };

                        isInputValid = true;

                        break;

                    case "B":
                        playerSpaceShip.shipType = "Shuttle";
                        playerSpaceShip.maxStructureHitPoints = 10000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;

                        //playerSpaceShip.spaceShipPowerOverhead = 0;
                        playerSpaceShip.structureMass = 10000;
                        

                        //playerSpaceShip.requiredRooms = new string[6] { "Bridge", "Engineering", "Life Support", "Comms", "Fire Control", "Cargo Hold" };

                        isInputValid = true;

                        break;

                    case "C":
                        playerSpaceShip.shipType = "Frigate";
                        playerSpaceShip.maxStructureHitPoints = 100000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;

                        //playerSpaceShip.spaceShipPowerOverhead = 0;
                        playerSpaceShip.structureMass = 100000;
                      

                        //playerSpaceShip.requiredRooms = new string[7] { "Bridge", "Engineering", "Life Support", "Comms", "Fire Control", "Fire Control 2", "Medibay" };

                        isInputValid = true;

                        break;

                    case "D":
                        playerSpaceShip.shipType = "Cruiser";
                        playerSpaceShip.maxStructureHitPoints = 1000000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;

                        //playerSpaceShip.spaceShipPowerOverhead = 0;
                        playerSpaceShip.structureMass = 1000000;
                        

                        //playerSpaceShip.requiredRooms = new string[9] { "Bridge", "Engineering", "Life Support", "Comms", "Fire Control", "Fire Control 2", "Fire Control 3", "Medibay", "Shuttle Bay" };

                        isInputValid = true;

                        break;

                    case "E":
                        playerSpaceShip.shipType = "Capital";
                        playerSpaceShip.maxStructureHitPoints = 10000000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;

                        //playerSpaceShip.spaceShipPowerOverhead = 0;
                        playerSpaceShip.structureMass = 10000000;
                        

                        //playerSpaceShip.requiredRooms = new string[10] { "Bridge", "Engineering", "Life Support", "Comms", "Fire Control", "Fire Control 2", "Fire Control 3", "Fire Control 4", "Medibay", "Shuttle Bay" };

                        isInputValid = true;

                        break;

                    default:

                        Console.WriteLine("That is not a valid selection, please try again.");
                        shipClassInput = Console.ReadLine();

                        break;
                }


            } 
        }

        public static void setShipRooms(SpaceShip playerSpaceShip)
        {
            if (playerSpaceShip.shipType == "Fighter")
            {
                playerSpaceShip.fighterCockpit = new Room("Fighter Cockpit");
                playerSpaceShip.isFighter = true;
            }

            else
            {
                playerSpaceShip.isFighter = false;
            }

            if (playerSpaceShip.shipType == "Shuttle")
            {
                playerSpaceShip.bridge = new Room("Bridge");
                playerSpaceShip.engineering = new Room("Engineering");
                playerSpaceShip.lifeSupport = new Room("Life Support");
                playerSpaceShip.comms = new Room("Comms");
                playerSpaceShip.fireControl = new Room("Fire Control");
                playerSpaceShip.cargoHold = new Room("Cargo Hold");
            }
            if (playerSpaceShip.shipType == "Frigate")
            {
                playerSpaceShip.bridge = new Room("Bridge");
                playerSpaceShip.engineering = new Room("Engineering");
                playerSpaceShip.lifeSupport = new Room("Life Support");
                playerSpaceShip.comms = new Room("Comms");
                playerSpaceShip.fireControl = new Room("Fire Control");
                playerSpaceShip.fireControl2 = new Room("Fire Control 2");
                playerSpaceShip.medibay = new Room("Medibay");
            }
            if (playerSpaceShip.shipType == "Cruiser")
            {
                playerSpaceShip.bridge = new Room("Bridge");
                playerSpaceShip.engineering = new Room("Engineering");
                playerSpaceShip.lifeSupport = new Room("Life Support");
                playerSpaceShip.comms = new Room("Comms");
                playerSpaceShip.fireControl = new Room("Fire Control");
                playerSpaceShip.fireControl2 = new Room("Fire Control 2");
                playerSpaceShip.fireControl3 = new Room("Fire Control 3");
                playerSpaceShip.medibay = new Room("Medibay");
                playerSpaceShip.shuttleBay = new Room("Shuttle Bay");

            }
            if (playerSpaceShip.shipType == "Capital")
            {

                playerSpaceShip.bridge = new Room("Bridge");
                playerSpaceShip.engineering = new Room("Engineering");
                playerSpaceShip.lifeSupport = new Room("Life Support");
                playerSpaceShip.comms = new Room("Comms");
                playerSpaceShip.fireControl = new Room("Fire Control");
                playerSpaceShip.fireControl2 = new Room("Fire Control 2");
                playerSpaceShip.fireControl3 = new Room("Fire Control 3");
                playerSpaceShip.fireControl4 = new Room("Fire Control 4");
                playerSpaceShip.medibay = new Room("Medibay");
                playerSpaceShip.shuttleBay = new Room("Shuttle Bay");
            }
        }

        public static void setShipSystems(SpaceShip playerSpaceShip)
        {
            if (playerSpaceShip.fighterCockpit != null)
            {
                playerSpaceShip.fighterCockpit.pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.temperatureControl = new ShipSystem("Temperature Control", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.airScrubber = new ShipSystem("Air Scrubber", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.heatExchanger = new ShipSystem("Heat Exchanger", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.shields = new ShipSystem("Shields", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.engines = new ShipSystem("Engines", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.transmitter = new ShipSystem("Transmitter", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.receiver = new ShipSystem("Receiver", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.cryptography = new ShipSystem("Cryptography", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.powerDistributor = new ShipSystem("Power Distributor", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.fighterCockpit.roomType);
                playerSpaceShip.fighterCockpit.shipCapacitor = new ShipSystem("Capacitor", playerSpaceShip.fighterCockpit.roomType);

            }

            if (playerSpaceShip.bridge != null)
            {
                playerSpaceShip.bridge.pilotControls = new ShipSystem ("Pilot Controls", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.shields = new ShipSystem ("Shields", playerSpaceShip.bridge.roomType);
                playerSpaceShip.bridge.aI = new ShipSystem ("A.I.", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.engines = new ShipSystem ("Engines", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.powerGenerator = new ShipSystem ("Power Generator", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.fabricator = new ShipSystem ("Fabricator", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.wasteDisposal = new ShipSystem ("Waste Disposal", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.fuelStore = new ShipSystem ("Fuel Store", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.airScrubber = new ShipSystem ("Air Scrubber", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.gravityGenerator = new ShipSystem ("Gravity Generator", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.temperatureControl = new ShipSystem ("Temperature Control", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.transmitter = new ShipSystem ("Transmitter", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.receiver = new ShipSystem ("Receiver", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.cryptography = new ShipSystem ("Cryptography", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.weaponsTargeting = new ShipSystem ("Weapons Targeting", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.weaponsFiring = new ShipSystem ("Weapons Firing", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.surgeryTable = new ShipSystem ("Surgery Table", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.hangar = new ShipSystem ("Hangar", playerSpaceShip.bridge.roomType);
                //playerSpaceShip.bridge.repairBay = new ShipSystem ("Repair Bay", playerSpaceShip.bridge.roomType);
            }

            if (playerSpaceShip.engineering != null)
            {
                //playerSpaceShip.engineering.pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.bridge.roomType);
                playerSpaceShip.engineering.shields = new ShipSystem("Shields", playerSpaceShip.engineering.roomType);
                //playerSpaceShip.engineering.aI = new ShipSystem("A.I.", playerSpaceShip.bridge.roomType);
                playerSpaceShip.engineering.engines = new ShipSystem("Engines", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.fabricator = new ShipSystem("Fabricator", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.wasteDisposal = new ShipSystem("Waste Disposal", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.powerDistributor = new ShipSystem("Power Distributor", playerSpaceShip.engineering.roomType);
                playerSpaceShip.engineering.shipCapacitor = new ShipSystem("Capacitor", playerSpaceShip.engineering.roomType);
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
            }

            if (playerSpaceShip.lifeSupport != null)
            {

                playerSpaceShip.lifeSupport.airScrubber = new ShipSystem("Air Scrubber", playerSpaceShip.lifeSupport.roomType);
                playerSpaceShip.lifeSupport.gravityGenerator = new ShipSystem("Gravity Generator", playerSpaceShip.lifeSupport.roomType);
                playerSpaceShip.lifeSupport.temperatureControl = new ShipSystem("Temperature Control", playerSpaceShip.lifeSupport.roomType);

            }

            if (playerSpaceShip.comms != null)
            {

                playerSpaceShip.comms.transmitter = new ShipSystem("Transmitter", playerSpaceShip.comms.roomType);
                playerSpaceShip.comms.receiver = new ShipSystem("Receiver", playerSpaceShip.comms.roomType);
                playerSpaceShip.comms.cryptography = new ShipSystem("Cryptography", playerSpaceShip.comms.roomType);

            }

            if (playerSpaceShip.fireControl != null)
            {

                playerSpaceShip.fireControl.weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.fireControl.roomType);
                playerSpaceShip.fireControl.weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.fireControl.roomType);

            }

            if (playerSpaceShip.fireControl2 != null)
            {

                playerSpaceShip.fireControl2.weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.fireControl2.roomType);
                playerSpaceShip.fireControl2.weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.fireControl2.roomType);

            }

            if (playerSpaceShip.fireControl3 != null)
            {

                playerSpaceShip.fireControl3.weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.fireControl3.roomType);
                playerSpaceShip.fireControl3.weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.fireControl3.roomType);

            }

            if (playerSpaceShip.fireControl4 != null)
            {

                playerSpaceShip.fireControl4.weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.fireControl4.roomType);
                playerSpaceShip.fireControl4.weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.fireControl4.roomType);

            }

            if (playerSpaceShip.medibay != null)
            {
                playerSpaceShip.medibay.surgeryTable = new ShipSystem("Surgery Table", playerSpaceShip.medibay.roomType);
            }

            if (playerSpaceShip.cargoHold != null)
            {

            }

            if (playerSpaceShip.shuttleBay != null)
            {
                playerSpaceShip.shuttleBay.hangar = new ShipSystem("Hangar", playerSpaceShip.shuttleBay.roomType);
                playerSpaceShip.shuttleBay.repairBay = new ShipSystem("Repair Bay", playerSpaceShip.shuttleBay.roomType);
            }

        }

        //public static void calculateShipHitPoints(SpaceShip playerSpaceShip)
        //{
        //    int shipHitPointsRunningTotal = 0;

        //    shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.maxStructureHitPoints;

        //    if (playerSpaceShip.fighterCockpit != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.fighterCockpit.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.bridge != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.bridge.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.engineering != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.engineering.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.lifeSupport != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.lifeSupport.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.comms != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.comms.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.fireControl != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.fireControl.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.fireControl2 != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.fireControl2.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.fireControl3 != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.fireControl3.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.fireControl4 != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.fireControl4.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.medibay != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.medibay.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.cargoHold != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.cargoHold.maxBulkheadHitPoints;
        //    }

        //    if (playerSpaceShip.shuttleBay != null)
        //    {
        //        shipHitPointsRunningTotal = shipHitPointsRunningTotal + playerSpaceShip.shuttleBay.maxBulkheadHitPoints;
        //    }

        //    playerSpaceShip.maxTotalHitPoints = shipHitPointsRunningTotal;

        //}



    }
}
