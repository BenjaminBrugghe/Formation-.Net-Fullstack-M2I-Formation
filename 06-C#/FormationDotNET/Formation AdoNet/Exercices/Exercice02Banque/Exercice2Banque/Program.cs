using Exercice2Banque.Classes;
using Exercice2Banque.DAO_DataAccessObject_;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//IHM ihm = new();
//ihm.Start();

ClientDAO _clientDAO = new(); ;

Client c = new Client("Brugghe", "Benjamin", "+33 6 07 08 09 10");

_clientDAO.Create(c);




Console.WriteLine("\nPress ENTER to exit...");
Console.Read();
