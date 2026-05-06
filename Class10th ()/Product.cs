using System;
using System.Collections.Generic;
using System.Text;

internal abstract class Product
{
    protected string instruction;
    protected int price;
    public void Descirbe()
    {
        Console.WriteLine("Price : " + price);
        Console.WriteLine("Insturction : " + instruction);
        Console.WriteLine();
    }
}