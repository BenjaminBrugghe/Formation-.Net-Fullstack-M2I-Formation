using Ex6_InterfacesAnimaux.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_InterfacesAnimaux.Classes
{
    internal class Lapin : Ianimal
    {
        public void Crier()
        {
            Console.WriteLine("Le lapin ne crie pas");
        }

        public void Manger()
        {
            Console.WriteLine("Le lapin mange des carottes");
        }
    }
}
