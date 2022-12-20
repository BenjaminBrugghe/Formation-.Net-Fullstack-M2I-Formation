using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01ListContactAdoNet.Classes
{
    internal class Adresse
    {
        private int numero;
        private string rue;
        private int codePostal;
        private string ville;
        private string pays;

        public Adresse()
        {

        }
        public Adresse(int numero, string rue, int codePostal, string ville, string pays)
        {
            this.numero = numero;
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.pays = pays;
        }


        #region Propriétés

        public int Numero
        {
            get => numero;
            set
            {
                if (Tools.IsNumeric(Convert.ToString(value)))
                {
                    numero = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format numero...");
                }
            }
        }
        public string Rue
        {
            get => rue;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    rue = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format rue...");
                }
            }
        }
        public int CodePostal
        {
            get => codePostal;
            set
            {
                if (Tools.IsCodePostal(Convert.ToString(value)))
                {
                    codePostal = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format code postal...");
                }
            }
        }
        public string Ville
        {
            get => ville;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    ville = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format ville...");
                }
            }
        }
        public string Pays
        {
            get => pays;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    pays = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format pays...");
                }
            }
        }

        #endregion

        public void AddAddress(int numeroParse, string rue, int codePostalParse, string ville, string pays)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestAddress = "INSERT INTO ADRESSE (numero, rue, codePostal, ville, pays) OUTPUT INSERTED.ID VALUES (@numero, @rue, @codePostal, @ville, @pays)";

            SqlCommand command2 = new SqlCommand(requestAddress, connection);

            command2.Parameters.Add(new SqlParameter("@numero", numeroParse));
            command2.Parameters.Add(new SqlParameter("@rue", rue));
            command2.Parameters.Add(new SqlParameter("@codePostal", codePostalParse));
            command2.Parameters.Add(new SqlParameter("@ville", ville));
            command2.Parameters.Add(new SqlParameter("@pays", pays));

            connection.Open();
            int id2 = (int)command2.ExecuteScalar();
            command2.Dispose();
            connection.Close();
        }

        public void UpdateAddress(string idModif, int numeroParse, string rue, int codePostalParse, string ville, string pays)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = $"UPDATE ADRESSE SET Numero='{numeroParse}', Rue='{rue}', CodePostal='{codePostalParse}', Ville='{ville}', Pays='{pays}' WHERE Id='{idModif}'";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            connection.Open();
            SqlDataReader id = command.ExecuteReader();
            command.Dispose();
            connection.Close();

        }

        public void DeletePersonne(string idModif)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = $"DELETE ADRESSE WHERE Id={idModif}";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            connection.Open();
            int id = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}
