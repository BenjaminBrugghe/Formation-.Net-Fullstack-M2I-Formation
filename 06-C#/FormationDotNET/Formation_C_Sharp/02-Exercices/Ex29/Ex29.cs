Console.WriteLine("*** Gestion des notes ***");

int nbUser = 0;
int maxNote = 0;
int minNote = 20;
int somme = 0;
int moyenne;
int i = 0;

Console.WriteLine("Veuillez saisir les notes : \n(999 pour sortir)\n");

while (nbUser != 999)
{
    Console.WriteLine($"\t- Merci de saisir la note {i} (sur /20) : ");
    nbUser = Convert.ToInt32(Console.ReadLine());

    if ((nbUser > 0 && nbUser < 20) && nbUser != 999)
    {
        somme += nbUser;
        i++;

        if (nbUser > maxNote)
        {
            maxNote = nbUser;
        }
        if (nbUser < minNote)
        {
            minNote = nbUser;
        }
    }
    else if ((nbUser < 0 || nbUser > 20) && nbUser != 999)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tErreur de saisie, la note doit être comprise entre 0 et 20");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

moyenne = somme / i;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est de {maxNote}/20.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est de {minNote}/20.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est de {moyenne}/20.");



//
Console.WriteLine("Press ENTER to exit...");
Console.Read();