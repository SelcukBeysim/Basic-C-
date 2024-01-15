int startingPoints = int.Parse(Console.ReadLine());

double bonusPoints = 0;

if (startingPoints <= 100)
{
    bonusPoints += 5;
}
else if (startingPoints > 1000)
{
    bonusPoints += 0.1 * startingPoints;
}
else
{
    bonusPoints += 0.2 * startingPoints;
}

if (startingPoints % 2 == 0)
{
    bonusPoints += 1;
}
else if (startingPoints % 10 == 5)
{
    bonusPoints += 2;
}

double totalPoints = startingPoints + bonusPoints;

Console.WriteLine($"{bonusPoints}");
Console.WriteLine($"{totalPoints}");