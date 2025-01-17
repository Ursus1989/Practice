
Console.WriteLine("what is your name?");
var Admin = "yes";
if (Admin == "yes")
{
    Console.WriteLine("are you Admin?");
}

Console.WriteLine("Enter your gender (male or female):");
var gender = Console.ReadLine();

if (gender == "male")
{
    Console.WriteLine("are you married? (yes or no):");
    var isMarried = Console.ReadLine();

    if (isMarried == "yes")
    {
        Console.WriteLine("you are married.");
    }
    else if (isMarried == "no")
    {
        Console.WriteLine("yor are not married.");
    }
}
else if (gender == "female")
{
    Console.WriteLine("are you married? (yes or no):");
    var isMarried = Console.ReadLine();

    if (isMarried == "yes")
    {
        Console.WriteLine("you are married.");
    }
    else if (isMarried == "no")
    {
        Console.WriteLine("you are not married.");
    }
}

Console.WriteLine("How old are you?");
var ageInput = Console.ReadLine();
var age = Int32.Parse(ageInput);
if (age < 18)
{
    Console.WriteLine("Access Denied");
}
else
{
    Console.WriteLine("Access Granted");
}

Console.WriteLine("where do you live?");
var country = Console.ReadLine();
if(country=="Russian Federation")
{
    Console.WriteLine("You live in Russian Federation");
}
else if (country == "China")
{
    Console.WriteLine("You live in China");
}
else if (country == "Turkey")
{
    Console.WriteLine("You live in Turkey");
}
else
{
    Console.WriteLine($"You live in country:{country}");
}

   
































