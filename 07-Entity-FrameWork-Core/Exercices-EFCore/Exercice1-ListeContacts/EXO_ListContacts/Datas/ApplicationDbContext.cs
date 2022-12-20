using EXO_ListContacts.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_ListContacts.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\MSSQLLOCALDB; Initial Catalog = PRF2022_EXO_Contacts; Integrated Security = True;");
        }
    }
}
