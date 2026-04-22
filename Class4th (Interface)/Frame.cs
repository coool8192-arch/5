using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Frame : ISelectable
    {
        public void select()
        {
            Console.WriteLine("Try checking the frame.");
        }
    }
}
