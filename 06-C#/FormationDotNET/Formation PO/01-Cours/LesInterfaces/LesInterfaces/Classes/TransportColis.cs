using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class TransportColis
    {
        private IVolant volant;

        public TransportColis(IVolant v)
        {
            volant = v;
        }

        public void Transporter()
        {
            volant.Voler();
            Console.WriteLine("Je suis en chemin pour la livraison...");
        }

        public void Livrer()
        {
            volant.Atterrir();
            Console.WriteLine("Le colis a été livré !");
        }


    }
}
