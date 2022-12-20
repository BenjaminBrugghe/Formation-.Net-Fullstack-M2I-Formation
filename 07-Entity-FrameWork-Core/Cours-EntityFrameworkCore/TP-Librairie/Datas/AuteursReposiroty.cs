using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Librairie.Classes;

namespace TP_Librairie.Datas
{
    internal class AuteursReposiroty : BaseRepository, IRepository<Auteur>
    {
        public bool Add(Auteur element)
        {
            _context.Auteurs.Add(element);

            return _context.SaveChanges() == 1;
        }

        public bool Delete(Auteur element)
        {
            _context.Auteurs.Remove(element);

            return _context.SaveChanges() == 1;
        }

        public ICollection<Auteur> Filter(Func<Auteur, bool> predicate)
        {
            return _context.Auteurs.Where(predicate).ToList();
        }

        public ICollection<Auteur> GetAll()
        {
            return _context.Auteurs.ToList();
        }

        public Auteur? GetById(int id)
        {
            return _context.Auteurs.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Auteur element)
        {
            _context.Update(element);

            return _context.SaveChanges() >= 1;
        }
    }
}
