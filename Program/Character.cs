using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Program
{
    internal class Character
    {
        private List<Weapon> weaponSlot;
        private int currentCount;
        public Character()
        {
            weaponSlot = new List<Weapon>();
        }
        public void Acquire(Weapon weapon)
        {
            weaponSlot.Add(weapon);
        }

        public void Swap()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    currentCount += 1;

                    if (weaponSlot.Count <= currentCount)
                    {
                        currentCount = 0;
                    }
                }
            }
        }

        public void Use()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    weaponSlot[currentCount].Attack();
                }
            }
        }
    }
}
