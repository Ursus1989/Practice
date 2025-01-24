
for(var position = 0; position < 100; position = position + 1)
{
    Console.WriteLine(position);
}

for(var position = 1; position <100; position++)
{
    Console.WriteLine($"Line:{position}");
}

for (var position = 0; position <= 50; position++)
{
    if ((position >= 10 && position <= 20) || (position >= 40 && position <= 50))
    {
        Console.WriteLine(position);
    }
}

var sum = 0;
for (var position = 0; position < 1000; position++)
{
    sum += position;
    if (sum > 100000)
    {
        Console.WriteLine($"The total amount is more than 100000:{position}");
        break;
    }

}

for (var position = 0; position <= 100; position++)
{
    if ((position / 2) * 2 == position)
        Console.WriteLine(position);
}


  





