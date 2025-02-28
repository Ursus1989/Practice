class Tourist
{
    public string Name;
    public int Age;
    public string Destination;
    
    public string GetTouristInfo()
    {
        return "Name: "+Name + "\r\nAge: " + Age + "\r\nDestination: " + Destination;
    }
}