using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Librairie.Classes;

namespace TP_Librairie.Datas
{
    internal class OuvragesRepository : BaseRepository, IRepository<Ouvrage>
    {
        public bool Add(Ouvrage element)
        {
            _context.Ouvrages.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(Ouvrage element)
        {
            _context.Ouvrages.Remove(element);

            return _context.SaveChanges() == 1;
        }

        public ICollection<Ouvrage> Filter(Func<Ouvrage, bool> predicate)
        {
            return _context.Ouvrages.Where(predicate).ToList();
        }

        public ICollection<Ouvrage> GetAll()
        {
            return _context.Ouvrages.ToList();
        }

        public Ouvrage? GetById(int id)
        {
            return _context.Ouvrages.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Ouvrage element)
        {
            _context.Update(element);

            return _context.SaveChanges() >= 1;
        }
    }
}
