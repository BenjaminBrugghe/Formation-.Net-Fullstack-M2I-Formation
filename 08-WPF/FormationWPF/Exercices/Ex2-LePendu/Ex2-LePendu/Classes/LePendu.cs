using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_LePendu.Classes
{
    internal class LePendu
    {
        private int nbEssai;
        private string masque;
        private string motATrouver;
        private GenerateurDeMot generateur;
        //private IGenerator generateur;

        public LePendu()
        {
            generateur = new GenerateurDeMot();
            NbEssai = 10;
            MotATrouver = generateur.Generer();
            Masque = GenererMasque();
        }

        public LePendu(int n) : this()
        {
            NbEssai = n;
        }

        public int NbEssai { get => nbEssai; set => nbEssai = value; }
        public string Masque { get => masque; set => masque = value; }
        public string MotATrouver { get => motATrouver; set => motATrouver = value; }

        public bool TestChar(char c)
        {
            bool found = false;
            string masqueTmp = "";

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                {
                    masqueTmp += masque[i];
                }
            }

            masque = masqueTmp;

            if (!found)
            {
                NbEssai--;
            }
            return found;
        }

        public bool TestWin()
        {
            return (NbEssai > 0 && MotATrouver == Masque);
        }

        public string GenererMasque()
        {
            string masqueTmp = "";
            for (int i = 0; i < MotATrouver.Length; i++)

                masqueTmp += "*";
            return masqueTmp;
        }
    }
}
