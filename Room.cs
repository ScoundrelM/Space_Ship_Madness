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
            this.airPressure = 101; // kPa
            this.bulkheadHitPoints = 100;
            this.maxBulkheadHitPoints = 100;
            this.bulkheadMass = 100;
            this.oxygenLevel = 100; // %
            this.airScrubberInterface = true;
            this.airTemperature = 20; // degrees c
            this.heatExchangerInterface = true;
            this.bulkheadCompromised = false;
            this.bulkheadHitPointsStructuralIntegrityThreshold = 20;

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
        //public ShipSystem[] shipSystems { get; set; }
        public int oxygenLevel { get; set; }
        public int bulkheadHitPoints { get; set; }
        public int maxBulkheadHitPoints { get; set; }
        public int airPressure { get; set; }
        public bool airScrubberInterface { get; set; }
        public bool heatExchangerInterface { get; set; }
        public int airTemperature { get; set; }
        public int bulkheadMass { get; set; }
        public bool bulkheadCompromised { get; set; }
        public int bulkheadHitPointsStructuralIntegrityThreshold { get; set; }

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
    }
}

