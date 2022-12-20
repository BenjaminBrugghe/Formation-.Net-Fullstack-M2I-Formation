using EXO_eLibrary.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Classes
{
    internal class IHM
    {
        private IRepository<Book> _booksRepo = new BooksRepository();
        private IRepository<Author> _authorsRepo = new AuthorsRepository();
        private IRepository<Editor> _editorsRepo = new EditorsRepository();
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Gérer les ouvrages");
                Console.WriteLine("2. Gérer les auteurs");
                Console.WriteLine("3. Gérer les éditeurs");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        BooksMenu();
                        break;

                    case 2:
                        AuthorsMenu();
                        break;

                    case 3:
                        EditorsMenu();
                        break;

                    default:
                        Console.WriteLine("Votre choix n'est pas parmi les choix disponibles !");
                        break;
                }
            }
        }

        private void EditorsMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== GESTION DES EDITEURS ===\n");

                Console.WriteLine("1. Voir les éditeurs");
                Console.WriteLine("2. Ajouter un éditeur");
                Console.WriteLine("3. Modifier un éditeur");
                Console.WriteLine("4. Supprimer un éditeur");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Faites votre choix : ");
                int bookMenuChoice = int.Parse(Console.ReadLine());

                switch (bookMenuChoice)
                {
                    case 0:
                        return;

                    case 1:
                        ListEditors();
                        break;

                    case 2:
                        AddEditor();
                        break;

                    case 3:
                        EditEditor();
                        break;

                    case 4:
                        DeleteEditor();
                        break;

                    default:
                        Console.WriteLine("Votre choix n'est pas parmi les choix disponibles !");
                        break;
                }
            }
        }

        private void DeleteEditor()
        {
            Console.WriteLine("\n--- Supprimer un éditeur ---");

            Console.Write("Quel est l'Id de l'éditeur à supprimer ? ");
            int idEditorToDel = int.Parse(Console.ReadLine());

            var editorToDel = _editorsRepo.GetById(idEditorToDel);

            if (editorToDel is null)
            {
                Console.WriteLine("Il n'y a aucun éditeur avec cet Id !");
            } else
            {
                if (_editorsRepo.Delete(editorToDel))
                {
                    Console.WriteLine("L'éditeur a été supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la suppression de l'éditeur.");
                }

            }
            
        }

        private void EditEditor()
        {
            Console.WriteLine("\n--- Editer un éditeur ---");

            Console.Write("Quel est l'Id de l'éditeur à éditer ? ");
            int idEditorToEd = int.Parse(Console.ReadLine());

            var editorToEd = _editorsRepo.GetById(idEditorToEd);

            if (editorToEd is null)
            {
                Console.WriteLine("Il n'y a aucun éditeur avec cet Id !");
            }
            else
            {
                Console.Write("Nouveau nom de l'éditeur : ");
                string editorNewName = Console.ReadLine();

                editorToEd.Name = editorNewName;

                if (_editorsRepo.Update(editorToEd))
                {
                    Console.WriteLine("L'éditeur a été édité avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la modification de l'éditeur.");
                }

            }
        }

        private void AddEditor()
        {
            Console.WriteLine("\n--- Ajouter un éditeur ---");

            Console.Write("Nom de l'éditeur : ");
            string newEditorName = Console.ReadLine();

            var newEditor = new Editor()
            {
                Name = newEditorName
            };

            if (_editorsRepo.Add(newEditor))
            {
                Console.WriteLine($"{newEditorName} ajouté avec succès !");
            } else
            {
                Console.WriteLine("Un problème est survenu durant l'ajout de l'éditeur.");
            }
        }

        private void ListEditors()
        {
            Console.WriteLine("\n--- Liste des éditeurs ---");

            var editorsList = _editorsRepo.GetAll();

            if (editorsList.Count > 0)
            {
                foreach(var editor in editorsList) Console.WriteLine(editor);
            } else
            {
                Console.WriteLine("Il n'y a pas d'éditeur en base de données !");
            }
        }

        private void AuthorsMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== GESTION DES AUTEURS ===\n");

                Console.WriteLine("1. Voir les auteurs");
                Console.WriteLine("2. Ajouter un auteur");
                Console.WriteLine("3. Modifier un auteur");
                Console.WriteLine("4. Supprimer un auteur");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Faites votre choix : ");
                int bookMenuChoice = int.Parse(Console.ReadLine());

                switch (bookMenuChoice)
                {
                    case 0:
                        return;

                    case 1:
                        ListAuthors();
                        break;

                    case 2:
                        AddAuthor();
                        break;

                    case 3:
                        EditAuthor();
                        break;

                    case 4:
                        DeleteAuthor();
                        break;

                    default:
                        Console.WriteLine("Votre choix n'est pas parmi les choix disponibles !");
                        break;
                }
            }
        }

        private void DeleteAuthor()
        {
            Console.WriteLine("\n--- Supprimer un auteur ---");

            Console.Write("Quel est l'Id de l'auteur à supprimer ? ");
            int idAuthorToDel = int.Parse(Console.ReadLine());

            var authorToDel = _authorsRepo.GetById(idAuthorToDel);

            if (authorToDel is null)
            {
                Console.WriteLine("Il n'y a aucun auteur avec cet Id !");
            }
            else
            {
                if (_authorsRepo.Delete(authorToDel))
                {
                    Console.WriteLine("L'auteur a été supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la suppression de l'auteur.");
                }
            }
        }

        private void EditAuthor()
        {
            Console.WriteLine("\n--- Editer un auteur ---");

            Console.Write("Quel est l'Id de l'auteur à éditer ? ");
            int idAuthorToEdit = int.Parse(Console.ReadLine());

            var authorToEdit = _authorsRepo.GetById(idAuthorToEdit);

            if (authorToEdit is null)
            {
                Console.WriteLine("Il n'y a aucun auteur avec cet Id !");
            }
            else
            {
                Console.Write("Nouveau nom de l'auteur : ");
                string authorNewLastName = Console.ReadLine();

                Console.Write("Nouveau prénom de l'auteur : ");
                string authorNewFirstName = Console.ReadLine();

                Console.Write("Nouvelle date de naissance de l'auteur (dd/MM/yyyy) : ");
                DateTime authorNewDOB = DateTime.Parse(Console.ReadLine());

                authorToEdit.FirstName = authorNewFirstName;
                authorToEdit.LastName = authorNewLastName;
                authorToEdit.DateOfBirth = authorNewDOB;

                if (_authorsRepo.Update(authorToEdit))
                {
                    Console.WriteLine("L'auteur a été édité avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la modification de l'auteur.");
                }
            }
        }

        private void AddAuthor()
        {
            Console.WriteLine("\n--- Ajouter un auteur ---");

            Console.Write("Nom de l'auteur : ");
            string newAuthorLastName = Console.ReadLine();

            Console.Write("Prénom de l'auteur : ");
            string newAuthorFirstName = Console.ReadLine();

            Console.Write("Date de naissance de l'auteur (dd/MM/yyyy) : ");
            DateTime newAuthorDOB = DateTime.Parse(Console.ReadLine());

            var newAuthor = new Author()
            {
                LastName = newAuthorLastName,
                FirstName = newAuthorFirstName,
                DateOfBirth = newAuthorDOB
            };

            if (_authorsRepo.Add(newAuthor))
            {
                Console.WriteLine($"{newAuthorFirstName} {newAuthorLastName} ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Un problème est survenu durant l'ajout de l'auteur.");
            }
        }

        private void ListAuthors()
        {
            Console.WriteLine("\n--- Liste des auteurs ---");

            var authorsList = _authorsRepo.GetAll();

            if (authorsList.Count > 0)
            {
                foreach (var author in authorsList) Console.WriteLine(author);
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'auteur en base de données !");
            }
        }

        private void BooksMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== GESTION DES LIVRES ===\n");

                Console.WriteLine("1. Voir les ouvrages");
                Console.WriteLine("2. Ajouter un ouvrage");
                Console.WriteLine("3. Modifier un ouvrage");
                Console.WriteLine("4. Supprimer un ouvrage");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Faites votre choix : ");
                int bookMenuChoice = int.Parse(Console.ReadLine());

                switch (bookMenuChoice)
                {
                    case 0:
                        return;

                    case 1:
                        ListBooks();
                        break;

                    case 2:
                        AddBook();
                        break;

                    case 3:
                        EditBook();
                        break;

                    case 4:
                        DeleteBook();
                        break;

                    default:
                        Console.WriteLine("Votre choix n'est pas parmi les choix disponibles !");
                        break;
                }
            }
        }

        private void DeleteBook()
        {
            Console.WriteLine("\n--- Supprimer un ouvrage ---");

            Console.Write("Quel est l'Id du livre à supprimer ? ");
            int idBookToDel = int.Parse(Console.ReadLine());

            var bookToDel = _booksRepo.GetById(idBookToDel);

            if (bookToDel is null)
            {
                Console.WriteLine("Il n'y a aucun ouvrage avec cet Id !");
            }
            else
            {
                if (_booksRepo.Delete(bookToDel))
                {
                    Console.WriteLine("Le livre a été supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la suppression du livre.");
                }
            }
        }

        private void EditBook()
        {
            Console.WriteLine("\n--- Editer un ouvrage ---");

            Console.Write("Quel est l'Id du livre à modifier ? ");
            int idBookToEdit= int.Parse(Console.ReadLine());

            var bookToEdit = _booksRepo.GetById(idBookToEdit);

            if (bookToEdit is null)
            {
                Console.WriteLine("Il n'y a aucun ouvrage avec cet Id !");
            }
            else
            {
                Console.Write("Nouveau titre de l'ouvrage : ");
                string bookNewTitle = Console.ReadLine();

                Console.Write("Nouvelle description de l'ouvrage : ");
                string bookNewDesc = Console.ReadLine();

                Console.Write("Nouvel ISBN de l'ouvrage : ");
                string bookNewISBN = Console.ReadLine();

                Console.Write("Nouveau nombre de pages de l'ouvrage : ");
                int bookNewNbPages = int.Parse(Console.ReadLine());

                Console.WriteLine($"Catégories disponibles : {string.Join(", ", Enum.GetNames(typeof(BookCategory)))}");
                Console.Write("Nouvelle catégorie de l'ouvrage : ");
                BookCategory bookNewCategory = (BookCategory)Enum.Parse(typeof(BookCategory), Console.ReadLine(), true);

                Console.Write("Nouvel ID de l'auteur de l'ouvrage : ");
                int bookNewAuthorId = int.Parse(Console.ReadLine());

                Console.Write("Nouvel ID de l'éditeur de l'ouvrage : ");
                int bookNewEditorId = int.Parse(Console.ReadLine());

                bookToEdit.Title = bookNewTitle;
                bookToEdit.Description = bookNewDesc;
                bookToEdit.ISBN = bookNewISBN;
                bookToEdit.NbPages = bookNewNbPages;
                bookToEdit.Category = bookNewCategory;
                bookToEdit.AuthorId = bookNewAuthorId;
                bookToEdit.EditorId = bookNewEditorId;

                if (_booksRepo.Update(bookToEdit))
                {
                    Console.WriteLine("Le livre a été édité avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue durant la modification du livre.");
                }
            }
        }

        private void AddBook()
        {
            Console.WriteLine("\n--- Ajouter un ouvrage ---");

            Console.Write("Titre de l'ouvrage : ");
            string newBookTitle = Console.ReadLine();

            Console.Write("Description de l'ouvrage : ");
            string newBookDesc= Console.ReadLine();

            Console.Write("ISBN de l'ouvrage : ");
            string newBookISBN = Console.ReadLine();

            Console.Write("Nombre de pages de l'ouvrage : ");
            int newBookNbPages = int.Parse(Console.ReadLine());

            Console.WriteLine($"Catégories disponibles : {string.Join(", ", Enum.GetNames(typeof(BookCategory)))}");
            Console.Write("Catégorie de l'ouvrage : ");
            BookCategory newBookCategory = (BookCategory) Enum.Parse(typeof(BookCategory), Console.ReadLine(), true);

            Console.Write("ID de l'auteur de l'ouvrage : ");
            int newBookAuthorId = int.Parse(Console.ReadLine());

            Console.Write("ID de l'éditeur de l'ouvrage : ");
            int newBookEditorId = int.Parse(Console.ReadLine());

            var newBook = new Book()
            {
                Title = newBookTitle,
                Description = newBookDesc,
                ISBN = newBookISBN,
                NbPages = newBookNbPages,
                Category = newBookCategory,
                AuthorId = newBookAuthorId,
                EditorId = newBookEditorId
            };

            if (_booksRepo.Add(newBook))
            {
                Console.WriteLine($"{newBookTitle} ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Un problème est survenu durant l'ajout de l'ouvrage.");
            }
        }

        private void ListBooks()
        {
            Console.WriteLine("\n--- Liste des ouvrages ---");

            var booksList = _booksRepo.GetAll();

            if (booksList.Count > 0)
            {
                foreach (var book in booksList) Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Il n'y a pas de livre en base de données !");
            }
        }
    }
}
