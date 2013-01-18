using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class Damage
    {
        public string damageType;
        /*
         *Possible types: Laser, Accelerated Particle, Projectile, Explosive, EMP, Quantum Tunneler.     
        */
        public string[] targets;
        /*
         *A list of systems in the line of fire for the attack
         */
        public int damageValue;
        /*
         *The initial amount of damage coming in 
         */

    }
}
