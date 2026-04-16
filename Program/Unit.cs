using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal abstract class Unit
    {
        protected int health;
        protected int defence;

        public abstract void Attack();
    }
}
