using Ex6_InterfacesAnimaux.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_InterfacesAnimaux.Classes
{
    internal class Chien : Ianimal
    {
        public void Crier()
        {
            Console.WriteLine("Le chien aboye");
        }

        public void Manger()
        {
            Console.WriteLine("Le chien mange des os");
        }
    }
}
