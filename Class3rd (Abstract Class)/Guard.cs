using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Guard : Soldier
    {
        public Guard()
        {
            health = 250;
            defense = 30;
        }
        public override void Attack()
        {
            Console.WriteLine("Guard's attack!");
        }
    }
}
