// Program simulující závody koní
using PrvniHodina;

// promenná pro generování náhodných čísel
Random random = new Random();

// zadání počtu koni kteří mají startovat (pokud není zadané číslo nebo je číslo menší než 1 pak se zadání opakuje)
Console.WriteLine("Zadej pocet startujicich koni");
string pocetText = Console.ReadLine();
int pocet;
while(!int.TryParse(pocetText,out pocet)||pocet<1)
{
    Console.WriteLine("Toto není spravna hodnota, zadej znovu:");
    pocetText= Console.ReadLine();
}

// vytvoření pole o počtu prvků dle zadaného počtu koní
Kun[] startovniPole = new Kun[pocet];

// naplnění pole koní
for (int i = 0; i < startovniPole.Length; i++)
{
    Console.WriteLine($"Zadej jméno {i+1}. koně:");
    // vytvoření nové instance koně
    startovniPole[i]=new Kun();
    //načtení jména z klávesnice
    startovniPole[i].Jmeno = Console.ReadLine();
    // vygenerování času náhodně v rozmezí 10min(600s) až 20min(1200s)
    // rozmezí je 100krát větší aby vygenerované číslo mohlo být vyděleno 100 a měli jsme tak náhodné desetinné číslo
    startovniPole[i].Cas = random.Next(60000, 120000) / 100d;
}

//vypsání koní (jméno a čas)
for (int i = 0; i < startovniPole.Length; i++)
{
    Console.WriteLine($"{startovniPole[i].Jmeno}\t{startovniPole[i].Cas}s");
}

//zjištění nejrychlejšího koně
// jako výchozí vezmu prvního koně
Kun nejrychlejsi = startovniPole[0];
// cyklus for tim padem muzu zacit az od druheho koně(indexu 1)
for (int i = 1; i < startovniPole.Length; i++)
{
    // pokud bude mít kun menci cas(bude rychlejsi), pak si jej zapamatuji jako nejrychlejsiho
    if (startovniPole[i].Cas<nejrychlejsi.Cas)
    {
        nejrychlejsi = startovniPole[i];
    }
}

// vypsani nejrychlejsiho kone
Console.WriteLine($"Nejrychlejší byl kun {nejrychlejsi.Jmeno} s casem {nejrychlejsi.Cas}s");

Console.ReadLine();