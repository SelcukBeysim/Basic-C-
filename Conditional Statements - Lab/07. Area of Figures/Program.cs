string figureType = Console.ReadLine().ToLower();

double area = 0;

if (figureType == "square")
{
    Console.Write("Въведете дължина на страната на квадрата: ");
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (figureType == "rectangle")
{
    Console.Write("Въведете дължина на правоъгълника: ");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Въведете ширина на правоъгълника: ");
    double width = double.Parse(Console.ReadLine());
    area = length * width;
}
else if (figureType == "circle")
{
    Console.Write("Въведете радиуса на кръга: ");
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
}
else if (figureType == "triangle")
{
    Console.Write("Въведете дължината на страната на триъгълника: ");
    double triangleSide = double.Parse(Console.ReadLine());
    Console.Write("Въведете дължината на височината към тази страна: ");
    double height = double.Parse(Console.ReadLine());
    area = 0.5 * triangleSide * height;
}
else
{
    Console.WriteLine("Невалиден вид на фигурата.");
    return;
}

Console.WriteLine($"Лицето на фигурата е: {area}");