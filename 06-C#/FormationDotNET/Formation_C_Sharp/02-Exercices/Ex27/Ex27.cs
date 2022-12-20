Console.WriteLine("*** Les suites chainées de nombres ***");

int nbUser;
int somme = 0;
string affichage = "";
int i = 0;
int j = 0;

Console.WriteLine("Merci de saisir un nombre : ");
nbUser = Convert.ToInt32(Console.ReadLine());

while (i <= (nbUser / 2) + 1)
{
    i++;
    somme = i;
    j = i + 1;
    affichage = Convert.ToString($"{nbUser} = {i}");

    while (j <= (nbUser / 2) + 1)
    {
        somme += j;
        affichage += Convert.ToString($" + {j}");
        j++;
        if (somme == nbUser)
        {
            Console.WriteLine($"{affichage}");
        }
    }
}

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();