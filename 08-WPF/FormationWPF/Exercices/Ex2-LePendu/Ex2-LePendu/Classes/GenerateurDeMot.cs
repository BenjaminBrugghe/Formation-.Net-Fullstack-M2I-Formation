using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_LePendu.Classes
{
    internal class GenerateurDeMot : IGenerator
    {

        public string[] tableau = new string[] { "camion", "oiseau", "pomme", "ascenseur", "ordinateur", "javascript", "formation", "cafe", "vacances", "fenetre" };

        public string Generer()
        {
            Random aleatoire = new Random();
            int nbRandom = aleatoire.Next(0, tableau.Length);
            string motMystere = tableau[nbRandom];
            return motMystere;
        }
    }
}
