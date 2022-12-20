using Cours_EntityFrameworkCore.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_EntityFrameworkCore.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Voir les chiens");
                Console.WriteLine("2. Ajouter un chien");
                Console.WriteLine("3. Modifier un chien");
                Console.WriteLine("4. Supprimer un chien");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        ListDogs();
                        break;

                    case 2:
                        AddDog();
                        break;

                    case 3:
                        EditDog();
                        break;

                    case 4:
                        DeleteDog();
                        break;

                    default:
                        Console.WriteLine("Votre choix est incorrect !");
                        break;
                }
            }
        }

        private void ListDogs()
        {
            Console.WriteLine("\n--- Liste des chiens ---\n");

            // Pour récupérer toutes nos données dans le BDD, il suffit de caster notre DbSet<Dogs> en une liste utilisable au niveau de notre code
            List<Dog> dogList = _context.Dogs.ToList();

            if (dogList.Count > 0)
            {
                foreach (var dog in dogList)
                {
                    Console.WriteLine(dog);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas de chiens dans la base de données !");
            }
        }

        public void AddDog()
        {
            Console.WriteLine("\n--- Ajout d'un chien ---\n");

            Console.Write("Veuillez saisir le nom du chien : ");
            string dogName = Console.ReadLine();

            Console.Write("Veuillez saisir la race du chien : ");
            string dogBreed = Console.ReadLine();

            Console.Write("Veuillez saisir l'age du chien : ");
            int dogAge = int.Parse(Console.ReadLine());

            Dog newDog = new Dog
            {
                Name = dogName,
                Breed = dogBreed,
                Age = dogAge
            };

            // Pour ajouter l'élément à la BDD, il suffit d'utiliser la méthode .Add() de notre DbSet
            _context.Dogs.Add(newDog);

            // Pour faire s'executer les modifs en RAM dans notre BDD, il faut faire appel à la méthode .SaveChanges()
            _context.SaveChanges();
        }

        private void EditDog()
        {
            Console.WriteLine("\n--- Modification d'un chien ---\n");

            Console.Write("Entrez l'Id du chien à modifier : ");
            int idToEdit = int.Parse(Console.ReadLine());

            // Pour récupérer une valeur unique dans la BDD, il existe la méthode .FirstOrDefault()
            Dog dogToEdit = _context.Dogs.FirstOrDefault(x => x.Id == idToEdit);

            // 2ème méthode
            Dog dogToEdit2 = _context.Dogs.LastOrDefault(x => x.Id == idToEdit); // Commence à parcourir la BDD en partant du bas

            // 3ème méthode
            Dog dogToEdit3 = _context.Dogs.SingleOrDefault(x => x.Id == idToEdit); // Pour lever une exception en cas de multiples éléments basés sur le prédicat

            // 4ème méthode
            Dog dogToEdit4 = _context.Dogs.Find(idToEdit); // Si l'on veut trouver simplement avec l'Id

            if (dogToEdit != null)
            {
                Console.Write("Veuillez saisir le nouveau nom du chien : ");
                string dogNewName = Console.ReadLine();

                Console.Write("Veuillez saisir la nouvelle race du chien : ");
                string dogNewBreed = Console.ReadLine();

                Console.Write("Veuillez saisir le nouvel age du chien : ");
                int dogNewAge = int.Parse(Console.ReadLine());


                // Les modifications de notre objet vont lever des événements dans EF Core, qui pourront être traités par la suite
                dogToEdit.Name = dogNewName;
                dogToEdit.Breed = dogNewBreed;
                dogToEdit.Age = dogNewAge;

                // La sauvegarde va automatiquement modifier en dur (SQL) les éléments modifiés en RAM.
                // Chaque modification dans le programme va être suivie par le mécanisme de tracking d'EFCore
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Il n'existe pas de chien avec cet Id dans la base de données !");
            }
        }

        private void DeleteDog()
        {
            Console.WriteLine("\n--- Suppression d'un chien ---\n");

            Console.Write("Entrez l'Id du chien à supprimer : ");
            int idToDelete = int.Parse(Console.ReadLine());

            Dog dogToDelete = _context.Dogs.Find(idToDelete);

            if (dogToDelete != null)
            {
                _context.Dogs.Remove(dogToDelete);

                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Il n'existe pas de chien avec cet Id dans la base de données !");
            }
        }
    }
}
