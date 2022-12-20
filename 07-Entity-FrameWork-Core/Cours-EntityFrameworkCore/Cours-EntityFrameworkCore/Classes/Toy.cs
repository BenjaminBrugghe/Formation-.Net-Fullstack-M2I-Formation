using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_EntityFrameworkCore.Classes
{
    internal class Toy
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; } // Ici, la description devient optionelle car nullable
    }
}
