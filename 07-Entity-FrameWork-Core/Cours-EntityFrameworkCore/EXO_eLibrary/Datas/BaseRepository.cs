using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal abstract class BaseRepository
    {
        protected ApplicationDbContext _context = new();
    }
}
