class Outwear
{
    public string Name;
    public string Color;
    public string Size;
    public double Price;

    public string GetOutwearInfo()
    {
        return "Name:" + Name + "\r\nColor:" + Color + "\r\nSize:" + Size + "\r\nPrice:" + Price;
    }
    public void SetPrice(double price)
    {
        if (price > 0)
        {
            Price = price;
        }
    }

    public void ShowText(string text)
    {
        Console.WriteLine(text);
    }

    public void DisplayFullInfo()
    {
        Console.Write("Enter the clothing category: ");
        string category = Console.ReadLine();

        string info = "Category: " + category + "\n" +
                      "Name: " + Name + "\n" +
                      "Color: " + Color + "\n" +
                      "Size: " + Size + "\n" +
                      "Price: $" + Price;

        ShowText(info);
    }



}