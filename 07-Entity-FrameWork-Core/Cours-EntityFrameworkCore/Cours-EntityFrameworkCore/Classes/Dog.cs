using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // pour [Key]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_EntityFrameworkCore.Classes
{
    internal class Dog
    {
        // Sert à définir quelle est la clé primaire de notre modèle
        [Key] // Facultatif, car nous respectons le nom conventionné de notre prop (Id, classId)

        public int Id { get; set; }
        //public int DogId { get; set; }

        // Sert à définir la taille maximale de notre texte une fois en SQL
        [StringLength(80)] // Doit se placer juste avant la propriété concernée

        [Required] // Permet de s'assurer que la propriété est alimentée en cas d'ajout d'un chien

        public string Name { get; set; }

        [StringLength(80)]
        [Required]
        public string Breed { get; set; }

        [Required]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Breed} - {Age} ans.";
        }
    }
}
