using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercice2Banque.Classes
{
    internal class Tools
    {
        /*
         * Pattern Regex
         *  ^ = commence
         *  $ = fin
         *  \d = nombre
         *  \w = Letter, Digit, Underscrore
         *  \s = White-Space(tabs, spaces)
         *  \D = Tout sauf les \d
         *  \W = Tout sauf des \w
         *  \S = Tout sauf les \s
         *  | = OU
         *  * = 0 ou plus
         *  + = au moins une fois
         *  ? = 0 ou 1 fois
         *  {1} = nb répétition
         *  {2,4}= 2 à 4 fois
         *  . = tout sauf Return
         */

        public static bool IsName(string name)
        {
            string pattern = @"^([A-Z]{1})([a-zA-Z\séèë\-]*)$";
            return Regex.IsMatch(name, pattern);
        }

        public static bool IsDate(string date)
        {
            string pattern = @"^([0-9]{4})([/]{1})([0-9]{2})([/]{1})([0-9]{2})$";
            return Regex.IsMatch(date, pattern);
        }

        public static bool IsAlphabetic(string text)
        {
            string pattern = @"^([a-zA-Z\s\-\'éèëêà]*)$";
            return Regex.IsMatch(text, pattern);
        }

        public static bool IsCodePostal(string text)
        {
            string pattern = @"^([0-9]{5})$";
            return Regex.IsMatch(text, pattern);
        }

        public static bool IsNumeric(string text)
        {
            string pattern = @"^([0-9]+)$";
            return Regex.IsMatch(text, pattern);
        }

        public static bool IsPhone(string phone)
        {
            string pattern = @"^([0|\+33|33]+)(\.|\-|\s)?([1-9]{1})((\.|\-|\s)?[0-9]{2}){4}$";
            return Regex.IsMatch(phone, pattern);
        }
        public static bool IsEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9._-]+)@([a-zA-Z0-9-_]+)(\.)?([a-zA-Z0-9-_]+)?(\.){1}([a-zA-Z]{2,13})$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
