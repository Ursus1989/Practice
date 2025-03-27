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
}