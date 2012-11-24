using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class ShipSystem
    {
        public ShipSystem(string systemName, string roomName)
        {
            this.systemName = systemName;
            this.systemRoomName = roomName;

            if (systemName == "Pilot Controls")
            {
                this.mass = 100;
                this.maxHitPoints = 1000;
                this.maxTemperature = 3000;
                this.operationalHitPointThreshold = 25;
                this.maxPowerStorage = 1000;
                this.canBurn = false;
                this.canExplode = false;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 1;
                this.maxHackPoints = 1000;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "A.I.")
            {
                this.mass = 500;
                this.maxHitPoints = 100;
                this.maxTemperature = 90;
                this.operationalHitPointThreshold = 50;
                this.maxPowerStorage = 1000;
                this.canBurn = false;
                this.canExplode = false;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 2;
                this.maxHackPoints = 100;
                this.overHeatDamage = 5;
                this.breakHitPointThreshold = 25;
                this.operationalPowerConsumption = 100;
            }

            if (systemName == "Shields")
            {
                this.damageReduction = 0;//don't accidentally remove
                this.shieldPoints = 0;//don't accidentally remove
                this.shieldRechargeRate = 0;//don't accidentally remove
                this.shieldEfficiency = 0;//don't accidentally remove

                this.mass = 1000;
                this.maxHitPoints = 350;
                this.maxTemperature = 1000;
                this.operationalHitPointThreshold = 100;
                this.maxPowerStorage = 2000;
                this.canBurn = false;
                this.canExplode = false;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 3;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 50;
                this.operationalPowerConsumption = 100;
            }

            if (systemName == "Engines")
            {
                this.thrust = 0;//don't accidentally remove
                this.fuelLevel = 0;//don't accidentally remove
                this.maxFuelLevel = 50;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 10000;
                this.maxTemperature = 50000;
                this.operationalHitPointThreshold = 1000;
                this.maxPowerStorage = 1000;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 4;
                this.maxHackPoints = 100;
                this.overHeatDamage = 1;
                this.breakHitPointThreshold = 500;
                this.operationalPowerConsumption = 0;
            }

            //not filled in yet past this point

            if (systemName == "Power Generator")
            {
                this.powerGeneration = 0; //don't accidentally remove
                this.fuelLevel = 0;//don't accidentally remove
                this.maxFuelLevel = 50;//don't accidentally remove
                this.efficiency = 4;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Fabricator")
            {
                this.fabricatorEfficiency = 0;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Waste Disposal")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Fuel Store")
            {

            this.fuelLevel = 0;//don't accidentally remove
            this.maxFuelLevel = 50;//don't accidentally remove
            this.mass = 10;
            this.maxHitPoints = 100;
            this.maxTemperature = 300;
            this.operationalHitPointThreshold = 20;
            this.maxPowerStorage = 10;
            this.canBurn = true;
            this.canExplode = true;
            this.canSpark = true;
            this.powerSupplyHierarchyPosition = 0;
            this.maxHackPoints = 100;
            this.overHeatDamage = 2;
            this.breakHitPointThreshold = 10;
            this.operationalPowerConsumption = 10;

            }

            if (systemName == "Air Scrubber")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Gravity Generator")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Temperature Control")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Transmitter")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Receiver")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Cryptography")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Weapons Targeting")
            {
                this.reloadRate = 0;
                this.weaponType = "";
                this.weaponEfficiency = 0;
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Weapons Firing")
            {
                this.reloadRate = 0;
                this.weaponType = "";
                this.weaponEfficiency = 0;
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Surgery Table")
            {
                this.healRate = 0;//don't accidentally remove
                this.healEfficiency = 0;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Hangar")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Repair Bay")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            if (systemName == "Power Distributor")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 10;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.operationalPowerConsumption = 10;
            }

            this.currentHackPoints = maxHackPoints;
            this.currentHitPoints = maxHitPoints;
            this.currentTemperature = 28;
            this.isOperational = true;
            this.operationalHackPointThreshold = 0;
            this.isDestroyed = false;
            this.destructionHitPointThreshold = 0;
            this.isBroken = false;
            this.currentPowerStored = 0;
            this.isSwitchedOn = true;

        }

        public string systemName { get; set; }
        public string systemRoomName { get; set; }        
        public int mass { get; set; }
        public bool isOperational { get; set; }
        public int maxHitPoints { get; set; }
        public int currentHitPoints { get; set; }
        public int maxHackPoints { get; set; }
        public int currentHackPoints { get; set; }
        public int operationalHitPointThreshold { get; set; }
        public int operationalHackPointThreshold { get; set; }
        public bool canSpark { get; set; }
        public bool canExplode { get; set; }
        public bool canBurn { get; set; }
        public int currentTemperature { get; set; }
        public int maxTemperature { get; set; }
        public int overHeatDamage { get; set; }
        public int efficiency { get; set; }
        public int fuelLevel { get; set; }
        public int maxFuelLevel { get; set; }
        public bool isDestroyed { get; set; }
        public int destructionHitPointThreshold { get; set; }
        public bool isBroken { get; set; }
        public int breakHitPointThreshold { get; set; }
        public int operationalPowerConsumption { get; set; }
        public int currentPowerStored { get; set; }
        public int maxPowerStorage { get; set; }
        public int powerSupplyHierarchyPosition { get; set; }
        public bool isSwitchedOn { get; set; }

        //generator stats
        public int powerGeneration { get; set; }
        public bool setToLowPowerOutput { get; set; }
        public bool setToNormalPowerOutput { get; set; }
        public bool setToHighPowerOutput { get; set; }
        public bool setToOverDrivePowerOutput { get; set; }
        public int efficiencyForLowPowerOutput { get; set; }
        public int efficiencyForNormalPowerOutput { get; set; }
        public int efficiencyForHighPowerOutput { get; set; }
        public int efficiencyForOverDrivePowerOutput { get; set; }

        //engine stats
        public int thrust { get; set; }

        //shield stats
        public int damageReduction { get; set; }
        public int shieldPoints { get; set; }
        public int shieldRechargeRate { get; set; }//maximum recharge per tick
        public int shieldEfficiency { get; set; }//power units per shield point restored

        //Weaponry stats
        public int reloadRate { get; set; }
        public string weaponType { get; set; }
        public int weaponEfficiency { get; set; }//power/ammo used per shot


        //Fabricator stats
        //need variable for known schematics for fabricator
        public int fabricatorEfficiency { get; set; }

        //Medibay stats
        public int healRate { get; set; }//max healing per tick
        public int healEfficiency { get; set; }//power units required per health point

    }
}
