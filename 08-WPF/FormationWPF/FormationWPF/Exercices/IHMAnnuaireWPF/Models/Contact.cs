using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHMAnnuaireWPF.Models
{
    internal class Contact
    {
        private static int id = 0;

        public Contact()
        {
            Id = ++id;
        }

        public Contact(string nom, string prenom, string telephone, string email, int age) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Email = email;
            Age = age;
        }

        public int Id { get => id ; set => id = value; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"\nId : {Id} - Nom : {Nom} Prénom : {Prenom} \n\tTéléphone : {Telephone} \n\t Email : {Email} \n\t Age : {Age} ans.\n";
        }

    }
}
