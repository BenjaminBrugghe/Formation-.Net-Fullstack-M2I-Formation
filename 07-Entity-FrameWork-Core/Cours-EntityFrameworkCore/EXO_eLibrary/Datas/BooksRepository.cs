using EXO_eLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal class BooksRepository : BaseRepository, IRepository<Book>
    {
        public bool Add(Book element)
        {
            _context.Books.Add(element);

            return _context.SaveChanges() > 0;
        }

        public bool Delete(Book element)
        {
            if (element != null)
            {
                _context.Books.Remove(element);
            }

            return _context.SaveChanges() == 1;
        }

        public ICollection<Book> GetAll()
        {
            return _context.Books.Include(x => x.Author).Include(x => x.Editor).ToList();
        }

        public Book GetById(int id)
        {
            return _context.Books.Include(x => x.Author).Include(x => x.Editor).SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Book element)
        {
            if (element != null)
            {
                _context.Books.Update(element);
            }

            return _context.SaveChanges() > 0;
        }
    }
}
