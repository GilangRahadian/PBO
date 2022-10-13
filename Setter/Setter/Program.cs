// Include namespace system
using System;


public class User
{
    public String username;
    public String password;
    public User(String username, String password)
    {
        this.username = username;
        this.password = password;
    }
}
public class DemoConstructor
{
    public static void Main(String[] args)
    {
        var petani = new User("petanikode", "kopi");
        Console.WriteLine("Username: " + petani.username);
        Console.WriteLine("Password: " + petani.password);
    }
}