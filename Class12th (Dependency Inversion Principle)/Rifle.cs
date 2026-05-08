using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

internal class Rifle : Weapon
{
    public Rifle()
    {
        power = 3;
        range = 12.75f;
    }
    public override void Attack()
    {
        Console.WriteLine("Attack by rifle");
        Console.WriteLine(power + " damage to enemy");
    }
}