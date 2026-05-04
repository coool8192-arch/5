using System;
using System.Collections.Generic;
using System.Text;

internal class User
{
    private string email;
    private string password;

    public string Email { get { return email; } }
    public User(string email, string password)
    {
        this.email = email;
        this.password = password;
    }
}
