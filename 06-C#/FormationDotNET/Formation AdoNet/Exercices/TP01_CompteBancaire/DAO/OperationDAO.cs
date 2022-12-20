using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01_CompteBancaire.Classes;
using TP01_CompteBancaire.Tools;

namespace TP01_CompteBancaire.DAO
{
    internal class OperationDAO : BaseDAO<Operation>
    {
        public override int Create(Operation element)
        {
            // Redaction de la requete
            _request = "INSERT INTO OPERATION (MONTANT , DATE_OPERATION, COMPTE_ID) OUTPUT INSERTED.ID VALUES (@Montant, @DateOPeration, @CompteId)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Montant", element.Montant));
            _command.Parameters.Add(new SqlParameter("@DateOPeration", element.DateOperation));
            _command.Parameters.Add(new SqlParameter("@CompteId", element.CompteId));

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
            _request = "DELETE FROM OPERATION WHERE ID = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", id));

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

        public override bool Delete(Operation element)
        {
            // Redaction de la requete
            _request = "DELETE FROM OPERATION WHERE ID = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));

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

        public override Operation Find(int index)
        {
            // Redaction de la requete
            _request = "SELECT MONTANT, DATE_OPERATION, COMPTE_ID FROM OPERATION WHERE ID = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", index));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            var operationFound = new Operation();

            if (_reader.Read())
            {
                operationFound = new Operation()
                {
                    Id = index,
                    Montant = _reader.GetDecimal(0),
                    DateOperation = _reader.GetDateTime(1),
                    CompteId = _reader.GetInt32(2)
                };
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return operationFound;
        }

        public override List<Operation> Find(Func<Operation, bool> criteria)
        {
            // Redaction de la requete
            _request = "SELECT ID, MONTANT, DATE_OPERATION, COMPTE_ID FROM OPERATION";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<Operation> operationsList = new List<Operation>();

            while (_reader.Read())
            {
                var operationFound = new Operation()
                {
                    Id = _reader.GetInt32(0),
                    Montant = _reader.GetDecimal(1),
                    DateOperation = _reader.GetDateTime(2),
                    CompteId = _reader.GetInt32(3)
                };

                operationsList.Add(operationFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return operationsList.Where(criteria).ToList();
        }

        public override List<Operation> FindAll()
        {
            // Redaction de la requete
            _request = "SELECT ID, MONTANT, DATE_OPERATION, COMPTE_ID FROM OPERATION";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<Operation> operationsList = new List<Operation>();

            while (_reader.Read())
            {
                var operationFound = new Operation()
                {
                    Id = _reader.GetInt32(0),
                    Montant = _reader.GetDecimal(1),
                    DateOperation = _reader.GetDateTime(2),
                    CompteId = _reader.GetInt32(3)
                };

                operationsList.Add(operationFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return operationsList;
        }

        public override bool Update(Operation element)
        {
            // Redaction de la requete
            _request = "UPDATE OPERATION SET MONTANT = @Montant, DATE_OPERATION = @DateOperation, COMPTE_ID = @CompteID WHERE ID = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));
            _command.Parameters.Add(new SqlParameter("@Montant", element.Montant));
            _command.Parameters.Add(new SqlParameter("@DateOperation", element.DateOperation));
            _command.Parameters.Add(new SqlParameter("@CompteID", element.CompteId));

            // Ouverture de la connection
            _connection.Open();

            int nbRows = (int)_command.ExecuteNonQuery();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            return nbRows == 1;
        }
    }
}
