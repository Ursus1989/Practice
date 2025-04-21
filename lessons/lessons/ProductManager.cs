public class ProductManager
{
    private List<Product> products = new List<Product>();
    public Product CreateProduct()
    {
        Console.WriteLine("Add new product");

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product description: ");
        string description = Console.ReadLine();

        Console.Write("Enter product price: ");
        string priceInput = Console.ReadLine();
        decimal price;
        if (!decimal.TryParse(priceInput, out price) || price <= 0)
        {
            Console.WriteLine("Invalid price.");
            Console.ReadKey();
            return null;
        }

        var product = new Product(name, description, price);

        Console.WriteLine("Product created successfully!");
        Console.ReadKey();

        return product;
    }
    public void AddProduct(Product product)

    {
        products.Add(product);
    }
    public void ShowProducts()
    {
        Console.WriteLine("Product list:");

        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}");
            }
        }

        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
    public void DeleteProduct()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available to delete.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Select a product to delete:");
        int i = 1;
        foreach (Product product in products)
            Console.WriteLine(i++ + ". " + product.Name);
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > products.Count)
            Console.WriteLine("Invalid selection. Press any key...");
        else
        {
            string deletedProductName = products.ElementAt(choice - 1).Name;
            products.RemoveAt(choice - 1);
            Console.WriteLine("Product \"" + deletedProductName + "\" has been deleted.");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public void EditProduct()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products to edit.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Product list:");
        for (int i = 0; i < products.Count; i++)
            Console.WriteLine((i + 1) + ". " + products.ElementAt(i).Name);
        Console.Write("Select product number: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > products.Count)
        {
            Console.WriteLine("Invalid selection.");
            Console.ReadKey();
            return;
        }
        Product product = products.ElementAt(choice - 1);
        Console.Write("New name: ");
        product.Name = Console.ReadLine();
        Console.Write("New description: ");
        product.Description = Console.ReadLine();
        Console.Write("New price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal newPrice) && newPrice > 0)
            product.Price = newPrice;
        Console.WriteLine("Product updated successfully.");
        Console.ReadKey();
    }
}