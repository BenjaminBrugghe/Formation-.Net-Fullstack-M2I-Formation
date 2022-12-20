using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Classes
{
    internal class Author
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public int NbBooks
        {
            get
            {
                return Books.Count;
            }
        }

        public override string ToString()
        {
            return $"{Id}. {FirstName} {LastName} né le {DateOfBirth.ToShortDateString()} | {NbBooks} ouvrages écrits";
        }
    }
}
