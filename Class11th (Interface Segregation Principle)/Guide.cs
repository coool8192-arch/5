using System;
using System.Collections.Generic;
using System.Text;

internal class Guide : IConversable
{
    public void Conversation()
    {
        Console.WriteLine("Hello! Do you want to know something?");
    }
}