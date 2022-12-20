using EXO_eLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal class AuthorsRepository : BaseRepository, IRepository<Author>
    {
        public bool Add(Author element)
        {
            _context.Authors.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(Author element)
        {
            if (element != null)
            {
                _context.Authors.Remove(element);
            }

            return _context.SaveChanges() > 0;
        }

        public ICollection<Author> GetAll()
        {
            return _context.Authors.Include(x => x.Books).ToList();
        }

        public Author GetById(int id)
        {
            return _context.Authors.Include(x => x.Books).FirstOrDefault(x => x.Id == id);
        }

        //public ICollection<Author> Find(Func<Author, bool> predicate)
        //{
        //    return _context.Authors.Include(x => x.Books).Where(predicate).ToList();
        //}

        public bool Update(Author element)
        {
            if (element != null)
            {
                _context.Authors.Update(element);
            }

            return _context.SaveChanges() > 0;
        }
    }
}
