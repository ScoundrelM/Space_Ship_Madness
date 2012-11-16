using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class ShipSystemMethods
    {
        //public static ShipSystem findSystemPilotControls(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Pilot Controls":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemShields(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Shields":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemAI(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "A.I.":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemEngines(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Engines":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemPowerGenerator(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Power Generator":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemFabricator(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Fabricator":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWasteDisposal(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Waste Disposal":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemFuelStore(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Fuel Store":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            } return null;
        //        }
        //    } return null;
        //}
        
        //public static ShipSystem findSystemAirScrubbers(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Air Scrubbers":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemGravityGenerator(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Gravity Generator":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemTemperatureControl(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Temperature Control":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemTransmitter(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Transmitter":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemReceiver(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Receiver":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemCryptography(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Cryptography":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsFiring4(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Firing 4":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsFiring3(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Firing 3":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsFiring2(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Firing 2":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsFiring1(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Firing 1":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsTargeting4(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Targeting 4":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsTargeting3(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Targeting 3":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsTargeting2(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Targeting 2":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemWeaponsTargeting1(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Weapons Targeting 1":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemSurgeryTable(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Surgery Table":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemHangar(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Hangar":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}

        //public static ShipSystem findSystemRepairBay(SpaceShip playerSpaceShip)
        //{
        //    foreach (Room room in playerSpaceShip.rooms)
        //    {
        //        foreach (ShipSystem shipSystem in room.shipSystems)
        //        {
        //            switch (shipSystem.name)
        //            {
        //                case "Repair bay":

        //                    return shipSystem;

        //                default:

        //                    break;
        //            }
        //            return null;
        //        }
        //    } return null;
        //}


        /* "Pilot Controls"
         * 
         * This system controls the movement of the ship as a whole in space.
         * Links to the engines for thrust and has control over the throttle. Also controls the many small orientation engines on the ship exterior that rotate it independant of its
         * direction of travel.
         * Not really relevant until the ship movement methods are on the go.
              
         * "Shields"
         *
         * Controls the orientation of the sheilds relative to the ship. Fore, aft, port and starboard.
         * The system has a power buffer that is used to recharge and overcharge the shields. Overcharging increases shielding but the boost decreases over time.
         * Overcharging also causes the system to heat up.

         * "A.I."
         * 
         * This system allows you to automate some other systems.

         * "Engines"
         * 
         * The engines have a power buffer which can be accessed by the pilot controls and the engines have an efficiency at which they can convert it to thrust.
         * These are the engines that provide directional thrust to the whole ship. Orientation of the ship is controlled by the pilot controls. Orientating the ship
         * does not consume engine power.

         * "Power Generator"
         * 
         * This system Takes fuel and converts it into power for systems, can be run in overdrive to produce more but this will cause heat to build up.

         * "Fabricator"
         *
         * This system takes power and converts it into materials. Materials are used to repair broken systems and also produce crew equipment.
              
         * "Waste Disposal"
         * 
         * This system takes waste materials and converts them into fuel.
              
         * "Fuel Store"
         * 
         * This is where the fuel is stored. Doesn't really do anything except maybe explode if it gets severely damaged.
              
         * "Air Scrubbers"
         * 
         * This system cleans the air in the room, removing toxins and replenishing oxygen levels. I'm not sure whether to make it one scrubber per room or a central system.
              
         * "Gravity Generator"
         * 
         * This controls whether the crew experience local gravity.
              
         * "Temperature Control"
         * 
         * This system maintains the air temperature in rooms. Each room has a heat sink that the temperature control system monitors.
              
         * "Transmitter"
         * 
         * This system allows the crew external communications with other ships, space stations and planet based stuff.

         * "Receiver"
         * 
         * This system allows the crew to receive communications from outside the ship.
              
         * "Cryptography"
         * 
         * This system allows the crew to encrypt and decrypt friendly communications. It also allows an operator to attempt to decode enemy transmissions.
              
         * "Weapons Targeting ( 1 to 4)"
         * 
         * This system allows the weapon operator to designate targets for the exterior ship weapons.
              
         * "Weapons Firing (1 to 4)"
         * 
         * This system allows the weapon operator to fire.
              
         * "Surgery Table"
         * 
         * This system heals the user based on its power supply and efficiency.
                         
         * "Hangar"
         * 
         * This system is a holding bay for shuttles, fighters etc...
              
         * "Repair bay"
         * 
         * This system alows the operator to repair ships that can be stowed in a hangar, it also allows moer complicated reparis on damaged systems and robots etc...
         */



    }
}
