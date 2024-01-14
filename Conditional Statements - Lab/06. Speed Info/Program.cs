if (double.TryParse(Console.ReadLine(), out double speed))
{
    if (speed <= 10)
    {
        Console.WriteLine("slow");
    }
    else if (speed <= 50)
    {
        Console.WriteLine("average");
    }
    else if (speed <= 150)
    {
        Console.WriteLine("fast");
    }
    else if (speed <= 1000)
    {
        Console.WriteLine("ultra fast");
    }
    else
    {
        Console.WriteLine("extremely fast");
    }
}
else
{
    Console.WriteLine("Грешен формат на входните данни. Моля, въведете реално число.");
}