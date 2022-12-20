Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("--- La lettre est-elle une voyelle ? ---");

Console.WriteLine("Entrez une lettre : ");
string lettre = Console.ReadLine();

if (lettre == "a" || lettre == "e" || lettre == "i" || lettre == "o" || lettre == "u" || lettre == "y")
{
    Console.WriteLine("Cette lettre est une voyelle !");
}
else
{
    Console.WriteLine("Erreur ! Cette lettre n'est pas une voyelle !");
}


Console.WriteLine("Press ENTER to exit...");
Console.Read();