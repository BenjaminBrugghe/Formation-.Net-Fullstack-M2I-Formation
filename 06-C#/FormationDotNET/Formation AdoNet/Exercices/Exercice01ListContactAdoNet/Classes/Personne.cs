using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01ListContactAdoNet.Classes
{
    internal class Personne
    {
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;

        public Personne()
        {

        }
        public Personne(string firstname, string lastname, DateTime dateOfBirth)
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        #region Propriétés
        public string Firstname
        {
            get => firstname;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    firstname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format prénom...");
                }
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    lastname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format nom...");
                }
            }
        }
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        #endregion

        public void AddPersonne(string prenom, string nom, DateTime dateOfBirth)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = "INSERT INTO PERSONNE (firstname, lastname, DateOfBirth) OUTPUT INSERTED.ID VALUES (@firstname, @lastname, @DateOfBirth)";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            command.Parameters.Add(new SqlParameter("@firstname", prenom));
            command.Parameters.Add(new SqlParameter("@lastname", nom));
            command.Parameters.Add(new SqlParameter("@DateOfBirth", dateOfBirth));

            connection.Open();
            int id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
        }

        public void UpdatePersonne(string idModif, string prenom, string nom, DateTime dateOfBirth)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = $"UPDATE PERSONNE SET Firstname='{prenom}', Lastname='{nom}', DateOfBirth='{dateOfBirth}' WHERE Id='{idModif}'";

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

            string requestPerson = $"DELETE PERSONNE WHERE Id={idModif}";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            connection.Open();
            int id = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}
