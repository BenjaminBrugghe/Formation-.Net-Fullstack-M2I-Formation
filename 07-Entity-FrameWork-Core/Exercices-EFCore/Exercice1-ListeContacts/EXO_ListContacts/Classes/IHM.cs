using EXO_ListContacts.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ListContacts.Classes
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
                Console.WriteLine("3. Editer un contact");
                Console.WriteLine("4. Supprimer un contact");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Faites votre choix : ");
                if (int.TryParse(Console.ReadLine(), out int mainChoice))
                {
                    switch (mainChoice)
                    {
                        case 0:
                            Environment.Exit(0);

                            break;

                        case 1:
                            var contactList = _context.Contacts.ToList();
                            if (contactList.Count > 0)
                            {
                                Console.WriteLine("\n--- Liste des contacts ---");
                                foreach (var contact in contactList) Console.WriteLine(contact);
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a actuellement aucun contact dans la liste !");
                            }

                            break;

                        case 2:
                            Console.WriteLine("\n--- Ajouter un contact ---");

                            Console.Write("Nom du contact : ");
                            string lastName = Console.ReadLine();

                            Console.Write("Prénom du contact : ");
                            string firstName = Console.ReadLine();

                            Console.WriteLine($"Genres disponibles : {string.Join(", ", Enum.GetNames(typeof(Gender)))}");
                            Console.Write("Genre du contact : ");
                            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                            Console.Write("Date de naissance du contact (format dd/MM/yyyy) : ");
                            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

                            Console.Write("Numéro de téléphone du contact : ");
                            string phoneNumber = Console.ReadLine();

                            Console.Write("Email du contact : ");
                            string email = Console.ReadLine();

                            Contact newContact = new()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Gender = gender,
                                DateOfBirth = dateOfBirth,
                                PhoneNumber = phoneNumber,
                                Email = email
                            };

                            _context.Contacts.Add(newContact);
                            if (_context.SaveChanges() == 1)
                            {
                                Console.WriteLine($"{newContact.FirstName} {newContact.LastName} ajouté avec succès !");
                            }
                            else
                            {
                                Console.WriteLine("Une erreur s'est produite pendant l'ajout !");
                            }

                            break;

                        case 3:
                            Console.WriteLine("\n--- Editer un contact ---");

                            Console.Write("Id du contact : ");
                            int contactId = Convert.ToInt32(Console.ReadLine());

                            var contactFound = _context.Contacts.FirstOrDefault(x => x.Id == contactId);
                            if (contactFound != null)
                            {
                                Console.Write("Nouveau Nom du contact : ");
                                string newLastName = Console.ReadLine();

                                Console.Write("Nouveau Prénom du contact : ");
                                string newFirstName = Console.ReadLine();

                                Console.WriteLine($"Genres disponibles : {string.Join(", ", Enum.GetNames(typeof(Gender)))}");
                                Console.Write("Nouveau genre du contact : ");
                                Gender newGender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                                Console.Write("Nouvelle Date de naissance du contact (format dd/MM/yyyy) : ");
                                DateTime newDateOfBirth = Convert.ToDateTime(Console.ReadLine());

                                Console.Write("Nouveau Numéro de téléphone du contact : ");
                                string newPhoneNumber = Console.ReadLine();

                                Console.Write("Nouvel Email du contact : ");
                                string newEmail = Console.ReadLine();


                                contactFound.LastName = newLastName;
                                contactFound.FirstName = newFirstName;
                                contactFound.Gender = newGender;
                                contactFound.DateOfBirth = newDateOfBirth;
                                contactFound.PhoneNumber = newPhoneNumber;
                                contactFound.Email = newEmail;

                                if (_context.SaveChanges() > 0)
                                {
                                    Console.WriteLine($"{contactFound.FirstName} {contactFound.LastName} modifié avec succès !");
                                }
                                else
                                {
                                    Console.WriteLine("Une erreur s'est produite pendant l'édition !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aucun contact trouvé avec cet ID ! ");
                            }

                            break;

                        case 4:
                            Console.WriteLine("\n--- Supprimer un contact ---");

                            Console.Write("Id du contact : ");
                            int delContactId = Convert.ToInt32(Console.ReadLine());

                            var contactToDel = _context.Contacts.FirstOrDefault(x => x.Id == delContactId);
                            if (contactToDel != null)
                            {
                                _context.Contacts.Remove(contactToDel);

                                if (_context.SaveChanges() > 0)
                                {
                                    Console.WriteLine("Contact supprimé avec succès !");
                                }
                                else
                                {
                                    Console.WriteLine("Une erreur s'est produite pendant la suppression !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aucun contact trouvé avec cet ID ! ");
                            }

                            break;

                        default:
                            Console.WriteLine("Ce choix n'est pas un choix possible !");

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ce choix n'est pas valide !");
                }
            }

        }
    }
}
