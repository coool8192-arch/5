using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Knight : Unit
    {
        public Knight()
        {
            health = 150;
            defence = 20;
        }
        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
