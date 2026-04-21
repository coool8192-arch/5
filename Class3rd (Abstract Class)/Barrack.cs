using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Barrack
    {
        private int count = 0;
        private Soldier[] soldiers = new Soldier[5];

        public void Create(int select)
        {
            if (count < soldiers.Length)
            {
                switch (select)
                {
                    case 1:
                    soldiers[count] = new Knight();
                        break;
                    case 2:
                    soldiers[count] = new Archer();
                        break;
                    case 3:
                    soldiers[count] = new Guard();
                        break;
                    default: Console.WriteLine("Exception");
                        break;
                }
                count++;
            }
            else
            {
                Console.WriteLine("No more unit can be trained");
            }
        }

        public void Battle()
        {
            foreach(Soldier element in soldiers)
            {
                if (element != null)
                {
                    element.Attack();
                }
            }
        }

    }
}
