using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Librairie.Classes
{
    internal class Auteur
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime Naissance { get; set; }

        public virtual ICollection<Ouvrage> Ouvrages { get; set; }

        
    }
}
