// Входни данни
        double budget = double.Parse(Console.ReadLine());
int actorsCount = int.Parse(Console.ReadLine());
double clothingPricePerActor = double.Parse(Console.ReadLine());

// Изчисления
double decorPrice = budget * 0.10;
double totalClothingPrice = actorsCount * clothingPricePerActor;

// Проверка за отстъпка за облеклото
if (actorsCount > 150)
{
    totalClothingPrice -= 0.10 * totalClothingPrice; // 10% отстъпка
}

// Общи разходи
double totalExpenses = decorPrice + totalClothingPrice;

// Изход
if (totalExpenses > budget)
{
    double neededMoney = totalExpenses - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double remainingMoney = budget - totalExpenses;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
}