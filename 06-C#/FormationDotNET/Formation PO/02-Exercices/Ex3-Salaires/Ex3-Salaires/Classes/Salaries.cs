using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Salaires.Classes
{
    internal class Salarie
    {
        #region Attributs
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static int compteur = 0;
        #endregion

        #region Constructeurs
        public Salarie()
        {
            compteur++;
        }

        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this()
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
        }

        #endregion

        #region Propriétés

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }
        public static int Compteur { get => compteur; }
        #endregion

        #region Méthodes
        public virtual void CalculerSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de {salaire} €");
        }

        public static void ResetCompteur()
        {
            compteur = 0;
        }

        public override string ToString()
        {
            return "Je suis un salarié";
        }


        #endregion
    }
}
