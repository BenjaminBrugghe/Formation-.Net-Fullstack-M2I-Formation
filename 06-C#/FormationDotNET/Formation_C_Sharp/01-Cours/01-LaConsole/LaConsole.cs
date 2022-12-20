using System;

namespace LaConsole
{
    internal class LaConsole
    {
        static void Main(string[] args)
        {
            // Affichage dans la console sans retours à la ligne
            #region Affichage dans la console
            Console.Write("bla");
            Console.Write("bla2");
            Console.Write("bla3");
            #endregion

            #region Lecture console
            // Lire un caractère de l'utilisateur => Console.Read();
            char @charactere = (char)Console.Read();
            Console.WriteLine(@charactere);

            // Lire une chaine de caractères avec => Console.ReadLine();
            string Nom = Console.ReadLine(); // ReadLine = Prompt
            Console.WriteLine(Nom);
            #endregion

            #region Changements de couleur de la police dans la console
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Je suis en Magenta !");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Caractères Spéciaux
            // Affichage d'un chemin dans la console
            Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            Console.WriteLine(@"c:\repertoire\MonFichier.cs");

            // Le caractère "
            Console.WriteLine("Bonjour, je m'appelle \"Benjamin\"");

            // Le \n pour sauter une ligne
            Console.WriteLine("Je saute une ligne\n");
            Console.WriteLine("Je saute une ligne\n");

            // Le \t pour les tabulations
            Console.WriteLine("Liste de choses à faire :");
            Console.WriteLine("\t - Apprendre ReactJS :");
            Console.WriteLine("\t - Apprendre C# :");

            // Les caractères spéciaux
            Console.WriteLine("€uros");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("€uros");
            #endregion

            #region Affichage Date et Heure
            DateTime dateHeure = DateTime.Now;
            Console.WriteLine("Date et heure : {0:d} at {0:t}",dateHeure);
            #endregion


            // Affichage avec un retour à la ligne (le retour se fait après la ligne)
            Console.WriteLine("Hello World!");

            Console.WriteLine("Appuyez sur la touche ENTER pour fermer le programme.");
            Console.Read(); // Permet de ne pas fermer la console
        }
    }
}
