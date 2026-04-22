using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Switch : ISelectable, IActivatable
    {
        private bool OnOff = false;
        public void select()
        {
            Console.WriteLine("Try checking the switch.");
        }
        public void activate()
        {

            OnOff = !OnOff;

            if (OnOff)
            {
                Console.WriteLine("Switch is turned on.");
            }
            else
            {
                Console.WriteLine("Switch is turned off.");
            }
        }
}
}
