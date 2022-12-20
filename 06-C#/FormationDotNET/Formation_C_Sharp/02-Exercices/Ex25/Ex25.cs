Console.WriteLine("*** Gestion des notes ***");

int nbUser;
int maxNote = 0;
int minNote = 20;
int somme = 0;
int moyenne;

Console.WriteLine("Veuillez saisir 5 notes :");

for (int i = 1; i <=5 ; i++)
{
    Console.WriteLine($"\t- Merci de saisir la note {i} (sur /20) : ");
    nbUser = Convert.ToInt32(Console.ReadLine());
    somme += nbUser;

    if (nbUser > maxNote)
    {
        maxNote = nbUser;
    }
    if (nbUser < minNote)
    {
        minNote = nbUser;
    }
}

moyenne = somme/5;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est de {maxNote}/20.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est de {minNote}/20.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est de {moyenne}/20.");

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();