using EXO_eLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal class EditorsRepository : BaseRepository, IRepository<Editor>
    {
        public bool Add(Editor element)
        {
            _context.Editors.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(Editor element)
        {
            if (element != null)
            {
                _context.Editors.Remove(element);
            }

            return _context.SaveChanges() > 0;
        }

        public ICollection<Editor> GetAll()
        {
            return _context.Editors.Include(x => x.Books).ToList();
        }

        public Editor GetById(int id)
        {
            return _context.Editors.Include(x => x.Books).SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Editor element)
        {
            if (element != null)
            {
                _context.Editors.Update(element);
            }

            return _context.SaveChanges() > 0;
        }
    }
}
