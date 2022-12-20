using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VideoStore.Classes
{
    internal class Film
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Director { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(10)]
        public int Score { get; set; }

        [StringLength(50)]
        public int Price { get; set; }

        public int? ClientId { get; set; }

        public virtual Client? Client { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} - '{Description}'\n\tDirector : {Director}\n\tPrix : {Price}";
        }
    }
}
