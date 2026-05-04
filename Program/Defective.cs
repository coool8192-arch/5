using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Defective : Product
    {
        public Defective()
        {
            price = 0;

            instruction = "Defective product. It's valueless.";
        }
    }
}
