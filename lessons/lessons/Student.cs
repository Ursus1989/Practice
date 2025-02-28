using System.Drawing;

class Student
{
    public string Name;
    public string Classnumber;
    public string Subject;
    public string FavoriteSubject;

    public string GetStudentInfo()
    {
        return "Name:" + Name + "\r\nClassnumber:" + Classnumber + "\r\nSubject:" + Subject;
    }

    public void AskSubjectPreference()
    {
        Console.Write($"Do you like the subject {Subject}? (yes/no): ");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            Console.WriteLine("The lesson will start in an hour.");
        }
        else
        {
            Console.Write("Which subject do you like more? ");
            FavoriteSubject = Console.ReadLine();
        }
    }
}