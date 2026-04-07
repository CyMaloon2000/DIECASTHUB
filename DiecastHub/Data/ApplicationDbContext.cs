using DiecastHub.Models;
using Microsoft.EntityFrameworkCore;

namespace DiecastHub.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Person> Person => Set<Person>();
        public DbSet<User> User => Set<User>();
    }
}
