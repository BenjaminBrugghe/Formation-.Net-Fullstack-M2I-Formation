using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Classes
{
    internal class Adoption
    {
        public int Id { get; set; }

        public DateTime DateOfAdoption { get; set; }

        public int DogId { get; set; }
        public int MasterId { get; set; }

        public Dog Dog { get; set; }
        public Master Master { get; set; }
    }
}
