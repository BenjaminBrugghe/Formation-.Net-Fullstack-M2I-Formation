using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Classes
{
    internal enum BookCategory
    {
        None,
        Biographie,
        Fantastique,
        Poesie,
        Educatif,
        Polar,
        Classiques
    }
    internal class Book
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Title { get; set; }

        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [StringLength(50)]
        [Required]
        public string ISBN { get; set; }

        [Required]
        public int NbPages { get; set; }

        public BookCategory Category { get; set; }
        
        public virtual Author Author { get; set; }
        public virtual Editor Editor { get; set; }

        public int AuthorId { get; set; }
        public int EditorId { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} ({NbPages} pages) - {ISBN} | {Category}"
                + $"\n\tAuteur : {Author}"
                + $"\n\tEditeur : {Editor}";
        }
    }
}
