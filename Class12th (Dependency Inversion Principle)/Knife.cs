using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

internal class Knife : Weapon
{
    public Knife()
    {
        power = 10;
        range = 1.25f;
    }
    public override void Attack()
    {
        Console.WriteLine("Attack by knife");
        Console.WriteLine(power + " damage to enemy");
    }
}