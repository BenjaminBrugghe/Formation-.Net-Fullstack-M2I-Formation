Console.WriteLine("*** Dans quelle catégorie se trouve votre enfant ? ***");

Console.WriteLine("Veuillez saisir l'âge de votre enfant :");

int age = Convert.ToInt32(Console.ReadLine());

switch (age)
{
    case < 3:
        Console.WriteLine("Votre enfant est trop jeune !");
        break;

    case int n when n >= 3 && n <= 6:
        Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !");
        break;

    case int n when n >= 7 && n <= 8:
        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !");
        break;

    case int n when n >= 9 && n <= 10:
        Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !");
        break;

    case int n when n >= 11 && n <= 12:
        Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !");
        break;

    case >= 13:
        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !");
        break;

    default:
        Console.WriteLine("Votre enfant est trop vieux pour ces catégories !");
        break;
}

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();