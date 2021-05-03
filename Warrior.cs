using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;
using WarriorWars.Tools;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_START_HEALTH = 50;
        private const int BAD_START_HEALTH = 50;

        private Category category;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive 
        { 
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armour armour;

        public Warrior(string name, Category category)
        {
            this.name = name;
            this.category = category;
            isAlive = true;
       


            switch (category)
	        {
		        case Category.GoodGuy:
                    weapon = new Weapon(category);
                    armour = new Armour(category);
                    health = GOOD_START_HEALTH;
                 break;

                case Category.BadGuy:
                    weapon = new Weapon(category);
                    armour = new Armour(category);
                    health = BAD_START_HEALTH;
                 break;

                default:
                 break;
	        }


        }

        public void Fight(Warrior opponent)
        {
            int damage = weapon.Strength / opponent.armour.ArmourPoints;

            opponent.health = opponent.health - damage;

            if (opponent.health <= 0)
            {
                opponent.isAlive = false;
                Console.WriteLine($"{opponent.name} is lost and {name} has won");
            }
            else
            {
                Console.WriteLine($"{name} attacked {opponent.name}. {damage} damage inflicted. Remaining health = {opponent.health}");
            }
        }
    }
}
