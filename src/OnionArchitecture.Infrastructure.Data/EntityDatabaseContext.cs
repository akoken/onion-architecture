using System.Data.Entity;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Infrastructure.Data
{
    public class EntityDatabaseContext : DbContext
    {
        public EntityDatabaseContext(string connectionString) 
            : base(connectionString)
        {            
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
