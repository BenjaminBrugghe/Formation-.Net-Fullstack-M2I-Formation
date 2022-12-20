using EFCORE_Liaisons.Datas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();

        public void Run()
        {
            //AddBrand();
            //AddToy();
            //AddDog();
            GetMyDog();
            GetMyDogWithToy();
        }

        private void AddBrand()
        {
            _context.Brands.Add(new Brand()
            {
                Name = "Pedigree"
            });
        }

        private void GetMyDogWithToy()
        {
            // Pour alimenter nos propriétés de navigation, et ainsi avoir la présence des jointures dans nos objets,
            // il va falloir utiliser la méthode Include() proposée par EF Core
            //
            // Si l'on veut avoir accès aux données liées des données précédemment liées, il va nous falloir
            // utiliser la méthode .ThenInclude() en lui passant une lambda pour la propriété de navigation
            Dog dogFound = _context.Dogs
                .Include(x => x.Toys).ThenInclude(x => x.Brand)
                .FirstOrDefault(x => x.Id == 5);

            // Si l'on veut désormais retrouver les élément joints en Many-to-Many
            // dans le cas où l'on utilise une table de jointure personnalisée
            //
            // Il va nous falloir parcourir cette fois-ci la table de jointure, avec les méthodes LINQ qui nous servent
            // à récupérer les éléments qui nous intéressent. Une fois fait, on peut parcourir l'autre côté de la jointure librement
            Master masterOfDog = _context.Adoptions
                .Include(x => x.Dog) // .ThenInclude(x => x.Toys).ThenInclude(x => x.Brand)
                .Include(x => x.Master)
                .FirstOrDefault(x => x.Dog == dogFound)?.Master;

            Console.WriteLine(dogFound);
        }

        private void GetMyDog()
        {
            // Par défault les propriétés de navigation ne sont pas alimentés par EF Core, dans le but d'alléger au maximum
            // les objets (Il n'y a pas besoin d'avoir accès au jouet du chien si l'on veut éditer son nom,
            // par exemple, ou supprimer le chien)
            Dog dogFound = _context.Dogs.Find(5);

            // La ligne ci-dessous va lever une erreur car il n'y a pas alimentation de nos proprietés de navigations,
            // elles restent à null car on a omit 
            //
            // Console.WriteLine(dogFound.Toy.Brand.Name); 

            Console.WriteLine(dogFound);
        }

        private void AddToy()
        {
            _context.Toys.Add(new Toy()
            {
                Name = "Ball",
                BrandId = 1
            });

            _context.SaveChanges();
        }

        private void AddDog()
        {
            _context.Dogs.Add(new Dog()
            {
                Name = "Bernie",
                Breed = "Labrador",
                Age = 7
                // Via l'utilisation de la proprieté ToyId, il nous est possible
                // d'ajouter la jointure via l'utilisation d'une variable de taille plus petite
                // que l'objet entier (celui de la propriété de navigation)
            });

            _context.SaveChanges();
        }
    }
}
