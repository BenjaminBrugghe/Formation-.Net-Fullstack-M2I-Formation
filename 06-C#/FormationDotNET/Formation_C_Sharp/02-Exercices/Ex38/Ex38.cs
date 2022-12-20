Random aleatoire = new Random();
int nbMystere;

int[] tableau = new int[10];
string space = "";

for (int i = 0; i < 10; i++)
{
    tableau[i] = nbMystere = aleatoire.Next(1, 51);
}

Console.WriteLine("*** Où est passé mon numéro ? ***");
Console.WriteLine("Affectation des valeurs...");
Console.WriteLine("\nAffichage avant triage : ");

foreach (var number in tableau)
{
    Console.WriteLine($"{space}{number}");
    space += "  ";
}

Console.WriteLine("Après triage : ");

int[] tableauSorted = (int[])tableau.Clone();

Array.Sort(tableauSorted);

foreach (var number in tableauSorted)
{
    Console.WriteLine($"{space}{number}");
    space += "  ";
}

int position = 0;

foreach (var number in tableauSorted)
{
    if (number == tableau[0])
    {
        position = Array.IndexOf(tableauSorted, number);
    }
}

Console.WriteLine($"Le nombre {tableau[0]} se trouvait en 1ère position.");
Console.WriteLine($"Il se retrouve à la position {position+1} après le triage.");

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();