// Входни данни
string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

// Изчисления
double lunchTime = breakDuration * 1.0 / 8;
double relaxationTime = breakDuration * 1.0 / 4;
double totalWatchingTime = breakDuration - lunchTime - relaxationTime;

// Проверка за достатъчно време
if (totalWatchingTime >= episodeDuration)
{
    int remainingTime = (int)Math.Ceiling(totalWatchingTime - episodeDuration);
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {remainingTime} minutes free time.");
}
else
{
    int neededTime = (int)Math.Ceiling(episodeDuration - totalWatchingTime);
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neededTime} more minutes.");
}