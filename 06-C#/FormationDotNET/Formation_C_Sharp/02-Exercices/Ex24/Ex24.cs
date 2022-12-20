Console.WriteLine("*** Les suites chainées de nombres ***");

int nbUser;
int somme = 0;
string affichage = "";
int i = 0;
int j = 0;

Console.WriteLine("Merci de saisir un nombre : ");
nbUser = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= (nbUser / 2) + 1; i++)
{
    somme = i;
    affichage = Convert.ToString($"{nbUser} = {i}");

    for (j = i +1; j <= (nbUser / 2) + 1; j++)
    {
        somme = somme + j;
        affichage += Convert.ToString($" + {j}");
        if (somme == nbUser)
        {
            Console.WriteLine($"{affichage}");
        }
    }
}




//
Console.WriteLine("Press ENTER to exit...");
Console.Read();