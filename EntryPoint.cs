using System;
using System.Threading;
using WarriorWars.Enum;
using WarriorWars.Tools;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rnd = new Random();
        static void Main()
        {
            Warrior goodHuman = new Warrior("Good", Category.GoodGuy);
            Warrior badHuman = new Warrior("Evil", Category.BadGuy);

            while (goodHuman.IsAlive && badHuman.IsAlive)
            {
                if (rnd.Next(1,100) > 50)
                {
                    badHuman.Fight(goodHuman);
                }
                else
                {
                    goodHuman.Fight(badHuman);
                }
                Thread.Sleep(500);

            }
        }
    }
}
