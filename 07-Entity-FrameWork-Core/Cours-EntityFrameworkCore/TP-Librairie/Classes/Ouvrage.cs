using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Librairie.Classes
{
    internal class Ouvrage
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        public int ISBN { get; set; }

        public int NbPages { get; set; }

        public string Categorie { get; set; }

        public Auteur Auteur { get; set; }

        public MaisonEdition MaisonEdition { get; set; }

        public int AuteurId { get; set; }

        public int MaisonEditionId { get; set; }

    }
}
