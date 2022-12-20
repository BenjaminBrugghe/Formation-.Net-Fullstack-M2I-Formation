using TpListContactClassAdoNET.Classes;

namespace TpListContactIhmAdoNET.Classes
{
    public class IHM
    {
        List<Contact> Contacts;

        public IHM()
        {
            RefreshContactList();
        }



        public void Start()
        {
            string choix = "";
            do
            {
                MainMenu();
                choix = UserChoice();
                switch (choix)
                {
                    case "1":
                        AddContactAction();
                        break;
                    case "2":
                        UpdateContactAction();
                        break;
                    case "3":
                        DeleteContactAction();
                        break;
                    case "4":
                        FindContactAction();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        OnRed("Erreur, verifier votre choix!");
                        WaitUser();
                        break;
                }

            } while (choix != "0");
        }

        public static void AppTitle()
        {
            OnCyan("----------------------------------------------------------------------");
            OnCyan("--------------------- TP List Contact (Annuaire) ---------------------");
            OnCyan("----------------------------------------------------------------------\n");
        }

        public static void MainMenu()
        {
            AppTitle();

            OnCyan("\t\tMain Menu");
            Console.WriteLine("\t1-- Ajouter un Contact");
            Console.WriteLine("\t2-- Modifier un Contact");
            Console.WriteLine("\t3-- Supprimer un Contact");
            Console.WriteLine("\t4-- Rechercher un Contact par Id");
            OnRed("\t0--- Quitter");
        }

        public string UserChoice()
        {
            Console.Write("\nVeuillez faire votre choix : ");
            return Console.ReadLine();
        }

        public void RefreshContactList()
        {
            Contacts = Contact.GetAll();
        }

        public void AddContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            // Affichage du Titre de la sous partie
            OnCyan("\t\t\tAjouter un contact");

            // Création d'un contact
            Contact c = null;

            // Recupération des saisies utilisateur pour la création d'un nouveau contact
            try
            {
                int day, month, year, number, postalcode;
                string firstname, lastname, roadName, town, country, phone, email;
                DateTime dateOfBirth;
                OnCyan("------------------------------ Personne ------------------------------\n");

                Console.Write("Veuillez saisir le nom du contact : ");
                lastname = Console.ReadLine();

                Console.Write("Veuillez saisir le prénom du contact : ");
                firstname = Console.ReadLine();

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

                OnCyan("------------------------------ Adresse -------------------------------\n");


                Console.Write("Veuillez saisir numéro de porte : ");
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.Write("Erreur! Veuillez saisir numéro de porte : ");

                Console.Write("Veuillez saisir le nom de la rue : ");
                roadName = Console.ReadLine();

                Console.Write("Veuillez saisir le code postal de la ville : ");
                while (!int.TryParse(Console.ReadLine(), out postalcode))
                    Console.Write("Erreur! Veuillez saisir le code postal de la ville : ");

                Console.Write("Veuillez saisir le nom de la Ville : ");
                town = Console.ReadLine();

                Console.Write("Veuillez saisir le nom du pays : ");
                country = Console.ReadLine();

                Address contactAdress = new Address(number, roadName, postalcode, town, country);

                OnCyan("------------------------------ Contact -------------------------------\n");

                Console.Write("Veuillez saisir le numéro de téléphone : ");
                phone = Console.ReadLine();

                Console.Write("Veuillez saisir l'email : ");
                email = Console.ReadLine();


                // Création du contact
                contactAdress.AddressId = contactAdress.Add();
                c = new(firstname, lastname, dateOfBirth, contactAdress, phone, email);
                c.Id = c.Add();

                if (c.Id > 0)
                    OnGreen("\nContact ajouté avec succès!\n");
                else
                    OnRed("\nErreur lors de l'ajout du contact!\n");
            }
            catch (Exception e)
            {
                OnRed(e.Message);
            }


            WaitUser();
        }

        public void UpdateContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            // Affichage du Titre de la sous partie
            OnCyan("\n\t\t\tModifier un contact");

            
            // Création d'un contact
            Contact c = null;
            // Initialisation de l'id du contact a update
            int index = -1;

            // Recupération de la saisie utilisateur pour l'id
            Console.Write("Veuillez saisir l'id du contact à modifier : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index > 0)
                OnRed("Veuillez saisir un entier positif");


            (bool found, Contact tmp) = GetContact(index);


            //// Si le contact existe dans la liste
            //if (GetContact(index).Item1)
            //    // Assignation a c du contact
            //    c = GetContact(index).Item2;
            if (found)
            {
                c = tmp;
            }
            else
            {
                // Sinon affichage de l'erreur
                OnRed("\nAucun contact avec cet ID!\n");
                WaitUser();
                return;
            }



            // Recupération des saisies utilisateur pour la création d'un nouveau contact
            try
            {
                int day, month, year, number, postalcode, intTmp;
                string firstname, lastname, roadName, town, country, phone, email;
                DateTime dateOfBirth;
                OnCyan("------------------------------ Personne ------------------------------\n");


                Console.Write($"Veuillez saisir le nom du contact (Actual Value = {c.Lastname} => PRESS ENTER pour conserver) : ");
                string stringTmp = Console.ReadLine();
                lastname = stringTmp == "" ? c.Lastname : stringTmp;

                Console.Write($"Veuillez saisir le prénom du contact (Actual Value = {c.Firstname} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                firstname = stringTmp == "" ? c.Firstname : stringTmp;

                Console.Write($"Veuillez saisir le jour de naissance du contact (Actual Value = {c.DateOfBirth.Day} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    Console.Write($"Erreur! Veuillez saisir le jour de naissance du contact (Actual Value = {c.DateOfBirth.Day} => saisir 0 pour conserver) : ");
                day = intTmp == 0 ? c.DateOfBirth.Day : intTmp;

                Console.Write($"Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Month} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    Console.Write($"Erreur! Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Month} => saisir 0 pour conserver) : ");
                month = intTmp == 0 ? c.DateOfBirth.Month : intTmp;

                Console.Write($"Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Year} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    Console.Write($"Erreur! Veuillez saisir le mois de naissance du contact (Actual Value = {c.DateOfBirth.Year} => saisir 0 pour conserver) : ");
                year = intTmp == 0 ? c.DateOfBirth.Year : intTmp;

                if (c.DateOfBirth.Year != year || c.DateOfBirth.Month != month || c.DateOfBirth.Day != day)
                    dateOfBirth = new DateTime(year, month, day);
                else
                    dateOfBirth = c.DateOfBirth;


                OnCyan("------------------------------ Adresse -------------------------------\n");


                Console.Write($"Veuillez saisir numéro de porte (Actual Value = {c.ContactAddress.Number} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    Console.Write($"Erreur! Veuillez saisir numéro de porte (Actual Value = {c.ContactAddress.Number} => saisir 0 pour conserver) : ");
                number = intTmp == 0 ? c.ContactAddress.Number : intTmp;

                Console.Write($"Veuillez saisir le nom de la rue (Actual Value = {c.ContactAddress.RoadName} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                roadName = stringTmp == "" ? c.ContactAddress.RoadName : stringTmp;

                Console.Write($"Veuillez saisir le code postal de la ville (Actual Value = {c.ContactAddress.PostalCode} => saisir 0 pour conserver) : ");
                while (!int.TryParse(Console.ReadLine(), out intTmp))
                    Console.Write($"Erreur! Veuillez saisir le code postal de la ville (Actual Value = {c.ContactAddress.PostalCode} => saisir 0 pour conserver): ");
                postalcode = intTmp == 0 ? c.ContactAddress.PostalCode : intTmp;

                Console.Write($"Veuillez saisir le nom de la Ville (Actual Value = {c.ContactAddress.Town} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                town = stringTmp == "" ? c.ContactAddress.Town : stringTmp;

                Console.Write($"Veuillez saisir le nom du pays (Actual Value = {c.ContactAddress.Country} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                country = stringTmp == "" ? c.ContactAddress.Country : stringTmp;
                Address contactAdress;
                if (c.ContactAddress.Number != number || c.ContactAddress.RoadName != roadName || c.ContactAddress.PostalCode != postalcode
                    || c.ContactAddress.Town != town || c.ContactAddress.Country != country)
                {
                    contactAdress = new Address(number, roadName, postalcode, town, country);
                    contactAdress.AddressId = c.ContactAddress.AddressId;
                    contactAdress.Update();
                }
                else
                    contactAdress = c.ContactAddress;


                OnCyan("------------------------------ Contact -------------------------------\n");

                Console.Write($"Veuillez saisir le numéro de téléphone (Actual Value = {c.PhoneNumber} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                phone = stringTmp == "" ? c.PhoneNumber : stringTmp;

                Console.Write($"Veuillez saisir l'email (Actual Value = {c.Email} => PRESS ENTER pour conserver) : ");
                stringTmp = Console.ReadLine();
                email = stringTmp == "" ? c.Email : stringTmp;

                // Update du contact
                Contact tmp2 = new Contact()
                {
                    Id = c.Id,
                    Firstname = firstname,
                    Lastname = lastname,
                    DateOfBirth = dateOfBirth,
                    ContactAddress = contactAdress,
                    Email = email,
                    PhoneNumber = phone
                };
                // Si la méthode update return false
                if (!tmp2.Update())
                    OnRed("\nErreur lors la modification du contact.\n");
                else
                    OnGreen("\nContact modifié avec succès...");
            }
            catch (Exception e)
            {
                OnRed(e.Message);
            }


            WaitUser();

        }

        public void DeleteContactAction()
        {
            // Nettoyage console
            Console.Clear();
            // Affichage du titre de l'application
            AppTitle();
            OnCyan("------------------------- Supprimer Contact -------------------------\n");
            // Initialisation de l'index
            int index = -1;
            // Recupération de la saisie utilisateur pour l'index
            Console.Write("Veuillez saisir l'id du contact à supprimer : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index >= 0)
                OnRed("Veuillez saisir un entier");

            // Création d'un contact
            (bool found, Contact c) = GetContact(index);
            // Si le contact existe dans la liste
            if (!found)
                // Sinon affichage de l'erreur
                OnRed("\nAucun contact avec cet ID!\n");

            if (c != null)
            {
                ( bool result, string message) = c.Delete();
                
                if (result)
                    OnGreen("\nContact supprimé avec succès!\n");
                else
                    OnRed("\nErreur lors de la suppression du contact!\n");
            }
            WaitUser();
        }

        public void FindContactAction()
        {
            Console.Clear();
            AppTitle();


            OnCyan("------------------------- Rechercher Contact -------------------------\n");

            int index = -1;
            Console.Write("Veuillez saisir l'id du contact à rechercher : ");
            while (!int.TryParse(Console.ReadLine(), out index) && index > 0)
                OnRed("Veuillez saisir un entier positif");


            Contact c = null;
            if (GetContact(index).Item1)
                c = GetContact(index).Item2;
            else
                OnRed("\nAucun contact avec cet ID!\n");

            if (c != null)
            {
                OnCyan("\nVoici le contact trouvé dans l'annuaire : \n");
                Console.WriteLine(c);
            }
            WaitUser();
        }

        public (bool, Contact) GetContact(int id)
        {
            RefreshContactList();
            Contact contact = new();
            (bool found, Contact c) = contact.Get(id);
            //bool found = contact.Get(id).Item1;
            if (found)            
                contact = c;            

            return (found, c);
        }

        public void WaitUser()
        {
            OnCyan("\nAppuyez sur ENTER pour revenir au menu pricipal...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void OnCyan(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnGreen(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
