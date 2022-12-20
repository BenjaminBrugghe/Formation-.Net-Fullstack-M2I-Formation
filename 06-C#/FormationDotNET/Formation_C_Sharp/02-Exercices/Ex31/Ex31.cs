int i = 0;
int nbUser = 0;
int maxNote = 0;
int minNote = 20;
int somme = 0;
double moyenne = 0;
int userChoice;

do
{
    Console.WriteLine("*** Gestion des notes avec menu ***");
    Console.WriteLine("\n1---Saisir les notes");
    Console.WriteLine("2---La plus petite note");
    Console.WriteLine("3---La plus grande note");
    Console.WriteLine("4---La moyenne des notes");
    Console.WriteLine("0---Quitter");

    Console.WriteLine("\nFaites votre choix : ");
    userChoice = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Saisir les notes ***");
            Console.WriteLine("(999 pour stopper la saisie)");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine($"Merci de saisir la note {i+1} (sur /20) : ");
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

            } while (nbUser != 999);
            break;

        case 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** La plus petite note ***");
            Console.WriteLine($"\n\nLa note la plus petite est de {minNote}/20.");
            Console.ForegroundColor = ConsoleColor.White;
            
            break;

        case 3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** La plus grande note ***");
            Console.WriteLine($"\n\nLa note la plus grande est de {maxNote}/20.");
            Console.ForegroundColor = ConsoleColor.White;

            break;

        case 4:
            moyenne = somme / i;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** La moyenne des notes ***");
            Console.WriteLine($"\n\nLa moyenne des notes est de {moyenne}/20.");
            Console.ForegroundColor = ConsoleColor.White;

            break;
    }
} while (userChoice != 0);
