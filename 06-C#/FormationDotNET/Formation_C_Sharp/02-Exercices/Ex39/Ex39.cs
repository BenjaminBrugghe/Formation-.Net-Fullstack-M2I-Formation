string[] dejaTirees = new string[16];
string[] restantes = new string[16] { "Manu", "Jonathan", "Audrey", "Patrick", "Sofiane", "Soukaina", "Thomas", "Myriam", "Dylan", "Frank", "Romain", "Benjamin", "Rock", "Alexandre", "Mathieu", "Anthony" };
string userChoice = "";
int userChoiceParse = 0;
string space;
string winner = "";
int j = 0;

Random aleatoire = new Random();
int nbMystere = 0;
//nbMystere = aleatoire.Next(1, 51);

do
{
    Console.WriteLine("\n*** Le grand tirage ! ***\n");
    Console.WriteLine("1---Effectuer un tirage");
    Console.WriteLine("2---Voir la liste des personnes déjà tirées");
    Console.WriteLine("3---Voir la liste des personnes restantes");
    Console.WriteLine("0---Effectuer un tirage");
    Console.WriteLine("\nFaites votre choix : ");
    userChoice = Console.ReadLine();

    bool userChoiceIsANumber = int.TryParse(userChoice, out userChoiceParse);

    while (!userChoiceIsANumber)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur ! Saisie invalide !");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("\n*** Le grand tirage ! ***\n");
        Console.WriteLine("1---Effectuer un tirage");
        Console.WriteLine("2---Voir la liste des personnes déjà tirées");
        Console.WriteLine("3---Voir la liste des personnes restantes");
        Console.WriteLine("0---Effectuer un tirage");
        Console.WriteLine("\nFaites votre choix : ");
        userChoice = Console.ReadLine();

        userChoiceIsANumber = int.TryParse(userChoice, out userChoiceParse);

    }

    switch (userChoiceParse)
    {
        case 1:
            Console.Clear();

            if (j == dejaTirees.Length)
            {
                restantes = (string[])dejaTirees.Clone();
                Array.Clear(dejaTirees);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************");
                Console.WriteLine("*** Tout les participants ont été tirés ! ***");
                Console.WriteLine("*******************************\n");
                Console.ForegroundColor = ConsoleColor.White;
                j = 0;
            }
            else
            {
                do
                {
                    nbMystere = aleatoire.Next(0, restantes.Length);
                    winner = restantes[nbMystere];

                } while (dejaTirees.Contains(winner));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************");
                Console.WriteLine($"L'heureux gagnant est : {winner} ");
                Console.WriteLine("*******************************");
                Console.ForegroundColor = ConsoleColor.White;

                dejaTirees[j] = winner;
                j++;

                Array.Clear(restantes, nbMystere, 1);
            }

            break;

        case 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************");
            Console.WriteLine("Liste des personnes déjà tirées");
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.White;

            space = "";
            for (int i = 0; i < dejaTirees.Length; i++)
            {
                Console.WriteLine($"n°{i + 1} {space}{dejaTirees[i]}");
                space += " ";
            }
            break;

        case 3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************");
            Console.WriteLine("Liste des personnes éligibles au tirage");
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.White;

            space = "";
            for (int i = 0; i < restantes.Length; i++)
            {
                if (restantes[i] != null)
                {
                Console.WriteLine($"{space}{restantes[i]}");
                space += " ";
                }

            }
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur ! Saisie invalide !");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

} while (userChoiceParse != 0);
