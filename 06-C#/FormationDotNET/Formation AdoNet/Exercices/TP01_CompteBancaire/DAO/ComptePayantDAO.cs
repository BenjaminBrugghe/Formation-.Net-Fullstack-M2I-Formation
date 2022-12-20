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
    internal class ComptePayantDAO : BaseDAO<ComptePayant>
    {
        public override int Create(ComptePayant element)
        {
            // Redaction de la requete
            _request = "INSERT INTO COMPTE (CLIENT_ID , SOLDE, TAUX, COUTOPERATION) OUTPUT INSERTED.ID VALUES (@ClientId, @Solde, 0, @CoutOperation)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@ClientId", element.ClientBanque.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@CoutOperation", element.CoutOperation));

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
            _request = "DELETE FROM COMPTE WHERE ID = @id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

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

        public override bool Delete(ComptePayant element)
        {
            // Redaction de la requete
            _request = "DELETE FROM COMPTE WHERE ID = @id";

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

        public override ComptePayant Find(int index)
        {
            // Redaction de la requete
            _request = "SELECT CLIENT_ID, SOLDE, COUTOPERATION FROM COMPTE WHERE ID = @id";

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

            var accountFound = new ComptePayant();

            if (_reader.Read())
            {
                accountFound = new ComptePayant()
                {
                    Id = index,
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(0)),
                    Solde = _reader.GetDecimal(1),
                    CoutOperation = _reader.GetDecimal(2),
                    Operations = new List<Operation>()
                };
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            // Récupération des opérations liées au compte 
            accountFound.Operations.AddRange(new OperationDAO().Find(x => x.CompteId == accountFound.ClientBanque.Id));

            return accountFound;
        }

        public override List<ComptePayant> Find(Func<ComptePayant, bool> criteria)
        {
            // Redaction de la requete
            _request = "SELECT ID, CLIENT_ID, SOLDE, COUTOPERATION FROM COMPTE";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<ComptePayant> accountList = new List<ComptePayant>();

            while (_reader.Read())
            {
                var accountFound = new ComptePayant
                {
                    Id = _reader.GetInt32(0),
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(1)),
                    Solde = _reader.GetDecimal(2),
                    CoutOperation = _reader.GetDecimal(3),
                    Operations = new List<Operation>()
                };

                accountList.Add(accountFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            // Récupération des opérations liées au compte 
            foreach (var account in accountList)
            {
                account.Operations.AddRange(new OperationDAO().Find(x => x.CompteId == account.ClientBanque.Id));

            }

            return accountList.Where(criteria).ToList();
        }

        public override List<ComptePayant> FindAll()
        {
            // Redaction de la requete
            _request = "SELECT ID, CLIENT_ID, SOLDE, COUTOPERATION FROM COMPTE";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<ComptePayant> accountList = new List<ComptePayant>();

            while (_reader.Read())
            {
                var accountFound = new ComptePayant
                {
                    Id = _reader.GetInt32(0),
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(1)),
                    Solde = _reader.GetDecimal(2),
                    CoutOperation = _reader.GetDecimal(3),
                    Operations = new List<Operation>()
                };

                accountList.Add(accountFound);
            }

            // fermeture de notre reader
            _reader.Close();

            // libération de note objet commande
            _command.Dispose();

            // fermeture de la connection
            _connection.Close();

            // Récupération des opérations liées au compte 
            foreach (var account in accountList)
            {
                account.Operations.AddRange(new OperationDAO().Find(x => x.CompteId == account.ClientBanque.Id));

            }

            return accountList;
        }

        public override bool Update(ComptePayant element)
        {
            // Redaction de la requete
            _request = "UPDATE COMPTE SET CLIENT_ID = @ClientId, SOLDE = @Solde, COUTOPERATION = @CoutOperation WHERE id = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));
            _command.Parameters.Add(new SqlParameter("@ClientId", element.ClientBanque.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@CoutOperation", element.CoutOperation));

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
