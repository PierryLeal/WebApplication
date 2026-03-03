using Microsoft.EntityFrameworkCore;
using WebApplication.Domain.entities;

namespace WebApplication.Infastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teste> teste { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
