using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactClassAdoNET.Tools;

namespace TpListContactClassAdoNET.Classes
{
    public class Contact : Person
    {
        private int id;
        private Address contactAddress;
        private string phoneNumber;
        private string email;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Contact()
        {

        }
        public Contact(string firstname, string lastname, DateTime dateOfBirth, Address contactAddress, string phoneNumber, string email) : base(firstname, lastname, dateOfBirth)
        {
            ContactAddress = contactAddress;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public int Id { get => id; set => id = value; }
        public Address ContactAddress { get => contactAddress; set => contactAddress = value; }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (MyRegex.IsPhone(value))
                    phoneNumber = value;
                else
                    throw new FormatException("Erreur format Télephone.");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (MyRegex.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur format Email.");
            }
        }

        public (bool,Contact) Get(int id)
        {
            Contact contact = null;
            bool found = false;

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT ctc.id, ctc.email, ctc.telephone, psn.id, psn.prenom, psn.nom, psn.date_naissance, " +
                "adr.id, adr.number, adr.road_name, adr.postal_code, adr.town, adr.country " +
                "FROM CONTACT AS ctc " +
                "INNER JOIN PERSON AS psn ON ctc.Person_ID = psn.Id " +
                "INNER JOIN ADDRESS AS adr ON ctc.Address_ID = adr.Id " +
                "WHERE ctc.id = @Id";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ajout des paramètres de la commande
            command.Parameters.Add(new SqlParameter("@Id", id));

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                contact = new Contact()
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    PhoneNumber = reader.GetString(2),
                    PersonId = reader.GetInt32(3),
                    Firstname = reader.GetString(4),
                    Lastname = reader.GetString(5),
                    DateOfBirth = (DateTime)reader[6],
                    contactAddress = new Address()
                    {
                        AddressId = reader.GetInt32(7),
                        Number = reader.GetInt32(8),
                        RoadName = reader.GetString(9),
                        PostalCode = reader.GetInt32(10),
                        Town = reader.GetString(11),
                        Country = reader.GetString(12)
                    }
                };
                found = true;
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return (found,contact);
        }

        public static List<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();

            // Création d'un instance de connection
            SqlConnection connection = Connection.New;

            // Prépartion de la commande
            string request = "SELECT ctc.id, ctc.email, ctc.telephone, psn.id, psn.prenom, psn.nom, psn.date_naissance, " +
                "adr.id, adr.number, adr.road_name, adr.postal_code, adr.town, adr.country " +
                "FROM CONTACT AS ctc " +
                "INNER JOIN PERSON AS psn ON ctc.Person_ID = psn.Id " +
                "INNER JOIN ADDRESS AS adr ON ctc.Address_ID = adr.Id";

            // Préparation de la commande
            SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connexion
            connection.Open();

            // Execution de la commande
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Contact contact = new Contact()
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    PhoneNumber = reader.GetString(2),
                    PersonId = reader.GetInt32(3),
                    Firstname = reader.GetString(4),
                    Lastname = reader.GetString(5),
                    DateOfBirth = (DateTime)reader[6],
                    ContactAddress = new Address()
                    {
                        AddressId = reader.GetInt32(7),
                        Number = reader.GetInt32(8),
                        RoadName = reader.GetString(9),
                        PostalCode = reader.GetInt32(10),
                        Town = reader.GetString(11),
                        Country = reader.GetString(12)
                    }
                };
                contacts.Add(contact);
            }
            reader.Close();

            // Libération de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();

            // Retour de la liste de contact
            return contacts;
        }

        public override int Add()
        {
            // Création d'une instance de connection
            _connection = Connection.New;
            // Ajout de la personne en BDD
            int personId = base.Add();
            //int addressId = ContactAddress.AddressId;

            if (personId > 0)
            {
                // Prépartion de la commande
                _request = "INSERT INTO Contact (email, telephone, person_id, address_id) " +
                    "OUTPUT INSERTED.ID VALUES (@Email, @PhoneNumber, @PersonId, @AddressId)";

                // Préparation de la commande
                SqlCommand command = new SqlCommand(_request, _connection);

                // Ajout des paramètres de la commande
                command.Parameters.Add(new SqlParameter("@Email", Email));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@PersonId", personId));
                command.Parameters.Add(new SqlParameter("@AddressId", contactAddress.AddressId));

                // Execution de la commande
                _connection.Open();
                int Id = (int)command.ExecuteScalar();

                // Libération de l'objet command
                command.Dispose();
                // Fermeture de la connection
                _connection.Close();

                return Id;
            }
            else
                return -1;
        }

        public override bool Update()
        {
            // Création d'une instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE CONTACT SET email=@Email, telephone=@PhoneNumber OUTPUT INSERTED.PERSON_ID WHERE id=@Id ";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Email", Email));
            _command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));            
            _command.Parameters.Add(new SqlParameter("@Id", Id));
            

            // Execution de la commande
            _connection.Open();

            // Execution de la commande
            int personId = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();

            // Prépartion de la commande
            _request = "UPDATE PERSON SET prenom=@Prenom, nom=@Nom, date_naissance=@DateNaissance WHERE id=@PersonId ";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande           
            _command.Parameters.Add(new SqlParameter("@Prenom", Firstname));
            _command.Parameters.Add(new SqlParameter("@Nom", Lastname));
            _command.Parameters.Add(new SqlParameter("@DateNaissance", DateOfBirth));
            _command.Parameters.Add(new SqlParameter("@PersonId", personId));

            // Execution de la commande
            int NbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();

            return NbLignes > 0;
        }

        public (bool,string) Delete()
        {
            bool result = false;
            Person person = new() { PersonId = PersonId };
            try
            {
                ContactAddress.Delete();
                person.Delete();
            }
            catch (Exception e)
            {
                return (false,e.Message);
            }

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE CONTACT WHERE id=@Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", Id));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return (nbLignes > 0 , nbLignes > 0 ? $"Le contact N°{Id} à été supprimé":"Erreur lors de la suppression du contact");
        }

        public override string ToString()
        {
            return $"\n Contact N°{Id}\n{base.ToString()}\n\tAdresse : {ContactAddress} \n\tPhone : {PhoneNumber} \n\tEmail : {Email}\n";
        }
    }
}
