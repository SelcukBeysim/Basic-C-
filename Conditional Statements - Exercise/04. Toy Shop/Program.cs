double excursionPrice = double.Parse(Console.ReadLine());
int puzzlesCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int teddyBearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

// Цени на играчките
double puzzlePrice = 2.60;
double dollPrice = 3.00;
double teddyBearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2.00;

// Обща сума без отстъпка
double totalPrice = (puzzlesCount * puzzlePrice) + (dollsCount * dollPrice) +
                    (teddyBearsCount * teddyBearPrice) + (minionsCount * minionPrice) +
                    (trucksCount * truckPrice);

// Проверка за отстъпка
if ((puzzlesCount + dollsCount + teddyBearsCount + minionsCount + trucksCount) >= 50)
{
    totalPrice -= 0.25 * totalPrice; // 25% отстъпка
}

// Отчет за наема
double rent = 0.10 * totalPrice;
totalPrice -= rent;

// Сравнение с цената на екскурзията
double difference = Math.Abs(excursionPrice - totalPrice);

// Изход
if (totalPrice >= excursionPrice)
{
    Console.WriteLine($"Yes! {difference:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
}