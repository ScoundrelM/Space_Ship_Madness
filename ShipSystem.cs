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

            if (systemName == "Capacitor")
            {
                this.mass = 1000;
                this.maxHitPoints = 1000;
                this.maxTemperature = 1000;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 1000;
                this.canBurn = false;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 0;
                this.maxHackPoints = 100;
                this.overHeatDamage = 1;
                this.breakHitPointThreshold = 15;
                this.systemOperationalPowerConsumption = 0;
            }

            if (systemName == "Pilot Controls")
            {
                this.mass = 100;
                this.maxHitPoints = 1000;
                this.maxTemperature = 3000;
                this.operationalHitPointThreshold = 25;
                this.maxPowerStorage = 100;
                this.canBurn = false;
                this.canExplode = false;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 1;
                this.maxHackPoints = 1000;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 5;
                this.systemActivationPowerConsumption = 0;
            }

            if (systemName == "A.I.")
            {
                this.mass = 500;
                this.maxHitPoints = 100;
                this.maxTemperature = 90;
                this.operationalHitPointThreshold = 50;
                this.maxPowerStorage = 100;
                this.canBurn = false;
                this.canExplode = false;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 2;
                this.maxHackPoints = 100;
                this.overHeatDamage = 5;
                this.breakHitPointThreshold = 25;
                this.systemOperationalPowerConsumption = 5;
                this.systemActivationPowerConsumption = 0;
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
                this.systemOperationalPowerConsumption = 100;
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
                this.maxPowerStorage = 0;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 4;
                this.maxHackPoints = 100;
                this.overHeatDamage = 1;
                this.breakHitPointThreshold = 500;
                this.systemOperationalPowerConsumption = 1;
            }

            //not filled in yet past this point

            if (systemName == "Power Generator")
            {
                
                this.generatorFuelLevel = 0;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 0;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 5;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 10;
                this.efficiencyForLowPowerOutput = 10;
                this.efficiencyForNormalPowerOutput = 8;
                this.efficiencyForHighPowerOutput = 6;
                this.efficiencyForOverDrivePowerOutput = 4;
                this.setToHighPowerOutput = true;
            }

            if (systemName == "Fabricator")
            {
                this.fabricatorEfficiency = 0;//don't accidentally remove
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 100;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 6;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 10;
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
                this.powerSupplyHierarchyPosition = 7;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 1;
            }

            if (systemName == "Fuel Store")
            {

            this.fuelLevel = 0;//don't accidentally remove
            this.maxFuelLevel = 50;//don't accidentally remove
            this.mass = 10;
            this.maxHitPoints = 100;
            this.maxTemperature = 300;
            this.operationalHitPointThreshold = 20;
            this.maxPowerStorage = 0;
            this.canBurn = true;
            this.canExplode = true;
            this.canSpark = true;
            this.powerSupplyHierarchyPosition = 8;
            this.maxHackPoints = 100;
            this.overHeatDamage = 2;
            this.breakHitPointThreshold = 10;
            this.systemOperationalPowerConsumption = 0;
            this.systemActivationPowerConsumption = 0;

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
                this.powerSupplyHierarchyPosition = 9;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;
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
                this.powerSupplyHierarchyPosition = 10;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;
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
                this.powerSupplyHierarchyPosition = 11;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;
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
                this.powerSupplyHierarchyPosition = 12;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 1;
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
                this.powerSupplyHierarchyPosition = 13;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 1;
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
                this.powerSupplyHierarchyPosition = 14;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 10;
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
                this.powerSupplyHierarchyPosition = 15;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;
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
                this.powerSupplyHierarchyPosition = 16;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                //this.systemActivationPowerConsumption = 10; special case for weapons systems
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
                this.powerSupplyHierarchyPosition = 17;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 10;
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
                this.powerSupplyHierarchyPosition = 18;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;
            }

            if (systemName == "Repair Bay")
            {
                this.mass = 10;
                this.maxHitPoints = 100;
                this.maxTemperature = 300;
                this.operationalHitPointThreshold = 20;
                this.maxPowerStorage = 100;
                this.canBurn = true;
                this.canExplode = true;
                this.canSpark = true;
                this.powerSupplyHierarchyPosition = 19;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 10;
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
                this.powerSupplyHierarchyPosition = 20;
                this.maxHackPoints = 100;
                this.overHeatDamage = 2;
                this.breakHitPointThreshold = 10;
                this.systemOperationalPowerConsumption = 1;
                this.systemActivationPowerConsumption = 0;

            }

            this.currentHackPoints = maxHackPoints;
            this.currentHitPoints = maxHitPoints;
            this.currentTemperature = 28;
            this.operationalHackPointThreshold = 0;
            this.destructionHitPointThreshold = 0;
            this.currentPowerStored = 0;
            this.isSwitchedOn = true;

            this.heatDissipationRate = 5;

        }

        public string systemName { get; set; }
        public string systemRoomName { get; set; }        
        public int mass { get; set; }
        public bool isOperational
        {
            get
            {
                return (isSwitchedOn || !isBroken || !isDestroyed);
            }
        }
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
        
        
        public int heatDissipationRate { get; set; }
        public int maxFuelLevel { get; set; }
        public bool isDestroyed
        {
            get
            {
                return (currentHitPoints > destructionHitPointThreshold);
            }
        }
        public bool readyToActivate
        {
            get
            {
                if (currentPowerStored > systemActivationPowerConsumption)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        private bool _isOverheating;
        public bool isOverheating
        {
            get
            {
                if (currentTemperature > maxTemperature)
                {
                    _isOverheating = true;
                    return _isOverheating;
                }

                else
                {
                    _isOverheating = false;
                    return _isOverheating;
                }
            }
        }

        public void applyOverheatingDamage()
        {
            int damage = (currentTemperature - maxTemperature)*overHeatDamage;
            currentHitPoints = currentHitPoints - damage;
        }
        
        public int destructionHitPointThreshold { get; set; }

        public bool isBroken
        {
            get
            {
                return (currentHitPoints > breakHitPointThreshold);
            }
        }

        public int breakHitPointThreshold { get; set; }
        public int systemOperationalPowerConsumption { get; set; }
        public int systemActivationPowerConsumption { get; set; }

        private int _currentPowerStored;
        public int currentPowerStored
        {
            get
            {
                return _currentPowerStored;
            }

            set
            {
                if (value > maxPowerStorage)
                {
                    int difference = value - maxPowerStorage;
                    currentTemperature = currentTemperature + difference;
                    _currentPowerStored = maxPowerStorage;
                    //raise temperature
                }


                else
                {
                    _currentPowerStored = value;
                }
            }
        }
        public int maxPowerStorage { get; set; }
        public int powerSupplyHierarchyPosition { get; set; }
        public bool isSwitchedOn { get; set; }

        //generator stats
        //public int powerGeneration { get; set; }
        private bool _setToLowPowerOutput;
        public bool setToLowPowerOutput
        {
            get
            {
                return _setToLowPowerOutput;
            }

            set
            {
                if (value == true)
                {
                    _setToHighPowerOutput = false;
                    _setToNormalPowerOutput = false;
                    _setToOverDrivePowerOutput = false;
                    _setToLowPowerOutput = true;
             
                }

                else
                {
                    _setToLowPowerOutput = false;
                }
            }
        }

        private bool _setToNormalPowerOutput { get; set; }
        public bool setToNormalPowerOutput
        {
            get
            {
                return _setToNormalPowerOutput;
            }

            set
            {
                if (value == true)
                {
                    _setToHighPowerOutput = false;
                    _setToLowPowerOutput = false;
                    _setToOverDrivePowerOutput = false;
                    _setToNormalPowerOutput = true;
    
                }

                else
                {
                    _setToNormalPowerOutput = false;
                }
            }
        }

        private  bool _setToHighPowerOutput { get; set; }
        public bool setToHighPowerOutput
        {
            get
            {
                return _setToHighPowerOutput;
            }

            set
            {
                if (value == true)
                {
                    _setToNormalPowerOutput = false;
                    _setToLowPowerOutput = false;
                    _setToOverDrivePowerOutput = false;
                    _setToHighPowerOutput = true;
     
                }

                else
                {
                    _setToHighPowerOutput = false;
                }
            }
        }

        private bool _setToOverDrivePowerOutput { get; set; }
        public bool setToOverDrivePowerOutput
        {
            get
            {
                return _setToOverDrivePowerOutput;
            }

            set
            {
                if (value == true)
                {
                    _setToNormalPowerOutput = false;
                    _setToLowPowerOutput = false;
                    _setToHighPowerOutput = false;
                    _setToOverDrivePowerOutput = true;
                 
                }

                else
                {
                    _setToOverDrivePowerOutput = false;
                }
            }
        }

        public int _generatorFuelLevel { get; set; }
        public int generatorFuelLevel
        {
            get
            {
                return _generatorFuelLevel;
            }

            set
            {
                if (value > maxGeneratorFuelLevel)
                {
                    _generatorFuelLevel = maxGeneratorFuelLevel;
                    
                }

                else
                {
                    _generatorFuelLevel = value;
                }
            }
        }

        
        public int maxGeneratorFuelLevel
        {
            get
            {
                if (setToLowPowerOutput == true)
                {
                    return 25;
                }

                if (setToNormalPowerOutput == true)
                {
                    return 50;
                }

                if (setToHighPowerOutput == true)
                {
                    return 100;
                }

                if (setToOverDrivePowerOutput == true)
                {
                    return 200;
                }

                else
                {
                    return 400;
                }
            }
        }

        public int efficiencyForLowPowerOutput { get; set; }
        public int efficiencyForNormalPowerOutput { get; set; }
        public int efficiencyForHighPowerOutput { get; set; }
        public int efficiencyForOverDrivePowerOutput { get; set; }
        public int efficiency
        {
            get
            {
                if (setToHighPowerOutput)
                {
                    return efficiencyForHighPowerOutput;
                }

                if (setToLowPowerOutput)
                {
                    return efficiencyForLowPowerOutput;
                }

                if (setToNormalPowerOutput)
                {
                    return efficiencyForNormalPowerOutput;
                }

                if (setToOverDrivePowerOutput)
                {
                    return efficiencyForOverDrivePowerOutput;
                }

                else
                {
                    return 0;
                }
            }
            
        }

        //fuelstore ststs

        public int fuelLevel { get; set; }

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

        public int systemtPowerShortfall()
        {
            return maxPowerStorage - currentPowerStored;
        }
        
        public KeyValuePair<string,int> systemPowerHierarchyPosition()
        {
            KeyValuePair<string, int> hierarchy = new KeyValuePair<string, int>(this.systemName, this.powerSupplyHierarchyPosition);            
            return hierarchy;
        }

        public void activateSystemFunctionPowerDrain()
        {
            if (systemActivationPowerConsumption < currentPowerStored)
            {
                currentPowerStored -= systemActivationPowerConsumption;
            }
            else
            {
                currentPowerStored = 0;
            }
        }
    }
}
