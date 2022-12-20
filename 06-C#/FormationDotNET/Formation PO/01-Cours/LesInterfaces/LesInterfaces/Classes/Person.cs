using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Person
    {
        private int id;
        private string nom;
        private string prenom;
        //private Address personAddress;
        private IAddress personAddress;

        public Person(IAddress personAddress)
        {
            PersonAddress = personAddress;
            PersonAddress.AddressInformation();
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public IAddress PersonAddress { get => personAddress; set => personAddress = value; }
    }
}
