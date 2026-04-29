using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

    internal class Enumerator<T> : IEnumerator
{
    private int position = -1;
    private int count;
    private T[] items;

    public object Current => items[position];

    public bool MoveNext()
    {
        position++;

        return position < count;
    }

    public void Reset()
    {
        position = -1;
    }


    public Enumerator(T[] items,int count)
    {
        this.items = items;
        this.count = count;
    }
}

