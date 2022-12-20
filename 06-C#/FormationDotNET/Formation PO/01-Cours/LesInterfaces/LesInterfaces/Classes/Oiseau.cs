using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Oiseau : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris où je veux.");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis n'importe où.");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole et je chie sur les voitures.");
        }
    }
}
