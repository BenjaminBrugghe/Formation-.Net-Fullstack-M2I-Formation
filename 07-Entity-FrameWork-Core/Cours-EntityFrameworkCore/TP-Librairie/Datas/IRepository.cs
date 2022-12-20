using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Librairie.Datas
{
    internal interface IRepository<T> where T : class
    {
        // La méthode pour INSERT
        public bool Add(T element);

        // La méthode pour DELETE
        public bool Delete(T element);

        // La méthode pour UPDATE
        public bool Update(T element);

        // La méthode pour SELECT un élément
        public T? GetById(int id);

        // La méthode pour SELECT tous les éléments
        public ICollection<T> GetAll();

        // La méthode pour SELECT plusieurs éléments basés sur un filtre
        public ICollection<T> Filter(Func<T, bool> predicate);
    }
}
