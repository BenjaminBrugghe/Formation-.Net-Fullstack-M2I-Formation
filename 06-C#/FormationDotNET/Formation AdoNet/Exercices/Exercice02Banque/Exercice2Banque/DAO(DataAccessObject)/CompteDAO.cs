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
    internal class CompteDAO : BaseDAO<Compte>
    {
        public override int Create(Compte element)
        {
            // Rédaction de la requête
            _request = "INSERT INTO COMPTE (CLIENT_ID, SOLDE, TAUX, COUTOPERATION) OUTPUT INSERTED.ID VALUES (@client_id, @solde, @taux, @coutoperation)";

            // Création de notre nouvelle instance de connection
            _connection = Connection.New;

            // Création de l'objet command
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la requête
            _command.Parameters.Add(new SqlParameter("@client_id", element.client_id));
            _command.Parameters.Add(new SqlParameter("@solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@taux", element.taux));
            _command.Parameters.Add(new SqlParameter("@coutoperation", element.coutOperation));

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

        public override int Delete(Compte element)
        {
            throw new NotImplementedException();
        }

        public override Compte Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Compte> Find(Func<Compte, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Compte> FindAll()
        {
            throw new NotImplementedException();
        }

        public override int Update(Compte element)
        {
            throw new NotImplementedException();
        }
    }
}
