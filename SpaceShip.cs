using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class SpaceShip
    {
        public SpaceShip(string name)
        {
            this.exteriorStructureCompromised = false;
            this.fighterCockpit = null;
            this.bridge = null;
            this.engineering = null;
            this.lifeSupport = null;
            this.comms = null;
            this.fireControl = null;
            this.fireControl2 = null;
            this.fireControl3 = null;
            this.fireControl4 = null;
            this.medibay = null;
            this.shuttleBay = null;
            this.cargoHold = null;
            this.structuralAirPressure = 26;
            this.maxStructuralAirPressure = 100;
        }

        public Room fighterCockpit { get; set; }
        public Room bridge { get; set; }
        public Room engineering { get; set; }
        public Room lifeSupport { get; set; }
        public Room comms { get; set; }
        public Room fireControl { get; set; }
        public Room fireControl2 { get; set; }
        public Room fireControl3 { get; set; }
        public Room fireControl4 { get; set; }
        public Room medibay { get; set; }
        public Room shuttleBay { get; set; }
        public Room cargoHold { get; set; }

        public string shipName { get; set; }
        public string shipType { get; set; }
        public int totalMass
        {
            get
            {
                return cargoMass + structureMass + getRooms().Sum(room => room.bulkheadMass) + getRooms().Sum(room => room.getSystems().Sum(system => system.mass));
            }
        }
        public int structureMass { get; set; }
        public int maxTotalHitPoints { get; set; }
        public int currentTotalHitPoints
        {
            get
            {
                return currentStructureHitPoints + getRooms().Sum(room => room.currentBulkheadHitPoints) + getRooms().Sum(room => room.getSystems().Sum(system => system.currentHitPoints));
            }
        }
        public int operationalHitPointThreshold { get; set; }
        public int maxStructureHitPoints { get; set; }

        private int _currentStructureHitPoints { get; set; }
        public int currentStructureHitPoints
        {
            get
            {
                return _currentStructureHitPoints;
            }

            set
            {
                if(value < structuralIntegrityThreshold)
                {
                    exteriorStructureCompromised = true;
                    structuralBulkheadBreachArea = structuralIntegrityThreshold - value;
                }

                _currentStructureHitPoints = value;

                if (value <= 0)
                {
                    _currentStructureHitPoints = 0;
                }

                if (value > maxStructureHitPoints)
                {
                    _currentStructureHitPoints = maxStructureHitPoints;
                }
                
            }

        }


        public int structuralIntegrityThreshold
        {
            get
            {
                return maxStructureHitPoints / 4;
            }

        }
        public bool exteriorStructureCompromised { get; set; }
        public int maxStructuralAirPressure { get; set; }
        public int cargoMass { get; set; }

        private int _structuralAirPressure { get; set; }
        public int structuralAirPressure
        {
            get
            {
                return _structuralAirPressure;
            }

            set
            {
                if (value > maxStructuralAirPressure)
                {
                    exteriorStructureCompromised = true;
                    structuralBulkheadBreachArea = value - maxStructuralAirPressure;
                }
            }
        }

        public int structuralBulkheadBreachArea { get; set; }

        public bool destroyed
        {
            get
            {
                if (currentStructureHitPoints <= 0)
                {
                    return (destroyed);
                }
                else
                {
                    return (!destroyed);
                }
            }
        }
        
        //public int spaceShipPowerOverhead { get; set; }
        
        public bool isFighter { get; set; }

        public List<Room> getRooms()
        {

            var rooms = new Room[] { fighterCockpit,
        					  	 bridge,
						         engineering,
						         lifeSupport,
						         comms,
						         fireControl,
						         fireControl2,
						         fireControl3,
						         fireControl4,
						         medibay,
						         shuttleBay,
						         cargoHold
						       };

            return rooms.Where(r => r != null).ToList();

        }

        public int countShipSystems()
        {
            return getRooms().Sum(room => room.roomSystemCount());
        }

        public int shipOperationalPowerConsumption()
        {

            return getRooms().Sum(room => room.roomOperationalPowerConsumption());

        }

        public int shipStoredPower()
        {

            return getRooms().Sum(room => room.roomStoredPower());

        }

        public List<KeyValuePair<string, int>> shipPowerHierarchy()
        {
            var hierarchy = new List<KeyValuePair<string, int>> { };

            foreach (Room room in getRooms())
            {
                foreach (KeyValuePair<string, int> hierarchyData in room.roomPowerHierarchyPositions())
                {
                    hierarchy.Add(hierarchyData);
                }
            }
            return hierarchy;

        }

        public void enforceValidityOnHierarchy()
        {
            //var hierarchy = shipPowerHierarchy();
            //var hierarchy;
            int newPosition = 1;
            var hierarchy = (from entry in shipPowerHierarchy() orderby entry.Value ascending select entry)
            .ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (KeyValuePair<string, int> datablock in hierarchy)
            {
                ShipSystem system = getSpecificShipSystem(datablock.Key);
                if (system.powerSupplyHierarchyPosition <= 0)
                {

                }

                else
                {
                    system.powerSupplyHierarchyPosition = newPosition;
                    newPosition++;
                }

            }
        }

        public void distributePower()
        {
            Console.WriteLine("Current Power Pool: " + getSpecificShipSystem("Capacitor").currentPowerStored);

            bool distributorOperational = getSpecificShipSystem("Power Distributor").isOperational;

            if (distributorOperational)
            {
                if (getSpecificShipSystem("Capacitor").currentPowerStored < shipOperationalPowerConsumption())
                {
                    bool keepGoing = true;
                    int hierarchyPositionChecking = 1;
                    int numberOfSystems = countShipSystems();

                    while (keepGoing)
                    {
                        foreach (Room room in getRooms())
                        {
                            foreach (ShipSystem shipsystem in room.getSystems())
                            {
                                if (shipsystem.powerSupplyHierarchyPosition == hierarchyPositionChecking)
                                {
                                    //ReportingMethods.shipSystemReport(shipsystem);
                                    if (getSpecificShipSystem("Capacitor").currentPowerStored < shipsystem.systemOperationalPowerConsumption)
                                    {
                                        if ((getSpecificShipSystem("Capacitor").currentPowerStored + shipsystem.currentPowerStored) < shipsystem.systemOperationalPowerConsumption)
                                        {
                                            //shipsystem.isSwitchedOn = false;
                                            shipsystem.currentPowerStored = 0;
                                            getSpecificShipSystem("Capacitor").currentPowerStored = 0;
                                        }

                                        if ((getSpecificShipSystem("Capacitor").currentPowerStored + shipsystem.currentPowerStored) >= shipsystem.systemOperationalPowerConsumption)
                                        {
                                            if (shipsystem.currentPowerStored >= shipsystem.systemOperationalPowerConsumption)
                                            {
                                                shipsystem.currentPowerStored = shipsystem.currentPowerStored - shipsystem.systemOperationalPowerConsumption;
                                            }

                                            else
                                            {
                                                getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored - (shipsystem.systemOperationalPowerConsumption - shipsystem.currentPowerStored);
                                                shipsystem.currentPowerStored = 0;
                                            }

                                        }
                                    }

                                    if (getSpecificShipSystem("Capacitor").currentPowerStored >= shipsystem.systemOperationalPowerConsumption)
                                    {
                                        getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored - shipsystem.systemOperationalPowerConsumption;
                                    }
                                }
                            }
                        }

                        hierarchyPositionChecking++;
                        if (hierarchyPositionChecking == numberOfSystems + 1)
                        {
                            keepGoing = false;
                        }

                    }
                }

                if (getSpecificShipSystem("Capacitor").currentPowerStored >= shipOperationalPowerConsumption())
                {
                    bool keepGoing = true;
                    int hierarchyPositionChecking = 1;
                    int numberOfSystems = countShipSystems();

                    getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored - shipOperationalPowerConsumption();

                    while (keepGoing)
                    {
                        foreach (Room room in getRooms())
                        {
                            foreach (ShipSystem shipsystem in room.getSystems())
                            {
                                //ReportingMethods.shipSystemReport(shipsystem);
                                if (shipsystem.powerSupplyHierarchyPosition == hierarchyPositionChecking)
                                {
                                    if (getSpecificShipSystem("Capacitor").currentPowerStored < shipsystem.systemtPowerShortfall())
                                    {
                                        shipsystem.currentPowerStored = shipsystem.currentPowerStored + getSpecificShipSystem("Capacitor").currentPowerStored;
                                        getSpecificShipSystem("Capacitor").currentPowerStored = 0;
                                    }

                                    if (getSpecificShipSystem("Capacitor").currentPowerStored >= shipsystem.systemtPowerShortfall())
                                    {
                                        getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored - shipsystem.systemtPowerShortfall();
                                        shipsystem.currentPowerStored = shipsystem.maxPowerStorage;
                                    }

                                }
                            }
                        }

                        hierarchyPositionChecking++;
                        if (hierarchyPositionChecking == numberOfSystems + 1 || getSpecificShipSystem("Capacitor").currentPowerStored <= 0)
                        {
                            keepGoing = false;
                        }
                    }

                }

            }

        }

        public void runPowerGenerator()
        {
            ShipSystem powerGenerator = getSpecificShipSystem("Power Generator");

            if (powerGenerator.isOperational)
            {
                if (powerGenerator.generatorFuelLevel <= 0)
                {
                    Console.WriteLine("Not enough fuel to run generator.");
                }


                if (powerGenerator.generatorFuelLevel > 0)
                {
                    getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored + (powerGenerator.generatorFuelLevel * powerGenerator.efficiency);
                    getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored + powerGenerator.currentPowerStored;
                    engineering.powerGenerator.generatorFuelLevel = 0;
                }
            }

            Console.WriteLine("Current Power Pool: " + getSpecificShipSystem("Capacitor").currentPowerStored);
        }

        public void primeGeneratorWithFuel()
        {

            ShipSystem generator = getSpecificShipSystem("Power Generator");
            ShipSystem fuelStore = getSpecificShipSystem("Fuel Store");
            int fuelRequrement = generator.maxGeneratorFuelLevel - generator.generatorFuelLevel;




            if (fuelStore.fuelLevel == 0)
            {
                Console.WriteLine("You have no fuel.");
            }

            if (fuelStore.fuelLevel > 0)
            {

                if (fuelRequrement <= fuelStore.fuelLevel)
                {
                    generator.generatorFuelLevel = generator.maxGeneratorFuelLevel;
                    fuelStore.fuelLevel = fuelStore.fuelLevel - fuelRequrement;

                    Console.WriteLine("Your generator is primed. Ship fuel stores are now: " + fuelStore.fuelLevel);
                }

                if (fuelRequrement > fuelStore.fuelLevel)
                {
                    generator.generatorFuelLevel = generator.generatorFuelLevel + fuelStore.fuelLevel;
                    fuelStore.fuelLevel = 0;

                    Console.WriteLine("You have used the last of your fuel priming your generator.");
                }
            }
        }

        public void runGenerator()
        {
            int generatorFuelInput;
            ShipSystem generator = null;

            if (isFighter)
            {
                generator = fighterCockpit.powerGenerator;
                generatorFuelInput = fighterCockpit.powerGenerator.generatorFuelLevel;
            }

            else
            {
                generator = engineering.powerGenerator;
                generatorFuelInput = engineering.powerGenerator.generatorFuelLevel;
            }

            if (generator.isOperational)
            {
                if (generatorFuelInput <= 0)
                {
                    Console.WriteLine("Not enough fuel to run generator.");
                }


                if (generatorFuelInput > 0)
                {
                    getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored + (generatorFuelInput * generator.efficiency);
                    getSpecificShipSystem("Capacitor").currentPowerStored = getSpecificShipSystem("Capacitor").currentPowerStored + generator.currentPowerStored;
                    generator.generatorFuelLevel = 0;
                }
            }

            Console.WriteLine("Current Power Pool: " + getSpecificShipSystem("Capacitor").currentPowerStored);
        }

        public void powerBleed()
        {
            foreach (Room room in getRooms())
            {
                foreach (ShipSystem shipSys in room.getSystems())
                {
                    if (shipSys.currentPowerStored > 0)
                    {
                        shipSys.currentPowerStored--;
                    }
                }
            }
        }

        public ShipSystem getSpecificShipSystem(string systemName)
        {
            ShipSystem output = null;

            foreach (Room room in getRooms())
            {
                foreach (ShipSystem sys in room.getSpecificSystem(systemName))
                {
                    if (sys.systemName == systemName)
                    {
                        output = sys;
                    }

                }
            }

            return output;
        }

        public Room getSpecificRoom(string roomName)
        {
            Room output = null;

            foreach (Room room in getRooms())
            {
                if(room.roomName == roomName)
                {
                   output = room;
                }
            }

            return output;
        }

        public void checkForOverheating()
        {
            foreach (Room room in getRooms())
            {
                foreach (ShipSystem sys in room.getSystems())
                {
                    if (sys.currentTemperature > room.airTemperature)
                    {
                        room.airTemperature = room.airTemperature + sys.heatDissipationRate;
                        sys.currentTemperature = sys.currentTemperature - sys.heatDissipationRate;
                    }

                    if (sys.currentTemperature < room.airTemperature)
                    {
                        room.airTemperature = room.airTemperature - sys.heatDissipationRate;
                        sys.currentTemperature = sys.currentTemperature + sys.heatDissipationRate;
                    }

                    if (sys.isOverheating)
                    {
                        sys.applyOverheatingDamage();

                    }
                }
            }
        }

        public void checkAirForLeaks()
        {
            // Time frsme needs determining.

            foreach (Room room in getRooms())
            {
                if (room.bulkheadCompromised)
                {

                }
            }
        }

        public void receiveDamagePacket(int value, string type, string[] targets)
        {
            //Damage has: Value, Type & Targets
            
            //First it Has to pass through the shield layer

            //second it hits the hull armour

            //third it hits the hull

            //fourth plus it hits any rooms and systems in the target path

            //each layer absorbs or negates a certain amount of damage based on the damage type.

        }
    }
}

