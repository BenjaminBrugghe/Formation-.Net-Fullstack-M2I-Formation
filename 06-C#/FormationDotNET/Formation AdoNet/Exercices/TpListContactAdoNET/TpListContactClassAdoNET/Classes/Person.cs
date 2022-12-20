using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactClassAdoNET.Tools;

namespace TpListContactClassAdoNET.Classes
{
    public class Person
    {
        private int personid;
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Person()
        {

        }

        public Person(string firstname, string lastname, DateTime dateOfBirth) : this()
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public int PersonId { get => personid; init => personid = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public virtual Person Get(int id)
        {
            Person person = null;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT (nom, prenom , date_naissance) FROM PERSON WHERE id=@Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", id));
            

            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                person = new Person() { PersonId = _reader.GetInt32(0), Firstname = _reader.GetString(2), Lastname = _reader.GetString(1), DateOfBirth = (DateTime)_reader[2] };
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();
            // Fzermeture de la connection à la BDD
            _connection.Close();


            return person;
        }

        public virtual int Add()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO Person (nom, prenom, date_naissance) OUTPUT INSERTED.ID VALUES (@Firstname, @Lastname, @DateOfBirth)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Firstname", Firstname));
            _command.Parameters.Add(new SqlParameter("@Lastname", Lastname));
            _command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));

            // Execution de la commande
            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();


            return Id;
        }

        public virtual bool Update()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE PERSON SET nom = @Firstname, prenom = @Lastname, date_naissance = @DateOfBirth WHERE id=@PersonId";
            

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Firstname", Firstname));
            _command.Parameters.Add(new SqlParameter("@Lastname", Lastname));
            _command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
            _command.Parameters.Add(new SqlParameter("@PersonId", PersonId));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public virtual bool Delete()
        {

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE PERSON WHERE id=@PersonId";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@PersonId", PersonId));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }


        public override string ToString()
        {
            return $"\tNom : {Lastname}\tPrénom : {Firstname} \t DateOfBirth : {DateOfBirth.Day}/{DateOfBirth.Month}/{DateOfBirth.Year}";
        }
    }
}
