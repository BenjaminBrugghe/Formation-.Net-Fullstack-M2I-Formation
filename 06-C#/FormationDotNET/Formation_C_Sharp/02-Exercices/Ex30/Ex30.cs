Console.WriteLine("*** Question à choix multiples ***");

Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ?");
Console.WriteLine("\ta) quit");
Console.WriteLine("\tb) continue");
Console.WriteLine("\tc) break");
Console.WriteLine("\td) exit");

string userChoice;
string nouvelEssai;

Console.WriteLine("Entrez votre réponse : ");
userChoice = Convert.ToString(Console.ReadLine());

do
{
    if (userChoice == "c" || userChoice == "C")
    {
        break;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect !");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("Un nouvel essai ? Oui / Non : ");
    nouvelEssai = Convert.ToString(Console.ReadLine());

    if (nouvelEssai == "oui")
    {
        Console.WriteLine("Entrez votre réponse : ");
        userChoice = Convert.ToString(Console.ReadLine());
    }
    else if (nouvelEssai == "non")
    {
        break;
    }

} while (userChoice != "c");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bravo ! C'est la bonne réponse");


//
Console.WriteLine("Press ENTER to exit...");
Console.Read();