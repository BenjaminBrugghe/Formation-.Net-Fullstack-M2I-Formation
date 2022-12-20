Console.WriteLine("*** Insertion des valeurs du tableau : ***");

int i ;
int nbUser;
string tab = "";

string[] Tableau;
Tableau = new string[10];

for (i = 0; i <10 ; i++)
{
    Console.Write($"Saisir la valeur {i+1} : ");
    nbUser = Convert.ToInt32(Console.ReadLine());
    Tableau[i] = nbUser.ToString();
}

Console.WriteLine("Affichage des valeurs du tableau : ");

for (i = 0; i <10 ; i++)
{
    Console.WriteLine($"{tab}{Tableau[i]}");
    tab += "\t";
}


//
Console.WriteLine("Press ENTER to exit...");
Console.Read();