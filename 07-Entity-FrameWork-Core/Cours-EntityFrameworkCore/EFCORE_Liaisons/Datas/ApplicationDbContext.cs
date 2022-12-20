using EFCORE_Liaisons.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Liaisons.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\MSSQLLOCALDB; Initial Catalog = PRF2022_EFCore_Demo_Jointures; Integrated Security = True;")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
