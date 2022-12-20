int i;
string note = "";
int noteParse = 0;
string nbNotes = "";
int nbNotesParse = 0;
int somme = 0;
int moyenne;

bool result;
bool result2;


Console.WriteLine("*** Tableau des notes ***");
Console.WriteLine("Combien de notes comportera le tableau ? : ");
nbNotes = Console.ReadLine();

result2 = Int32.TryParse(nbNotes, out nbNotesParse);

    int[] tableau;
    tableau = new int[0];

while (!result2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Erreur ! Saisie invalide");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("*** Tableau des notes ***");
    Console.WriteLine("Combien de notes comportera le tableau ? : ");
    nbNotes = Console.ReadLine();

    result2 = Int32.TryParse(nbNotes, out nbNotesParse);
}

if (result2)
{
    tableau = new int[nbNotesParse];

    Console.WriteLine($"Merci de saisir les {nbNotesParse} notes : ");

    for (i = 0; i < nbNotesParse;)
    {
        Console.Write($"\t-Note {i + 1} : ");
        note = Console.ReadLine();
        result = int.TryParse(note, out noteParse);

        if (result)
        {
            if (noteParse >= 0 && noteParse <= 20)
            {
                tableau[i] = Convert.ToInt32(noteParse);
                i++;
                somme += noteParse;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\tErreur ! Merci de saisir une note entre 0 et 20");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur ! Saisie invalide");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

Console.WriteLine("\n*** Liste des notes : ***");
for (i = 0; i < nbNotesParse; i++)
{
    Console.WriteLine($"La note {i + 1} est de : {tableau[i]}");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nLa note max est de : {tableau.Max()}/20");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La note min est de : {tableau.Min()}/20");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"La moyenne est de : {somme / nbNotesParse}/20");

Console.ForegroundColor = ConsoleColor.White;

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();