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
                        playerSpaceShip.structuralAirPressure = 26;
                        
                        
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
                        playerSpaceShip.structuralAirPressure = 26;
                        

                        //playerSpaceShip.requiredRooms = new string[6] { "Bridge", "Engineering", "Life Support", "Comms", "Fire Control", "Cargo Hold" };

                        isInputValid = true;

                        break;

                    case "C":
                        playerSpaceShip.shipType = "Frigate";
                        playerSpaceShip.maxStructureHitPoints = 100000;
                        playerSpaceShip.maxTotalHitPoints = 0;
                        playerSpaceShip.operationalHitPointThreshold = 0;
                        playerSpaceShip.structuralAirPressure = 26;
                       
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
                        playerSpaceShip.structuralAirPressure = 26;

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
                        playerSpaceShip.structuralAirPressure = 26;

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
            playerSpaceShip.rooms = new List<Room>();

            if (playerSpaceShip.shipType == "Fighter")
            {
                playerSpaceShip.rooms.Add (new Room ("Fighter Cockpit"));
                playerSpaceShip.isFighter = true;
            }

            else
            {
                playerSpaceShip.isFighter = false;
            }

            if (playerSpaceShip.shipType == "Shuttle")
            {
                Room bridge = new Room("Bridge");

                playerSpaceShip.rooms.Add (bridge);
                playerSpaceShip.rooms.Add ( new Room("Engineering"));
                playerSpaceShip.rooms.Add ( new Room("Life Support"));
                playerSpaceShip.rooms.Add ( new Room("Comms"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control"));
                playerSpaceShip.rooms.Add ( new Room("Cargo Hold"));
            }
            if (playerSpaceShip.shipType == "Frigate")
            {
                playerSpaceShip.rooms.Add ( new Room("Bridge"));
                playerSpaceShip.rooms.Add ( new Room("Engineering"));
                playerSpaceShip.rooms.Add ( new Room("Life Support"));
                playerSpaceShip.rooms.Add ( new Room("Comms"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 2"));
                playerSpaceShip.rooms.Add ( new Room("Medibay"));
            }
            if (playerSpaceShip.shipType == "Cruiser")
            {
                playerSpaceShip.rooms.Add ( new Room("Bridge"));
                playerSpaceShip.rooms.Add ( new Room("Engineering"));
                playerSpaceShip.rooms.Add ( new Room("Life Support"));
                playerSpaceShip.rooms.Add ( new Room("Comms"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 2"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 3"));
                playerSpaceShip.rooms.Add ( new Room("Medibay"));
                playerSpaceShip.rooms.Add ( new Room("Shuttle Bay"));

            }
            if (playerSpaceShip.shipType == "Capital")
            {
                playerSpaceShip.rooms.Add ( new Room("Bridge"));
                playerSpaceShip.rooms.Add ( new Room("Engineering"));
                playerSpaceShip.rooms.Add ( new Room("Life Support"));
                playerSpaceShip.rooms.Add ( new Room("Comms"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 2"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 3"));
                playerSpaceShip.rooms.Add ( new Room("Fire Control 4"));
                playerSpaceShip.rooms.Add ( new Room("Medibay"));
                playerSpaceShip.rooms.Add ( new Room("Shuttle Bay"));
            }
        }

        public static void setShipSystems(SpaceShip playerSpaceShip)
        {
            if (playerSpaceShip.getSpecificRoom("Fighter Cockpit") != null)
            {
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").temperatureControl = new ShipSystem("Temperature Control", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").airScrubber = new ShipSystem("Air Scrubber", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").heatExchanger = new ShipSystem("Heat Exchanger", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").shields = new ShipSystem("Shields", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").engines = new ShipSystem("Engines", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").transmitter = new ShipSystem("Transmitter", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").receiver = new ShipSystem("Receiver", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").cryptography = new ShipSystem("Cryptography", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").powerDistributor = new ShipSystem("Power Distributor", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);
                playerSpaceShip.getSpecificRoom("Fighter Cockpit").shipCapacitor = new ShipSystem("Capacitor", playerSpaceShip.getSpecificRoom("Fighter Cockpit").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Bridge") != null)
            {
                playerSpaceShip.getSpecificRoom("Bridge").pilotControls = new ShipSystem("Pilot Controls", playerSpaceShip.getSpecificRoom("Bridge").roomType);
                
                playerSpaceShip.getSpecificRoom("Bridge").aI = new ShipSystem("A.I.", playerSpaceShip.getSpecificRoom("Bridge").roomType);
                
            }

            if (playerSpaceShip.getSpecificRoom("Engineering") != null)
            {
                playerSpaceShip.getSpecificRoom("Engineering").shields = new ShipSystem("Shields", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").engines = new ShipSystem("Engines", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").powerGenerator = new ShipSystem("Power Generator", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").fabricator = new ShipSystem("Fabricator", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").wasteDisposal = new ShipSystem("Waste Disposal", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").fuelStore = new ShipSystem("Fuel Store", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").powerDistributor = new ShipSystem("Power Distributor", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                playerSpaceShip.getSpecificRoom("Engineering").shipCapacitor = new ShipSystem("Capacitor", playerSpaceShip.getSpecificRoom("Engineering").roomType);
                
                //playerSpaceShip.engineering.repairBay = new ShipSystem ("Repair Bay", playerSpaceShip.bridge.roomType);
            }

            if (playerSpaceShip.getSpecificRoom("Life Support") != null)
            {

                playerSpaceShip.getSpecificRoom("Life Support").airScrubber = new ShipSystem("Air Scrubber", playerSpaceShip.getSpecificRoom("Life Support").roomType);
                playerSpaceShip.getSpecificRoom("Life Support").gravityGenerator = new ShipSystem("Gravity Generator", playerSpaceShip.getSpecificRoom("Life Support").roomType);
                playerSpaceShip.getSpecificRoom("Life Support").temperatureControl = new ShipSystem("Temperature Control", playerSpaceShip.getSpecificRoom("Life Support").roomType);
                playerSpaceShip.getSpecificRoom("Life Support").airPump = new ShipSystem("Air Pump", playerSpaceShip.getSpecificRoom("Life Support").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Comms") != null)
            {

                playerSpaceShip.getSpecificRoom("Comms").transmitter = new ShipSystem("Transmitter", playerSpaceShip.getSpecificRoom("Comms").roomType);
                playerSpaceShip.getSpecificRoom("Comms").receiver = new ShipSystem("Receiver", playerSpaceShip.getSpecificRoom("Comms").roomType);
                playerSpaceShip.getSpecificRoom("Comms").cryptography = new ShipSystem("Cryptography", playerSpaceShip.getSpecificRoom("Comms").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Fire Control") != null)
            {

                playerSpaceShip.getSpecificRoom("Fire Control").weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.getSpecificRoom("Fire Control").roomType);
                playerSpaceShip.getSpecificRoom("Fire Control").weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.getSpecificRoom("Fire Control").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Fire Control 2") != null)
            {

                playerSpaceShip.getSpecificRoom("Fire Control 2").weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.getSpecificRoom("Fire Control 2").roomType);
                playerSpaceShip.getSpecificRoom("Fire Control 2").weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.getSpecificRoom("Fire Control 2").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Fire Control 3") != null)
            {

                playerSpaceShip.getSpecificRoom("Fire Control 3").weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.getSpecificRoom("Fire Control 3").roomType);
                playerSpaceShip.getSpecificRoom("Fire Control 3").weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.getSpecificRoom("Fire Control 3").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Fire Control 4") != null)
            {

                playerSpaceShip.getSpecificRoom("Fire Control 4").weaponsTargeting = new ShipSystem("Weapons Targeting", playerSpaceShip.getSpecificRoom("Fire Control 4").roomType);
                playerSpaceShip.getSpecificRoom("Fire Control 4").weaponsFiring = new ShipSystem("Weapons Firing", playerSpaceShip.getSpecificRoom("Fire Control 4").roomType);

            }

            if (playerSpaceShip.getSpecificRoom("Medibay") != null)
            {
                playerSpaceShip.getSpecificRoom("Medibay").surgeryTable = new ShipSystem("Surgery Table", playerSpaceShip.getSpecificRoom("Medibay").roomType);
            }

            if (playerSpaceShip.getSpecificRoom("Cargo Hold") != null)
            {

            }

            if (playerSpaceShip.getSpecificRoom("Shuttle Bay") != null)
            {
                playerSpaceShip.getSpecificRoom("Shuttle Bay").hangar = new ShipSystem("Hangar", playerSpaceShip.getSpecificRoom("Shuttle Bay").roomType);
                playerSpaceShip.getSpecificRoom("Shuttle Bay").repairBay = new ShipSystem("Repair Bay", playerSpaceShip.getSpecificRoom("Shuttle Bay").roomType);
            }

        }





    }
}
