using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Knight : Soldier
    {
        public Knight()
        {
            health = 150;
            defense = 20;
        }
        public override void Attack()
        {
            Console.WriteLine("Knight's attack!");
        }
    }
}
