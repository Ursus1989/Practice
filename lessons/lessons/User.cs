﻿public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Adress { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}



