using Exercice1_ListeContacts.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Librairie.Datas
{
    internal abstract class BaseRepository
    {
        // Il lui faudra une propriété protégée (récupérée par les classes qui vont hériter de notre classe abstraite)
        // qui servira à avoir le lien vers le contexte de données
        protected ApplicationDbContext _context = new();
    }
}
