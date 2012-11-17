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
    }



}
