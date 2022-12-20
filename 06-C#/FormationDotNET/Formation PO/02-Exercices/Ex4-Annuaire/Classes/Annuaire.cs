using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Annuaire.Classes
{
    internal class Annuaire
    {
        private List<Contact> listeAnnuaire;

        public Annuaire()
        {
            ListeAnnuaire = new List<Contact>();
        }

        public List<Contact> ListeAnnuaire { get => listeAnnuaire; set => listeAnnuaire = value; }
    }
}
