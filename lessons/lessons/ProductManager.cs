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
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name}");
        }

        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice > 0 && choice <= products.Count)
        {
            string deletedProductName = products[choice - 1].Name;
            products.RemoveAt(choice - 1);
            Console.WriteLine($"Product \"{deletedProductName}\" has been successfully deleted.");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter a valid product number.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
    public void EditProduct()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available to edit.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Select a product to edit:");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name}");
        }

        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice > 0 && choice <= products.Count)
        {
            var product = products[choice - 1];
            Console.WriteLine($"Editing product: {product.Name}");
            Console.WriteLine("Leave the field empty to keep the current value.");

            Console.Write($"Enter new name (current: {product.Name}): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                product.Name = newName;
            }

            Console.Write($"Enter new description (current: {product.Description}): ");
            string newDescription = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newDescription))
            {
                product.Description = newDescription;
            }

            Console.Write($"Enter new price (current: {product.Price}): ");
            string newPriceInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPriceInput))
            {
                if (decimal.TryParse(newPriceInput, out decimal newPrice) && newPrice > 0)
                {
                    product.Price = newPrice;
                }
                else
                {
                    Console.WriteLine("Invalid price entered. Keeping the original price.");
                }
            }

            Console.WriteLine("Product updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter a valid product number.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}