using Exercice2Banque.Classes;
using Exercice2Banque.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Banque.DAO_DataAccessObject_
{
    internal class ClientDAO : BaseDAO<Client>
    {
        public override int Create(Client element)
        {            
            // Rédaction de la requête
            _request = "INSERT INTO CLIENT (NOM, PRENOM, TELEPHONE) OUTPUT INSERTED.ID VALUES (@Nom, @Prenom, @Telephone)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de l'objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la requête
            _command.Parameters.Add(new SqlParameter("@Nom", element.Nom));
            _command.Parameters.Add(new SqlParameter("@Prenom", element.Prenom));
            _command.Parameters.Add(new SqlParameter("@Telephone", element.Telephone));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec ExecuteScalar (Retourne la valeur d'un champ => ici : ID)
            element.Id = (int)_command.ExecuteScalar();

            // Libération de l'objet commande
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();

            return element.Id;
        }

        public override int Delete(Client element)
        {
            _request = "DELETE CLIENT WHERE Id=@ClientId";

            _connection = Connection.New;

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@ClientId", element.Id));

            _connection.Open();
            element.Id = (int)_command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
        }

        public override List<Client> Find(Func<Client, bool> criteria)
        {
            _request = "SELECT * FROM CLIENT WHERE Id=@ClientId";

            _connection = Connection.New;

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@ClientId", index));

            _connection.Open();
            _reader = _command.ExecuteReader();

            var clientFound = new Client();

            if (_reader.Read())
            {
                Id = index;
                Nom = _reader.GetString(0);
                Prenom = _reader.GetString(1);
                Adresse = _reader.GetString(2);
            }

            _command.Dispose();
            _connection.Close();
        }

        public override List<Client> Find(Func<Client, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Client> FindAll()
        {
            throw new NotImplementedException();
        }

        public override int Update(Client element)
        {
            throw new NotImplementedException();
        }
    }
}
