using System;
using System.Collections.Generic;
using System.Text;

internal abstract class Weapon
{
    protected int power;
    protected float range;

    public abstract void Attack();
}