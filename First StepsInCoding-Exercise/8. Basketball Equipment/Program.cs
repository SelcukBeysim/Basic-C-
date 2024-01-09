int taxYear = int.Parse(Console.ReadLine());
double shoes = taxYear - taxYear * 0.4;
double outfit = shoes - shoes * 0.2;
double ball = outfit / 4;
double acc = ball / 5;

double result = taxYear + shoes + outfit + ball + acc;

Console.WriteLine(result);