using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Annuaire.Classes
{
    internal class Personne
    {
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;

        public Personne()
        {

        }
        public Personne(string firstname, string lastname, DateTime dateOfBirth)
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public string Firstname
        {
            get => firstname; 
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    firstname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format prénom...");
                }
            }
        }
        public string Lastname { 
            get => lastname; 
            set
            {
                if (Tools.IsAlphabetic(value))
                {
                    lastname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format nom...");
                }
            }
        }
        public DateTime DateOfBirth { 
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
    }
}
