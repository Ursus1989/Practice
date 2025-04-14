using lessons;

var productManager = new ProductManager();
var usermanager = new UserManager();
var mainmenu = new MainMenuManager();
while (true)
{
    Console.Clear();
    Console.WriteLine("1. register");
    Console.WriteLine("2. login");
    Console.Write("Choose option: ");
    string option = Console.ReadLine();


    if (option == "1")
    {
        usermanager.RegisterUser();
    }
    else if (option == "2")
    {
       var currentUser= usermanager.Login();

        if (currentUser == null)
        {
            continue;
        }

        mainmenu.ShowMainMenu(currentUser, productManager);
    }
}









