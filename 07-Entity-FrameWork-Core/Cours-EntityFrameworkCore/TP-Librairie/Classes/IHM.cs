using Exercice1_ListeContacts.Datas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Librairie.Datas;

namespace TP_Librairie.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();


        private IRepository<Auteur> _auteursRepo;
        private IRepository<Ouvrage> _ouvragesRepo;
        private IRepository<MaisonEdition> _maisonEditionRepo;

        public IHM()
        {
            _auteursRepo = new AuteursReposiroty();
            _ouvragesRepo = new OuvragesRepository();
            _maisonEditionRepo = new MaisonEditionsRepository();
        }


        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Consulter les Auteurs");
                Console.WriteLine("2. Consulter les Ouvrages");
                Console.WriteLine("3. Consulter les Maisons d'éditions");
                Console.WriteLine("\n0. Quitter le programme\n");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        MenuAuteurs();
                        break;

                    case 2:
                        MenuOuvrages();
                        break;

                    case 3:
                        MenuMaisonsEdition();
                        break;

                    default:
                        Console.WriteLine("Votre choix est incorrect !");
                        break;
                }
            }
        }

        public void MenuAuteurs()
        {
            Console.WriteLine("\n=== GESTION DES AUTEURS ===\n");

            Console.WriteLine("1. Afficher les auteurs");
            Console.WriteLine("2. Ajouter un auteur");
            Console.WriteLine("3. Modifier un auteur");
            Console.WriteLine("4. Supprimer un auteur");
            Console.WriteLine("\n0. Retour au menu principal\n");

            Console.Write("Faites votre choix : ");
            int mainChoice = int.Parse(Console.ReadLine());

            switch (mainChoice)
            {
                case 0:
                    break;

                case 1:
                    AfficherAuteurs();
                    break;

                case 2:
                    AjouterAuteur();
                    break;

                case 3:
                    ModifierAuteur();
                    break;

                case 4:
                    SupprimerAuteur();
                    break;

                default:
                    Console.WriteLine("Votre choix est incorrect !");
                    break;
            }
        }

        public void AfficherAuteurs()
        {
            Console.Clear();
            Console.WriteLine("\n=== AFFICHAGE DES AUTEURS ===\n");

            var auteursList = _context.Auteurs.Include(x=> x.Ouvrages).ToList();

            if (auteursList.Count > 0)
            {
                foreach (var a in auteursList)
                {
                    Console.WriteLine($"{a.Id}. {a.Nom} {a.Prenom}\n\tNb d'ouvrages : {a.Ouvrages.Count}");
                }
            }
            else
            {
                Console.WriteLine("Il n'y a actuellement aucun auteur dans la liste !");
            }
        }

        public void AjouterAuteur()
        {
            Console.Clear();
            Console.WriteLine("\n=== AJOUTER UN AUTEUR ===\n");

            Console.Write("Veuillez saisir le nom : ");
            string nom = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom : ");
            string prenom = Console.ReadLine();

            Console.Write("Veuillez saisir la date de naissance : ");
            DateTime naissance = Convert.ToDateTime(Console.ReadLine());

            Auteur newAuteur = new()
            {
                Nom = nom,
                Prenom = prenom,
                Naissance = naissance
            };

            //_context.Auteurs.Add(newAuteur);
            _auteursRepo.Add(newAuteur);

            //_context.SaveChanges();

            if (_context.SaveChanges() == 1)
            {
                Console.WriteLine($"{newAuteur.Nom} {newAuteur.Prenom} a bien été ajouté !");
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite pendant l'ajout !");
            }
        }

        public void ModifierAuteur()
        {
            Console.Clear();
            Console.WriteLine("\n=== MODIFIER UN AUTEUR ===\n");

            Console.Write("Veuillez saisir l'Id de l'auteur à modifier : ");
            int auteurId = Convert.ToInt32(Console.ReadLine());

            var auteurFound = _context.Auteurs.FirstOrDefault(x => x.Id == auteurId);
            //var auteurFound = _auteursRepo.GetById(auteurId);

            if (auteurFound != null)
            {
                Console.Write("Veuillez saisir le nouveau nom : ");
                string newNom = Console.ReadLine();

                Console.Write("Veuillez saisir le nouveau prénom : ");
                string newPrenom = Console.ReadLine();

                Console.Write("Veuillez saisir la nouvelle date de naissance : ");
                DateTime newNaissance = Convert.ToDateTime(Console.ReadLine());

                auteurFound.Nom = newNom;
                auteurFound.Prenom = newPrenom;
                auteurFound.Naissance = newNaissance;

                if (_context.SaveChanges() == 1)
                {
                    Console.WriteLine($"{auteurFound.Nom} {auteurFound.Prenom} a bien été modifié !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la modification !");
                }
            }
            else
            {
                Console.WriteLine("Aucun auteur n'a été trouvé !");
            }
        }

        public void SupprimerAuteur()
        {
            Console.Clear();
            Console.WriteLine("\n=== SUPPRIMER UN AUTEUR ===\n");

            Console.Write("Veuillez saisir l'Id de l'auteur à supprimer : ");
            int auteurId = Convert.ToInt32(Console.ReadLine());

            var auteurFound = _context.Auteurs.FirstOrDefault(x => x.Id == auteurId);

            if (auteurFound != null)
            {
                _context.Auteurs.Remove(auteurFound);

                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Auteur supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la suppression !");
                }
            }
            else
            {
                Console.WriteLine("Aucun auteur n'a été trouvé !");
            }
        }

        public void MenuOuvrages()
        {
            Console.WriteLine("\n=== GESTION DES OUVRAGES ===\n");

            Console.WriteLine("1. Afficher les ouvrages");
            Console.WriteLine("2. Ajouter un ouvrage");
            Console.WriteLine("3. Modifier un ouvrage");
            Console.WriteLine("4. Supprimer un ouvrage");
            Console.WriteLine("\n0. Retour au menu principal\n");

            Console.Write("Faites votre choix : ");
            int mainChoice = int.Parse(Console.ReadLine());

            switch (mainChoice)
            {
                case 0:
                    break;

                case 1:
                    AfficherOuvrage();
                    break;

                case 2:
                    AjouterOuvrage();
                    break;

                case 3:
                    ModifierOuvrage();
                    break;

                case 4:
                    SupprimerOuvrage();
                    break;

                default:
                    Console.WriteLine("Votre choix est incorrect !");
                    break;
            }
        }

        public void AfficherOuvrage()
        {
            Console.Clear();
            Console.WriteLine("\n=== AFFICHAGE DES OUVRAGES ===\n");

            var ouvragesList = _context.Ouvrages.ToList();

            if (ouvragesList.Count > 0)
            {
                foreach (var a in ouvragesList)
                {
                    Console.WriteLine($"{a.Id}. {a.Titre} - {a.Description}");
                }
            }
            else
            {
                Console.WriteLine("Il n'y a actuellement aucun ouvrage dans la liste !");
            }
        }

        public void AjouterOuvrage()
        {
            Console.Clear();
            Console.WriteLine("\n=== AJOUTER UN OUVRAGE ===\n");

            Console.Write("Veuillez saisir le titre : ");
            string titre = Console.ReadLine();

            Console.Write("Veuillez saisir la description : ");
            string description = Console.ReadLine();

            Console.Write("Veuillez saisir le numéro ISBN : ");
            int ISBN = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir le nombre de pages : ");
            int nbPages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir la catégorie : ");
            string categorie = Console.ReadLine();

            Console.Write("Veuillez saisir l'ID de l'auteur : ");
            int auteurId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veuillez saisir l'ID de la maison d'edition : ");
            int maisonEditionId = Convert.ToInt32(Console.ReadLine());

            Ouvrage newOuvrage = new()
            {
                Titre = titre,
                Description = description,
                ISBN = ISBN,
                NbPages = nbPages,
                Categorie = categorie,
                AuteurId = auteurId,
                MaisonEditionId = maisonEditionId
            };

            _context.Ouvrages.Add(newOuvrage);
            //_context.SaveChanges();

            if (_context.SaveChanges() == 1)
            {
                Console.WriteLine($"L'ouvrage {newOuvrage.Titre} a bien été ajouté !");
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite pendant l'ajout !");
            }
        }

        public void ModifierOuvrage()
        {
            Console.Clear();
            Console.WriteLine("\n=== MODIFIER UN OUVRAGE ===\n");

            Console.Write("Veuillez saisir l'Id de l'ouvrage à modifier : ");
            int ouvrageId = Convert.ToInt32(Console.ReadLine());

            var ouvrageFound = _context.Ouvrages.FirstOrDefault(x => x.Id == ouvrageId);

            if (ouvrageFound != null)
            {
                Console.Write("Veuillez saisir le nouveau titre : ");
                string titre = Console.ReadLine();

                Console.Write("Veuillez saisir la nouvelle description : ");
                string description = Console.ReadLine();

                Console.Write("Veuillez saisir le nouveau numéro ISBN : ");
                int ISBN = Convert.ToInt32(Console.ReadLine());

                Console.Write("Veuillez saisir le nouveau nombre de pages : ");
                int nbPages = Convert.ToInt32(Console.ReadLine());

                Console.Write("Veuillez saisir la nouvelle catégorie : ");
                string categorie = Console.ReadLine();

                Console.Write("Veuillez saisir le nouvel ID de l'auteur : ");
                int auteurId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Veuillez saisir le nouvel ID de la maison d'edition : ");
                int maisonEditionId = Convert.ToInt32(Console.ReadLine());

                ouvrageFound.Titre = titre;
                ouvrageFound.Description = description;
                ouvrageFound.ISBN = ISBN;
                ouvrageFound.NbPages = nbPages;
                ouvrageFound.Categorie = categorie;
                ouvrageFound.AuteurId = auteurId;
                ouvrageFound.MaisonEditionId = maisonEditionId;

                if (_context.SaveChanges() == 1)
                {
                    Console.WriteLine($"{ouvrageFound.Titre} a bien été modifié !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la modification !");
                }
            }
            else
            {
                Console.WriteLine("Aucun ouvrage n'a été trouvé !");
            }
        }

        public void SupprimerOuvrage()
        {
            Console.Clear();
            Console.WriteLine("\n=== SUPPRIMER UN OUVRAGE ===\n");

            Console.Write("Veuillez saisir l'Id de l'ouvrage à supprimer : ");
            int ouvrageId = Convert.ToInt32(Console.ReadLine());

            var ouvrageFound = _context.Auteurs.FirstOrDefault(x => x.Id == ouvrageId);

            if (ouvrageFound != null)
            {
                _context.Auteurs.Remove(ouvrageFound);

                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Ouvrage supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la suppression !");
                }
            }
            else
            {
                Console.WriteLine("Aucun ouvrage n'a été trouvé !");
            }
        }

        public void MenuMaisonsEdition()
        {
            Console.WriteLine("\n=== GESTION DES MAISONS D'EDITION ===\n");

            Console.WriteLine("1. Afficher les maisons d'édition");
            Console.WriteLine("2. Ajouter une maison d'édition");
            Console.WriteLine("3. Modifier une maison d'édition");
            Console.WriteLine("4. Supprimer une maison d'édition");
            Console.WriteLine("\n0. Retour au menu principal\n");

            Console.Write("Faites votre choix : ");
            int mainChoice = int.Parse(Console.ReadLine());

            switch (mainChoice)
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    AfficherMaisonEdition();
                    break;

                case 2:
                    AjouterMaisonEdition();
                    break;

                case 3:
                    ModifierMaisonEdition();
                    break;

                case 4:
                    SupprimerMaisonEdition();
                    break;

                default:
                    Console.WriteLine("Votre choix est incorrect !");
                    break;
            }
        }

        public void AfficherMaisonEdition()
        {
            Console.Clear();
            Console.WriteLine("\n=== AFFICHAGE DES MAISONS D'EDITION ===\n");

            var maisonEditionList = _context.MaisonEditions.Include(x=>x.Ouvrages).ToList();

            if (maisonEditionList.Count > 0)
            {
                foreach (var a in maisonEditionList)
                {
                    //Console.WriteLine($"{a.Id}. {a.Nom} - Nb d'ouvrages : {a.Ouvrages.Count}");
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a actuellement aucune maison d'edition dans la liste !");
            }
        }

        public void AjouterMaisonEdition()
        {
            Console.Clear();
            Console.WriteLine("\n=== AJOUTER UNE MAISON D'EDITION ===\n");

            Console.Write("Veuillez saisir le nom : ");
            string nom = Console.ReadLine();

            MaisonEdition newMaisonEdition = new()
            {
                Nom = nom
            };

            _context.MaisonEditions.Add(newMaisonEdition);
            //_context.SaveChanges();

            if (_context.SaveChanges() == 1)
            {
                Console.WriteLine($"La maison d'édition {newMaisonEdition.Nom} a bien été ajoutée !");
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite pendant l'ajout !");
            }
        }

        public void ModifierMaisonEdition()
        {
            Console.Clear();
            Console.WriteLine("\n=== MODIFIER UNE MAISON D'EDITION ===\n");

            Console.Write("Veuillez saisir l'Id de la maison d'édition à modifier : ");
            int maisonEditionId = Convert.ToInt32(Console.ReadLine());

            var maisonEditionFound = _context.MaisonEditions.FirstOrDefault(x => x.Id == maisonEditionId);

            if (maisonEditionFound != null)
            {
                Console.Write("Veuillez saisir le nouveau nom : ");
                string nom = Console.ReadLine();

                maisonEditionFound.Nom = nom;

                if (_context.SaveChanges() == 1)
                {
                    Console.WriteLine($"{maisonEditionFound.Nom} a bien été modifiée !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la modification !");
                }
            }
            else
            {
                Console.WriteLine("Aucune maison d'édition n'a été trouvée !");
            }
        }

        public void SupprimerMaisonEdition()
        {
            Console.Clear();
            Console.WriteLine("\n=== SUPPRIMER UNE MAISON D'EDITION ===\n");

            Console.Write("Veuillez saisir l'Id de la maison d'édition à supprimer : ");
            int maisonEditionId = Convert.ToInt32(Console.ReadLine());

            var maisonEditionFound = _context.MaisonEditions.FirstOrDefault(x => x.Id == maisonEditionId);

            if (maisonEditionFound != null)
            {
                _context.MaisonEditions.Remove(maisonEditionFound);

                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Maison d'édition supprimée avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur s'est produite pendant la suppression !");
                }
            }
            else
            {
                Console.WriteLine("Aucune maison d'édition n'a été trouvée !");
            }
        }
    }
}
