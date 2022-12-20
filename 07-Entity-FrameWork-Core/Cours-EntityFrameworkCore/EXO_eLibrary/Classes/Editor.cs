using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Classes
{
    internal class Editor
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

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
            return $"{Id}. {Name} | {NbBooks} ouvrages édités";
        }
    }
}
