using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Classes
{
    internal class Dog
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        public int Age { get; set; }


        // Par ajout d'une propriété virtualisée d'une autre classe de nos modèles de données,
        // nous informons EF Core qu'il va y avoir une jointure au niveau des tables
        public virtual ICollection<Toy> Toys { get; set; }

        // Si l'on veut lier plusieurs données à notre classe, dans le cas d'un One-To-Many ou d'un Many-to-Many,
        // il va nous falloir une propriété de navigation de type IEnumerable, ou ICollection si l'on le préfère
        // public virtual ICollection<Master> Masters { get; set; }
    }
}
