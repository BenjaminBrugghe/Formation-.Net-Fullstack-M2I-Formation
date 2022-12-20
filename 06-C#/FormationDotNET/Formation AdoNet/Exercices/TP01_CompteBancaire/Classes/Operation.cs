using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_CompteBancaire.Classes
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateOperation;
        private int compteId; 
        private static int compteur = 0;

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }

        public int CompteId { get => compteId; init => compteId = value; }

        public Operation()
        {
            DateOperation = DateTime.Now;
            Id = ++compteur;
        }

        public Operation(decimal montant)
        {
            Montant = montant;
            DateOperation = DateTime.Now;
            Id = ++compteur;
        }

        public override string ToString()
        {
            return $" Id : {(Id > 9 ? id : "0" + Id)}, Date : {DateOperation}";
        }
    }
}
