// EXERCICE 01 : CHAISES

using Ex1_Chaises.Classes;

Chaises chaise1 = new Chaises();
chaise1.NbPieds = 4;
chaise1.Materiaux = "bois";
chaise1.Couleur = "bleue";

Chaises chaise2 = new Chaises(4, "blanche", "métal");

Chaises chaise3 = new Chaises(1, "transparente", "pléxiglass");

Console.WriteLine(chaise1);
Console.WriteLine(chaise2);
Console.WriteLine(chaise3);






//
Console.WriteLine("\nPress ENTER to exit...");
Console.Read();