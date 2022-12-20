Console.WriteLine("Enumération d'un tableau avec For Each :");

string[] tableau = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

string space = "";

foreach (var mois in tableau)
{
    Console.WriteLine($"{space}{mois}");
    space += "\t";
}

//
Console.WriteLine("Press ENTER to exit...");
Console.Read();