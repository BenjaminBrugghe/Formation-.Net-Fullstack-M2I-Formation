using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Classes
{
    internal class Master
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        // public virtual ICollection<Dog> Dogs { get; set; }
    }
}
