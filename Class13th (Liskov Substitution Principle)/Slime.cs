using System;
using System.Collections.Generic;
using System.Text;

internal class Slime : Enemy
{
    public Slime()
    {
        health = 20;
    }

    public override void Attack()
    {
        Console.WriteLine("Slime's body slam");
    }

    public override void Patrol()
    {
        Console.WriteLine("Slime is wandering nearby.");
    }
}