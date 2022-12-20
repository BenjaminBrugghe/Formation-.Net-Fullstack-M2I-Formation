Console.WriteLine("*** Accroissement de la population ***");

decimal accroissement = 1.0089M;
decimal populationDepart;
int annee = 2015;
decimal populationFinale = 0;
decimal i = 0;

for (populationDepart = 96809; populationDepart <= 120000; i++)
{
    annee++;
    populationDepart = populationDepart * accroissement;
}

Console.WriteLine($"En {annee}, il y aura {Math.Round(populationDepart,0)} habitants. Celà aura prit {i} années.");
















//
Console.WriteLine("Press ENTER to exit...");
Console.Read();