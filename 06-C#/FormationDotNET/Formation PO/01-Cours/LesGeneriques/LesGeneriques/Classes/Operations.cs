using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesGeneriques.Classes
{
    internal class Operations<T>
    {
        public string EstEquivalent(T a, T b) // T => On ne connais pas le type à l'avance, il est donc générique
        {
            if (a.Equals(b))
            {
                return "C'est équivalent";
            }
            else
            {
                return "Erreur ! Ce n'est pas équivalent";
            }
        }
    }
}
