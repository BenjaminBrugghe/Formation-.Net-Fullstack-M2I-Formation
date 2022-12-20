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
    internal class CompteEpargneDAO : BaseDAO<CompteEpargne>
    {
        public override int Create(CompteEpargne element)
        {
            // Redaction de la requete
            _request = "INSERT INTO COMPTE (CLIENT_ID , SOLDE, TAUX, COUTOPERATION) OUTPUT INSERTED.ID VALUES (@ClientId, @Solde, @Taux, 0)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@ClientId", element.ClientBanque.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@Taux", element.Taux));

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

        public override bool Delete(CompteEpargne element)
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

        public override CompteEpargne Find(int index)
        {
            // Redaction de la requete
            _request = "SELECT CLIENT_ID, SOLDE, TAUX FROM COMPTE WHERE ID = @id";

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

            var accountFound = new CompteEpargne();

            if (_reader.Read())
            {
                accountFound = new CompteEpargne()
                {
                    Id = index,
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(0)),
                    Solde = _reader.GetDecimal(1),
                    Taux = _reader.GetDecimal(2),
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

        public override List<CompteEpargne> Find(Func<CompteEpargne, bool> criteria)
        {
            // Redaction de la requete
            _request = "SELECT ID, CLIENT_ID, SOLDE, TAUX FROM COMPTE";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<CompteEpargne> accountList = new List<CompteEpargne>();

            while (_reader.Read())
            {
                var accountFound = new CompteEpargne
                {
                    Id = _reader.GetInt32(0),
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(1)),
                    Solde = _reader.GetDecimal(2),
                    Taux = _reader.GetDecimal(3),
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

        public override List<CompteEpargne> FindAll()
        {
            // Redaction de la requete
            _request = "SELECT ID, CLIENT_ID, SOLDE, TAUX FROM COMPTE";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande avec execute reader (pour pouvoir lire plusieurs colonnes)
            _reader = _command.ExecuteReader();

            List<CompteEpargne> accountList = new List<CompteEpargne>();

            while (_reader.Read())
            {
                var accountFound = new CompteEpargne
                {
                    Id = _reader.GetInt32(0),
                    ClientBanque = new ClientDAO().Find(_reader.GetInt32(1)),
                    Solde = _reader.GetDecimal(2),
                    Taux = _reader.GetDecimal(3),
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

        public override bool Update(CompteEpargne element)
        {
            // Redaction de la requete
            _request = "UPDATE COMPTE SET CLIENT_ID = @ClientId, SOLDE = @Solde, TAUX = @Taux WHERE id = @Id";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));
            _command.Parameters.Add(new SqlParameter("@ClientId", element.ClientBanque.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@Taux", element.Taux));

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
