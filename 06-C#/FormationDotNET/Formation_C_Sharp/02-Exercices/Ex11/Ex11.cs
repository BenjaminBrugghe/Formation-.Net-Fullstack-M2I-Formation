Console.WriteLine("*** Le nombre est-il divisible par...? ***");

int entier;
int diviseur;

Console.WriteLine("Entrer un chiffre/nombre entier : ");
entier = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrer un chiffre/nombre diviseur : ");
diviseur = Convert.ToInt32(Console.ReadLine());

int resultat = entier % diviseur;

if (resultat == 0)
{
    if (entier < 10)
    {
        Console.WriteLine($"Le chiffre {entier} est divisible par {diviseur} => {resultat}");
    }
    else
    {
        Console.WriteLine($"Le nombre {entier} est divisible par {diviseur} => {resultat}");
    }
}
else
{
    if (entier < 10)
    {
        Console.WriteLine($"ERREUR ! Le chiffre {entier} n'est PAS divisible par {diviseur} => Modulo = {resultat}");
    }
    else
        Console.WriteLine($"ERREUR ! Le nombre {entier} n'est PAS divisible par {diviseur} => Modulo = {resultat}");
}

Console.WriteLine("Press ENTER to exit...");
Console.Read();