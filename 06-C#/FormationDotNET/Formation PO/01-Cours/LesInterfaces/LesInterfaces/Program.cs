

using LesInterfaces.Classes;
using LesInterfaces.Interfaces;



#region Avec Class Person et Address et Address2
//Address a = new();

Person p = new(new Address2()) { Nom = "Brugghe" , Prenom = "Benjamin" };

p.PersonAddress.AddressInformation();

#endregion

#region Avec interface Ivolant

List<IVolant> volants = new List<IVolant>();

volants.Add(new Oiseau());
volants.Add(new Drone());
volants.Add(new Avion());

foreach (IVolant v in volants)
{
    v.Voler();
}

IVolant avion = new Avion();
IVolant drone = new Drone();
IVolant oiseau = new Oiseau();

TransportColis t = new TransportColis(avion);

t.Transporter();
t.Livrer();

#endregion





Console.WriteLine("Press ENTER to exit...");
Console.Read();
