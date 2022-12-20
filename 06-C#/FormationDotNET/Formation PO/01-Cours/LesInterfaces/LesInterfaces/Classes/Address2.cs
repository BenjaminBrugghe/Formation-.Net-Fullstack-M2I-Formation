using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Address2 : IAddress
    {
        public void AddressInformation()
        {
            Console.WriteLine("J'affiche l'adresse de type Adress2.");
        }
    }
}
