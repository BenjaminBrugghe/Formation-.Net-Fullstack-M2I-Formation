using Exercice1_ListeContacts.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_ListeContacts.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Voir les contacts");
                Console.WriteLine("2. Ajouter un contact");
                Console.WriteLine("3. Modifier un contact");
                Console.WriteLine("4. Supprimer un contact");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        ListContact();
                        break;

                    case 2:
                        AddContact();
                        break;

                    case 3:
                        UpdateContact();
                        break;

                    case 4:
                        DeleteContact();
                        break;

                    default:
                        Console.WriteLine("Votre choix est incorrect !");
                        break;
                }
            }
        }

        private void ListContact() 
        {
            Console.WriteLine("\n--- Liste des contacts ---\n");

            List<Contact> contactList = _context.Contacts.ToList();

            if (contactList != null)
            {
                foreach (var c in contactList)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a aucun contact dans la base de données !");
            }
        }
        private void AddContact()
        {
            Console.Write("\n--- Ajout d'un contact ---\n");

            Console.Write("Veuillez saisir le nom : ");
            string lastName = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom : ");
            string firstName= Console.ReadLine();

            Console.Write("Veuillez saisir la date de naissance : ");
            string birthDate = Console.ReadLine();

            Console.Write("Veuillez saisir l'âge : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Veuillez saisir le genre (Mr/Mme) : ");
            string gender = Console.ReadLine();

            Console.Write("Veuillez saisir le numéro de téléphone : ");
            string phone = Console.ReadLine();

            Console.Write("Veuillez saisir l'email : ");
            string email = Console.ReadLine();

            Contact newContact = new Contact
            {
                LastName = lastName,
                FirstName = firstName,
                BirthDate = birthDate,
                Age = age,
                Gender = gender,
                PhoneNumber = phone,
                Email = email
            };

            _context.Contacts.Add(newContact);
            _context.SaveChanges();

        }
        private void UpdateContact()
        {
            Console.WriteLine("\n--- Modification d'un contact ---\n");

            Console.Write("Entrez l'Id du contact à modifier : ");
            int idToEdit = int.Parse(Console.ReadLine());

            // 4ème méthode
            Contact contactToUpdate = _context.Contacts.Find(idToEdit);

            if (contactToUpdate != null)
            {
                Console.Write("Veuillez saisir le nom : ");
                string lastNameNew = Console.ReadLine();

                Console.Write("Veuillez saisir le prénom : ");
                string firstNameNew = Console.ReadLine();

                Console.Write("Veuillez saisir la date de naissance : ");
                string birthDateNew = Console.ReadLine();

                Console.Write("Veuillez saisir l'âge : ");
                int ageNew = int.Parse(Console.ReadLine());

                Console.Write("Veuillez saisir le genre (Mr/Mme) : ");
                string genderNew = Console.ReadLine();

                Console.Write("Veuillez saisir le numéro de téléphone : ");
                string phoneNew = Console.ReadLine();

                Console.Write("Veuillez saisir l'email : ");
                string emailNew = Console.ReadLine();

                contactToUpdate.FirstName = lastNameNew;
                contactToUpdate.LastName = firstNameNew;
                contactToUpdate.BirthDate = birthDateNew;
                contactToUpdate.Age = ageNew;
                contactToUpdate.Gender = genderNew;
                contactToUpdate.PhoneNumber = phoneNew;
                contactToUpdate.Email = emailNew;

                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Il n'existe aucun contact avec cet Id dans la base de données !");
            }
        }
        private void DeleteContact()
        {
            Console.WriteLine("\n--- Suppression d'un contact ---\n");

            Console.Write("Entrez l'Id du contact à supprimer : ");
            int idToDelete = int.Parse(Console.ReadLine());

            Contact dogToDelete = _context.Contacts.Find(idToDelete);

            if (dogToDelete != null)
            {
                _context.Contacts.Remove(dogToDelete);

                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Il n'existe pas de chien avec cet Id dans la base de données !");
            }
        }
    }
}
