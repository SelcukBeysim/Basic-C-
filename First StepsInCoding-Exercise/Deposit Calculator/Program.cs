double deposit = double.Parse(Console.ReadLine());
int time = int.Parse(Console.ReadLine());
double procent =  double.Parse(Console.ReadLine())/100;

double sum = deposit + time * ((deposit * procent) / 12);

Console.WriteLine(sum);