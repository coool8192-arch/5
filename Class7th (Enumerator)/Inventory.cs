using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Inventory<T> : IEnumerable
{
    private T[] list;
    private int count = 0;

    public Inventory()
    {
        list = new T[5];
    }
    public IEnumerator GetEnumerator()
    {
        return new Enumerator<T>(list, count);
    }

    public void Add(T item)
    {
        if (count < list.Length)
        {
            list[count++] = item;
        }
        else
        {
            Console.WriteLine("Inventory is full.");
        }
    }
}
