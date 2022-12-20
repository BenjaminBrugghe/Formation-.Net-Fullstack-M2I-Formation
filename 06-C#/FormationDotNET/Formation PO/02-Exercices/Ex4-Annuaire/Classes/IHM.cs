using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Annuaire.Classes
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
                        p = AjouterContact();

                        if (p != null)
                        {
                            annuaire.ListeAnnuaire.Add(p);
                        }
                        break;

                    case "2":
                        p = ModifierContact();

                        if (p != null)
                        {
                            for (int i = 0; i < annuaire.ListeAnnuaire.Count; i++)
                            {
                                if (annuaire.ListeAnnuaire[i].Id == p.Id)
                                {
                                    annuaire.ListeAnnuaire[i] = p;
                                }
                            }
                        }
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
            Console.WriteLine("4 - Rechercher un contact par son nom");
            Console.WriteLine("5 - Afficher tout les contacts");
            Console.WriteLine("0 - Quitter\n");
            Console.Write("Veuillez indiquer votre choix : ");
        }

        public Contact AjouterContact()
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

            Console.Write("Veuillez saisir la date de naissance (aaaa/mm/jj) : ");
            string naissance = Console.ReadLine();
            while (!Tools.IsDate(naissance))
            {
                ErreurDeSaisie();
                Console.Write("Veuillez saisir la date de naissance (aaaa/mm/jj) : ");
                naissance = Console.ReadLine();
            }
            int naissanceParse = 0;
            bool test = int.TryParse(naissance, out naissanceParse);

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

            return new Contact(prenom, nom, new DateTime(naissanceParse), new Adresse(numeroParse, rue, codePostalParse, ville, pays), telephone, email);
        }

        public Contact ModifierContact()
        {
            Console.Clear();
            Console.WriteLine("***** Modification d'un contact *****\n");

            Console.Write("Veuillez entrer le prénom du contact à modifier : ");
            string prenomModif = Console.ReadLine();

            Contact p = null;

            for (int i = 0; i < annuaire.ListeAnnuaire.Count; i++)
            {
                if (annuaire.ListeAnnuaire[i] != null)
                {
                    if (annuaire.ListeAnnuaire[i].Firstname == prenomModif)
                    {
                        Console.WriteLine("\n*************** Class Personne ***************\n");

                        Console.Write("Veuillez saisir le prénom : ");
                        annuaire.ListeAnnuaire[i].Firstname = Console.ReadLine();
                        while (!Tools.IsAlphabetic(annuaire.ListeAnnuaire[i].Firstname))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le prénom : ");
                            annuaire.ListeAnnuaire[i].Firstname = Console.ReadLine();
                        }

                        Console.Write("Veuillez saisir le nom : ");
                        annuaire.ListeAnnuaire[i].Lastname = Console.ReadLine();
                        while (!Tools.IsAlphabetic(annuaire.ListeAnnuaire[i].Lastname))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le nom : ");
                            annuaire.ListeAnnuaire[i].Lastname = Console.ReadLine();
                        }

                        Console.Write("Veuillez saisir la date de naissance (aaaa/mm/jj) : ");

                        string naissance = Console.ReadLine();
                        while (!Tools.IsDate(naissance))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir la date de naissance (aaaa/mm/jj) : ");
                            naissance = Console.ReadLine();
                        }
                        int naissanceParse = 0;
                        bool test = int.TryParse(naissance, out naissanceParse);

                        if (test)
                        {
                            annuaire.ListeAnnuaire[i].DateOfBirth = Convert.ToDateTime(naissanceParse);
                        }

                        Console.WriteLine("\n*************** Class Adresse ***************\n");

                        Console.Write("Veuillez saisir le numéro de rue : ");
                        annuaire.ListeAnnuaire[i].Adresse.Numero = Convert.ToInt32(Console.ReadLine());

                        while (!Tools.IsNumeric(Convert.ToString(annuaire.ListeAnnuaire[i].Adresse.Numero)))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le numéro de rue : ");
                            annuaire.ListeAnnuaire[i].Adresse.Numero = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Veuillez saisir la rue : ");
                        annuaire.ListeAnnuaire[i].Adresse.Rue = Console.ReadLine();
                        while (!Tools.IsAlphabetic(annuaire.ListeAnnuaire[i].Adresse.Rue))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir la rue : ");
                            annuaire.ListeAnnuaire[i].Adresse.Rue = Console.ReadLine();
                        }

                        Console.Write("Veuillez saisir le code postal : ");
                        annuaire.ListeAnnuaire[i].Adresse.CodePostal = Convert.ToInt32(Console.ReadLine());
                        int codePostalParse;
                        while (!Tools.IsCodePostal(Convert.ToString(annuaire.ListeAnnuaire[i].Adresse.CodePostal)))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le code postal : ");
                            annuaire.ListeAnnuaire[i].Adresse.CodePostal = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Veuillez saisir la ville : ");
                        annuaire.ListeAnnuaire[i].Adresse.Ville = Console.ReadLine();
                        while (!Tools.IsAlphabetic(annuaire.ListeAnnuaire[i].Adresse.Ville))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir la ville : ");
                            annuaire.ListeAnnuaire[i].Adresse.Ville = Console.ReadLine();
                        }

                        Console.Write("Veuillez saisir le pays : ");
                        annuaire.ListeAnnuaire[i].Adresse.Pays = Console.ReadLine();
                        while (!Tools.IsAlphabetic(annuaire.ListeAnnuaire[i].Adresse.Pays))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le pays : ");
                            annuaire.ListeAnnuaire[i].Adresse.Pays = Console.ReadLine();
                        }

                        Console.WriteLine("\n*************** Class Contact ***************\n");

                        Console.Write("Veuillez saisir le téléphone : ");
                        annuaire.ListeAnnuaire[i].Telephone = Console.ReadLine();
                        while (!Tools.IsPhone(annuaire.ListeAnnuaire[i].Telephone))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir le téléphone : ");
                            annuaire.ListeAnnuaire[i].Telephone = Console.ReadLine();
                        }

                        Console.Write("Veuillez saisir l'email : ");
                        annuaire.ListeAnnuaire[i].Email = Console.ReadLine();
                        while (!Tools.IsEmail(annuaire.ListeAnnuaire[i].Email))
                        {
                            ErreurDeSaisie();
                            Console.Write("Veuillez saisir l'email : ");
                            annuaire.ListeAnnuaire[i].Email = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur ! Aucun contact n'a été trouvé...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            return p;
        }

        public void AfficherTout()
        {
            Console.Clear();
            Console.WriteLine("***** Affichage de tout les contacts *****\n");
            foreach (var p in annuaire.ListeAnnuaire)
            {
                Console.WriteLine($"\tid : {p.Id} - Nom : {p.Lastname} - Prénom : {p.Firstname}");
            }
        }

        public void SupprimerContact()
        {
            Console.Clear();
            Console.WriteLine("***** Suppression d'un contact *****\n");

            Console.Write("Veuillez entrer le prénom du contact à rechercher : ");
            string recherche = Console.ReadLine();

            for (int i = 0; i < annuaire.ListeAnnuaire.Count; i++)
            {
                if (annuaire.ListeAnnuaire[i] != null)
                {
                    if (annuaire.ListeAnnuaire[i].Firstname == recherche)
                    {
                        annuaire.ListeAnnuaire[i] = null;

                        Console.WriteLine("Contact supprimé avec succès !\n");
                        Console.WriteLine("Press ENTER to exit...");
                        Console.Read();
                    }
                }
            }
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

        public void ErreurDeSaisie()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur de saisie !");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
