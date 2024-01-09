int list = int.Parse(Console.ReadLine());
int listHours = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int time = list / listHours;

int hoursDay = time / days;

Console.WriteLine(hoursDay);