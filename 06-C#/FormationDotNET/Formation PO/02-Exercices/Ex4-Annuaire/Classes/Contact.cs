using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Annuaire.Classes
{
    internal class Contact : Personne
    {
        private string telephone;
        private string email;
        private Adresse adresse;
        private int id;
        private static int compteur = 0;

        public Contact() : base()
        {
            Id = ++compteur;
        }

        public Contact(string firstname, string lastname, DateTime dateOfBirth, Adresse adress, string telephone, string email)
            : base(firstname, lastname, dateOfBirth)
        {
            adresse = adress;
            Telephone = telephone;
            Email = email;
            Id = ++compteur;
        }

        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        internal Adresse Adresse { get => adresse; set => adresse = value; }
        public int Id { get => id; set => id = value; }
    }
}
