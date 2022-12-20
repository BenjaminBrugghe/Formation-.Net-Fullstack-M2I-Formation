
using TP01_CompteBancaire.Classes;
using TP01_CompteBancaire.DAO;

ClientDAO _clientDAO = new();

#region Test Ajout d'un client

Console.WriteLine("Ajout d'un client...");
Client c = new Client("Di Persio", "Anthony", "+33 6 41 52 63 98");
int newClientId = _clientDAO.Create(c);

if (newClientId != 0) Console.WriteLine($"Client ajouté avec succès ! Id : {newClientId}");
#endregion

#region Test Récupération d'un client

Console.WriteLine($"Récupération du client à l'Id {newClientId}");
Console.WriteLine(_clientDAO.Find(newClientId));
#endregion

#region Test Récupértion des clients

Console.WriteLine("Récupération de tous les clients...");
foreach (var client in _clientDAO.FindAll())
{
    Console.WriteLine(client);
}
#endregion

#region Test Recherche de client

Console.WriteLine($"Récupération de tous les clients dont le nom est ABADI...");
foreach (var client in _clientDAO.Find(x => x.Nom == "Abadi"))
{
    Console.WriteLine(client);
}
#endregion

#region Test Modification d'un client

Console.WriteLine("Modification du client ajouté précédemment...");
c.Prenom = "Charles";
c.Nom = "Dupont";

if (_clientDAO.Update(c))
{
    Console.WriteLine($"Client modifié avec succès ! Nouveau client à l'Id : {newClientId}...");
    Console.WriteLine(_clientDAO.Find(newClientId));
}
#endregion

#region Test Suppression d'un client

Console.WriteLine($"Suppression du client à l'Id : {newClientId}...");
if (_clientDAO.Delete(newClientId)) Console.WriteLine("Client supprimé avec succès !");
#endregion












Console.WriteLine("à Bientôt...");
