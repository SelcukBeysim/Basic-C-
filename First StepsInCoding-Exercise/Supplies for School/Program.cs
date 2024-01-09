int broiPaketiHimikali = int.Parse(Console.ReadLine());
int broiPaketiMarkeri = int.Parse(Console.ReadLine());
int litriPrepParachka = int.Parse(Console.ReadLine());
int namalenieProcent = int.Parse(Console.ReadLine());

// Цени на продуктите
double cenaPaketHimikali = 5.80;
double cenaPaketMarkeri = 7.20;
double cenaPrepParachka = 1.20;

// Изчисляване на общата сума преди намалението
double obshtaSuma = (broiPaketiHimikali * cenaPaketHimikali) + (broiPaketiMarkeri * cenaPaketMarkeri) + (litriPrepParachka * cenaPrepParachka);

// Изчисляване на сумата след намалението
double sumaSNamalenie = obshtaSuma - (obshtaSuma * namalenieProcent / 100);

// Отпечатване на резултата
Console.WriteLine(sumaSNamalenie);