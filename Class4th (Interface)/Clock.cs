using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Clock : ISelectable, IActivatable
    {

        public void select()
        {
            Console.WriteLine("Try Checking the clock.");
        }
        public void activate()
        {
            Console.WriteLine("Current time : " + DateTime.Now.ToString("HH:mm:ss"));
        }
}
}
