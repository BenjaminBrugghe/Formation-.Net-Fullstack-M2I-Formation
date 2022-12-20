// Import de Voiture.cs
using IntroductionPOO.Classes;

// Création d'ue instance de la classe voiture
Voiture voitureDeBenjamin = new Voiture();

// Ajout des propriétés de notre objet voiture
voitureDeBenjamin.Modele = "206";
voitureDeBenjamin.Couleur = "noire";
voitureDeBenjamin.Reservoir = 60;
voitureDeBenjamin.Autonomie = 850;

// Affichage de l'objet voitureDeBenjamin
// Console.WriteLine(voitureDeBenjamin.ToString());

Console.WriteLine($"\n{voitureDeBenjamin}\n");// Affiche la même chose, car "ToString" a été override
Console.WriteLine($"\n{voitureDeBenjamin.Demarrer()}\n");

// Création d'une instance de Voiture par le constructeur à 4 params
Voiture voitureDeJulie = new Voiture("Clio", "blanche", 50, 650);
Console.WriteLine("***** Voiture de Julie *****\n");
Console.WriteLine(voitureDeJulie);
Console.WriteLine(voitureDeJulie.Demarrer());
Console.WriteLine(voitureDeJulie.Demarrer());

Console.WriteLine(voitureDeJulie.Rouler());
Console.WriteLine(voitureDeJulie.Klaxonner());
Console.WriteLine(voitureDeJulie.Stopper());
Console.WriteLine(voitureDeJulie.Arreter());

MyFunctions.Display(voitureDeJulie.ToString());
Console.WriteLine(MyFunctions.Compteur);








//
Console.WriteLine("\nPress ENTER to exit...");
Console.Read();