using System.Net.Sockets;

var tourist1 = new Tourist();
tourist1.Name = "Roman";
tourist1.Age = 35;
tourist1.Destination="Russia";
var info = tourist1.GetTouristInfo();
Console.WriteLine(info);
Console.ReadLine();


var Jacket = new Outwear();
Jacket.Name = "Polo";
Jacket.Color = "black";
Jacket.Size = "M";
Jacket.Price = 79;
var info1 = Jacket.GetOutwearInfo();
Console.WriteLine(info1);
Console.ReadLine();
Jacket.SetPrice(100);
Console.WriteLine("Clothing Information:");
Jacket.DisplayFullInfo();
Console.WriteLine();
Console.ReadLine();

var Coat = new Outwear();
Coat.Name = "CalvinKlein";
Coat.Color = "white";
Coat.Size = "S";
Coat.Price = 99;
var info2 = Coat.GetOutwearInfo();
Console.WriteLine(info2);
Console.ReadLine();
Console.WriteLine("Clothing Information:");
Coat.DisplayFullInfo();
Console.WriteLine();
Console.ReadLine();


var Furcoat = new Outwear();
Furcoat.Name = "Burberry";
Furcoat.Color = "brown";
Furcoat.Size = "L";
Furcoat.Price = 1499;
var info3 = Furcoat.GetOutwearInfo();
Console.WriteLine(info3);
Console.ReadLine();
Console.WriteLine("Clothing Information:");
Furcoat.DisplayFullInfo();
Console.WriteLine();
Console.ReadLine();


var Student1 = new Student();
Student1.Name = "Alex";
Student1.Classnumber = "10B";
Student1.Subject = "Geometry";
var info4 = Student1.GetStudentInfo();
Console.WriteLine(info4);
Console.ReadLine();
Student1.AskSubjectPreference();
Console.ReadLine();


var Student2 = new Student();
Student2.Name = "Peter";
Student2.Classnumber = "9C";
Student2.Subject = "Biology";
var info5 = Student2.GetStudentInfo();
Console.WriteLine(info5);
Console.ReadLine();
Student2.AskSubjectPreference();
Console.ReadLine();