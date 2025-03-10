

  Console.WriteLine("1. register");
  Console.WriteLine("2. login");
  Console.Write("Choose option: ");
  string option = Console.ReadLine();

  var users = new List<User>();

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
    var User = users.ElementAt(i);
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


   
}


           

