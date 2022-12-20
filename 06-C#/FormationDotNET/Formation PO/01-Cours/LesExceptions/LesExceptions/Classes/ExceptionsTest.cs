using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions.Classes
{
    internal class ExceptionsTest
    {
        public static double SafeDivision(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Erreur ! Vous tentez de diviser par zéro !");
            }
            return a / b;
        }
    }
}
