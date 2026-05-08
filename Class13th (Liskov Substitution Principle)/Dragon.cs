using System;
using System.Collections.Generic;
using System.Text;

internal class Dragon : Enemy, IFlyable
{
    public Dragon()
    {
        health = 1000;
    }
    public override void Attack()
    {
        Console.WriteLine("Dragon's breath attack");
    }

    public void Fly()
    {
        Console.WriteLine("Dragon is flying.");
    }

    public override void Patrol()
    {
        Console.WriteLine("Dragon is looking around.");
    }
}