var users = new List<User>();

while (true)
{
    Console.Clear();
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

        Console.WriteLine("User registered successfully");

        var user = new User(username, password);
        users.Add(user);

        for (int i = 0; i < users.Count; i++)
        {
            user = users.ElementAt(i);
            Console.WriteLine($"user {i + 1}: {user.Username}");
        }
    }
    else if (option == "2")
    {
        Console.WriteLine("Login");
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        for (int i = 0; i < users.Count; i++)
        {
            var currentUser = users.ElementAt(i);

            if (currentUser.Username == username &&
                currentUser.Password == password)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {currentUser.Username}");
                    Console.WriteLine("1. Products");
                    Console.WriteLine("2. Coupons");
                    Console.WriteLine("3. Change user adress");
                    Console.WriteLine("4. Change user password");
                    Console.WriteLine("5. Show order history");
                    Console.WriteLine("6. Log out");

                    var choice = Console.ReadLine();
                    if (choice == "6")
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine("User with this name and password does not exist");
    }
}




