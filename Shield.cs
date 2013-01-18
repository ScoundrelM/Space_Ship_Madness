using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSGMadNess
{
    class Shield
    {
        public void regenerateShield(ShipSystem shieldGenerator)
        {

            int efficiency = shieldGenerator.shieldEfficiency;
            int recharge = shieldGenerator.shieldRechargeRate;
            focusPanel = shieldGenerator.powerPanelFocus;

            //List<object> panelList = ;
            

            if (shieldGenerator.setShieldsToEvenDistribution)
            {
                int splitValue = recharge / 12;                
            }

            if (shieldGenerator.setShieldsToPreferential)
            {
                int focusValue = (recharge / 12) * 7;
                int otherValue = (recharge / 12) * 1;
            }

            if (shieldGenerator.setShieldsToExclusive)
            {

            }
        }

        public Shield()
        {
            Front frontPanel = new Front();
            Rear rearPanel = new Rear();
            Top topPanel = new Top();
            Bottom bottomPanel = new Bottom();
            Right rightPanel = new Right();
            Left leftPanel = new Left();
        }

        //general Shield Stats
        public string shieldType;
        public int maxShieldHitPoints;
        public string focusPanel;

        //Panel stats
        class Front : Shield
        {
            public bool isFocusPanel
            {
                get
                {
                    if(focusPanel == "Front")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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

        class Rear : Shield
        {
            public bool isFocusPanel
            {
                get
                {
                    if (focusPanel == "Rear")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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

        class Top : Shield
        {
            public bool isFocusPanel
            {
                get
                {
                    if (focusPanel == "Top")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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

        class Bottom : Shield
        {
            public bool isFocusPanel
            {
                get
                {
                    if (focusPanel == "Bottom")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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

        class Right : Shield
        {

            public bool isFocusPanel
            {
                get
                {
                    if (focusPanel == "Right")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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

        class Left : Shield
        {
            public bool isFocusPanel
            {
                get
                {
                    if (focusPanel == "Left")
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            public int layer1;
            public int layer2;
            public int layer3;

            public bool layer1Full
            {
                get
                {
                    if (layer1 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer2Full
            {
                get
                {
                    if (layer2 >= maxShieldHitPoints)
                    {
                        return true;
                    }

                    else
                    {
                        return false;

                    }
                }
            }
            public bool layer3Full
            {
                get
                {
                    if (layer3 >= maxShieldHitPoints)
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
}
