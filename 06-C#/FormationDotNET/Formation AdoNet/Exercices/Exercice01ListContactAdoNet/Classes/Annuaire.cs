using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01ListContactAdoNet.Classes
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
