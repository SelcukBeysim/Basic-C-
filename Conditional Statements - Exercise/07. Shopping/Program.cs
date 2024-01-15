// Входни данни
double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramModules = int.Parse(Console.ReadLine());

// Цени
double videoCardPrice = 250.0;
double processorPricePercentage = 35.0;
double ramPricePercentage = 10.0;

// Изчисления
double videoCardsCost = videoCards * videoCardPrice;
double processorsCost = processors * (videoCardsCost * processorPricePercentage / 100.0);
double ramCost = ramModules * (videoCardsCost * ramPricePercentage / 100.0);

double totalCost = videoCardsCost + processorsCost + ramCost;

// Отстъпка за видеокарти
if (videoCards > processors)
{
    totalCost -= totalCost * 0.15;
}

// Проверка за достатъчен бюджет
if (budget >= totalCost)
{
    double remainingBudget = budget - totalCost;
    Console.WriteLine($"You have {remainingBudget:F2} leva left!");
}
else
{
    double neededMoney = totalCost - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
}