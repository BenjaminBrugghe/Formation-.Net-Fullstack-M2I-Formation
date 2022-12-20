using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01ListContactAdoNet.Classes
{
    internal class Contact : Personne
    {
        private string telephone;
        private string email;
        private Adresse adresse;
        private int id;
        private static int compteur = 0;

        public Contact() : base()
        {
            Id = ++compteur;
        }

        public Contact(string firstname, string lastname, DateTime dateOfBirth, Adresse adress, string telephone, string email)
            : base(firstname, lastname, dateOfBirth)
        {
            adresse = adress;
            Telephone = telephone;
            Email = email;
            Id = ++compteur;
        }

        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        internal Adresse Adresse { get => adresse; set => adresse = value; }
        public int Id { get => id; set => id = value; }

        public void AddContact(string telephone, string email)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = "INSERT INTO CONTACT (telephone, email) OUTPUT INSERTED.ID VALUES (@telephone, @email)";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            command.Parameters.Add(new SqlParameter("@telephone", telephone));
            command.Parameters.Add(new SqlParameter("@email", email));

            connection.Open();
            int id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
        }

        public void UpdateContact(string idModif, string telephone, string email)
        {
            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string requestPerson = $"UPDATE CONTACT SET Telephone='{telephone}', Email='{email}' WHERE Id='{idModif}'";

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

            string requestPerson = $"DELETE CONTACT WHERE Id={idModif}";

            SqlCommand command = new SqlCommand(requestPerson, connection);

            connection.Open();
            int id = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}