using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Factory<T> where T : new()
    {
        private T[] objects;
        private int count;

        public Factory(int size = 5)
       {
            objects = new T[size];
       }

        public T Instantiate()
        {
            if (count >= objects.Length)
            {
                Console.WriteLine("You can't create anymore.");

                return default;
            }
            T clone = new();

            objects[count]= clone;

            return objects[count++];
        }
    }
}
