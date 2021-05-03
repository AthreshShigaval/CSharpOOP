using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;

namespace WarriorWars.Tools

{
    class Weapon
    {
        private const int GOOD_GUY_STRENGTH = 10;
        private const int BAD_GUY_STRENGTH = 10;

        private int strength;

        public int Strength 
        {
            get
            {
                return strength;
            }
        }

        public Weapon(Category category)
        {
            switch (category)
            {
                case Category.GoodGuy:
                    strength = GOOD_GUY_STRENGTH;
                    break;
                case Category.BadGuy:
                    strength = BAD_GUY_STRENGTH;
                    break;
                default:
                    break;
            }
        }
    }
}
