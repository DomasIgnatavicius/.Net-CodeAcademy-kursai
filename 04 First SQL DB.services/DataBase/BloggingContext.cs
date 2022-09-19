using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_First_SQL_DB.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace _04_First_SQL_DB.services.DataBase
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CodeFirstBogging.db");
        }
        // Registruojame nauja lentele musu DB
        public DbSet<Person> Persons { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public string DbPath { get;}

        // nusistatom kaip norim prisijungti prie DB - konfiguruojam kur musu DB yra
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            //Needs: Microsoft.EntityFrameworkCore.Proxies
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
