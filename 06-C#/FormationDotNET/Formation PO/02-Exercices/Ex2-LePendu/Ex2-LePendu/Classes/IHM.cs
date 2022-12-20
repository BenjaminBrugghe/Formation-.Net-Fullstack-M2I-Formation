using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex2_LePendu.Classes;

namespace Ex2_LePendu.Classes
{
    internal class IHM
    {
        LePendu lePendu;
        bool ok = false;

        public void Start()
        {
            while (!ok)
            {
                Console.WriteLine("Combien d'essais souhaitez-vous avoir ? : ");
                if (int.TryParse(Console.ReadLine(), out int nb))
                {
                    lePendu = new LePendu(nb);
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Erreur de saisie ! Veuillez entrer un chiffre/nombre !");
                }
            }

            do
            {
                Console.Clear();
                Console.WriteLine($"----- Le jeu du Pendu -----\n");
                Console.WriteLine($"Le mot à trouver est : {lePendu.Masque}");
                Console.WriteLine($"Il vous reste {lePendu.NbEssai} essais");
                Console.WriteLine($"Veuillez saisir une lettre : ");

                char c = Convert.ToChar(Console.ReadLine());

                lePendu.TestChar(c);

                lePendu.TestWin();

                if (lePendu.TestWin())
                {
                    break;
                }

            } while (lePendu.NbEssai > 0);

            if (lePendu.TestWin())
            {
                Console.Clear();
                Console.WriteLine($"----- Le jeu du Pendu -----\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***** Victoire ! *****");
                Console.WriteLine("\n\t\\O/\n\t |\n\t |\\\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"----- Le jeu du Pendu -----\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Vous avez épuisé toutes vos chances !\n");
                Console.WriteLine("\t___\n\t|  |\n\t| _O_\n\t|  |\n\t|  |\\\n\t|________\n");
                Console.WriteLine($"Le mot à trouver était : {lePendu.MotATrouver} !\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
