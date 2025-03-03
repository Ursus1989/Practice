

        Console.WriteLine("1. register");
        Console.WriteLine("2. login");
        Console.Write("Choose option: ");
        string option = Console.ReadLine();

if (option == "1")
{
    Console.WriteLine("Register new user");
    Console.Write("Enter username: ");
    string username = Console.ReadLine();
    Console.Write("Enter password: ");
    string password = Console.ReadLine();
    var user1 = new User(username, password);
    Console.WriteLine("User registered successfully");
}
else if (option == "2")
{
    Console.WriteLine("Login");
    Console.Write("Enter username: ");
    string username = Console.ReadLine();
    Console.Write("Enter password: ");
    string password = Console.ReadLine();
}



           

