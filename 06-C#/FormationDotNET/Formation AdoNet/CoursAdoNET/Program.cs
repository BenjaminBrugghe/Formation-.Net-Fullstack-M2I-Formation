
#region Cours Ado.NET Mode Connecté

using Microsoft.Data.SqlClient;

// Connexion à la base de données
string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

// Utilisation du type SQLConnection pour connecter notre programme C# à la base de données
SqlConnection connection = new SqlConnection(connectionString);

// Executer la requête SQL => On utilise un objet de commande
// Préparation de la commande

// 1ère méthode avec ExecuteNonQuery() => Retourne le nombre de lignes impactées par notre commande (appelé "sans retour")
string request = "INSERT INTO UTILISATEUR (nom, prenom, email, telephone) " +
                "VALUES ('Brugghe', 'Benjamin', 'Myemail@gmail.com','+33 6 07 08 09 10')";

// 2ème méthode avec ExecuteScalar() => Retourne la valeur du champ recherché
string request2 = "INSERT INTO UTILISATEUR (nom, prenom, email, telephone) " +
                "OUTPUT INSERTED.ID " +
                "VALUES ('Doe', 'John', 'Myemail2@gmail.com','+33 6 17 28 39 40')";

// 3ème méthode 
string request3 = "SELECT TOP 3 (id, nom, prenom, email, telephone) FROM UTILISATEUR";


// Instanciation de l'objet command
SqlCommand command = new SqlCommand(request, connection);
SqlCommand command2 = new SqlCommand(request2, connection);
SqlCommand command3 = new SqlCommand(request3, connection);

// Ouverture de la connection
connection.Open();

// 1ère méthode pour executer notre commande => ExecuteNonQuery => Retourne le nombre de lignes impactées par notre commande (appelé "sans retour")
int nbLignes = command.ExecuteNonQuery();

// 2ème méthode pour executer notre commande => ExecuteScalar() => Retourne la valeur du champ ciblé dans la request
int id = (int)command2.ExecuteScalar();

// 3ème méthode avec un Reader => Retourne l'ensemble des entités qui répondent aux critères
SqlDataReader reader = command3.ExecuteReader();

// Lire la totalité des éléments retournés par la BDD
while (reader.Read())
{
    Console.WriteLine($"Id : {reader.GetInt32(0)} - Nom : {reader.GetString(1)} - Prenom : {reader.GetString(2)} - Email : {reader.GetString(3)} - Téléphone : {reader.GetString(4)}");
}

// Fermeture du Reader
reader.Close();


// Libérer la connection afin de pouvoir executer une autre commande
command.Dispose();

// Fermeture de la connectionà la BDD
connection.Close();

// Affichage du retour d'informations fait par la BDD
Console.WriteLine(nbLignes > 0 ? $"Il y a eu {nbLignes} lignes impactées." : "Erreur lors de l'ajout dans la base de données");

Console.WriteLine(id > 0 ? $"Insertion réussie, l'id de la personne est  {id}." : "Erreur lors de l'ajout dans la base de données");

// Récupération des saisies utilisateur
Console.Write("Veuillez saisir le nom de la personne : ");
string nom = Console.ReadLine();
Console.Write("Veuillez saisir le prenom de la personne : ");
string prenom = Console.ReadLine();
Console.Write("Veuillez saisir l'email de la personne : ");
string email = Console.ReadLine();
Console.Write("Veuillez saisir le téléphone de la personne : ");
string telephone = Console.ReadLine();

// Rédaction de la request
string request = "INSERT INTO UTILISATEUR (nom, prenom, email, telephone) OUTPUT INSERTED.ID VALUES (@Nom, @Prenom, @Email, @Telephone)"; // @ => Alias

// Création de notre objet command
SqlCommand command = new SqlCommand(request, connection);

// Ajout des paramètres de la commande
command.Parameters.Add(new SqlParameter("@Nom", nom));
command.Parameters.Add(new SqlParameter("@Prenom", prenom));
command.Parameters.Add(new SqlParameter("@Email", email));
command.Parameters.Add(new SqlParameter("@Telephone", telephone));

// Execution de la commande
connection.Open();
int id = (int)command.ExecuteScalar();
command.Dispose();
connection.Close();

#endregion



Console.WriteLine("\nPress ENTER to exit...");
Console.Read();