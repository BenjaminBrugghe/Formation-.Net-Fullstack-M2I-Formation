using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesGeneriques.Classes
{
    internal class Piles<T>
    {
        T[] elements;
        int taille;
        int compteur = 0;

        public Piles(int t)
        {
            taille = t;
            elements = new T[taille];
        }

        public void Empiler(T element)
        {
            if (compteur < taille)
            {
                elements[compteur] = element;
                compteur++;
            }
            else
            {
                Console.WriteLine("Erreur ! La pile est pleine");
            }
        }

        public void Depiler()
        {
            if (compteur > 0)
            {
                Console.WriteLine("Je dépile le dernier élément");
                elements[compteur-1] = default(T);
                compteur--;
            }
            else
            {
                Console.WriteLine("Erreur ! La pile est vide");
            }
        }

        public T Get(int index)
        {
            return elements[index];
        }
    }
}
