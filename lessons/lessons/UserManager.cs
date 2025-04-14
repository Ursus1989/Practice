
namespace lessons;

class UserManager
{
    private List<User> users = new List<User>();

    public void RegisterUser()
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

    public User Login()
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
                return currentUser;
            }
        }

        return null;
    }
}
