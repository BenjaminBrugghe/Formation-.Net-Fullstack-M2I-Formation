using Ex2_LePendu.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_LePendu.Classes
{
    internal class GenerateurDeMot : IGenerateur
    {
        #region TableauDeNoms
        public string[] tableau = new string[] {"camion","oiseau","pomme","ascenseur","ordinateur","javascript","formation","cafe","vacances","fenetre" };
        #endregion

        #region Méthodes
        public string Generer()
        {
            Random aleatoire = new Random();
            int nbRandom = aleatoire.Next(0, tableau.Length);
            string motMystere = tableau[nbRandom];
            return motMystere;
        }
        #endregion
    }
}
