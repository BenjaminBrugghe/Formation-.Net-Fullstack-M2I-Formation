using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_CompteBancaire.Classes
{
    public class CompteEpargne : Compte
    {
        private decimal taux;

        public CompteEpargne(decimal solde, Client clientBanque, decimal taux) : base(solde, clientBanque)
        {
            Taux = taux;
        }

        public CompteEpargne()
        {

        }

        public decimal Taux { get => taux; set => taux = value; }


        public bool CalculInterets()
        {
            return base.Depot(new Operation(Solde * Taux / 100));
        }
    }
}
