using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Chaises.Classes
{
    internal class Chaises
    {
        #region Attributs (Privés)
        private int nbPieds;
        private string couleur;
        private string materiaux;
        #endregion

        #region Constructeurs
        public Chaises()
        {

        }

        public Chaises(int nbPieds, string couleur, string materiaux)
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }

        public int NbPieds { get => nbPieds; set => nbPieds = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return $"***** Affichage d'un nouvel objet *****\n\n" +
                $"Je suis une chaise, avec {NbPieds} pieds en {Materiaux} et de couleur {Couleur}.\n\n" +
                $"*****************************************************************\n";
        }
        #endregion
    }
}
