using Ex6_InterfacesAnimaux.Classes;
using Ex6_InterfacesAnimaux.Interface;

// Déclaration liste Ianimal

List<Ianimal> animaux = new List<Ianimal>();

// Instanciation et ajout à la liste

animaux.Add(new Chien());
animaux.Add(new Chat());
animaux.Add(new Lapin());

// Utilisation des méthodes interfacées, pour chaque animal

foreach (Ianimal a in animaux)
{
    a.Manger();
    a.Crier();
}





Console.WriteLine("\nPress ENTER to exit...");
Console.Read();