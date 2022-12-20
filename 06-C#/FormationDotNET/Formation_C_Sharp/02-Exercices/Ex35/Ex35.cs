Console.WriteLine("*** Gestion des contacts ***");

Console.WriteLine("Merci de saisir le nombre de contacts : ");
int nbContact = Convert.ToInt32(Console.ReadLine());

string[] tableau;
tableau = new string[nbContact];

int userChoice;

    Console.Clear();
    Console.WriteLine("*** Ma liste de contacts ***");
    Console.WriteLine("1---Saisir les contacts");
    Console.WriteLine("2---Afficher mes contacts");
    Console.WriteLine("0---Quitter");

    Console.WriteLine("\nFaites votre choix : ");
    userChoice = Convert.ToInt32(Console.ReadLine());
do
{

    switch (userChoice)
    {
        case 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Saisir les contacts ***");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < nbContact; i++)
            {
                Console.WriteLine($"Nom et prénom du contact N° {i + 1} : ");
                tableau[i] = Convert.ToString(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("*** Ma liste de contacts ***");
            Console.WriteLine("1---Saisir les contacts");
            Console.WriteLine("2---Afficher mes contacts");
            Console.WriteLine("0---Quitter");
            Console.WriteLine("\nFaites votre choix : ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            break;

        case 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Affichage des contacts ***");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < nbContact; i++)
            {
                Console.WriteLine($"\t-Contact N°{i + 1} : {tableau[i]}");
            }

            Console.WriteLine("\n*** Ma liste de contacts ***");
            Console.WriteLine("1---Saisir les contacts");
            Console.WriteLine("2---Afficher mes contacts");
            Console.WriteLine("0---Quitter");
            Console.WriteLine("\nFaites votre choix : ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            break;
    }

} while (userChoice != 0);
