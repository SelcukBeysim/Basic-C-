int duljina = int.Parse(Console.ReadLine());
int shirochina = int.Parse(Console.ReadLine());
int visochina = int.Parse(Console.ReadLine());
double procentZaetost = double.Parse(Console.ReadLine());

double obemV_litri = duljina * shirochina * visochina * 0.001;

double faktorZaetost = (100 - procentZaetost) / 100;

double krayenObem_litri = obemV_litri * faktorZaetost;

Console.WriteLine(krayenObem_litri);