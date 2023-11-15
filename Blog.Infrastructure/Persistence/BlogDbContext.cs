using Blog.Domain;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Blog.Infrastructure.Persistence
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrada>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Entrada>()
                .Property(e => e.Id)
                    .ValueGeneratedOnAdd();
        }

        public DbSet<Entrada>? Entradas { get; set; }

    }
}
