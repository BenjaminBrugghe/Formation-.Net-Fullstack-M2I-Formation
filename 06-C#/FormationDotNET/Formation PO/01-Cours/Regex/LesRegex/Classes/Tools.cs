using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;  // Pour les Regex
using System.Threading.Tasks;

namespace LesRegex.Classes
{
    internal class Tools
    {
        /*
         * Pattern Regex
         *  ^ = commence
         *  $ = fin
         *  \d = nombre
         *  \w = Letter, Digit, Underscore
         *  \s = White-Space(tabs, spaces)
         *  \D = Tout sauf les \d
         *  \W = Tout sauf des \w
         *  \S = Tout sauf les \s
         *  | = OU
         *  * = 0 ou plus
         *  + = au moins une fois
         *  ? = 0 ou 1 fois
         *  {1} = nb répétition
         *  {2,4} = 2 à 4 fois
         *  . = tout sauf Return
         */

        public static bool IsName(string name)
        { 
            // @ => Pour ne pas avoir à doubler les \
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-]*$";

            // Equivalent à:
            //string pattern = @"^([A-Z]{1})  ([a-zA-Z\séèë\-]*) $";

            return Regex.IsMatch(name,pattern) ;
        }

        public static bool IsPhone(string phone)
        {
            // +33 6 10 11 12 13
            // 33.6.14.85.96.32
            // 33-6-14-85-96-32
            // +33 6 14 85 96 32
            // +33.6.14.85.96.32
            // +33-6-14-85-96-32
            // 06 14 85 96 32
            // 0614859632

            //string pattern = @"^[\+{1}|0-9][0-9\s\-\.]+$";
            string pattern = @"^([0|\+33|33]+)(\.|\-|\s)?([1-9]{1})((\.|\-|\s)?[0-9]{2}){4}$";

            return Regex.IsMatch(phone,pattern) ;
        }

        public static bool IsEmail(string email)
        {
            // nom.prenom@domaine.com
            // Le tiret du 6 doit être placé à la fin des caractères utilisés

            string pattern = @"^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)([\.]?)([a-zA-Z]+)$";

            return Regex.IsMatch(email, pattern);
        }

        public static string ClearMultipleSpaces(string input)
        {
            string pattern = @"\s+";
            return Regex.Replace(input, pattern, " ");
        }


        public static string FormatPhone(string phone)
        {
            string chaine = phone;
            if (chaine.Length == 10)
            {
                chaine = "";
                for (int i = 0; i < phone.Length; i++)
                {
                    if (i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        chaine += " ";
                    }
                    else
                    {
                        chaine += phone[i];
                    }
                }
            }

            string pattern = @"[.-]+";
            string formatedString = Regex.Replace(chaine, pattern, " ");

            pattern = @"^[0|33]";
            formatedString = Regex.Replace(formatedString, pattern, "+33 ");

            return ClearMultipleSpaces(formatedString);
        }
    }
}
