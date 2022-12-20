using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Classes
{
    internal class Toy
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [ForeignKey("Brand")] 
        // Si l'on choisi de ne pas respecter les conventions de nommage
        // d'EF Core au niveau des clés étrangères, il va falloir passer par l'annotation ci-dessus
        public int? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }

        public int? DogId { get; set; }

        public virtual Dog? Dog { get; set; }


    }
}
