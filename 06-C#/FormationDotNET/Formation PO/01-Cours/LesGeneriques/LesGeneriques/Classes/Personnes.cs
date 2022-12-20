using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesGeneriques.Classes
{
    internal class Personnes
    {
        public string Prenom { get; set; }
        public string Telephone { get; set; }

        public override string ToString()
        {
            return $"Téléphone : {Telephone} - Prénom : {Prenom}";
        }
    }
}
