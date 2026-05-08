using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
        currentCount += 1;

        if (weaponSlot.Count <= currentCount)
        {
            currentCount = 0;
        }
    }

    public void Use()
    {
        weaponSlot[currentCount].Attack();
    }
}