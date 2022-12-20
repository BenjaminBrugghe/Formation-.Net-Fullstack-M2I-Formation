using Microsoft.Data.SqlClient;
using TpListContactClassAdoNET.Tools;

namespace TpListContactClassAdoNET.Classes
{
    public class Address
    {
        private int addressId;
        private int number;
        private string roadName;
        private int postalCode;
        private string town;
        private string country;
        string _request;
        SqlCommand _command;
        SqlConnection _connection;
        SqlDataReader _reader;

        public Address()
        {
            
        }
        public Address(int number, string roadName, int postalCode, string town, string country)
        {            
            Number = number;
            RoadName = roadName;
            PostalCode = postalCode;
            Town = town;
            Country = country;
        }

        public int AddressId { get => addressId; set => addressId = value; }
        public int Number { get => number; set => number = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public int PostalCode { get => postalCode; set => postalCode = value; }
        public string Town { get => town; set => town = value; }
        public string Country { get => country; set => country = value; }

        public int Add()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "INSERT INTO ADDRESS (NUMBER, ROAD_NAME, POSTAL_CODE, TOWN, COUNTRY) " +
                "OUTPUT INSERTED.ID VALUES (@Number, @RoadName, @PostalCode, @Town, @Country)";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Number", Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", RoadName));
            _command.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            _command.Parameters.Add(new SqlParameter("@Town", Town));
            _command.Parameters.Add(new SqlParameter("@Country", Country));

            // Ouverture de la connection à la BDD
            _connection.Open();

            // Execution de la commande
            int Id = (int)_command.ExecuteScalar();

            // Libération de l'objet command
            _command.Dispose();

            // Fermeture de la connection à la BDD
            _connection.Close();


            return Id;
        }
        
        public bool Update()
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE ADDRESS SET number = @Number, road_name = @RoadName, postal_code = @PostalCode, " +
                "town = @Town, country = @Country WHERE id=@AdresseId";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Number", Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", RoadName));
            _command.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            _command.Parameters.Add(new SqlParameter("@Town", Town));
            _command.Parameters.Add(new SqlParameter("@Country", Country));
            _command.Parameters.Add(new SqlParameter("@AdresseId", AddressId));

            // Execution de la commande
            _connection.Open();
            int NbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();


            return NbLignes > 0;
        }

        public bool Delete()
        {

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE ADDRESS WHERE id=@AddressId";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@AddressId", AddressId));

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
            return $"{Number} {RoadName} - {PostalCode} {Town} - {Country} ";
        }
    }
}
