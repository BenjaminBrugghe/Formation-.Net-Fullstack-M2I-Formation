using Microsoft.Data.SqlClient;
using TP01_CompteBancaire.Classes;
using TP01_CompteBancaire.Tools;

namespace TP01_CompteBancaire.DAO
{
    internal class ClientDAO : BaseDAO<Client>
    {
        public override int Create(Client element)
        {
            // Redaction de la requete
            _request = "INSERT INTO CLIENT (NOM , PRENOM, TELEPHONE) OUTPUT INSERTED.ID VALUES (@Nom, @Prenom, @Telephone)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request,_connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Nom", element.Nom));
            _command.Parameters.Add(new SqlParameter("@Prenom", element.Prenom));
            _command.Parameters.Add(new SqlParameter("@Telephone", element.Telephone));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute scalar ( retourne la valeur d'un champ => ici ID)
            element.Id = (int)_command.ExecuteScalar();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return element.Id;
        }

        public override bool Delete(int id)
        {
            // Redaction de la requete
            _request = "DELETE FROM CLIENT WHERE ID = @id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request,_connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@id", id));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute non query (retourne le nombre de modifications)
            int nbRows = _command.ExecuteNonQuery();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return nbRows == 1;
        }

        public override bool Delete(Client element)
        {
            // Redaction de la requete
            _request = "DELETE FROM CLIENT WHERE ID = @id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@id", element.Id));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute non query (retourne le nombre de modifications)
            int nbRows = _command.ExecuteNonQuery();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return nbRows == 1;
        }

        public override Client Find(int index)
        {
            // Redaction de la requete
            _request = "SELECT NOM, PRENOM, TELEPHONE FROM CLIENT WHERE ID = @id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@id", index));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            var clientFound = new Client();

            if (_reader.Read())
            {
                clientFound = new Client
                {
                    Id = index,
                    Nom = _reader.GetString(0),
                    Prenom = _reader.GetString(1),
                    Telephone = _reader.GetString(2)
                };
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return clientFound;
        }

        public override List<Client> Find(Func<Client, bool> criteria)
        {
            // Redaction de la requete
            _request = "SELECT ID, NOM, PRENOM, TELEPHONE FROM CLIENT";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<Client> clientList = new List<Client>();

            while (_reader.Read())
            {
                var clientFound = new Client
                {
                    Id = _reader.GetInt32(0),
                    Nom = _reader.GetString(1),
                    Prenom = _reader.GetString(2),
                    Telephone = _reader.GetString(3)
                };

                clientList.Add(clientFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return clientList.Where(criteria).ToList();
        }

        public override List<Client> FindAll()
        {
            // Redaction de la requete
            _request = "SELECT ID, NOM, PRENOM, TELEPHONE FROM CLIENT";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<Client> clientList = new List<Client>();

            while (_reader.Read())
            {
                var clientFound = new Client
                {
                    Id = _reader.GetInt32(0),
                    Nom = _reader.GetString(1),
                    Prenom = _reader.GetString(2),
                    Telephone = _reader.GetString(3)
                };

                clientList.Add(clientFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return clientList;
        }

        public override bool Update(Client element)
        {
            // Redaction de la requete
            _request = "UPDATE CLIENT SET NOM = @nom, PRENOM = @prenom, TELEPHONE = @telephone WHERE id = @id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@id", element.Id));
            _command.Parameters.Add(new SqlParameter("@nom", element.Nom));
            _command.Parameters.Add(new SqlParameter("@prenom", element.Prenom));
            _command.Parameters.Add(new SqlParameter("@telephone", element.Telephone));

            // Ouverture de la connection
            _connection.Open();

            int nbRows = (int) _command.ExecuteNonQuery();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return nbRows == 1;
        }
    }
}
