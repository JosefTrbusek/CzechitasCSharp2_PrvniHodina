Console.WriteLine("Zadej jakeho cislo chces nasobky");
int nasobek;
while (!int.TryParse(Console.ReadLine(), out nasobek)||nasobek<1)
{
    Console.WriteLine("Neplatna hodnota, zadej znovu");
}

Console.WriteLine("Zadej limit:");
int limit;
while(!int.TryParse(Console.ReadLine(),out limit)||limit<nasobek)
{
    Console.WriteLine("Spatny limit, zadej znovu:");
}

Console.WriteLine("Násobky:");
for (int i = nasobek; i <= limit; i = i + nasobek)
{
    Console.Write($"{i} ");
}

Console.ReadLine();