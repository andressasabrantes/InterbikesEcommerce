using Microsoft.EntityFrameworkCore;

namespace InterbikesWeb.Models.Data
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
                new Category { Id = 1, Name = "Bike", DisplayOrder = 1},
                new Category { Id = 2, Name = "Accessories", DisplayOrder = 2},
                new Category { Id = 3, Name = "Components", DisplayOrder = 3}
                );
        }
    }
}
