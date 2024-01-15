// Входни данни
double worldRecordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsPerMeter = double.Parse(Console.ReadLine());

// Изчисления
double timeNeeded = distanceInMeters * timeInSecondsPerMeter;
double resistanceTime = Math.Floor(distanceInMeters / 15) * 12.5; // Забавяне поради съпротивлението
double totalTime = timeNeeded + resistanceTime;

// Проверка за подобрение на световния рекорд
if (totalTime < worldRecordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    double secondsSlower = totalTime - worldRecordInSeconds;
    Console.WriteLine($"No, he failed! He was {secondsSlower:F2} seconds slower.");
}