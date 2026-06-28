using DiecastHub.Models;
using Microsoft.EntityFrameworkCore;

namespace DiecastHub.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Person> Person => Set<Person>();
        public DbSet<User> User => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.UserId);

                entity.Property(u => u.IsActive)
                      .HasDefaultValue(true);
            });
        }
    }
}
