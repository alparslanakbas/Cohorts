using Microsoft.EntityFrameworkCore;
using Week_12_Code_First.Library.Models;

namespace Week_12_Code_First.Library.Data
{
    internal class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasKey(m => m.Id);
            modelBuilder.Entity<Game>().HasKey(g => g.Id);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=Week12CodeFirst;Trusted_Connection=True;");
        }

    }
}
