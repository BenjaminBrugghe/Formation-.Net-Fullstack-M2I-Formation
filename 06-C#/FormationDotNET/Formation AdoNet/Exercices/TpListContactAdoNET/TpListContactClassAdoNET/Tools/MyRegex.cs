
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TpListContactClassAdoNET.Tools
{
    public class MyRegex
    {
        
        public static bool IsName(string name)
        {
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-_]*$";
            return Regex.IsMatch(name, pattern);
        }

        public static bool IsAlphabetic(string text)
        {
            string pattern = @"^([a-zA-Z\s\-\'éëà]*)$";
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
            string pattern = @"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$";
            return Regex.IsMatch(email, pattern);
        }

        public static string ClearMultipleSpace(string chaine)
        {
            string pattern = @"\s+";
            // string CleanedString = Regex.Replace(chaine, pattern, " ");
            // return CleanedString ;
            return Regex.Replace(chaine, pattern, " ");
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
                    chaine += phone[i];
                }
            }
            string pattern = @"[\.\-]+";
            string FormatedString = Regex.Replace(chaine, pattern, " ");

            pattern = @"^(0|33)";
            FormatedString = Regex.Replace(FormatedString, pattern, "+33 ");

            return ClearMultipleSpace(FormatedString);
        }
    }
}
