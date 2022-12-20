using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsDeMethodes.Classes
{
    internal static class Extensions
    {
        // L'extension de méthode est faite à l'aide du mot clé this en premier paramètre

        public static double Additionner(this double a, double b)
        {
            return a + b;
        }
    }
}
