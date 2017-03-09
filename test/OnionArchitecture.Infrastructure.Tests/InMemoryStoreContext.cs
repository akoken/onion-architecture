using OnionArchitecture.Infrastructure.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Infrastructure.Tests
{
    public class InMemoryStoreContext : DbContext, IStoreContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public int SaveChanges()
        {
            return SaveChanges();
        }
    }
}
