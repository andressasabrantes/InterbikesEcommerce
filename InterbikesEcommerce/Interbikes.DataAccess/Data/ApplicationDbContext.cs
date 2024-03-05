using Interbikes.Models;
using Microsoft.EntityFrameworkCore;

namespace InterbikesWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bicicleta", DisplayOrder = 1},
                new Category { Id = 2, Name = "Acessorios", DisplayOrder = 2},
                new Category { Id = 3, Name = "Pecas", DisplayOrder = 3}
                );
        }
    }
}
