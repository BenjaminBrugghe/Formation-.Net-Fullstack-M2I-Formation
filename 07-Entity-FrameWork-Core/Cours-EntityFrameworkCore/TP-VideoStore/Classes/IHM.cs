using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_VideoStore.Datas;
using Microsoft.EntityFrameworkCore;

namespace TP_VideoStore.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Ajouter un client");
                Console.WriteLine("2. Ajouter un film");
                Console.WriteLine("3. Voir les clients");
                Console.WriteLine("4. Voir les films");
                Console.WriteLine("5. Emprunter un film");
                Console.WriteLine("6. Retourner un film");
                Console.WriteLine("\n0. Quitter le programme\n");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        AddClient();
                        break;

                    case 2:
                        AddFilm();
                        break;

                    case 3:
                        ListClients();
                        break;

                    case 4:
                        ListFilms();
                        break;

                    case 5:
                        EmprunterFilm();
                        break;

                    case 6:
                        RetournerFilm();
                        break;

                    default:
                        Console.WriteLine("Votre choix est incorrect !");
                        break;
                }
            }
        }

        public void AddClient()
        {
            Console.Write("\n--- Ajout d'un Client ---\n");

            Console.Write("Veuillez saisir le nom : ");
            string lastName = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom : ");
            string firstName = Console.ReadLine();

            Console.Write("Veuillez saisir le numéro de téléphone : ");
            string phone = Console.ReadLine();

            Console.Write("Veuillez saisir l'email : ");
            string email = Console.ReadLine();

            Client newClient = new Client
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email
            };

            _context.Clients.Add(newClient);
            _context.SaveChanges();
        }

        public void AddFilm()
        {
            Console.Write("\n--- Ajout d'un Film ---\n");

            Console.Write("Veuillez saisir le titre : ");
            string title = Console.ReadLine();

            Console.Write("Veuillez saisir le réalisateur : ");
            string director = Console.ReadLine();

            Console.Write("Veuillez saisir la description : ");
            string description = Console.ReadLine();

            Console.Write("Veuillez saisir le score : ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir le prix : ");
            int price = Convert.ToInt32(Console.ReadLine());

            Film newFilm = new Film
            {
                Title = title,
                Director = director,
                Description = description,
                Score = score,
                Price = price
            };

            _context.Films.Add(newFilm);
            _context.SaveChanges();
        }

        public void ListClients()
        {
            Console.WriteLine("\n--- Liste des clients ---\n");

            List<Client> clientList = _context.Clients.ToList();

            if (clientList != null)
            {
                foreach (var c in clientList)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a aucun client dans la base de données !");
            }
        }

        public void ListFilms()
        {
            Console.WriteLine("\n--- Liste des films ---\n");

            List<Film> filmList = _context.Films.ToList();

            if (filmList != null)
            {
                foreach (var c in filmList)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a aucun film dans la base de données !");
            }
        }

        public void EmprunterFilm()
        {
            Console.WriteLine("\n--- Emprunter un film ---\n");

            Console.Write("Veuillez saisir l'Id du client : ");
            int clientID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir l'Id du film à réserver : ");
            int filmID = Convert.ToInt32(Console.ReadLine());

            Emprunt newEmprunt = new Emprunt
            {
                LoanDate = DateTime.Now,
                ClientId = clientID,
                FilmId = filmID
            };

            _context.Emprunts.Add(newEmprunt);
            _context.SaveChanges();
        }

        public void EmprunterPlusieursFilms()
        {
            Console.WriteLine("\n--- Emprunter des films ---\n");

            Console.Write("Veuillez saisir l'Id du client : ");
            int clientID = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Veuillez saisir l'Id du film à réserver (Taper 0 pour terminer) : ");
            //int filmID = Convert.ToInt32(Console.ReadLine());

            int filmID = 1;

            while (filmID != 0)
            {
                Console.Write("Veuillez saisir l'Id du film à réserver (Taper 0 pour terminer) : ");
                filmID = Convert.ToInt32(Console.ReadLine());

                Emprunt filmsAEmprunter = _context.Emprunts.Include(x => x.Films).FirstOrDefault(x => x.Film.Id == filmID);

                _context.Emprunts.Add(filmsAEmprunter);
                _context.SaveChanges();
            }

            Emprunt newEmprunt = new Emprunt
            {
                LoanDate = DateTime.Now,
                ClientId = clientID,
                FilmId = filmID
            };

            _context.Emprunts.Add(newEmprunt);
            _context.SaveChanges();
        }

        public void RetournerFilm()
        {
            Console.WriteLine("\n--- Retourner un film ---\n");

            Console.Write("Veuillez saisir l'Id du client : ");
            int clientID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir l'Id du film à retourner : ");
            int filmID = Convert.ToInt32(Console.ReadLine());

            Emprunt filmToReturn = _context.Emprunts.Include(x => x.Film).FirstOrDefault(x => x.Film.Id == filmID);

            _context.Emprunts.Remove(filmToReturn);
            _context.SaveChanges();
        }
    }
}
