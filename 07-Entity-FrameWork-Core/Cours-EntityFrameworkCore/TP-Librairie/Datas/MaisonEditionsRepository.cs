using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Librairie.Classes;

namespace TP_Librairie.Datas
{
    internal class MaisonEditionsRepository : BaseRepository, IRepository<MaisonEdition>
    {
        public bool Add(MaisonEdition element)
        {
            _context.MaisonEditions.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(MaisonEdition element)
        {
            _context.MaisonEditions.Remove(element);

            return _context.SaveChanges() == 1;
        }

        public ICollection<MaisonEdition> Filter(Func<MaisonEdition, bool> predicate)
        {
            return _context.MaisonEditions.Where(predicate).ToList();
        }

        public ICollection<MaisonEdition> GetAll()
        {
            return _context.MaisonEditions.ToList();
        }

        public MaisonEdition? GetById(int id)
        {
            return _context.MaisonEditions.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(MaisonEdition element)
        {
            _context.Update(element);

            return _context.SaveChanges() >= 1;
        }
    }
}
