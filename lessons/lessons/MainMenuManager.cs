namespace lessons;

class MainMenuManager
{
    public void ShowMainMenu(User currentUser, ProductManager productManager)
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
            if (choice == "1")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Product Menu");
                    Console.WriteLine("1. Add product");
                    Console.WriteLine("2. Show products");
                    Console.WriteLine("3. Delete");
                    Console.WriteLine("4. Edit products");
                    Console.WriteLine("5. Back");


                    string productChoice = Console.ReadLine();

                    if (productChoice == "1")
                    {
                        Console.Clear();
                        var product = productManager.CreateProduct();
                        productManager.AddProduct(product);
                    }
                    else if (productChoice == "2")
                    {
                        Console.Clear();
                        productManager.ShowProducts();
                    }
                    
                    else if (productChoice == "3")
                    {
                        Console.Clear();
                        productManager.DeleteProduct();
                    }

                    else if (productChoice == "4")
                    {
                        Console.Clear();
                        productManager.EditProduct();
                    }
                }
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}
