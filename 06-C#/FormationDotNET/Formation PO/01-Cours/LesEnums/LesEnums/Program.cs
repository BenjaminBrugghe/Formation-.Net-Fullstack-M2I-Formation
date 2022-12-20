
using static LesEnums.Classes.MyEnums;

Saison a = Saison.Hiver;
Console.WriteLine($"La valeur numérique de {a} est {(int)a}");

var b = (Saison)1;    // Saison à l'index 1
Console.WriteLine(b);





Console.WriteLine("Press ENTER to exit...");
Console.Read();