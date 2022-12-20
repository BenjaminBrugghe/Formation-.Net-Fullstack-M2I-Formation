Console.WriteLine("*** Trouver le nombre mystère : ***");

Random aleatoire = new Random();
int nbUser = 0;
int nbMystere = aleatoire.Next(1, 51);
int i = 0;

while (nbUser != nbMystere)
{
    i++;
    Console.WriteLine("Veuillez saisir un nombre : ");
    nbUser = Convert.ToInt32(Console.ReadLine());
    if (nbUser > nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit !");
    }
    else if (nbUser < nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus grand !");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo ! Vous avez trouvé le nombre mystère !");
        Console.WriteLine($"\nVous avez trouvé en {i} coups");
        break;
    }
}



//
Console.WriteLine("Press ENTER to exit...");
Console.Read();