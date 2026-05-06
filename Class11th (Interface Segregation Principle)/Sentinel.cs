using System;
using System.Collections.Generic;
using System.Text;

internal class Sentinel : IDamageable, IConversable
{
    private int health;

    public Sentinel()
    {
        health = 100;
    }
    public void Conversation()
    {
        Console.WriteLine("Oh, Is it time to fight?");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        Console.WriteLine("Sentinel takes " + damage + " damage!");
        Console.WriteLine("Sentinel's current health : " + health);

        if (health <= 0)
        {
            Console.WriteLine("Sentinel is fainted!");
        }
    }
}