using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_CompteBancaire.Classes
{
    public class Compte
    {        
        private int id;
        private decimal solde;
        private Client clientBanque;
        private List<Operation> operations;
       

        public Compte()
        {           
            Operations = new();
        }

        public Compte(decimal solde, Client clientBanque) : this()
        {
            Solde = solde;
            ClientBanque = clientBanque;
        }


        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public Client ClientBanque { get => clientBanque; set => clientBanque = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }

        public event Action<decimal, int> ADecouvert;


        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                if (Solde < 0)
                    if (ADecouvert != null)                    
                        ADecouvert(Solde, Id);                    
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
