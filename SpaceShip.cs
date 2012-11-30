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
            this.destroyed = false;
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
        public int totalMass { get; set; }
        public int structureMass { get; set; }
        public int maxTotalHitPoints { get; set; }
        public int currentTotalHitPoints { get; set; }
        public int operationalHitPointThreshold { get; set; }
        public int maxStructureHitPoints { get; set; }
        public int currentStructureHitPoints { get; set; }
        public int numberOfRooms { get; set; }
        public int roomsOccupied { get; set; }
        public int totalHitPointsStructuralIntegrityThreshold { get; set; }
        public bool exteriorStructureCompromised { get; set; }
        public bool destroyed { get; set; }
        public int spaceShipPowerOverhead { get; set; }
        public int powerPool { get; set; }
        //public string[] requiredRooms { get; set; }

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

        public void checkPowerHierarchyIntegrity()
        {
            bool keepGoing = true;

            int positionCurrentlyChecking = 1;
            int positionsConfirmed = 0;
            int positionOutsideRange = 0;

            foreach (KeyValuePair<string, int> hierarchyData in shipPowerHierarchy())
            {
                if (hierarchyData.Value > countShipSystems())
                {
                    foreach (Room room in getRooms())
                    {
                        foreach (ShipSystem shipsystem in room.getSystems())
                        {
                            if (shipsystem.systemName == hierarchyData.Key)
                            {
                                shipsystem.powerSupplyHierarchyPosition = -1;
                                positionOutsideRange++;

                            }
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> hierarchyData in shipPowerHierarchy())
            {
                int checkValueForDuplicates = hierarchyData.Value;

                foreach (KeyValuePair<string, int> hierarchyDataTwo in shipPowerHierarchy())
                {
                    if (hierarchyDataTwo.Value == checkValueForDuplicates && hierarchyData.Key != hierarchyDataTwo.Key)
                    {
                        foreach (Room room in getRooms())
                        {
                            foreach (ShipSystem shipSystem in room.getSystems())
                            {
                                if (hierarchyDataTwo.Key == shipSystem.systemName)
                                {
                                    shipSystem.powerSupplyHierarchyPosition = -1;
                                    positionOutsideRange++;
                                }
                            }
                        }
                    }
                }
            }

            while (keepGoing == true)
            {
                foreach (KeyValuePair<string, int> hierarchyData in shipPowerHierarchy())
                {
                    if (hierarchyData.Value == positionCurrentlyChecking)
                    {
                        positionsConfirmed++;
                        positionCurrentlyChecking++;
                    }
                }

                if (positionsConfirmed + positionOutsideRange == countShipSystems() + 1)
                {
                    keepGoing = false;
                }
            }

            while (positionOutsideRange > 0)
            {
                foreach (KeyValuePair<string, int> hierarchyData in shipPowerHierarchy())
                {
                    if (hierarchyData.Value == -1)
                    {
                        foreach (Room room in getRooms())
                        {
                            foreach (ShipSystem shipSystem in room.getSystems())
                            {
                                if (hierarchyData.Key == shipSystem.systemName)
                                {
                                    shipSystem.powerSupplyHierarchyPosition = positionCurrentlyChecking;
                                    positionCurrentlyChecking++;
                                    positionOutsideRange--;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(shipPowerHierarchy());
        }


        public void distributePower()
        {
            if (powerPool < shipOperationalPowerConsumption())
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
                                if (powerPool < shipsystem.systemOperationalPowerConsumption)
                                {
                                    if ((powerPool + shipsystem.currentPowerStored) < shipsystem.systemOperationalPowerConsumption)
                                    {
                                        shipsystem.isSwitchedOn = false;
                                        shipsystem.currentPowerStored = 0;
                                    }

                                    if ((powerPool + shipsystem.currentPowerStored) >= shipsystem.systemOperationalPowerConsumption)
                                    {
                                        shipsystem.currentPowerStored = shipsystem.currentPowerStored - (shipsystem.systemOperationalPowerConsumption - powerPool);
                                    }
                                }

                                if (powerPool >= shipsystem.systemOperationalPowerConsumption)
                                {
                                    powerPool = powerPool - shipsystem.systemOperationalPowerConsumption;
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

            if (powerPool >= shipOperationalPowerConsumption())
            {
                bool keepGoing = true;
                int hierarchyPositionChecking = 1;
                int numberOfSystems = countShipSystems();

                powerPool = powerPool - shipOperationalPowerConsumption();

                while (keepGoing)
                {
                    foreach (Room room in getRooms())
                    {
                        foreach (ShipSystem shipsystem in room.getSystems())
                        {
                            if (shipsystem.powerSupplyHierarchyPosition == hierarchyPositionChecking)
                            {
                                if (powerPool < shipsystem.systemtPowerShortfall())
                                {
                                    shipsystem.currentPowerStored = shipsystem.currentPowerStored + powerPool;
                                    powerPool = 0;
                                }

                                if (powerPool >= shipsystem.systemtPowerShortfall())
                                {
                                    powerPool = powerPool - shipsystem.systemtPowerShortfall();
                                    shipsystem.currentPowerStored = shipsystem.maxPowerStorage;
                                }

                            }
                        }
                    }

                    hierarchyPositionChecking++;
                    if (hierarchyPositionChecking == numberOfSystems + 1 || powerPool <= 0)
                    {
                        keepGoing = false;
                    }
                }

            }

        }

        
    }

}




