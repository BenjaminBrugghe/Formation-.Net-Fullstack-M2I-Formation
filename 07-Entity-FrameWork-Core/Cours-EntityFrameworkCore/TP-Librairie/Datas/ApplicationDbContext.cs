using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Librairie.Classes;

namespace Exercice1_ListeContacts.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Ouvrage> Ouvrages { get; set; }
        public DbSet<MaisonEdition> MaisonEditions { get; set; }

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
