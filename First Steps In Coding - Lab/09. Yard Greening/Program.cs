double yard = double.Parse(Console.ReadLine());

double price = yard * 7.61;
double discount = price * 0.18;

double finalPrice = price - discount;

Console.WriteLine($"{finalPrice} lv.");
Console.WriteLine($"{discount} lv.");