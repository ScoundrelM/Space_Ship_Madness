using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class Shield
    {
        public string sheildType;

        public int shieldLayer1HitPoints;
        public int shieldLayer1MaxHitPoints;
        public int shieldLayer1DamageReduction;
        public bool isShieldLayer1Full
        {
            get
            {
                if (shieldLayer1HitPoints >= shieldLayer1MaxHitPoints)
                {
                    return true;
                }

                else
                {
                    return false;

                }
            }
        }

        public int shieldLayer2HitPoints;
        public int shieldLayer2MaxHitPoints;
        public int shieldLayer2DamageReduction;
        public bool isShieldLayer2Full
        {
            get
            {
                if (shieldLayer2HitPoints >= shieldLayer2MaxHitPoints)
                {
                    return true;
                }

                else
                {
                    return false;

                }
            }
        }

        public int shieldLayer3HitPoints;
        public int shieldLayer3MaxHitPoints;
        public int shieldLayer3DamageReduction;
        public bool isShieldLayer3Full
        {
            get
            {
                if (shieldLayer3HitPoints >= shieldLayer3MaxHitPoints)
                {
                    return true;
                }

                else
                {
                    return false;

                }
            }
        }
    }
}
