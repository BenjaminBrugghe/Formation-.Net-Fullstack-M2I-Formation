using Ex6_InterfacesAnimaux.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_InterfacesAnimaux.Classes
{
    internal class Chat : Ianimal
    {
        public void Crier()
        {
            Console.WriteLine("Le chat miaule");
        }

        public void Manger()
        {
            Console.WriteLine("Le chat mange des croquettes");
        }
    }
}
