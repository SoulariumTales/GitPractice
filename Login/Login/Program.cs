using System;

class Login
{
    public void LoginUser(string username, string password)
    {
        if (username == "admin" && password == "123456")
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }
}