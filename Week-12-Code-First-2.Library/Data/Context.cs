using Microsoft.EntityFrameworkCore;
using Week_12_Code_First_2.Library.Models;

namespace Week_12_Code_First_2.Library.Data
{
    internal class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Week-12-Code-First-2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Post>().HasKey(p => p.Id);

            modelBuilder.Entity<User>().HasMany(u => u.Posts).WithOne(p => p.User);
        }
    }
}
