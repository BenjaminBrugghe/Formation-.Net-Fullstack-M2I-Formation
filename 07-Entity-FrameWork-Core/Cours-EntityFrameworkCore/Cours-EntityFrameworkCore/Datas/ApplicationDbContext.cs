using Cours_EntityFrameworkCore.Classes;
using Microsoft.EntityFrameworkCore; // Pour : DbContext
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_EntityFrameworkCore.Datas
{
    internal class ApplicationDbContext : DbContext
    {
        // Pour avoir accès par la suite à la table de chiens, il nous faut un DbSet de chiens (public)
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Toy> Toys { get; set; }

        // Pour gérer la configuration du lien avec la base de donnée, il nous faut avoir accès à la méthode OnConfiguring() dans laquelle nous pourrons avoir notre chaine de connexion SQLServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Program>()
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Default")).LogTo(Console.WriteLine, LogLevel.Information);
            // Si on veut avoir un log de ce qui se passe dans DF Core et observer les requêtes SQL générées pour nous
        }


    }
}
