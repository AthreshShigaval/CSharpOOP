using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;

namespace WarriorWars.Tools
{
    class Armour
    {

        private const int GOOD_ARMOUR_POINTS = 5;
        private const int BAD_ARMOUR_POINTS = 5;

        private int armourPoints;

        public int ArmourPoints
        { 
            get
            {
                return armourPoints;
            }
        }

        public Armour(Category category)
        {
            switch (category)
            {
                case Category.GoodGuy:
                    armourPoints = GOOD_ARMOUR_POINTS;
                    break;
                case Category.BadGuy:
                    armourPoints = BAD_ARMOUR_POINTS;
                    break;
                default:
                    break;
            }
        }
    }
}
