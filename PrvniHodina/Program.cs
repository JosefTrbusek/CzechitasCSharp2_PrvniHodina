using PrvniHodina;

Random random = new Random();
Console.WriteLine("Zadej pocet startujicich koni");
string pocetText = Console.ReadLine();
int pocet;
while(!int.TryParse(pocetText,out pocet)||pocet<1)
{
    Console.WriteLine("Toto není spravna hodnota, zadej znovu:");
    pocetText= Console.ReadLine();
}

Kun[] startovniPole = new Kun[pocet];

for (int i = 0; i < startovniPole.Length; i++)
{
    Console.WriteLine($"Zadej jméno {i+1}. koně:");
    startovniPole[i]=new Kun();
    startovniPole[i].Jmeno = Console.ReadLine();
    startovniPole[i].Cas = random.Next(60000, 120000) / 100d;
}

for (int i = 0; i < startovniPole.Length; i++)
{
    Console.WriteLine($"{startovniPole[i].Jmeno}\t{startovniPole[i].Cas}s");
}

Kun nejrychlejsi = startovniPole[0];
for (int i = 1; i < startovniPole.Length; i++)
{
    if (startovniPole[i].Cas<nejrychlejsi.Cas)
    {
        nejrychlejsi = startovniPole[i];
    }
}

Console.WriteLine($"Nejrychlejší byl {nejrychlejsi.Jmeno} s casem {nejrychlejsi.Cas}s");

Console.ReadLine();