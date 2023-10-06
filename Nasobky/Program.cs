// Program pro výpis násobků čísla zadaného uživatelem do čísla zadaného uživatelem
Console.WriteLine("Zadej jakeho cislo chces nasobky");

// nacteni jakeho cisla nasobky chce uzivatel
int nasobek;
// pokud uzivatel nezadá číslo nebo číslo je menší než 1(tedy je pro násobky nesmyslné)
// tak je uzivatel vyzvan k opakovanému zadání
while (!int.TryParse(Console.ReadLine(), out nasobek)||nasobek<1)
{
    Console.WriteLine("Neplatna hodnota, zadej znovu");
}

// zadání limitu do jakého čísla se mají násobky vypsat
Console.WriteLine("Zadej limit:");
int limit;
// uzivatel opakuje zadaní dokud nezadá číslo které je větší než násobek(jinak by nebylo možné něco vypsat)
while(!int.TryParse(Console.ReadLine(),out limit)||limit<nasobek)
{
    Console.WriteLine("Spatny limit, zadej znovu:");
}

// Výpis násobků pomocí cyklu for, který má přírustek o násobek
Console.WriteLine("Násobky:");
for (int i = nasobek; i <= limit; i = i + nasobek)
{
    Console.Write($"{i} ");
}

Console.ReadLine();