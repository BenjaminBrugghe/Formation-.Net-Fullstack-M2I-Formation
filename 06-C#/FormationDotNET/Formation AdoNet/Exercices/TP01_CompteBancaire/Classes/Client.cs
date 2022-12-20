using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01_CompteBancaire.Tools;

namespace TP01_CompteBancaire.Classes
{
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        

        public Client()
        {
           
        }
        public Client(string n, string p, string t) : this()
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
        }
        public Client(int id, string n, string p, string t) : this()
        {
            Id = id;
            Nom = n;
            Prenom = p;
            Telephone = t;
        }
        public int Id { get => id; set => id = value; }
        public string Nom
        {
            get => nom;
            set
            {
                if (MyRegex.IsName(value))
                    nom = value;
                else
                    throw new FormatException("Erreur nom");
            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                if (MyRegex.IsName(value))
                    prenom = value;
                else
                    throw new FormatException("Erreur prénom");
            }
        }
        public string Telephone
        {
            get => telephone;
            set
            {
                if (MyRegex.IsPhone(value))
                    telephone = value;
                else
                    throw new FormatException("Erreur téléphone");
            }
        }



        public override string ToString()
        {
            return $"Id: {Id}, Nom : {Nom}, Prénom : {Prenom}, Téléphone : {Telephone}";
        }
    }
}
