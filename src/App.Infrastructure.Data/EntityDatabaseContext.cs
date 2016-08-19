using System.Data.Entity;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Infrastructure.Data
{
    public class AppContext : DbContext
    {
        public AppContext(string connectionString) 
            : base(connectionString)
        {            
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
