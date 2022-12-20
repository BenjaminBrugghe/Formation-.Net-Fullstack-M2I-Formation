using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Drone : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris à la verticale.");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle à la verticale.");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole tout seul.");
        }
    }
}
