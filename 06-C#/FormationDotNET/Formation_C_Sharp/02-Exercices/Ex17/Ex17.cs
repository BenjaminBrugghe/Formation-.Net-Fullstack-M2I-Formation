Console.WriteLine("*** Quelle boisson souhaitez-vous ? ***");

int userChoice;
string boisson;

Console.WriteLine("Liste des boissons disponibles : ");
Console.WriteLine("\t1)Eau plate");
Console.WriteLine("\t2)Eau gazeuse");
Console.WriteLine("\t3)Coca-Cola");
Console.WriteLine("\t4)Fanta");
Console.WriteLine("\t5)Sprite");
Console.WriteLine("\t6)Orangina");
Console.WriteLine("\t7)7up");
Console.WriteLine("Faites votre choix (1 à 7) : ");

userChoice = Convert.ToInt32(Console.ReadLine());

switch (userChoice)
{
    case 1:
        boisson = "Eau plate";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 2:
        boisson = "Eau gazeuse";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 3:
        boisson = "Coca-Cola";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 4:
        boisson = "Fanta";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 5:
        boisson = "Sprite";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 6:
        boisson = "Orangina";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;
    case 7:
        boisson = "7up";
        Console.WriteLine($"Votre {boisson} est servi(e) !");
        break;

    default:
        Console.WriteLine("ERREUR ! Veuillez entrer un chiffre valide");
        break;
}


//
Console.WriteLine("Press ENTER to exit...");
Console.Read();