int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

DateTime currentTime = new DateTime(2022, 1, 1, hours, minutes, 0);
DateTime newTime = currentTime.AddMinutes(15);

int newHours = newTime.Hour;
int newMinutes = newTime.Minute;

Console.WriteLine($"{newHours:D1}:{newMinutes:D2}");