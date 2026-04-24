using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Obstacle
    {
        private int x = 0;
        private int y = 0;

        public void SetPosition(int x,int y)
        {
            this.x = x;
            this.y = y;

            Console.SetCursorPosition(this.x, this.y);
        }

        public void Render()
        {
            Console.Write("◇");
        }
    }
}
