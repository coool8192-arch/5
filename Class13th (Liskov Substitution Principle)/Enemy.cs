using System;
using System.Collections.Generic;
using System.Text;

internal abstract class Enemy
{
    protected int health;

    public abstract void Patrol();

    public abstract void Attack();
}