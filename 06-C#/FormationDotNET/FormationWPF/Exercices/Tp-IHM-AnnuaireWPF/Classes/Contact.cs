using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_IHM_AnnuaireWPF.Classes
{
    internal class Contact
    {
        private static int id = 0;

        public Contact()
        {
            Id = ++id;
        }

        public Contact(string nom, string prenom, int age) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }


        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"\n**********\n{Id}. Nom : {Nom}\nPrénom : {Prenom}\nAge : {Age}";
        }
    }
}
