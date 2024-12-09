using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Week_12_Survivor.API.Models;

namespace Week_12_Survivor.API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey(u => u.Id);
            modelBuilder.Entity<Competitor>().HasKey(p => p.Id);

            modelBuilder.Entity<Competitor>()
                .HasOne(c=> c.Category)
                .WithMany(c=> c.Competitors)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                ;

        }

    }
}
