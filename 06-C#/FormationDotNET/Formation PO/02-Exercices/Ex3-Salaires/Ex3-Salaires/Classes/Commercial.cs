using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Salaires.Classes
{
    internal class Commercial : Salarie
    {
        private decimal chiffreAffaire;
        private int commission;

        public Commercial() : base()
        {

        }

        public Commercial(string matricule, string categorie, string service, string nom, decimal salaire, decimal chiffreAffaire, int commission)
            : base(matricule, categorie, service, nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public int Commission { get => commission; set => commission = value; }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            decimal salaireReel = Salaire + (chiffreAffaire * commission / 100);
            Console.WriteLine($"La salaire avec commission de {Nom} est de {salaireReel} €");
        }

        public void AfficherCommercial()
        {
            Console.WriteLine("Je suis un commercial");
        }

        public override string ToString()
        {
            return "Je suis un commercial";
        }
    }
}
