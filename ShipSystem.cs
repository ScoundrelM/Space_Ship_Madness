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
            this.systemIsIn = roomName;
            this.currentHackPoints = 100;
            this.currentHitPoints = 100;
            this.currentTemperature = 28;
            this.isOperational = true;
            this.mass = 10;
            this.maxHackPoints = 100;
            this.maxHitPoints = 100;
            this.maxTemperature = 300;
            this.operationalHackPointThreshold = 0;
            this.operationalHitPointThreshold = 20;
            this.overHeatDamage = 2;
            this.isDestroyed = false;
            this.destructionHitPointThreshold = 0;
            this.canBurn = true;
            this.canExplode = true;
            this.canSpark = true;
            this.efficiency = 0;
            this.fuelLevel = 0;
            this.powerGeneration = 0;
            this.isBroken = false;
            this.breakHitPointThreshold = 10;
            this.operationalPowerConsumption = 10;
            this.currentPowerStored = 0;
            this.maxPowerStorage = 10;

            this.powerSupplyHierarchyPosition = 0;
            this.thrust = 0;
            this.damageReduction = 0;
            this.shieldPoints = 0;
            this.shieldRechargeRate = 0;
            this.shieldEfficiency = 0;
            this.reloadRate = 0;
            this.weaponType = "";
            this.weaponEfficiency = 0;
            this.fabricatorEfficiency = 0;
            this.healRate = 0;
            this.healEfficiency = 0;
        }

        public string systemName { get; set; }
        public string systemIsIn { get; set; }        
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
        public int powerGeneration { get; set; }
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
