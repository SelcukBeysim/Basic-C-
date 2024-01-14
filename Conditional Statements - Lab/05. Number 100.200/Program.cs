if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number < 100)
    {
        Console.WriteLine("Less than 100");
    }
    else if (number >= 100 && number <= 200)
    {
        Console.WriteLine("Between 100 and 200");
    }
    else
    {
        Console.WriteLine("Greater than 200");
    }
}
else
{
    Console.WriteLine("Грешен формат на входните данни. Моля, въведете цяло число.");
}