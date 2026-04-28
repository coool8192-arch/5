using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Enumerator<T> : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private int position = -1;
        private int count = 0;
        T[] items;

        public Enumerator()
        {

        }
    }
}
