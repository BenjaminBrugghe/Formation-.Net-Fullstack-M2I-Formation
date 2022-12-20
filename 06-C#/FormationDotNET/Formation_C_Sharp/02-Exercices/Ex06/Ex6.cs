int longueur;
int largeur;

Console.WriteLine("Veuillez saisir la longueur : ");
longueur= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez saisir la largeur : ");
largeur = Convert.ToInt32(Console.ReadLine());

int perimetre = longueur * 2 + largeur * 2;
int aire = longueur * largeur;

Console.WriteLine($"Le périmètre du rectangle est de : {perimetre} cm");
Console.WriteLine($"L'aire du rectangle est de : {aire} cm²");


Console.WriteLine("Press ENTER to exit...");
Console.Read();