using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Librairie.Classes
{
    internal class MaisonEdition
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public virtual ICollection<Ouvrage> Ouvrages { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Nom} - Nb d'ouvrages : {Ouvrages.Count}";
        }
    }
}
