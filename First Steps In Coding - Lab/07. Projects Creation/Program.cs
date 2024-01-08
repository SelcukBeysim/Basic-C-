string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int clock = projects * 3;

Console.WriteLine($"The architect {name} will need {clock} hours to complete {projects} project/s.");