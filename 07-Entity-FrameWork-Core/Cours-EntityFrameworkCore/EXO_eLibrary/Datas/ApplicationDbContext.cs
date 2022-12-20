using EXO_eLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_eLibrary.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Editor> Editors { get; set; }

        // Il est fréquent que dans une application usant de l'inversion de contrôle, notre ApplicationDbContext
        // pourra être créé en partant du constructeur ci-dessous
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public ApplicationDbContext()
        {
        }

        // Cette méthode n'est plus utile si jamais on se sert du constructeur numéro 1,
        // ici elle nous est cependant encore utile
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Program>()
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
        }
    }
}
