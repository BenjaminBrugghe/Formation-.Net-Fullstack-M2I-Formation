using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VideoStore.Classes
{
    internal class Emprunt
    {
        public int Id { get; set; }

        public DateTime LoanDate { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<Film> Films = new();
        //public virtual ICollection<Film> Films { get; set; }
    }
}
