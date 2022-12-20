using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Annuaire.Classes
{
    internal class Adresse
    {
        private int numero;
        private string rue;
        private int codePostal;
        private string ville;
        private string pays;

        public Adresse()
        {

        }
        public Adresse(int numero, string rue, int codePostal, string ville, string pays)
        {
            this.numero = numero;
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.pays = pays;
        }

        public int Numero { 
            get => numero;
            set
            {
                if (Tools.IsNumeric(Convert.ToString(value)))
                {
                    numero = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format numero...");
                }
            }
        }
        public string Rue { 
            get => rue;
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    rue = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format rue...");
                }
            }
        }
        public int CodePostal { 
            get => codePostal; 
            set
            {
                if (Tools.IsCodePostal(Convert.ToString(value)))
                {
                    codePostal = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format code postal...");
                }
            }
        }
        public string Ville { 
            get => ville; 
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    ville = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format ville...");
                }
            }
        }
        public string Pays { 
            get => pays; 
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    pays = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format pays...");
                }
            }
        }
    }
}
