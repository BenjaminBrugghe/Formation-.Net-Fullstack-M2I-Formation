using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal interface IRepository<T> where T : class
    {
        public bool Add(T element);
        public T GetById(int id);
        public ICollection<T> GetAll();
        public bool Delete(T element);
        public bool Update(T element);
    }
}
