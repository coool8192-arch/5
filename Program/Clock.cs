using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Clock : ISelectable
    {
        public void select()
        {
            Console.WriteLine("Try Checking the clock.");
        }
    }
}
