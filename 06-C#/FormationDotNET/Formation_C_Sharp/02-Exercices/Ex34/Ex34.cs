int nbUser;


Console.WriteLine("*** Est pair...? Est impair...? ***");

Console.WriteLine("Combien de nombres contiendra le tableau ? : ");
nbUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Affectation automatique des valeurs...\n");

string[] tableau;
tableau = new string[nbUser];

Random aleatoire = new Random();
int nbMystere = 0;


Console.WriteLine("Vérification des valeurs du tableau : ");

for (int i = 0; i < nbUser; i++)
{
    nbMystere = aleatoire.Next(1, 51);
    tableau[i] = Convert.ToString(nbMystere);
    int modulo = nbMystere % 2;
    if (modulo == 0)
    {
        Console.WriteLine($"\tLe nombre {nbMystere} est pair !");
    }
    else if (modulo != 0)
    {
        Console.WriteLine($"\tLe nombre {nbMystere} est impair !");
    }
}




//
Console.WriteLine("Press ENTER to exit...");
Console.Read();