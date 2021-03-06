﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SSGMadNess
{
    class Room
    {
        public Room(string name)
        {
            this.roomType = name;
            //this.systemSlots = 3; //placeholder for later when players select systems
            //this.airPressure = 101; // kPa

            this.maxBulkheadHitPoints = 500;
            this.currentBulkheadHitPoints = maxBulkheadHitPoints;
            this.bulkheadMass = 100;
            this.oxygenLevel = 100; // %
            this.airScrubberInterface = true;
            this.airTemperature = 293; // degrees K
            this.heatExchangerInterface = true;
            this.bulkheadCompromised = false;
            this.pilotControls = null;
            this.shields = null;
            this.aI = null;
            this.engines = null;
            this.powerGenerator = null;
            this.fabricator = null;
            this.wasteDisposal = null;
            this.fuelStore = null;
            this.airScrubber = null;
            this.gravityGenerator = null;
            this.temperatureControl = null;
            this.transmitter = null;
            this.receiver = null;
            this.cryptography = null;
            this.weaponsTargeting = null;
            this.weaponsFiring = null;
            this.surgeryTable = null;
            this.hangar = null;
            this.repairBay = null;

        }
        
        public string roomType { get; set; }
        public string roomName { get; set; }
        public string shipName { get; set; }

        //public int systemSlots { get; set; }
        
        
        
        //air variables
        public int oxygenLevel { get; set; }
        public double roomVolume { get; set; } //litres or m cubed
        public double roomSurfaceArea { get; set; }
        public double idealRoomPressure = 1013; // 1 atmosphere
        private double _airPressure;
        public double airPressure // Pa
        {
            get
            {
                return _airPressure;
            }

            set
            {
                if (value >= blowoutAirPressure)
                {
                    if (value >= blowoutAirPressure)
                        bulkheadBreachArea = value - blowoutAirPressure;
                }

                if (value > maxAirPressure)
                {
                    currentBulkheadHitPoints = currentBulkheadHitPoints - Convert.ToInt32(value - maxAirPressure);
                }

                _airPressure = value;
            }
        }
        private double _massOfAirInRoom { get; set; }
        public double massOfAirInRoom
        {
            get
            {
                return _massOfAirInRoom;
            }

            set
            {
                airPressure = (value / 29) * 29 * airTemperature;
                _massOfAirInRoom = value;
            }
        }
        private double _airTemperature { get; set; }
        public double airTemperature // degrees kelvin
        {
            get
            {
                return _airTemperature;
            }

            set
            {

                airPressure = (massOfAirInRoom / 29) * 29 * value;
                _airTemperature = value;
            }
        }



        
        private int _currentBulkheadHitPoints { get; set; }
        public int currentBulkheadHitPoints
        {
            get
            {
                return _currentBulkheadHitPoints;
            }

            set
            {
                if(value < bulkheadHitPointsStructuralIntegrityThreshold)
                {
                    bulkheadCompromised = true;
                    bulkheadBreachArea = bulkheadHitPointsStructuralIntegrityThreshold - value;
                }

                _currentBulkheadHitPoints = value;
            }
        }

        public int maxBulkheadHitPoints { get; set; }

        

        

        public bool airScrubberInterface { get; set; }
        public bool heatExchangerInterface { get; set; }
        
        


        public int bulkheadMass { get; set; }
        public bool bulkheadCompromised { get; set; }
        
        public int bulkheadHitPointsStructuralIntegrityThreshold
        {
            get
            {
                return maxBulkheadHitPoints / 5;
            }
        }

        public double blowoutAirPressure
        {
            get
            {
                return idealRoomPressure * 4;
            }
        }

        public double maxAirPressure
        {
            get
            {
                return idealRoomPressure * 3;
            }

        }

        public double bulkheadBreachArea { get; set; }

        public ShipSystem pilotControls { get; set; }
        public ShipSystem shields { get; set; }
        public ShipSystem aI { get; set; }
        public ShipSystem engines { get; set; }
        public ShipSystem powerGenerator { get; set; }
        public ShipSystem fabricator { get; set; }
        public ShipSystem wasteDisposal { get; set; }
        public ShipSystem fuelStore { get; set; }
        public ShipSystem airScrubber { get; set; }
        public ShipSystem gravityGenerator { get; set; }
        public ShipSystem temperatureControl { get; set; }
        public ShipSystem transmitter { get; set; }
        public ShipSystem receiver { get; set; }
        public ShipSystem cryptography { get; set; }
        public ShipSystem weaponsTargeting { get; set; }
        public ShipSystem weaponsFiring { get; set; }
        public ShipSystem surgeryTable { get; set; }
        public ShipSystem hangar { get; set; }
        public ShipSystem repairBay { get; set; }
        public ShipSystem heatExchanger { get; set; }
        public ShipSystem powerDistributor { get; set; }
        public ShipSystem shipCapacitor { get; set; }
        public ShipSystem airPump { get; set; }

        public List<ShipSystem> getSystems()
        {
           var systems = new ShipSystem[] { powerGenerator,
                                            shipCapacitor,
										    fabricator,
										    wasteDisposal,
										    fuelStore,
										    airScrubber,
										    gravityGenerator,
										    temperatureControl,
										    transmitter,
										    receiver,
										    cryptography,
										    weaponsTargeting,
										    weaponsFiring,
										    surgeryTable,
										    hangar,
										    repairBay,
										    heatExchanger,
										    powerDistributor };

            return systems.Where(s => s != null).ToList();
        }

        public List<ShipSystem> getSpecificSystem(string systemName)
        {
            var systems = getSystems();
            
            return systems.Where(s => s.systemName == systemName).ToList();
        }

        public int roomSystemCount()
        {
            return getSystems().Count();
        }

        public int roomOperationalPowerConsumption()
                {
                    return getSystems().Sum(systems => systems.systemOperationalPowerConsumption);
                }

        public List<KeyValuePair<string,int>> roomPowerHierarchyPositions()
        {
            var hierarchy = new List<KeyValuePair<string, int>> {};
            
            
            List<ShipSystem> thisRoomsSystems = getSystems(); 
            
            
            foreach (ShipSystem shipSystem in thisRoomsSystems)
            {
                hierarchy.Add(shipSystem.systemPowerHierarchyPosition());
            }
            
            return hierarchy;
        }

        public int roomStoredPower()
        {
            return getSystems().Sum(systems => systems.currentPowerStored);
        }

    }

}

