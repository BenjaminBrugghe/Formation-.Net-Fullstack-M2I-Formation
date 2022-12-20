using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Banque.Classes
{
    public class Compte
    {
        private static int instanceCounter = 0;
        private int id;
        private decimal solde;
        private Client clientBanque;
        private List<Operation> operations;

        public Compte()
        {
            Id = ++instanceCounter;
            Operations = new();
        }

        public Compte(decimal solde, Client clientBanque) : this()
        {
            Solde = solde;
            ClientBanque = clientBanque;
        }


        public int Id { get => id; init => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public Client ClientBanque { get => clientBanque; set => clientBanque = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }

        public event Action<decimal, int> ADecouvert;

        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0 && Math.Abs(operation.Montant) <= Solde)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                // Declencher l'ent ADecouvert
                return true;
            }
            else
                return false;

        }

        public virtual bool Depot(Operation operation)
        {
            if (operation.Montant > 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                // Declencher l'ent ADecouvert
                return true;
            }
            else
                return false;
        }

        public virtual bool AjouterCompte() // Dans la liste de compte de la class banque
        {
            return AjouterCompte();
        }

        public virtual Compte RechercherCompte(int id) // Dans la liste de compte de la class banque
        {
            return RechercherCompte(id);
        }

        public override string ToString()
        {
            string result = $"Client : {ClientBanque}\n";
            result += $"\n\t\t\t\t\t\tSolde : {Solde} €\n";
            result += $"------------ OPERATIONS ------------\n";
            Operations.ForEach(o =>
            {
                result += $"{o}\n";
            });


            return result;
        }
    }
}
