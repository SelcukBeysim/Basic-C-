
int neobhodimNylon = int.Parse(Console.ReadLine());
int neobhodimBoya = int.Parse(Console.ReadLine());
int kolichestvoRazreditel = int.Parse(Console.ReadLine());
int chasoveMajstori = int.Parse(Console.ReadLine());

// Цени на материалите
double cenaNylon = 1.50;
double cenaBoya = 14.50;
double cenaRazreditel = 5.00;

// Допълнителни разходи
double dopulnitelnoKolichestvoBoya = 0.1 * neobhodimBoya;
double dopulnitelnoKolichestvoNylon = 2.0;
double cenaTorbichki = 0.40;

// Изчисляване на сумата на материалите
double sumaMateriali = (neobhodimNylon + dopulnitelnoKolichestvoNylon) * cenaNylon +
                      (neobhodimBoya + dopulnitelnoKolichestvoBoya) * cenaBoya +
                      kolichestvoRazreditel * cenaRazreditel +
                      cenaTorbichki;

// Изчисляване на сумата за часовете на майсторите
double sumaMajstori = 0.3 * sumaMateriali * chasoveMajstori;

// Обща сума на разходите
double obshtaSuma = sumaMateriali + sumaMajstori;

// Отпечатване на резултата
Console.WriteLine(obshtaSuma);