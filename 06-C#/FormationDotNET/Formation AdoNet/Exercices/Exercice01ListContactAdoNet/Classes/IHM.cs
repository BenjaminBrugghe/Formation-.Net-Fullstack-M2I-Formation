using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Exercice01ListContactAdoNet.Classes
{
    internal class IHM
    {
        Annuaire annuaire;



        public IHM()
        {
            annuaire = new Annuaire();
        }

        public void Start()
        {

            string userChoice = "";

            do
            {
                bool success = false;
                //Console.Clear();
                MenuPrincipal();
                userChoice = Console.ReadLine();

                while (!success)
                {
                    if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5" || userChoice == "0")
                    {
                        success = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur ! Veuillez entrer un choix valide\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        MenuPrincipal();
                        userChoice = Console.ReadLine();
                    }
                }

                Contact p = null;

                switch (userChoice)
                {
                    case "1":
                        AjouterContact();
                        break;

                    case "2":
                        ModifierContact();
                        break;

                    case "3":
                        SupprimerContact();
                        break;

                    case "4":
                        p = RechercherContact();
                        AfficherContact(p);
                        break;

                    case "5":
                        AfficherTout();
                        break;
                    case "0":
                        break;
                }
            } while (userChoice != "0");
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("***** TP Annuaire *****\n");
            Console.WriteLine("1 - Ajouter un contact");
            Console.WriteLine("2 - Modifier un contact");
            Console.WriteLine("3 - Supprimer un contact");
            Console.WriteLine("4 - Rechercher un contact par son id");
            Console.WriteLine("5 - Afficher tout les contacts");
            Console.WriteLine("0 - Quitter\n");
            Console.Write("Veuillez indiquer votre choix : ");
        }

        public void AjouterContact()
        {
            Console.Clear();
            Console.WriteLine("***** Ajout d'un contact *****");

            Console.WriteLine("\n*************** Class Personne ***************\n");

            Console.Write("Veuillez saisir le prénom : ");
            string prenom = Console.ReadLine();
            while (!Tools.IsAlphabetic(prenom))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le prénom : ");
                prenom = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le nom : ");
            string nom = Console.ReadLine();
            while (!Tools.IsAlphabetic(nom))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le nom : ");
                nom = Console.ReadLine();
            }

            DateTime dateOfBirth;
            int day, month, year;

            Console.Write("Veuillez saisir le jour de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out day))
                Console.Write("Erreur! Veuillez saisir le jour de naissance du contact (en chiffre) : ");

            Console.Write("Veuillez saisir le mois de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out month))
                Console.Write("Erreur! Veuillez saisir le mois de naissance du contact (en chiffre) : ");

            Console.Write("Veuillez saisir le mois de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out year))
                Console.Write("Erreur! Veuillez saisir le mois de naissance du contact (en chiffre) : ");

            dateOfBirth = new DateTime(year, month, day);



            Console.WriteLine("\n*************** Class Adresse ***************\n");

            Console.Write("Veuillez saisir le numéro de rue : ");
            string numero = Console.ReadLine();
            int numeroParse;
            bool isANumber = int.TryParse(numero, out numeroParse);

            while (!isANumber)
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le numéro de rue : ");
                numero = Console.ReadLine();
                isANumber = int.TryParse(numero, out numeroParse);
            }

            Console.Write("Veuillez saisir la rue : ");
            string rue = Console.ReadLine();
            while (!Tools.IsAlphabetic(rue))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir la rue : ");
                rue = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le code postal : ");
            string codePostal = Console.ReadLine();
            int codePostalParse;
            while (!Tools.IsCodePostal(Convert.ToString(codePostal)))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le code postal : ");
                codePostal = Console.ReadLine();
            }
            codePostalParse = Convert.ToInt32(codePostal);

            Console.Write("Veuillez saisir la ville : ");
            string ville = Console.ReadLine();
            while (!Tools.IsAlphabetic(ville))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir la ville : ");
                ville = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le pays : ");
            string pays = Console.ReadLine();
            while (!Tools.IsAlphabetic(pays))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le pays : ");
                pays = Console.ReadLine();
            }

            Console.WriteLine("\n*************** Class Contact ***************\n");

            Console.Write("Veuillez saisir le téléphone : ");
            string telephone = Console.ReadLine();
            while (!Tools.IsPhone(telephone))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le téléphone : ");
                telephone = Console.ReadLine();
            }

            Console.Write("Veuillez saisir l'email : ");
            string email = Console.ReadLine();
            while (!Tools.IsEmail(email))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir l'email : ");
                email = Console.ReadLine();
            }

            // *****************************************************

            Personne p = new();
            Adresse a = new();
            Contact c = new();

            p.AddPersonne(prenom, nom, dateOfBirth);

            a.AddAddress(numeroParse, rue, codePostalParse, ville, pays);

            c.AddContact(telephone, email);

            // *****************************************************
        }

        public void ModifierContact()
        {
            Console.Clear();
            Console.WriteLine("***** Modification d'un contact *****\n");

            Console.Write("Veuillez entrer l'id du contact à modifier : ");
            string idModif = Console.ReadLine();

            Console.WriteLine("\n*************** Class Personne ***************\n");

            Console.Write("Veuillez saisir le prénom : ");
            string prenom = Console.ReadLine();
            while (!Tools.IsAlphabetic(prenom))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le prénom : ");
                prenom = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le nom : ");
            string nom = Console.ReadLine();
            while (!Tools.IsAlphabetic(nom))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le nom : ");
                nom = Console.ReadLine();
            }

            DateTime dateOfBirth;
            int day, month, year;

            Console.Write("Veuillez saisir le jour de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out day))
                Console.Write("Erreur! Veuillez saisir le jour de naissance du contact (en chiffre) : ");

            Console.Write("Veuillez saisir le mois de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out month))
                Console.Write("Erreur! Veuillez saisir le mois de naissance du contact (en chiffre) : ");

            Console.Write("Veuillez saisir le mois de naissance du contact (en chiffre) : ");
            while (!int.TryParse(Console.ReadLine(), out year))
                Console.Write("Erreur! Veuillez saisir le mois de naissance du contact (en chiffre) : ");

            dateOfBirth = new DateTime(year, month, day);



            Console.WriteLine("\n*************** Class Adresse ***************\n");

            Console.Write("Veuillez saisir le numéro de rue : ");
            string numero = Console.ReadLine();
            int numeroParse;
            bool isANumber = int.TryParse(numero, out numeroParse);

            while (!isANumber)
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le numéro de rue : ");
                numero = Console.ReadLine();
                isANumber = int.TryParse(numero, out numeroParse);
            }

            Console.Write("Veuillez saisir la rue : ");
            string rue = Console.ReadLine();
            while (!Tools.IsAlphabetic(rue))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir la rue : ");
                rue = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le code postal : ");
            string codePostal = Console.ReadLine();
            int codePostalParse;
            while (!Tools.IsCodePostal(Convert.ToString(codePostal)))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le code postal : ");
                codePostal = Console.ReadLine();
            }
            codePostalParse = Convert.ToInt32(codePostal);

            Console.Write("Veuillez saisir la ville : ");
            string ville = Console.ReadLine();
            while (!Tools.IsAlphabetic(ville))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir la ville : ");
                ville = Console.ReadLine();
            }

            Console.Write("Veuillez saisir le pays : ");
            string pays = Console.ReadLine();
            while (!Tools.IsAlphabetic(pays))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le pays : ");
                pays = Console.ReadLine();
            }

            Console.WriteLine("\n*************** Class Contact ***************\n");

            Console.Write("Veuillez saisir le téléphone : ");
            string telephone = Console.ReadLine();
            while (!Tools.IsPhone(telephone))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir le téléphone : ");
                telephone = Console.ReadLine();
            }

            Console.Write("Veuillez saisir l'email : ");
            string email = Console.ReadLine();
            while (!Tools.IsEmail(email))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir l'email : ");
                email = Console.ReadLine();
            }

            // *****************************************************

            Personne p = new();
            Adresse a = new();
            Contact c = new();

            p.UpdatePersonne(idModif, prenom, nom, dateOfBirth);

            a.UpdateAddress(idModif, numeroParse, rue, codePostalParse, ville, pays);

            c.UpdateContact(idModif, telephone, email);

            // *****************************************************
        }

        public void SupprimerContact()
        {
            Console.Clear();
            Console.WriteLine("***** Suppression d'un contact *****\n");

            Console.Write("Veuillez entrer l'id du contact à supprimer : ");
            string recherche = Console.ReadLine();

            Personne p = new();
            Adresse a = new();
            Contact c = new();

            p.DeletePersonne(recherche);
            a.DeletePersonne(recherche);
            c.DeletePersonne(recherche);
        }

        public void AfficherContact(Contact p)
        {
            if (p != null)
            {
                Console.WriteLine("\n********** Affichage du contact **********");
                Console.WriteLine($"\n{p.Id}");
                Console.WriteLine($"{p.Firstname}");
                Console.WriteLine($"{p.Lastname}");
                Console.Write($"{p.Adresse.Numero}, ");
                Console.Write($"{p.Adresse.Rue}. ");
                Console.Write($"{p.Adresse.CodePostal}, ");
                Console.Write($"{p.Adresse.Ville} ");
                Console.WriteLine($"{p.Adresse.Pays}");
                Console.WriteLine($"{p.Telephone}");
                Console.WriteLine($"{p.Email}\n");

                Console.WriteLine("Press ENTER to exit...");
                Console.Read();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur ! Aucun contact n'a été trouvé...");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPress ENTER to exit...");
                Console.Read();
            }
        }

        public void AfficherTout()
        {
            Console.Clear();
            Console.WriteLine("***** Affichage de tout les contacts *****\n");

            string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string request = "SELECT pe.id,pe.Lastname,pe.Firstname,pe.DateOfBirth,ad.Numero,ad.Rue,ad.CodePostal,ad.Ville,ad.Pays,co.Telephone,co.Email FROM ADRESSE ad INNER JOIN PERSONNE pe ON ad.Id = pe.Id INNER JOIN CONTACT co ON co.Id = ad.Id";

            SqlCommand command = new SqlCommand(request, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"\tId : {reader.GetInt32(0)} - Prenom : {reader.GetString(1)} - Nom : {reader.GetString(2)} - Birth : {reader.GetDateTime(3)}\n\t - Numero : {reader.GetInt32(4)} - Rue : {reader.GetString(5)} - Code Postal : {reader.GetInt32(6)} - Ville : {reader.GetString(7)} - Pays : {reader.GetString(8)}\n\t - Téléphone : {reader.GetString(9)} - Email : {reader.GetString(10)}\n");
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }


        public Contact RechercherContact()
        {
            Console.Clear();
            Console.WriteLine("***** Recherche d'un contact *****\n");

            Console.Write("Veuillez entrer le prénom du contact à rechercher : ");
            string recherche = Console.ReadLine();
            Contact findPerson = null;

            for (int i = 0; i < annuaire.ListeAnnuaire.Count; i++)
            {
                if (annuaire.ListeAnnuaire[i] != null)
                {
                    if (annuaire.ListeAnnuaire[i].Firstname == recherche)
                    {
                        findPerson = annuaire.ListeAnnuaire[i];
                    }
                }
            }
            return findPerson;
        }


        public void ErreurDeSaisie()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur de saisie !");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
