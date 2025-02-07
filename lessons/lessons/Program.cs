using System.ComponentModel.Design;

var firstName = GetUserName();
static string GetUserName()
{
    Console.WriteLine("What is your firstName?");
    return Console.ReadLine();
}

var lastName = GetUserlastName();
static string GetUserlastName()
{
    Console.WriteLine("what is your lastName?");
    return Console.ReadLine();
}

int age = GetUserAge();
static int GetUserAge()
{
    Console.Write("How old are you? ");
    int age;
    while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
    {
        Console.Write("Invalid input. Please enter a valid age: ");
    }
    return age;
}

var gender = GetUserGender();
static string GetUserGender()
{
    Console.WriteLine("What is your gender? (Male/Female):");
    return Console.ReadLine();
}

var isMarried = IsUserMarried();
static bool IsUserMarried()
{
    Console.Write("Are you married? (Yes/No):");
    var answer = Console.ReadLine().ToLower();
    return answer == "Yes";
}

bool likesCoffee = LikesCoffee();
Console.WriteLine("Likes Coffee:" + likesCoffee);
static bool LikesCoffee()
{
    Console.WriteLine("Do you like Coffee? (Yes/No):");
    string answer = Console.ReadLine();
    if (answer == "Yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string allergies = GetAllergies();
Console.WriteLine("Allergie Information:" + allergies);
static string GetAllergies()
{
    Console.WriteLine("Do you have allergies? (Yes/No):");
    string answer = Console.ReadLine();
    if (answer == "Yes")
    {
        Console.WriteLine("What are you allergic to?");
        return Console.ReadLine();
    }
    return "No allergies";
}

var marriage = GetMarriageCount();
static int GetMarriageCount()
{
    Console.Write("How many times have you been married? (0-100): ");
    int count;
    while (!int.TryParse(Console.ReadLine(), out count) || count < 0 || count > 100)
    {
        Console.Write("Invalid input. Please enter a number between 0 and 100: ");
    }
    return count;
}


string compliment = ComplimentUser();
Console.WriteLine(compliment);
static string ComplimentUser()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    return "Dear" +  name  + ",you look beautiful as always today!";
}








