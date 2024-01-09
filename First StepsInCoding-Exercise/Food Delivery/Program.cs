
int broiPileshkiMenu = int.Parse(Console.ReadLine());
int broiRibniMenu = int.Parse(Console.ReadLine());
int broiVegetarianskiMenu = int.Parse(Console.ReadLine());


double cenaPileshkoMenu = 10.35;
double cenaRibnoMenu = 12.40;
double cenaVegetarianskoMenu = 8.15;
double cenaDesert = 0.2 * (broiPileshkiMenu * cenaPileshkoMenu + broiRibniMenu * cenaRibnoMenu + broiVegetarianskiMenu * cenaVegetarianskoMenu);

double obshtaSuma = broiPileshkiMenu * cenaPileshkoMenu + broiRibniMenu * cenaRibnoMenu + broiVegetarianskiMenu * cenaVegetarianskoMenu + cenaDesert;

double cenaDostavka = 2.50;

double obshtaSumaSDostavka = obshtaSuma + cenaDostavka;

Console.WriteLine(obshtaSumaSDostavka);