using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_TpBanque.Classes
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateOperation;

        private static int compteur = 0;

        public int Id { get => id; init => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }

        public Operation(decimal montant)
        {
            Montant = montant;
            DateOperation = DateTime.Now;
            Id = ++compteur;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Date : {DateOperation}, Montant : {Montant}€";
        }
    }
}
