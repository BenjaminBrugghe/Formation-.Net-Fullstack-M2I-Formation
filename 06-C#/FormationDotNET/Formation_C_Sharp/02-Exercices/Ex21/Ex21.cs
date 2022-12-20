Console.WriteLine("*** Menus et sous-menus ***");

Console.WriteLine("Table des matières :");

for (int i = 1; i <=3 ; i++)
{
    Console.WriteLine($"\tChapitre {i}");
    for (int j = 1; j <=3 ; j++)
    {
        Console.WriteLine($"\t\tPartie {i}.{j}");
    }
}




//
Console.WriteLine("Press ENTER to exit...");
Console.Read();