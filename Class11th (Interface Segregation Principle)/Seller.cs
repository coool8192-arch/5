using System;
using System.Collections.Generic;
using System.Text;

internal class Seller : ISellable, IConversable
{
    public void Conversation()
    {
        Console.WriteLine("Welcome, Take a look.");
    }

    public void Sell()
    {
        Console.WriteLine("Select what you want to buy.");
        Console.WriteLine("1. Healing Potion");
        Console.WriteLine("2. Mana Potion");
        Console.WriteLine("3. Poison Cure Potion");
    }
}