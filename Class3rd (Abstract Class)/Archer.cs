using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Archer : Soldier
    {
        public Archer()
        {
            health = 100;
            defense = 10;
        }
        public override void Attack()
        {
            Console.WriteLine("Archer's attack!");
        }
    }
}
