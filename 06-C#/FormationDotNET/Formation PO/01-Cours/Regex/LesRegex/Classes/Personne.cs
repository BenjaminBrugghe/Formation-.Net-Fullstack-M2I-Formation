using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRegex.Classes
{
    internal class Personne
    {
        private int id;
        private string firstname;
        private string lastname;
        private string telephone;
        private string email;

        public Personne()
        {

        }

        public Personne(int id, string firstname, string lastname, string telephone, string email)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Telephone = telephone;
            Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname
        {
            get => firstname;
            set
            {
                if (Tools.IsName(value))
                {
                    firstname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format prénom...");
                }
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                if (Tools.IsName(value))
                {
                    lastname = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format nom...");
                }
            }
        }
        public string Telephone
        {
            get => telephone;
            set
            {
                if (Tools.IsPhone(value))
                {
                    telephone = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format telephone...");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Erreur, format email...");
                }
            }
        }
    }
}
