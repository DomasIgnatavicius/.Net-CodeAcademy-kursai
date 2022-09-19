using _05_Querying_SQLite_DB.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Querying_SQLite_DB.Infrastucture.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnectionString = Path.Join(path, "QueryingBloggingDb.db");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }

        public string ConnectionString { get;}

        // konfiguruojam kodo ir duomenubazes bendravyma, general settingus, kokiu budu bus prisijungta, kur bus prisijungta
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ConnectionString}"); // Nustatome, kad naudosime SQLite ir nurodome DB butvimo vieta(ConnectionString)
            optionsBuilder.UseLazyLoadingProxies(); // Ijungiame konfiguracijos pagalba - Lazy Loading
        }

        // konfiguruojam modeliu struktura, relationships taisykle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBlog>()
                .HasKey(ab => new { ab.AuthorId, ab.BlogId }); // Statome kompozicini Primary Key, kuris bus sudarytas is AuthorId ir BlodId

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Blog>(ab => ab.Blog)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.BlogId);
        }
    }
}
