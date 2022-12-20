using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Avion : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris sur une piste.");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis une piste.");
        }

        public void Voler()
        {
            Console.WriteLine("Je peux voler grâce à mes réacteurs.");
        }
    }
}
