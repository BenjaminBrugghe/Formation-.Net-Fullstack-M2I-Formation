using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_CompteBancaire.Classes
{
    public class ComptePayant : Compte
    {
        private decimal coutOperation;

        public ComptePayant(decimal solde, Client clientBanque,decimal coutOperation) :base( solde,  clientBanque)
        {
            CoutOperation = coutOperation;
        }

        public ComptePayant()
        {

        }

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }

        public override bool Depot(Operation operation)
        {
            if (operation.Montant > CoutOperation)
            {
                if (base.Depot(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
            }
            return false;
        }

        public override bool Retrait(Operation operation)
        {
            if (Solde >= Math.Abs(operation.Montant) + CoutOperation)
            {
                if (base.Retrait(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
            }
            return false;
        }
    }
}
