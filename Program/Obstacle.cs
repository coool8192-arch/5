using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Obstacle
    {
        private int x = 0;
        private int y = 0;

        public void Translate(int x,int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
        }
    }
}
