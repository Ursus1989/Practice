
string message = CongratulateBoss();
Console.WriteLine(message);
static string CongratulateBoss()
{
    Console.WriteLine("How many subordinates do you have? ");
    int count = int.Parse(Console.ReadLine());

    if (count == 1)
    {
        return "1 employee congratulates you on your anniversary.";
    }
    else if (count >= 2 && count <= 4)
    {
        return count + " employees congratulate you on your anniversary.";
    }
    else
    {
        return "All employees congratulate you on your anniversary.";
    }
}

string birthDate = GetBirthDate();
Console.WriteLine("Your birthdate is: " + birthDate);
static string GetBirthDate()
{
    Console.WriteLine("Please enter your birthdate (DD/MM/YYYY): ");
    string birthDate = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(birthDate))
    {
        Console.WriteLine("Birthdate cannot be empty. Please enter your birthdate: ");
        birthDate = Console.ReadLine();
    }

    return birthDate;
}



int movieCount = GetFavoriteMovies();
Console.WriteLine("Total movies entered: " + movieCount);
static int GetFavoriteMovies()
{
    Console.WriteLine("How many favorite movies do you have? ");
    int count = int.Parse(Console.ReadLine()); 

    if (count <= 0)
    {
        Console.WriteLine("Invalid number. Exiting program.");
        return 0; 
    }

    int i = 1;
    while (i <= count)
    {
        Console.WriteLine("Enter the name of movie " + i + ": ");
        Console.ReadLine(); 
        i = i + 1;
    }

    return count; 
}


    Console.WriteLine("Enter the cost of purchase 1: ");
    double purchase1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the cost of purchase 2: ");
    double purchase2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the cost of purchase 3: ");
    double purchase3 = double.Parse(Console.ReadLine());

    double total = SumPurchases(purchase1, purchase2, purchase3);
    Console.WriteLine("The total cost is: " + total);

    static double SumPurchases(double a, double b, double c)
    {
        return a + b + c;
    }

